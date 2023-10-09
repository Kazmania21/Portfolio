from .. import interfaces
from ....entries import interfaces as i_entry
from ...sign import interfaces as i_sign_list
from .....info import interfaces as info
from calculator.data.lists.calculation import interfaces as calc_str
from calculator.data.databases import interfaces as db
from .....collections import history_frame as his_frame


class CalculateEntryInputCommand(interfaces.IEntryInputCommand):
    def __init__(self, entry: i_entry.IEntry, calculation_string: calc_str.ICalculationString,
                 sign_list: i_sign_list.ISignList, history_database: db.IFileSystem,
                 history_frame: his_frame.IHistoryFrame):
        super().__init__(entry, calculation_string, sign_list)
        self.history_database = history_database
        self.history_frame = history_frame

    def perform(self, entry_input_info: info.IEntryInputInfo):
        expression = self.entry.get_text()
        answer = self.calculation_string.calculate()
        self.entry.set_answer(answer)
        self.calculation_string.set_answer(answer)
        self.history_database.create(expression, answer)
        self.history_frame.reload()
