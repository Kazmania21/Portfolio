from .. import interfaces
import tkinter as tk


class EntryInputButton(interfaces.IEntryInputButton):
    def load(self, frame: tk.Frame, row: int, column: int):
        command = self.commands.perform

        tk.Button(frame, text=self.text, font=self.font.font, command=lambda: command(self.entry_input_info))\
            .grid(row=row, column=column, sticky="NSEW")
        self.window.window.bind(self.hotkey, lambda event: command(self.entry_input_info))
