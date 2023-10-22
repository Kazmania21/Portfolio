from .. import interfaces
from selection import interfaces as sel_quest
from ...widgets import interfaces as widgets


class CompleteQuestAction(interfaces.IAction):
    def __init__(self, window: widgets.IWindow, selected_quest: sel_quest.SelectedQuest):
        self.window = window
        self.selected_quest = selected_quest

    def perform(self) -> None:
        quest = self.selected_quest.get()
        quest.complete()
        self.window.reload()
