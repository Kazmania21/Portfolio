import abc
from calculator.data.databases import interfaces as i_db
import tkinter as tk
import typing
from ..fonts import interfaces as i_font
from ..widgets.buttons.history_button import delete_history_button as dh_btn
from ..widgets.buttons.commands.delete import history_deletor as his_del
from ..widgets.buttons import interfaces as btn
from ..info.history import history as his_info
from ..masters import scrollable_frame as sf


class IHistoryFrame(metaclass=abc.ABCMeta):
    def __init__(self, history_database: i_db.IFileSystem, font: i_font.IFont, button_font: i_font.IFont):
        self.history_database = history_database
        self.loaded = False
        self.font = font
        self.button_font = button_font
        self.window = self.font.window
        self.frame: typing.Optional[tk.Widget] = None

    @abc.abstractmethod
    def load(self, frame: tk.Widget): ...

    @abc.abstractmethod
    def reload(self): ...

    @abc.abstractmethod
    def add_equation(self, expression: str, answer: str): ...


class HistoryFrame(IHistoryFrame):
    def load(self, frame: tk.Widget):
        scrollable_frame = sf.ScrollableFrame(frame, self.window, 0, 1)
        self.frame = scrollable_frame
        history = self.history_database.read()
        for index, equation in enumerate(history):
            expression = equation[1]
            answer = equation[2]
            tk.Label(self.frame.frame, text=f'{expression} = {answer}', font=self.font.font).grid(sticky="NSEW")
            button = dh_btn.DeleteHistoryButton(self.window, "X", self.button_font,
                                                his_del.DeleteHistoryCommand(self.history_database),
                                                his_info.HistoryInfo(index))
            button.load(self.frame.frame, index, 1)
            button.button.configure(command=lambda var=button: self.perform(var))
        self.loaded = True

    def unload(self):
        self.frame.grid_forget()
        self.loaded = False

    def reload(self):
        if self.loaded:
            self.unload()
            self.load(self.window.window)

    def perform(self, button: btn.IHistoryButton):
        button.command.perform(button.history_info)
        self.reload()

    def change_load_state(self, frame: tk.Widget):
        print("hi")
        if self.loaded:
            self.unload()
            self.window.window.rowconfigure(1, weight=0)
            self.window.window.columnconfigure(1, weight=0)
            return
        self.load(frame)
        self.window.window.rowconfigure(1, weight=1)
        self.window.window.columnconfigure(1, weight=1)

    def add_equation(self, expression: str, answer: str):
        tk.Label(self.frame, text=f'{expression} = {answer}', font=self.font.font).grid()
