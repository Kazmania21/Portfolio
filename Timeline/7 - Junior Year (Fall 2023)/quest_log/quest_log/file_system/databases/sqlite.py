import sqlite3
from .. import interfaces as fs


class SQLiteDatabaseFileSystem(fs.IFileSystem):
    def __init__(self):
        self.table_name = "QUESTS"

        location = r'..\quest_log.db'

        self.sqlite_connection = sqlite3.connect(location)

        self.cursor = self.sqlite_connection.cursor()

        self.cursor.execute(f"CREATE TABLE IF NOT EXISTS {self.table_name} " +
                            "(Name VARCHAR, Description VARCHAR, Parent VARCHAR, Level INT, ACTIVE BIT)")

    def create(self, name: str = "", description: str = "", parent: str = "", level: str = "0") -> None:
        print(name)
        print(description)
        print(parent)
        print(level)
        self.cursor.execute(f"INSERT INTO QUESTS VALUES ('{name}', '{description}', '{parent}', '{level}', '1')")
        self.sqlite_connection.commit()

    def read(self) -> list[tuple]:
        self.cursor.execute("SELECT * FROM QUESTS")
        return self.cursor.fetchall()

    def update(self, name: str, field: str, value: str) -> None:
        print(name)
        print(field)
        print(value)
        # self.cursor.execute(f"UPDATE QUESTS SET NAME = '{name}', DESCRIPTION = '{description}', PARENT = '{parent}', " +
        #                    f"[LEVEL] = '{level}', ACTIVE = '{active}' WHERE NAME = '{name}'")

        self.cursor.execute(f"UPDATE QUESTS SET [{field}] = '{value}' WHERE NAME = '{name}'")
        self.sqlite_connection.commit()

    def delete(self, record: str) -> None:
        self.cursor.execute(f"DELETE FROM QUESTS WHERE NAME = '{record}'")
        self.sqlite_connection.commit()
