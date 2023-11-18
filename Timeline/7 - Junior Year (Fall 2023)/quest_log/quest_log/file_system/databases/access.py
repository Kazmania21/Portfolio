from .. import interfaces as fs
import pyodbc
import os
import msaccessdb
import subprocess


class AccessDatabaseFileSystem(fs.IFileSystem):
    def __init__(self):
        location = r'..\quest_log.accdb'
        location = os.path.abspath(location)
        print(location)

        drivers = [x for x in pyodbc.drivers() if x.startswith('Microsoft Access Driver')]

        if not drivers:
            driver_url = 'https://www.microsoft.com/en-us/download/details.aspx?id=54920'
            subprocess.run(['curl', '-o', 'AccessDatabaseEngine_X64.exe', driver_url])
            subprocess.run(['AccessDatabaseEngine_X64.exe', '/quiet'])

        if not os.path.exists(location):
            msaccessdb.create(location)

        conn_str = (r'DRIVER={Microsoft Access Driver (*.mdb, *.accdb)};'
                    fr'DBQ={location};')
        conn = pyodbc.connect(conn_str, autocommit=True)
        self.cursor = conn.cursor()

        if not self.cursor.tables(table='QUESTS').fetchone():
            self.cursor.execute("CREATE TABLE QUESTS " +
                                "(Name VARCHAR, Description VARCHAR, Parent VARCHAR, Level INT, ACTIVE BIT)")

    def create(self, name: str = "", description: str = "", parent: str = "", level: str = "0") -> None:
        print(name)
        print(description)
        print(parent)
        print(level)
        self.cursor.execute(f"INSERT INTO QUESTS VALUES ('{name}', '{description}', '{parent}', '{level}', '-1')")

    def read(self):
        return self.cursor.execute("SELECT * FROM QUESTS")

    def update(self, name: str, field: str, value: str) -> None:
        print(name)
        print(field)
        print(value)
        # self.cursor.execute(f"UPDATE QUESTS SET NAME = '{name}', DESCRIPTION = '{description}', PARENT = '{parent}', " +
        #                    f"[LEVEL] = '{level}', ACTIVE = '{active}' WHERE NAME = '{name}'")

        self.cursor.execute(f"UPDATE QUESTS SET [{field}] = '{value}' WHERE NAME = '{name}'")

    def delete(self, record: str) -> None:
        self.cursor.execute(f"DELETE * FROM QUESTS WHERE NAME = '{record}'")
