from . import interfaces
from selection.quest import interfaces as sel_quest
from factory import factory as qf
from ..forms import interfaces as forms
from ..frames import interfaces as frames
import tkinter as tk


class EditQuestPage(interfaces.IQuestLogPage):
    def __init__(self, factory: qf.IQuestFactory,
                 form: forms.IEditQuestForm, button_frame: frames.IFrame, selected_quest: sel_quest.SelectedQuest):
        super().__init__(factory)
        self.form = form
        self.button_frame = button_frame
        self.selected_quest = selected_quest

    def load(self, frame: tk.Widget) -> None:
        quest = self.selected_quest.get()

        self.form.load(frame)
        self.form.name_entry.set_text(quest.name)
        self.form.description_text.set_text(quest.description)
        self.button_frame.load(frame, 15, 0)
