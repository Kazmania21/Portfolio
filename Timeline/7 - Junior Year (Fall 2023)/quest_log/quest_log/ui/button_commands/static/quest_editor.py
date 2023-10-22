from .. import interfaces
from ...forms import interfaces as forms
from selection import interfaces as sel_quest
from file_system import interfaces as fs
from ...widgets import interfaces as widgets
from tkinter import messagebox


class EditQuestPageAction(interfaces.IAction):
    def __init__(self, form: forms.IEditQuestForm, file_system: fs.IFileSystem, window: widgets.IWindow,
                 selected_quest: sel_quest.SelectedQuest, message=None):
        self.form = form
        self.file_system = file_system
        self.window = window
        self.selected_quest = selected_quest
        self.message = message

    def perform(self) -> None:
        try:
            quest = self.selected_quest.get()
            file_system = self.file_system
            file_system.update(quest.name, "NAME", self.form.name_entry.get())
            file_system.update(quest.name, "DESCRIPTION", self.form.description_text.get())
            if self.message:
                messagebox.showinfo("Success!", message=self.message)
            self.window.load_previous()
        except Exception:
            messagebox.showerror("Error", message=Exception)
