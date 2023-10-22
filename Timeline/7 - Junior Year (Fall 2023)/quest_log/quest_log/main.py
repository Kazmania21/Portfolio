import sys

from file_system.databases import access
from ui.widgets import window
from ui.button_commands.dynamic import create_quest_page_loader, quest_deletor
from ui.button_commands.static import active_quest_updater, edit_canceller, quest_completer, quest_creator as qc, \
    quest_editor as qe
from ui.forms import edit_quest
from ui.frames.quest import options, quest_normal, quest_shortened
from ui.frames.clickable import button
from ui.frames.entry import name, description
from ui.pages import home, log_editor, quest_creator, quest_editor
from selection import active_quests, quest as sel_quest
from factory import factory
import tkinter as tk

if __name__ == '__main__':
    text_color = "#EEEEEE"
    background_color = "#085394"
    entry_color = "#2B78E4"
    button_color = "#00AAAA"
    check_color = "#00FF00"

    window = window.Window(background_color=background_color)

    menu = tk.Menu(window.window)
    window.window.config(menu=menu)

    file_system = access.AccessDatabaseFileSystem()
    factory = factory.NormalQuestFactory(file_system)
    active_quest_variables = {}
    for quest in factory.create():
        active_quest_variables[quest.name] = quest.active

    """Selected Quest Creation"""

    selected_quest = sel_quest.SelectedQuest()
    selected_active_quest = active_quests.SelectedActiveQuests()

    """Entry Frame Creation"""

    name_entry = name.NameEntryFrame(text_color=text_color, background_color=background_color, entry_color=entry_color)
    description_text = description.DescriptionTextFrame(text_color=text_color, background_color=background_color,
                                                        entry_color=entry_color)

    """Form Creation"""

    edit_quest_form = edit_quest.EditQuestForm(name_entry, description_text)

    """Edit Quest Page"""

    edit_quest_action = qe.EditQuestPageAction(edit_quest_form, file_system, window, selected_quest,
                                               message="Quest edited successfully!")
    cancel_edit_action = edit_canceller.CancelEditPageAction("Are you sure you want to exit this page?", window)
# ✔ ❌
    edit_quest_button_frame = button.ButtonFrame("Apply", "Cancel", edit_quest_action, cancel_edit_action,
                                                 text_color=text_color, background_color=entry_color,
                                                 button_color=button_color)

    edit_quest_page = quest_editor.EditQuestPage(factory, edit_quest_form, edit_quest_button_frame, selected_quest)

    """Create Quest Page"""

    create_action = qc.CreateAction(edit_quest_form, file_system, window, selected_quest,
                                    message="Quest created successfully!")
    cancel_create_action = edit_canceller.CancelEditPageAction("Are you sure you want to exit this page?", window)

    create_button_frame = button.ButtonFrame("Create", "Cancel", create_action, cancel_create_action,
                                             text_color=text_color, background_color=entry_color,
                                             button_color=button_color)

    create_page = quest_creator.CreateQuestLogPage(factory, edit_quest_form, create_button_frame)

    """Edit Quest Log Page"""

    edit_page_create_action = create_quest_page_loader.LoadCreatePage(selected_quest, create_page, window)
    edit_page_edit_action = create_quest_page_loader.LoadCreatePage(selected_quest, edit_quest_page, window)
    delete_action = quest_deletor.DeleteQuestAction(file_system, window, selected_quest,
                                                    message="Quest Deleted Successfully!")
    apply_action = active_quest_updater.UpdateActiveQuestsPageAction(file_system, selected_active_quest)

    options_frame = options.OptionsFrame(edit_page_edit_action, delete_action, selected_quest, selected_active_quest,
                                         text_color=text_color, background_color=background_color,
                                         check_color=check_color, button_color=button_color)
    quest_frame = quest_normal.QuestFrame(options_frame, edit_page_create_action, selected_quest, selected_active_quest,
                                          text_color=text_color, background_color=background_color,
                                          button_color=button_color)
    edit_button_frame = button.ButtonFrame("Apply", "Cancel", apply_action, cancel_edit_action,
                                           text_color=text_color, background_color=entry_color,
                                           button_color=button_color)

    edit_page = log_editor.EditQuestLogPage(factory, edit_button_frame, quest_frame,
                                            selected_quest, edit_page_create_action, selected_active_quest,
                                            text_color=text_color, button_color=button_color,
                                            background_color=background_color)

    """Home Page"""

    complete_quest_action = quest_completer.CompleteQuestAction(window, selected_quest)

    shortened_quest_frame = quest_shortened.ShortenedQuestFrame(complete_quest_action, selected_quest,
                                                                text_color=text_color,
                                                                background_color=background_color)

    main_page = home.NormalQuestLogPage(factory, shortened_quest_frame, selected_quest,
                                        background_color=background_color)
    window.load(main_page)

    """Menu"""

    file_menu = tk.Menu(menu)
    file_menu.add_command(
        label='Edit',
        command=lambda: window.load(edit_page)
    )
    file_menu.add_command(
        label='Exit',
        command=sys.exit
    )
    menu.add_cascade(
        label="File",
        menu=file_menu
    )

    window.window.mainloop()
