from tkinter import ttk

from . import interfaces
from selection.quest import interfaces as sel_quest
from factory import factory as qf
from ..frames import interfaces as frames
import tkinter as tk
from ..widgets import scrollable_frame, image_button
from ..button_commands import interfaces as cmd


class EditQuestLogPage(interfaces.IQuestLogPage):
    def __init__(self, factory: qf.IQuestFactory,
                 button_frame: frames.IFrame, quest_frame: frames.IFrame,
                 selected_quest: sel_quest.SelectedQuest, create_action: cmd.IAction,
                 selected_active_quests: sel_quest.ISelectedActiveQuests, text_color: str = None,
                 button_color: str = None, background_color: str = None):
        super().__init__(factory)
        self.button_frame = button_frame
        self.quest_frame = quest_frame
        self.selected_quest = selected_quest
        self.selected_active_quests = selected_active_quests
        self.create_action = create_action
        self.text_color = text_color
        self.button_color = button_color
        self.background_color = background_color

    def load(self, frame: tk.Widget) -> None:
        # frame = Frame(self.window)
        scroll_frame = scrollable_frame.ScrollableFrame(frame, background_color=self.background_color).frame
        quests = self.factory.create()

        index = 0
        outer_row = 0
        inner_row = 0
        variables = {}
        self.selected_active_quests.set(variables)
        next_rule = 1
        quest_line_frame = tk.Frame(scroll_frame, bg=self.background_color)
        quest_line_frame.grid(sticky="N")
        scroll_frame.rowconfigure(0, weight=1)
        scroll_frame.columnconfigure(0, weight=1)
        prev_level = -1
        line_style = ttk.Style()
        line_style.configure("Line.TSeparator", background="grey")

        while quests:
            quest = quests.pop(0)
            print(quest.name)
            for child in quest.quests:
                quests.remove(child)
                quests.insert(0, child)
                next_rule += 1

            next_rule -= 1
            print(f'{next_rule}')

            level = quest.level
            if prev_level != level or level == 0:
                separator = ttk.Separator(quest_line_frame, orient='vertical', style="Line.TSeparator")
                separator.grid(row=0, column=level, sticky="NSW", rowspan=1000, padx=5)
            self.selected_quest.set(quest)
            self.quest_frame.load(quest_line_frame, inner_row, level)
            # quest_line_frame.rowconfigure(inner_row, weight=1)
            # quest_line_frame.columnconfigure(level, weight=1)

            if next_rule == 0 and not index == 0:
                separator = ttk.Separator(scroll_frame, orient='horizontal')
                separator.grid(row=outer_row + 1, column=0, sticky="WE")
                quest_line_frame = tk.Frame(scroll_frame, bg=self.background_color)
                quest_line_frame.grid(row=outer_row + 2, column=0, sticky="NSEW")
                scroll_frame.rowconfigure(outer_row, weight=1)
                next_rule = 1
                outer_row += 2

            index += 1
            inner_row += 1
            prev_level = level

        self.selected_quest.set()
        button = image_button.ImageButton(scroll_frame, "../images/plus.png", text_color=self.text_color,
                                          background_color=self.button_color, text="Add Final Quest")
        button.grid(row=outer_row + 2, sticky="W")
        button.configure(command=self.create_action.perform)

        self.button_frame.load(frame, outer_row + 3, 0)
