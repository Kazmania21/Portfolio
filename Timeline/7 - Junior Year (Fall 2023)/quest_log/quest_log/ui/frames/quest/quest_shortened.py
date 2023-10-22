from .. import interfaces
from selection import interfaces as sel_quest
import tkinter as tk
from ...button_commands import interfaces as cmd


class ShortenedQuestFrame(interfaces.IFrame):
    def __init__(self, complete_quest_action: cmd.IAction, selected_quest: sel_quest.SelectedQuest,
                 text_color: str = None, background_color: str = None):
        self.complete_quest_action = complete_quest_action
        self.selected_quest = selected_quest
        self.text_color = text_color
        self.background_color = background_color

    def load(self, frame: tk.Widget, row: int, column: int) -> None:
        quest = self.selected_quest.get()
        tk.Label(frame, text=quest.name, fg=self.text_color, bg=self.background_color).grid(row=row, sticky="NW")
        complete_quest_button = tk.Checkbutton(frame, bg=self.background_color, text="Complete", fg=self.text_color)
        action = self.complete_quest_action
        complete_quest_button.configure(command=lambda var=quest: self.selected_quest.perform(action, var))
        complete_quest_button.grid(row=row, column=1, sticky="N")
        description = tk.Label(frame, text=quest.description, fg=self.text_color, bg=self.background_color)
        description.grid(row=row + 1, sticky="NW", padx=32)
