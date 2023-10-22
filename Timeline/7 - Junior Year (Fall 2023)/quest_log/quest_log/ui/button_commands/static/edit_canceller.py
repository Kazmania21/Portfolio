from .. import interfaces
from tkinter import messagebox
from ... widgets import interfaces as widgets


class CancelEditPageAction(interfaces.IAction):
    def __init__(self, message_text: str, window: widgets.IWindow):
        self.message_text = message_text
        self.window = window

    def perform(self) -> None:
        exiting = messagebox.askyesno("Exit Page?", message=self.message_text)

        if exiting:
            self.window.load_previous()
