import sys
import tkinter as tk
from ui.masters import window as win
from ui.widgets.entries.calculator_entry import calculator_entry as entry
from ui.widgets.buttons import commands as cmd
from ui.widgets.buttons.entry_button import entry_button as btn
from ui.pages.pages import page
from ui.widgets.buttons.sign.sign_lists import sign_list
from ui.fonts.fonts import font
from ui.fonts import font_mediator as font_med
from ui.collections import history_frame as his_frame
from data.databases import history_database as db
from data.lists.calculation.calculation_string_lists import calculation_string as calc_str
from ui.info.entry_input import entry_input as info

if __name__ == '__main__':
    window = win.Window()

    """Fonts"""

    font_med = font_med.Fonts(window)
    entry_font = font.Font(window, 30)
    button_font = font.Font(window, 11)
    history_font = font.Font(window, 11)
    history_button_font = font.Font(window, 15)
    font_med.add(entry_font)
    font_med.add(button_font)

    """History"""

    history_location = r'..\history\history.accdb'
    history_database = db.HistoryDatabase("history", history_location)
    history_frame = his_frame.HistoryFrame(history_database, history_font, history_button_font)

    """Menu"""

    menu = tk.Menu(window.window)
    window.window.config(menu=menu)

    file_menu = tk.Menu(menu)
    file_menu.add_command(
        label='History',
        command=lambda: history_frame.change_load_state(window.window)
    )
    file_menu.add_command(
        label='Exit',
        command=sys.exit
    )
    menu.add_cascade(
        label="File",
        menu=file_menu
    )

    """Commands"""

    calculation_string = calc_str.CalculationString()

    entry = entry.Entry(window, entry_font)
    sign_list = sign_list.SignList(entry, calculation_string)

    convert_command = cmd.Commands([cmd.ConvertEntryInputCommand(entry, calculation_string, sign_list),
                                    cmd.EntryInputCommand(entry, calculation_string, sign_list),
                                    cmd.CalculateEntryInputCommand(entry, calculation_string, sign_list,
                                                                   history_database, history_frame)])

    delete_number_command = cmd.Commands([cmd.DeleteNumberEntryInputCommand(entry, calculation_string, sign_list)])

    delete_all_command = cmd.Commands([cmd.DeleteAllEntryInputCommand(entry, calculation_string, sign_list)])

    delete_last_command = cmd.Commands([cmd.DeleteLastEntryInputCommand(entry, calculation_string, sign_list)])

    operator_command = cmd.Commands([cmd.OperatorEntryInputCommand(entry, calculation_string, sign_list),
                                     cmd.EntryInputCommand(entry, calculation_string, sign_list)])

    input_command = cmd.Commands([cmd.EntryInputCommand(entry, calculation_string, sign_list)])

    sign_switch_command = cmd.Commands([cmd.SignEntryInputCommand(entry, calculation_string, sign_list)])

    calculate_command = cmd.Commands(
        [cmd.CalculateEntryInputCommand(entry, calculation_string, sign_list, history_database,
                                        history_frame)])

    """Normal Calculator Buttons"""

    buttons = [btn.EntryInputButton(window, "%", "%", button_font, convert_command,
                                    info.EntryInputInfo("%", calculation_input="/100")),
               btn.EntryInputButton(window, "CE", "C", button_font, delete_number_command, info.EntryInputInfo("CE")),
               btn.EntryInputButton(window, "C", "c", button_font, delete_all_command, info.EntryInputInfo("C")),
               btn.EntryInputButton(window, "<", "<BackSpace>", button_font, delete_last_command,
                                    info.EntryInputInfo("<")),
               btn.EntryInputButton(window, "1/x", "$", button_font, convert_command,
                                    info.EntryInputInfo("1/x", calculation_input="**-1")),
               btn.EntryInputButton(window, "x^2", "^", button_font, convert_command,
                                    info.EntryInputInfo("x^2", calculation_input="**2")),
               btn.EntryInputButton(window, "sqrt", "&", button_font, convert_command,
                                    info.EntryInputInfo("sqrt", calculation_input="**.5")),
               btn.EntryInputButton(window, "/", "/", button_font, operator_command, info.EntryInputInfo("/")),
               btn.EntryInputButton(window, "7", "7", button_font, input_command, info.EntryInputInfo("7")),
               btn.EntryInputButton(window, "8", "8", button_font, input_command, info.EntryInputInfo("8")),
               btn.EntryInputButton(window, "9", "9", button_font, input_command, info.EntryInputInfo("9")),
               btn.EntryInputButton(window, "*", "*", button_font, operator_command, info.EntryInputInfo("*")),
               btn.EntryInputButton(window, "4", "4", button_font, input_command, info.EntryInputInfo("4")),
               btn.EntryInputButton(window, "5", "5", button_font, input_command, info.EntryInputInfo("5")),
               btn.EntryInputButton(window, "6", "6", button_font, input_command, info.EntryInputInfo("6")),
               btn.EntryInputButton(window, "-", "-", button_font, operator_command, info.EntryInputInfo("-")),
               btn.EntryInputButton(window, "1", "1", button_font, input_command, info.EntryInputInfo("1")),
               btn.EntryInputButton(window, "2", "2", button_font, input_command, info.EntryInputInfo("2")),
               btn.EntryInputButton(window, "3", "3", button_font, input_command, info.EntryInputInfo("3")),
               btn.EntryInputButton(window, "+", "+", button_font, operator_command, info.EntryInputInfo("+")),
               btn.EntryInputButton(window, "+/-", "_", button_font, sign_switch_command, info.EntryInputInfo("+/-")),
               btn.EntryInputButton(window, "0", "0", button_font, input_command, info.EntryInputInfo("0")),
               btn.EntryInputButton(window, ".", ".", button_font, input_command, info.EntryInputInfo(".")),
               btn.EntryInputButton(window, "=", "<Return>", button_font, calculate_command, info.EntryInputInfo("="))]

    """Pages"""

    page = page.Page(window, entry, buttons, 4)
    page.load()
    # todo: fix answer to previous expression in calculation string list so that the digits are different indexes
    # todo: fix interaction with CE and ^2
    # todo: fix sign change with dp
    # todo: fix delete last number to include negative symbols next to a operation symbol
    # todo: turn fonts into its own class
    # todo: allow this module to set the button frame columns
    # todo: had catch for syntax errors
    # todo: fix the sign change with decimal answers
    # todo: fix fonts causing file menu to flash
    # todo: fix the sign change with answers (IndexError: string index out of range (sign_list.py line 37))
    window.window.mainloop()
