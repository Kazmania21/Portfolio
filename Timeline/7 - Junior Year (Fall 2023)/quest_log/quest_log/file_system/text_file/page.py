from quest_log.file_system.interfaces import *


class PageTextFileSystem(IFileSystem):
    def __init__(self): ...

    def create(self, page=""):
        with open("./pages.txt") as file:
            file.write(page)

    def read(self):
        with open("./pages.txt") as file:
            return file.readline().splitlines()

    def update(self, name, field, value): ...

    def delete(self, index):
        with open("./pages.txt") as file:
            ...
