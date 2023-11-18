import mysql.connector
from . import interfaces
import os


class HistoryDatabase(interfaces.IFileSystem):
    def __init__(self, table_name: str, database_name: str):
        self.table_name = table_name

        mydb = mysql.connector.connect(
            host="localhost",
            user="test"
        )

        self.cursor = mydb.cursor()

        #if "calculator_program" not in self.cursor.execute("SHOW USERS"):
        #    self.cursor.execute(f"CREATE USER calculator_program")

        if database_name not in self.cursor.execute("SHOW DATABASES"):
            self.cursor.execute(f"CREATE DATABASE {database_name}")

        if self.table_name not in self.cursor.execute("SHOW TABLES"):
            self.cursor.execute(f"CREATE TABLE {self.table_name} " +
                                "(ID INT, EXPRESSION VARCHAR, ANSWER VARCHAR)")

    def create(self, expression: str = "", answer: str = "") -> None:
        row = self.read()
        last_pid = 0
        if len(row) != 0:
            last_pid = int(row[-1][0])
        self.cursor.execute(f"INSERT INTO {self.table_name} VALUES ({last_pid + 1}, '{expression}', '{answer}')")

    def read(self) -> list[tuple]:
        self.cursor.execute(f"SELECT * FROM {self.table_name}")
        return self.cursor.fetchall()

    def update(self, pid: str, field: str, value: str) -> None:
        self.cursor.execute(f"UPDATE {self.table_name} SET [{field}] = '{value}' WHERE ID = {pid}")

    def delete(self, row_index: int) -> None:
        pid = int(self.read()[row_index][0])
        self.cursor.execute(f"DELETE * FROM {self.table_name} WHERE ID = {pid}")
