import abc
from data import quest
import tkinter as tk
from ui.button_commands import interfaces as cmd


class SelectedQuest(metaclass=abc.ABCMeta):
    def __init__(self, selected_quest: quest.IQuest = None):
        self.selected_quest = selected_quest

    @abc.abstractmethod
    def set(self, quest: quest.IQuest = None): ...

    @abc.abstractmethod
    def get(self) -> quest.IQuest: ...

    @abc.abstractmethod
    def perform(self, command: cmd.IAction, quest: quest.IQuest): ...


class ISelectedActiveQuests(metaclass=abc.ABCMeta):
    def __init__(self, selected_active_quests: dict[str, tk.IntVar] = None):
        self.selected_active_quests = selected_active_quests

    @abc.abstractmethod
    def set(self, selected_active_quests: dict[str, tk.IntVar]):
        self.selected_active_quests = selected_active_quests

    @abc.abstractmethod
    def get(self) -> dict[str, tk.IntVar]:
        return self.selected_active_quests
