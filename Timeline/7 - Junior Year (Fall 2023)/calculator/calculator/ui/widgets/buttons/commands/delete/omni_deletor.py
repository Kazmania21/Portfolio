from .. import interfaces
from .....info import interfaces as info


class DeleteAllEntryInputCommand(interfaces.IEntryInputCommand):
    def perform(self, entry_input_info: info.IEntryInputInfo):
        self.entry.delete_all()
        self.calculation_string.delete_all_inputs()
        self.sign_list.reset()
