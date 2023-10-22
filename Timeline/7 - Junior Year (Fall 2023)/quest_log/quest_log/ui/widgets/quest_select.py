import tkinter as tk


class QuestSelectWidget:
    def __init__(self, selected, widget: tk.Widget):
        self.selected = selected
        self.widget = widget

    def set_command(self, command):
        self.widget.config(command=command)
