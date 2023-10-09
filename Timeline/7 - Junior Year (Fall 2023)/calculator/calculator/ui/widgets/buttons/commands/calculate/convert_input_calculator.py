from .. import interfaces
from .....info import interfaces as info


class ConvertEntryInputCommand(interfaces.IEntryInputCommand):
    def perform(self, entry_input_info: info.IEntryInputInfo):
        if self.entry.get_text() != "":
            if self.calculation_string.get_inputs()[-1].isnumeric():
                return
        self.mediator.performable = False
