import tkinter as tk
import abc
import typing

from ...masters import window as win
from ...fonts import interfaces as i_font
from .commands import interfaces as cmd
from ...info import interfaces as info


class IEntryInputButton(metaclass=abc.ABCMeta):
    def __init__(self, window: "win.IWindow", text: str, hotkey: str, font: i_font.IFont, commands: cmd.ICommands,
                 entry_input_info: info.IEntryInputInfo):
        self.window = window
        self.text = text
        self.hotkey = hotkey
        self.font = font
        self.commands = commands
        self.entry_input_info = entry_input_info

    @abc.abstractmethod
    def load(self, frame: tk.Frame, row: int, column: int): ...


class IHistoryButton(metaclass=abc.ABCMeta):
    def __init__(self, window: "win.IWindow", text: str, font: i_font.IFont, command: cmd.IHistoryCommand,
                 history_info: info.IHistoryInfo):
        self.window = window
        self.text = text
        self.font = font
        self.command = command
        self.history_info = history_info
        self.button: typing.Optional[tk.Button] = None

    @abc.abstractmethod
    def load(self, frame: tk.Frame, row: int, column: int): ...
