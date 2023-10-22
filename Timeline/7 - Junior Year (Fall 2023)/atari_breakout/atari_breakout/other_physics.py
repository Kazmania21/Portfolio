import abc


class Gravity:
    def __init__(self): ...


class IGraphPhysics(metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def __init__(self, x: float, y: float):
        self.x = x
        self.y = y

    @abc.abstractmethod
    def change(self, x: float, y: float) -> None: ...

    @abc.abstractmethod
    def reset(self) -> None: ...


class Position(IGraphPhysics):
    def __init__(self, x: float, y: float):
        self.x = x
        self.y = y
        self.default_x = x
        self.default_y = y

    def change(self, x: float, y: float) -> None:
        self.x = x
        self.y = y

    def reset(self) -> None:
        self.x = self.default_x
        self.y = self.default_y


class Velocity(IGraphPhysics):
    def __init__(self, x: float, y: float):
        self.x = x
        self.y = y
        self.default_x = x
        self.default_y = y

    def change(self, x: float, y: float) -> None:
        self.x = x
        self.y = y

    def reset(self) -> None:
        self.x = self.default_x
        self.y = self.default_y
