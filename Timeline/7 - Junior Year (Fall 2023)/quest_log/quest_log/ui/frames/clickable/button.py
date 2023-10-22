from .. import interfaces
import tkinter as tk
from ...button_commands import interfaces as cmd
# TODO: make frame into its own class with an interface called IFrame
# TODO: type all functions that don't have return values to None
from ...widgets import image_button


class ButtonFrame(interfaces.IFrame):
    def __init__(self, apply_text: str, cancel_text: str, apply_command: cmd.IAction, cancel_command: cmd.IAction,
                 text_color: str = None, background_color: str = None, button_color: str = None):
        self.apply_text = apply_text
        self.cancel_text = cancel_text
        self.apply_command = apply_command
        self.cancel_command = cancel_command
        self.text_color = text_color
        self.background_color = background_color
        self.button_color = button_color

    def load(self, frame: tk.Tk, row: int, column: int) -> None:
        button_frame = tk.Frame(frame, bg=self.background_color)
        button_frame.grid(row=row, sticky="SEW", columnspan=1000)
        button_frame.columnconfigure(0, weight=1)
        button_frame.columnconfigure(1, weight=1)

        apply_button = image_button.ImageButton(button_frame, "./images/checkmark.png",
                                                text_color=self.text_color, background_color=self.button_color,
                                                text=self.apply_text)
        apply_button.grid(row=0, sticky="W")
        cancel_button = image_button.ImageButton(button_frame, "./images/x.png", text_color=self.text_color,
                                                 background_color=self.button_color,
                                                 text=self.cancel_text)
        cancel_button.grid(row=0, column=1, sticky="E")
        apply_button.configure(command=self.apply_command.perform)
        cancel_button.configure(command=self.cancel_command.perform)

