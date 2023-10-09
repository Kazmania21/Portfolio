from .. import interfaces
from .....info import interfaces as info


class DeleteLastEntryInputCommand(interfaces.IEntryInputCommand):
    def perform(self, entry_input_info: info.IEntryInputInfo):
        self.entry.delete_last()
        self.calculation_string.delete_last_input()

        length = self.entry.get_length()
        last_sign_index = self.sign_list.get_last()
        if length == last_sign_index and length != 0:
            self.sign_list.delete_last()
