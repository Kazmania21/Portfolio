from .. import interfaces
import tkinter as tk


class Page(interfaces.IPage):
    def load(self):
        self.entry.load(0, 0)
        frame = tk.Frame(self.window.frame)
        frame.grid(row=1, sticky="NSEW")
        for i in range(self.columns):
            frame.columnconfigure(i, weight=1)
        for index, button in enumerate(self.buttons):
            button.load(frame, row=int(index / self.columns) + 1, column=index % self.columns)
            if index % self.columns == 0:
                frame.rowconfigure(int(index/self.columns), weight=1)
