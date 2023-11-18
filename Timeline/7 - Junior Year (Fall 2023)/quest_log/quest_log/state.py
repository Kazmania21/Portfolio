from abc import ABCMeta, abstractmethod
from quest_log.ui.widgets.interfaces import IWindow


class IState(metaclass=ABCMeta):
    def __init__(self, window: IWindow, current = None, previous = None):
        self.window = window
        self.current = current
        self.previous = previous
        self.pages = []

    @abstractmethod
    def set_state(self, state): ...

    @abstractmethod
    def load_previous(self): ...


class State(IState):
    def set_state(self, state: ui.IPage):
        if self.current != state:
            self.previous = self.current
            self.current = state
        self.pages.append(self.current)
        self.window.reset_window()
        state.frame = self.window.frame

    def load_previous(self):
        del self.pages[len(self.pages) - 1]
        self.window.reset_window()
        self.current = self.previous
        self.previous = self.pages[len(self.pages) - 2]
        self.current.frame = self.window.frame
        self.current.load()
