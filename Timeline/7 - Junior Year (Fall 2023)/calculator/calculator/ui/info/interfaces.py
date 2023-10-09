import abc


class IHistoryInfo(metaclass=abc.ABCMeta):
    def __init__(self, pid: int):
        self.pid = pid


class IEntryInputInfo(metaclass=abc.ABCMeta):
    def __init__(self, entry_input: str, calculation_input: str = None):
        self.entry_input = entry_input
        self.calculation_input = calculation_input
        # if not entry_input:
        #     self.entry_input = self.text
        if not calculation_input:
            self.calculation_input = self.entry_input
