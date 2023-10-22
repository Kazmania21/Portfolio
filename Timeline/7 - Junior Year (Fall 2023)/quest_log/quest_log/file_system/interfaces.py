import abc
# todo: fix type of read method


class IFileSystem(metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def create(self, name: str = "", description: str = "", parent: str = "", level: str = "0") -> None: ...

    @abc.abstractmethod
    def read(self): ...

    @abc.abstractmethod
    def update(self, name: str, field: str, value: str) -> None: ...

    @abc.abstractmethod
    def delete(self, record: str) -> None: ...
