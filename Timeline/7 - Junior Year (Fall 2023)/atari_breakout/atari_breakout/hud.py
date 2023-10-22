import pygame
import abc

import other_physics
import shapes
import state
import collision_physics


class IHUD(metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def __init__(self): ...

    @abc.abstractmethod
    def draw(self, time: float) -> None: ...


class Background(IHUD):
    def __init__(self, shape: shapes.IShape, position: other_physics.IGraphPhysics):
        self.shape = shape
        self.position = position

    def draw(self, time: float) -> None:
        self.shape.draw(self.position)


class INumberHUD(IHUD, metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def add(self, amount: int) -> None: ...

    @abc.abstractmethod
    def reset(self) -> None: ...


class ILivesHUD(INumberHUD, metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def lose_life(self) -> None: ...

    @abc.abstractmethod
    def get_lives(self) -> int: ...


class Lives(ILivesHUD):
    def __init__(self, logo: shapes.IShape, lives: int, shape: shapes.ITextShape, state_manager: state.IStateManager):
        self.logo = logo
        self.lives = lives
        self.default_lives = lives
        self.shape = shape
        self.state_manager = state_manager
        shape.change_text(f'{lives}x')

    def draw(self, time: float) -> None:
        self.logo.draw(self.logo.get_position())
        self.shape.draw(self.logo.get_position())

    def add(self, lives: int) -> None:
        self.lives += lives
        self.shape.change_text(f'{self.lives}x')

    def reset(self) -> None:
        self.lives = self.default_lives
        self.shape.change_text(f'{self.lives}x')

    def lose_life(self) -> None:
        self.lives -= 1
        self.shape.change_text(f'{self.lives}x')
        if self.lives == 0:
            self.state_manager.lose()

    def get_lives(self) -> int:
        return self.lives


class StateButton(IHUD):
    def __init__(self, screen: pygame.Surface, color: tuple[int, int, int],
                 position: other_physics.IGraphPhysics, text: shapes.ITextShape,
                 image_location: str):
        self.screen = screen
        self.color = color
        self.position = position
        self.text = text
        self.image = pygame.image.load(image_location)
        self.width = None
        self.height = None

    def draw(self, time: float) -> None:
        self.width = self.image.get_width()
        self.height = self.image.get_height()
        self.screen.blit(self.image, (self.position.x, self.position.y))
        self.text.draw(self.position)


class Score(INumberHUD):
    def __init__(self, text: shapes.ITextShape, score: int = 0):
        self.text = text
        self.score = score
        self.default_score = score
        self.text.change_text(f"Score: {score}")

    def draw(self, time: float) -> None:
        self.text.draw(other_physics.Position(0, 0))

    def add(self, score: int) -> None:
        self.score += score
        self.text.change_text(f"Score: {self.score}")

    def reset(self) -> None:
        self.score = self.default_score
        self.text.change_text(f"Score: {self.score}")
