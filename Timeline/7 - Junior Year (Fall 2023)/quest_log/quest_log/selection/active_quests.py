from . import interfaces
import tkinter as tk


class SelectedActiveQuests(interfaces.ISelectedActiveQuests):
    def set(self, selected_active_quests: dict[str, tk.IntVar]):
        self.selected_active_quests = selected_active_quests

    def get(self) -> dict[str, tk.IntVar]:
        return self.selected_active_quests
