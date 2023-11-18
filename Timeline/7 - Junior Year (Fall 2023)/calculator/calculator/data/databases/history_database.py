from . import interfaces
import pyodbc
import os
import msaccessdb
import subprocess


class HistoryDatabase(interfaces.IFileSystem):
    def __init__(self, table_name: str, location: str):
        print(location)
        print(location)
        location = os.path.abspath(location)
        self.table_name = table_name

        drivers = [x for x in pyodbc.drivers() if x.startswith('Microsoft Access Driver')]

        if not drivers:
            subprocess.run(['AccessDatabaseEngine_X64.exe', '/quiet'])

        if not os.path.exists(location):
            msaccessdb.create(location)
        self.cursor = self.create_db(location)

    def create(self, expression: str = "", answer: str = "") -> None:
        row = self.read()
        last_pid = 0
        if len(row) != 0:
            last_pid = int(row[-1][0])
        self.cursor.execute(f"INSERT INTO {self.table_name} VALUES ({last_pid+1}, '{expression}', '{answer}')")

    def read(self) -> list[pyodbc.Row]:
        return self.cursor.execute(f"SELECT * FROM {self.table_name}").fetchall()

    def update(self, pid: str, field: str, value: str) -> None:
        self.cursor.execute(f"UPDATE {self.table_name} SET [{field}] = '{value}' WHERE ID = {pid}")

    def delete(self, row_index: int) -> None:
        pid = int(self.read()[row_index][0])
        self.cursor.execute(f"DELETE * FROM {self.table_name} WHERE ID = {pid}")

    def create_db(self, location):
        conn_str = (r'DRIVER={Microsoft Access Driver (*.mdb, *.accdb)};'
                    fr'DBQ={location};')
        conn = pyodbc.connect(conn_str, autocommit=True)
        cursor = conn.cursor()

        if not cursor.tables(table=self.table_name).fetchone():
            cursor.execute(f"CREATE TABLE {self.table_name} " +
                            "(ID INT, EXPRESSION VARCHAR, ANSWER VARCHAR)")

        return cursor
