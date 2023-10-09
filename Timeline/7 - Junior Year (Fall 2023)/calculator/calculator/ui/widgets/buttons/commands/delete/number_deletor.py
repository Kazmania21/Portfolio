from .. import interfaces
from .....info import interfaces as info


class DeleteNumberEntryInputCommand(interfaces.IEntryInputCommand):
    def perform(self, entry_input_info: info.IEntryInputInfo):
        last_sign_index = self.sign_list.get_last()
        self.entry.delete_last_number(last_sign_index)
        self.calculation_string.delete_last_number(last_sign_index)
