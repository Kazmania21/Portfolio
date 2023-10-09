import abc
import tkinter as tk


class IWindow(metaclass=abc.ABCMeta):
    def __init__(self):
        self.window = tk.Tk()
        self.window.title("Calculator")
        self.window.geometry("457x300")
        self.window.columnconfigure(0, weight=10)
        self.window.rowconfigure(0, weight=10)
        self.frame = tk.Frame(self.window)
        self.frame.grid(sticky="NSEW")
        self.frame.columnconfigure(0, weight=1)
        self.frame.rowconfigure(0, weight=1)


class Window(IWindow):
    ...
