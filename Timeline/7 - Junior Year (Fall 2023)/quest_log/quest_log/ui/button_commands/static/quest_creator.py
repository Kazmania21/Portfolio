from .. import interfaces
from selection import interfaces as sel_quest
from ...forms import interfaces as forms
from file_system import interfaces as fs
from ...widgets import interfaces as widgets
from tkinter import messagebox


class CreateAction(interfaces.IAction):
    def __init__(self, form: forms.IEditQuestForm, file_system: fs.IFileSystem, window: widgets.IWindow,
                 selected_quest: sel_quest.SelectedQuest, message=None):
        self.form = form
        self.file_system = file_system
        self.window = window
        self.selected_quest = selected_quest
        self.message = message

    def perform(self) -> None:
        try:
            parent = self.selected_quest.get()
            parent_name = ""
            name = self.form.name_entry.get()
            description = self.form.description_text.get()
            level = 0
            if parent is not None:
                parent_name = parent.name
                level = parent.level + 1
                self.file_system.update(parent.name, "ACTIVE", "0")
            self.file_system.create(name, description, parent_name, level)
            if self.message:
                messagebox.showinfo("Success!", message=self.message)
            self.window.load_previous()

        except Exception:
            messagebox.showerror("Error", message=Exception)
