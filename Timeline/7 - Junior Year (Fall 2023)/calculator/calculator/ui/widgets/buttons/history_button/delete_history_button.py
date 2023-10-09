from .. import interfaces
import tkinter as tk


class DeleteHistoryButton(interfaces.IHistoryButton):
    def load(self, frame: tk.Frame, row: int, column: int):
        command = self.command.perform

        self.button = tk.Button(frame, text=self.text, font=self.font.font, fg="white", bg="red")
        self.button.grid(row=row, column=column, sticky="NSEW")
