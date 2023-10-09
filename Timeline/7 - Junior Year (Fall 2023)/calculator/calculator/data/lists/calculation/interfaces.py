import abc


class ICalculationString(metaclass=abc.ABCMeta):
    def __init__(self):
        self.calculation_string_list: list[str] = []

    @abc.abstractmethod
    def add_input(self, calculation_input: str): ...

    @abc.abstractmethod
    def get_inputs(self) -> list[str]: ...

    @abc.abstractmethod
    def calculate(self) -> str: ...

    @abc.abstractmethod
    def delete_all_inputs(self): ...

    @abc.abstractmethod
    def delete_last_input(self): ...

    @abc.abstractmethod
    def delete_last_number(self, last_sign_index: int): ...

    @abc.abstractmethod
    def set_answer(self, answer: str): ...
