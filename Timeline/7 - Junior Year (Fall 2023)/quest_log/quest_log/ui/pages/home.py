from . import interfaces
from selection import interfaces as sel_quest
from factory import factory as qf
from ..frames import interfaces as frames
import tkinter as tk
from ..widgets import scrollable_frame


class NormalQuestLogPage(interfaces.IQuestLogPage):
    def __init__(self, factory: qf.IQuestFactory, shortened_quest_frame: frames.IFrame,
                 selected_quest: sel_quest.SelectedQuest, background_color=None):
        super().__init__(factory)
        self.shortened_quest_frame = shortened_quest_frame
        self.selected_quest = selected_quest
        self.background_color = background_color

    def load(self, frame: tk.Widget) -> None:
        # frame = Frame(self.window)
        frame = scrollable_frame.ScrollableFrame(frame, background_color=self.background_color).frame
        quests = self.factory.create()
        for index, quest in enumerate(quests):
            if quest.active:
                self.selected_quest.set(quest)
                self.shortened_quest_frame.load(frame, index * 2, 0)
        self.selected_quest.set()
