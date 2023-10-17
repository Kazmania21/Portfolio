import abc
# todo: add get_length to entries and calc_str
from ...entries import interfaces as i_entry
from data.lists.calculation import interfaces as calc_str


class ISignList(metaclass=abc.ABCMeta):
    def __init__(self, entry: i_entry.IEntry, calculation_list: calc_str.ICalculationString):
        self.sign_indices = [0]
        self.entry = entry
        self.calculation_list = calculation_list

    @abc.abstractmethod
    def change_sign(self): ...

    @abc.abstractmethod
    def add(self, index: int): ...

    @abc.abstractmethod
    def delete_last(self): ...

    @abc.abstractmethod
    def get_last(self) -> int: ...

    @abc.abstractmethod
    def get_length(self) -> int: ...

    @abc.abstractmethod
    def reset(self): ...
