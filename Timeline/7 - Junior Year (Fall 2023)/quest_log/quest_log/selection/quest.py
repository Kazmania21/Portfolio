from . import interfaces
from data import quest
from ui.button_commands import interfaces as cmd


class SelectedQuest(interfaces.SelectedQuest):
    def set(self, quest: quest.IQuest = None):
        self.selected_quest = quest

    def get(self) -> quest.IQuest:
        return self.selected_quest

    def perform(self, command: cmd.IAction, quest: quest.IQuest):
        self.set(quest)
        print(self.selected_quest.name)
        command.perform()
