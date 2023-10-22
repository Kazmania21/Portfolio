from .. import interfaces
from selection import interfaces as sel_quest
from ...pages import interfaces as pages
from ...widgets import interfaces as widgets


class LoadCreatePage(interfaces.IAction):
    def __init__(self, selected_quest: sel_quest.SelectedQuest, page: pages.IPage, window: widgets.IWindow):
        self.selected_quest = selected_quest
        self.page = page
        self.window = window

    def perform(self) -> None:
        self.window.load(self.page)
