from . import interfaces
from ....info import interfaces as info


class SignEntryInputCommand(interfaces.IEntryInputCommand):
    def perform(self, entry_input_info: info.IEntryInputInfo):
        self.sign_list.change_sign()
