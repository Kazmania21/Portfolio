import sys
import os
import parameterized
import unittest
import tkinter.messagebox as messagebox


calculation_string_lists = [["9", "+", "1", "0"], ["1", "0", "+", "9"]]

# @parameterized.parameterized_class(('calculation_string_list',), [[["9", "+", "1", "0"], ["1", "0", "+", "9"]]])
class CalculationString(unittest.TestCase):
    def add_input(self, calculation_input: str):
        self.calculation_string_list.append(calculation_input)

    def get_inputs(self) -> list[str]:
        return self.calculation_string_list

    def delete_last_input(self):
        if len(self.calculation_string_list) != 0:
            del self.calculation_string_list[-1]

    @parameterized.parameterized.expand([(1, calculation_string_lists[0], ["9", "+"]),
                                         (2, calculation_string_lists[1], ["1", "0", "+"])])
    def test_delete_last_number(self, last_sign_index: int, calculation_string_list, expected):
        self.calculation_string_list = calculation_string_list
        index = last_sign_index

        self.calculation_string_list = self.calculation_string_list[:index + 1]

        if index == 0 and len(self.calculation_string_list) != 0:
            del self.calculation_string_list[index]
        print(self.calculation_string_list)
        self.assertEqual(expected, self.get_inputs())

    def delete_all_inputs(self):
        self.calculation_string_list: list[str] = []

    @parameterized.parameterized.expand([(calculation_string_lists[0], 19), (calculation_string_lists[1], 19)])
    def test_calculate(self, calculation_string_list, expected) -> str:
        self.calculation_string_list = calculation_string_list
        answer = ""
        for item in self.calculation_string_list:
            answer += item
        if expected:
            self.assertEqual(expected, eval(answer))
        else:
            self.assertRaises(SyntaxError)
        return str(eval(answer))

    def set_answer(self, answer: str):
        self.delete_all_inputs()
        for character in answer:
            self.add_input(character)


# suite = unittest.TestLoader().loadTestsFromTestCase(CalculationString("test_delete_last_number"))
# unittest.TextTestRunner().run(suite)

"""suite = unittest.TestSuite()
suite.addTest(CalculationString("test_calculate"))
runner = unittest.TextTestRunner()
runner.run(suite)"""
