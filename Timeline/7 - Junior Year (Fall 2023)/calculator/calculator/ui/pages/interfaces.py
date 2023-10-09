import abc
from ..masters import window as win
from ..widgets.buttons import interfaces as btn
from ..widgets.entries.calculator_entry import interfaces as calc_entry


class IPage(metaclass=abc.ABCMeta):
    def __init__(self, window: win.IWindow, entry: calc_entry.IEntry, buttons: list[btn.IEntryInputButton],
                 columns: int):
        self.window = window
        self.entry = entry
        self.buttons = buttons
        self.columns = columns

    @abc.abstractmethod
    def load(self): ...
