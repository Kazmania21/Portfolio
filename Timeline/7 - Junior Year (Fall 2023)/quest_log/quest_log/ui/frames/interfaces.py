import typing
import tkinter as tk
import abc

# todo: Fix the naming of the frames and change the types of the frame parameters


class IFrame(metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def load(self, frame: tk.Widget, row: int, column: int) -> None: ...


class IEntryFrame(IFrame, metaclass=abc.ABCMeta):
    def __init__(self):
        self.text: typing.Optional[tk.Text] = None

    @abc.abstractmethod
    def get(self) -> str: ...

    @abc.abstractmethod
    def set_text(self, text: str): ...
