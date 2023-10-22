from .. import interfaces
from selection import interfaces as sel_quest
from file_system import interfaces as fs
from ...widgets import interfaces as widgets
from tkinter import messagebox


class DeleteQuestAction(interfaces.IAction):
    def __init__(self, file_system: fs.IFileSystem, window: widgets.IWindow, selected_quest: sel_quest.SelectedQuest,
                 message=None):
        self.file_system = file_system
        self.window = window
        self.selected_quest = selected_quest
        self.message = message

    def perform(self) -> None:
        try:
            quest = self.selected_quest.get()
            self.file_system.delete(quest.name)
            if self.message:
                messagebox.showinfo("Success!", message=self.message)
            self.window.reload()
        except Exception:
            messagebox.showerror("Error", message=Exception)
