from .. import interfaces
from ....entries import interfaces as i_entry
from calculator.data.lists.calculation import interfaces as calc_str


class SignList(interfaces.ISignList):
    def set_entry(self, entry: "i_entry.IEntry"):
        self.entry = entry

    def set_calculation_list(self, calculation_list: "calc_str.ICalculationString"):
        self.calculation_list = calculation_list

    def add(self, index: int):
        self.sign_indices.append(index)

    def delete_last(self):
        del self.sign_indices[-1]

    def get_last(self) -> int:
        return self.sign_indices[-1]

    def get_length(self) -> int:
        return len(self.sign_indices)

    def reset(self):
        self.sign_indices = [0]

    def change_sign(self):
        text = self.entry.get_text
        inputs = self.calculation_list.get_inputs()

        length = self.get_length()
        prev_index = None
        if length != 1:
            prev_index = self.sign_indices[-2]
        index = self.get_last()
        character = text()[index]
        print(self.sign_indices)
        if character == "+":
            self.entry.delete(index)
            self.entry.insert(index, "-")
            del inputs[index]
            inputs.insert(index, "-")

        elif character == "-":
            self.entry.delete(index)
            print(text()[index - 1])
            del inputs[index]
            print(inputs[index - 1])
            if prev_index is not None:
                if index - prev_index != 1 or prev_index == 0:
                    self.entry.insert(index, "+")
                    inputs.insert(index, "+")
                else:
                    self.delete_last()
            else:
                self.delete_last()

        elif length != 1:
            self.entry.insert(index + 1, "-")
            print(f"hi: {index}")
            inputs.insert(index + 1, "-")
            self.add(index + 1)

        else:
            self.entry.insert(index, "-")
            inputs.insert(index, "-")
            self.add(index)
        print(f"calc: {inputs}")
