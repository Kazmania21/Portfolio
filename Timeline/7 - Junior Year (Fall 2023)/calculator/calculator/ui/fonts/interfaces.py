import tkinter as tk
import abc

from ..masters import window as win
from tkinter import font


class IFont(metaclass=abc.ABCMeta):
    def __init__(self, window: "win.IWindow", size: float):
        self.window = window
        self.size = size
        self.font = font.Font(size=size)
        self.prev_screen_width = window.window.winfo_width()
        self.prev_screen_height = window.window.winfo_height()

    @abc.abstractmethod
    def configure(self): ...


class IFonts(metaclass=abc.ABCMeta):
    def __init__(self, window: win.IWindow):
        self.window = window
        self.fonts: list[IFont] = []
        window.window.bind('<Configure>', self.configure)

    @abc.abstractmethod
    def configure(self, event: tk.Event): ...

    @abc.abstractmethod
    def add(self, font: IFont): ...
