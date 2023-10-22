from .. import interfaces
from selection import interfaces as sel_quest
import tkinter as tk
from ... button_commands import interfaces as cmd
from ...widgets import image_button


class QuestFrame(interfaces.IFrame):
    def __init__(self, options_frame: interfaces.IFrame, create_action: cmd.IAction, selected_quest: sel_quest.SelectedQuest,
                 variables: sel_quest.ISelectedActiveQuests, text_color: str = None, background_color: str = None,
                 button_color: str = None):
        self.options_frame = options_frame
        self.create_action = create_action
        self.selected_quest = selected_quest
        self.variables = variables
        self.text_color = text_color
        self.background_color = background_color
        self.button_color = button_color

    def load(self, frame: tk.Widget, row: int, column: int) -> None:
        quest = self.selected_quest.get()
        variables = self.variables.get()
        name = quest.name
        active = int(quest.active)

        frame = tk.Frame(frame, bg=self.background_color)
        frame.grid(row=row, column=column, sticky="NSEW")

        name_label = tk.Label(frame, text=name, fg=self.text_color, bg=self.background_color)
        name_label.grid(row=0, column=0, sticky="E")

        variables[name] = tk.IntVar(value=active)

        self.options_frame.load(frame, 0, 1)

        create_button = image_button.ImageButton(frame, "./images/plus.png", text_color=self.text_color,
                                                 background_color=self.button_color, text="Add Preceding Quest")
        create_button.configure(command=lambda var=quest: self.selected_quest.perform(self.create_action, var))
        create_button.grid(row=1, column=1, sticky="W")
