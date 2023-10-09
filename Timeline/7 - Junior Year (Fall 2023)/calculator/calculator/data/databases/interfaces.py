import abc
import pyodbc


class IFileSystem(metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def create(self, expression: str = "", answer: str = "") -> None: ...

    @abc.abstractmethod
    def read(self) -> list[pyodbc.Row]: ...

    @abc.abstractmethod
    def update(self, pid: str, field: str, value: str) -> None: ...

    @abc.abstractmethod
    def delete(self, pid: int) -> None: ...
