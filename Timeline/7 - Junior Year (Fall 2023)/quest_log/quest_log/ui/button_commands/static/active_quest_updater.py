from .. import interfaces
from selection import interfaces as sel_quest
from file_system import interfaces as fs
# todo: I -> fs


class UpdateActiveQuestsPageAction(interfaces.IAction):
    def __init__(self, file_system: fs.IFileSystem, selected_active_quests: sel_quest.ISelectedActiveQuests):
        self.file_system = file_system
        self.selected_active_quests = selected_active_quests

    def perform(self) -> None:
        variables = self.selected_active_quests.get()
        for quest_name, variable in variables.items():
            self.file_system.update(quest_name, "ACTIVE", variable.get())
