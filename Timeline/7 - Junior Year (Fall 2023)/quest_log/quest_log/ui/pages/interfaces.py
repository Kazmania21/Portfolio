from factory import factory as qf
import abc
import tkinter as tk


class IPage(metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def load(self, frame: tk.Widget) -> None: ...


class IQuestLogPage(IPage, metaclass=abc.ABCMeta):
    def __init__(self, factory: qf.IQuestFactory):
        self.factory = factory

# class IEditQuestPage(IQuestLogPage, metaclass=ABCMeta):
#     def __init__(self, window: IWindow, factory: IQuestFactory, quest: IQuest):
#         super().__init__(window, factory)
#         self.quest = quest
