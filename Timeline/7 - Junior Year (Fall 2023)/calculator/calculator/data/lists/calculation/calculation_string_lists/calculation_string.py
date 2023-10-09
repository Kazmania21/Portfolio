from .. import interfaces
import tkinter.messagebox as messagebox


class CalculationString(interfaces.ICalculationString):
    def add_input(self, calculation_input: str):
        self.calculation_string_list.append(calculation_input)

    def get_inputs(self) -> list[str]:
        return self.calculation_string_list

    def delete_last_input(self):
        if len(self.calculation_string_list) != 0:
            del self.calculation_string_list[-1]

    def delete_last_number(self, last_sign_index: int):
        index = last_sign_index

        self.calculation_string_list = self.calculation_string_list[:index + 1]

        if index == 0 and len(self.calculation_string_list) != 0:
            del self.calculation_string_list[index]
        print(self.calculation_string_list)

    def delete_all_inputs(self):
        self.calculation_string_list: list[str] = []

    def calculate(self) -> str:
        try:
            answer = ""
            for item in self.calculation_string_list:
                answer += item
            return str(eval(answer))
        except SyntaxError as error:
            print(self.calculation_string_list)
            messagebox.showerror(title="Syntax Error", message=error.msg)
            return "Syntax Error"

    def set_answer(self, answer: str):
        self.delete_all_inputs()
        for character in answer:
            self.add_input(character)
