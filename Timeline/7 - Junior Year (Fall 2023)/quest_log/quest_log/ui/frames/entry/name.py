from .. import interfaces
import tkinter as tk


class NameEntryFrame(interfaces.IEntryFrame):
    def __init__(self, text_color: str = None, background_color: str = None, entry_color: str = None):
        super().__init__()
        self.text_color = text_color
        self.background_color = background_color
        self.entry_color = entry_color

    def load(self, frame: tk.Tk, row: int, column: int):
        # frame = Frame(frame)
        # frame.grid(row=row, column=column, sticky="NSEW")
        tk.Label(frame, text="Name:", fg=self.text_color, bg=self.background_color).grid(row=row, sticky="E")
        self.text = tk.Entry(frame, fg=self.text_color, bg=self.entry_color)
        self.text.grid(row=row, column=column + 1, sticky="W")

    def get(self) -> str:
        return self.text.get()

    def set_text(self, text: str):
        self.text.insert(0, text)
