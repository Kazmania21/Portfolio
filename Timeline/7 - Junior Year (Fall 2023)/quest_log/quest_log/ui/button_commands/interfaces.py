# todo: optimize imports
import abc


class IAction(metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def perform(self) -> None: ...

    def undo(self) -> None: ...
