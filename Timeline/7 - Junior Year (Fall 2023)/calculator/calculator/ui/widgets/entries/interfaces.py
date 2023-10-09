import abc
import tkinter as tk
import typing
from ...masters import window as win
from ...fonts import interfaces as i_font


class IEntry(metaclass=abc.ABCMeta):
    def __init__(self, window: "win.IWindow", font: i_font.IFont):
        self.window = window
        self.entry: typing.Optional[tk.Entry] = None
        self.font = font

    @abc.abstractmethod
    def insert(self, index: int, text: str): ...

    @abc.abstractmethod
    def delete(self, start: int, end: int = None): ...

    @abc.abstractmethod
    def load(self, row: int, column: int): ...

    @abc.abstractmethod
    def set_text(self, text: str): ...

    @abc.abstractmethod
    def get_text(self) -> str: ...

    @abc.abstractmethod
    def get_length(self) -> int: ...

    @abc.abstractmethod
    def delete_last_number(self, last_sign_index: int): ...

    @abc.abstractmethod
    def delete_last(self): ...

    @abc.abstractmethod
    def delete_all(self): ...

    @abc.abstractmethod
    def set_answer(self, answer: str): ...
