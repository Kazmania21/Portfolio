from .. import interfaces
from selection import interfaces as sel_quest
from ...widgets.label_image import LabelImage
from ...widgets import image_button
from ...button_commands import interfaces as cmd
import tkinter as tk
# todo: specify dict values


class OptionsFrame(interfaces.IFrame):
    def __init__(self, edit_command: cmd.IAction, delete_command: cmd.IAction, selected_quest: sel_quest.SelectedQuest,
                 variables: sel_quest.ISelectedActiveQuests, text_color: str = None, background_color: str = None,
                 check_color: str = None, button_color: str = None):
        self.edit_command = edit_command
        self.delete_command = delete_command
        self.selected_quest = selected_quest
        self.variables = variables
        self.text_color = text_color
        self.background_color = background_color
        self.check_color = check_color
        self.button_color = button_color

    def load(self, frame: tk.Tk, row: int, column: int) -> None:
        quest = self.selected_quest.get()
        variables = self.variables.get()
        name = quest.name

        options_frame = tk.Frame(frame, bg=self.background_color)
        options_frame.grid(row=row, column=column)
        tk.Checkbutton(options_frame, variable=variables[name], fg=self.check_color,
                       bg=self.background_color, highlightthickness=0).grid(row=0, column=0)
        check_label = tk.Label(options_frame, text="Active", fg=self.text_color, bg=self.background_color)
        check_label.grid(row=0, column=1)

        img_label = image_button.ImageButton(options_frame, "../edit_pen.png",
                                             text_color=self.text_color,
                                             background_color=self.button_color, text="Edit")
        img_label.grid(row=0, column=2)
        img_label.bind("<Button-1>", lambda event, var=quest: self.selected_quest.perform(self.edit_command, var))

        delete_button = image_button.ImageButton(options_frame, "./images/trash.png",
                                                 text_color=self.text_color,
                                                 background_color=self.button_color, text="Delete")
        delete_button.configure(command=lambda var=quest: self.selected_quest.perform(self.delete_command, var))
        delete_button.grid(row=0, column=4, padx=8)
