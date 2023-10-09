from .. import interfaces
from .....info import interfaces as info


class EntryInputCommand(interfaces.IEntryInputCommand):
    def perform(self, entry_input_info: info.IEntryInputInfo):
        entry_input = entry_input_info.entry_input
        calculation_input = entry_input_info.calculation_input
        self.entry.set_text(entry_input)
        self.calculation_string.add_input(calculation_input)
