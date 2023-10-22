import tkinter as tk
import abc
from ..pages import interfaces as pages


class IWindow(metaclass=abc.ABCMeta):
    def __init__(self, window: tk.Tk, frame: tk.Widget, current: str = None, previous: str = None):
        self.window = window
        self.frame = frame
        self.current = current
        self.previous = previous
        self.pages: list[pages.IPage] = []

    @abc.abstractmethod
    def reset_window(self) -> None: ...

    @abc.abstractmethod
    def set_state(self, state: pages.IPage) -> None: ...

    @abc.abstractmethod
    def load(self, page: pages.IPage) -> None: ...

    @abc.abstractmethod
    def reload(self) -> None: ...

    @abc.abstractmethod
    def get_previous(self) -> pages.IPage: ...

    @abc.abstractmethod
    def load_previous(self) -> None: ...
