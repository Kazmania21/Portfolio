from .. import interfaces
from .....info import interfaces as info


class OperatorEntryInputCommand(interfaces.IEntryInputCommand):
    def perform(self, entry_input_info: info.IEntryInputInfo):
        self.sign_list.add(len(self.entry.get_text()))
