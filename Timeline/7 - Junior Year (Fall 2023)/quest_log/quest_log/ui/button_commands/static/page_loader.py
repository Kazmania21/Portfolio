from .. import interfaces
from ...pages import interfaces as pages


class LoadPagePageAction(interfaces.IAction):
    def __init__(self, page: pages.IPage):
        self.page = page

    def perform(self) -> None:
        self.page.window.set_state(self.page)
