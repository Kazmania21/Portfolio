import sqlite3
from . import interfaces


class HistoryDatabase(interfaces.IFileSystem):
    def __init__(self, table_name: str, location: str):
        self.table_name = table_name

        self.sqlite_connection = sqlite3.connect(location)

        self.cursor = self.sqlite_connection.cursor()

        self.cursor.execute(f"CREATE TABLE IF NOT EXISTS {self.table_name} " +
                            "(ID INT, EXPRESSION VARCHAR, ANSWER VARCHAR)")

    def create(self, expression: str = "", answer: str = "") -> None:
        row = self.read()
        last_pid = 0
        if len(row) != 0:
            last_pid = int(row[-1][0])
        self.cursor.execute(f"INSERT INTO {self.table_name} VALUES ({last_pid + 1}, '{expression}', '{answer}')")
        self.sqlite_connection.commit()

    def read(self) -> list[tuple]:
        self.cursor.execute(f"SELECT * FROM {self.table_name}")
        return self.cursor.fetchall()

    def update(self, pid: str, field: str, value: str) -> None:
        self.cursor.execute(f"UPDATE {self.table_name} SET [{field}] = '{value}' WHERE ID = {pid}")
        self.sqlite_connection.commit()

    def delete(self, row_index: int) -> None:
        pid = int(self.read()[row_index][0])
        self.cursor.execute(f"DELETE FROM {self.table_name} WHERE ID = {pid}")
        self.sqlite_connection.commit()
