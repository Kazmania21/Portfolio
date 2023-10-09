from . import interfaces
import pyodbc
import win32com.client
import os


class HistoryDatabase(interfaces.IFileSystem):
    def __init__(self, table_name: str, location: str):
        self.table_name = table_name

        if not os.path.exists(location):
            o_access = win32com.client.Dispatch('Access.Application')
            db_lang_general = ';LANGID=0x0409;CP=1252;COUNTRY=0'
            db_version = 64
            o_access.DBEngine.CreateDatabase(location, db_lang_general, db_version)
            o_access.Quit()
            del o_access

        conn_str = (r'DRIVER={Microsoft Access Driver (*.mdb, *.accdb)};'
                    fr'DBQ={location};')
        conn = pyodbc.connect(conn_str, autocommit=True)
        self.cursor = conn.cursor()

        if not self.cursor.tables(table=self.table_name).fetchone():
            self.cursor.execute(f"CREATE TABLE {self.table_name} " +
                                "(ID INT, EXPRESSION VARCHAR, ANSWER VARCHAR)")

    def create(self, expression: str = "", answer: str = "") -> None:
        last_pid = int(self.read()[-1][0])
        self.cursor.execute(f"INSERT INTO {self.table_name} VALUES ({last_pid+1}, '{expression}', '{answer}')")

    def read(self) -> list[pyodbc.Row]:
        return self.cursor.execute(f"SELECT * FROM {self.table_name}").fetchall()

    def update(self, pid: str, field: str, value: str) -> None:
        self.cursor.execute(f"UPDATE {self.table_name} SET [{field}] = '{value}' WHERE ID = {pid}")

    def delete(self, row_index: int) -> None:
        pid = int(self.read()[row_index][0])
        self.cursor.execute(f"DELETE * FROM {self.table_name} WHERE ID = {pid}")
