import abc
from ..frames import interfaces as frames
import tkinter as tk


class IEditQuestForm(metaclass=abc.ABCMeta):
    def __init__(self, name_entry: frames.IEntryFrame, description_text: frames.IEntryFrame):
        self.name_entry = name_entry
        self.description_text = description_text

    @abc.abstractmethod
    def load(self, frame: tk.Widget) -> None: ...
