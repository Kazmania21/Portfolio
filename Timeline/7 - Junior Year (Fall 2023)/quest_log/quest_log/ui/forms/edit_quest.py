from .interfaces import *
import tkinter as tk


class EditQuestForm(IEditQuestForm):
    def load(self, frame: tk.Widget) -> None:
        background_color = frame["background"]
        inner_frame = tk.Frame(frame, bg=background_color)
        inner_frame.grid(row=0, column=0)
        self.name_entry.load(inner_frame, 0, 0)
        tk.Frame(inner_frame, height=10, bg=background_color).grid(row=1, sticky="NW")
        self.description_text.load(inner_frame, 2, 0)
        tk.Frame(inner_frame, height=10, bg=background_color).grid(row=3, sticky="NW")
        tk.Frame(inner_frame, height=10, bg=background_color, width=10).grid(row=3, column=2)
