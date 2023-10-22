from . import interfaces
from ..forms import interfaces as forms
from factory import factory as qf
from ..frames import interfaces as frames
import tkinter as tk


class CreateQuestLogPage(interfaces.IQuestLogPage):
    def __init__(self, factory: qf.IQuestFactory,
                 form: forms.IEditQuestForm, button_frame: frames.IFrame):
        super().__init__(factory)
        self.form = form
        self.button_frame = button_frame

    def load(self, frame: tk.Widget) -> None:
        self.form.load(frame)
        self.button_frame.load(frame, 1, 0)
