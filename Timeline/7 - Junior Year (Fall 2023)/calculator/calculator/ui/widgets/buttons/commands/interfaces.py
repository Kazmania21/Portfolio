import abc
import typing
from ...entries import interfaces as i_entry
from ..sign import interfaces as i_sign_list
from data.lists.calculation import interfaces as calc_str
from data.databases import interfaces as db
from ....info import interfaces as info


class IEntryInputCommand(metaclass=abc.ABCMeta):
    def __init__(self, entry: i_entry.IEntry, calculation_string: calc_str.ICalculationString,
                 sign_list: i_sign_list.ISignList):
        self.entry = entry
        self.calculation_string = calculation_string
        self.sign_list = sign_list
        self.mediator: typing.Optional["ICommands"] = None

    def set_mediator(self, mediator: "ICommands"):
        self.mediator = mediator

    @abc.abstractmethod
    def perform(self, entry_input_info: info.IEntryInputInfo): ...


class IHistoryCommand(metaclass=abc.ABCMeta):
    def __init__(self, history_database: db.IFileSystem):
        self.history_database = history_database

    @abc.abstractmethod
    def perform(self, button: info.IHistoryInfo): ...


class ICommands(metaclass=abc.ABCMeta):
    def __init__(self, commands: list[IEntryInputCommand]):
        self.commands = commands
        self.performable = True
        for command in commands:
            command.set_mediator(self)

    @abc.abstractmethod
    def perform(self, entry_input_info: info.IEntryInputInfo): ...


class Commands(ICommands):
    def perform(self, entry_input_info: info.IEntryInputInfo):
        for command in self.commands:
            if self.performable:
                command.perform(entry_input_info)
        self.performable = True
