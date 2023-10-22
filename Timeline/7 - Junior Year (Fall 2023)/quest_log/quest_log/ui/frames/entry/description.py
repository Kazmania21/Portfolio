from .. import interfaces
import tkinter as tk


class DescriptionTextFrame(interfaces.IEntryFrame):
    def __init__(self, text_color: str = None, background_color: str = None, entry_color: str = None):
        super().__init__()
        self.text_color = text_color
        self.background_color = background_color
        self.entry_color = entry_color

    def load(self, frame: tk.Tk, row: int, column: int) -> None:
        # frame = Frame(frame)
        # frame.grid(row=row, column=column)
        tk.Label(frame, text="Description:", fg=self.text_color, bg=self.background_color).grid(row=row, sticky="NW")
        self.text = tk.Text(frame, fg=self.text_color, bg=self.entry_color)
        self.text.grid(row=row, column=column + 1, sticky="W")

    def get(self) -> str:
        return self.text.get(0.0, tk.END)

    def set_text(self, text: str):
        self.text.insert(tk.END, text)
