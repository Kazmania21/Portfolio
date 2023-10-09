from .. import interfaces
import tkinter as tk


class Entry(interfaces.IEntry):
    def load(self, row: int, column: int):
        self.entry = tk.Entry(self.window.frame, font=self.font.font, state="readonly")
        self.entry.grid(row=row, column=column, sticky="NSEW")

    def insert(self, index: int, text: str):
        self.entry.config(state="normal")
        self.entry.insert(index, text)
        self.entry.config(state="readonly")

    def delete(self, start: int, end: int = None):
        self.entry.config(state="normal")
        self.entry.delete(start, end)
        self.entry.config(state="readonly")

    def set_text(self, text: str):
        self.insert(tk.END, text)

    def get_text(self) -> str:
        return self.entry.get()

    def get_length(self) -> int:
        return len(self.entry.get())

    def delete_last(self):
        length = self.get_length() - 1
        self.delete(length)

    def delete_last_number(self, last_sign_index: int):
        index = last_sign_index

        self.delete(index+1, tk.END)

        if index == 0:
            self.delete(index)

    def delete_all(self):
        length = len(self.entry.get())
        self.delete(0, length)

    def set_answer(self, answer: str):
        self.delete_all()
        self.set_text(answer)
