import pygame
import abc

from pygame import freetype

import other_physics


class IShape(metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def __init__(self): ...

    @abc.abstractmethod
    def draw(self, position: other_physics.IGraphPhysics) -> None: ...

    @abc.abstractmethod
    def get_position(self) -> other_physics.IGraphPhysics: ...

    @abc.abstractmethod
    def get_screen(self) -> pygame.Surface: ...


class ICircleShape(IShape, metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def get_radius(self) -> int: ...


class Circle(ICircleShape):
    def __init__(self, screen: pygame.Surface, color: str, position: other_physics.IGraphPhysics, radius: int):
        self.screen = screen
        self.color = color
        self.position = position
        self.radius = radius

    def draw(self, position: other_physics.IGraphPhysics) -> None:
        pygame.draw.circle(self.screen, self.color, pygame.Vector2(self.position.x, self.position.y), self.radius)

    def get_position(self) -> other_physics.IGraphPhysics:
        return self.position

    def get_screen(self) -> pygame.Surface:
        return self.screen

    def get_radius(self) -> int:
        return self.radius


class IRectangleShape(IShape, metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def get_width(self) -> int: ...

    @abc.abstractmethod
    def get_height(self) -> int: ...


class Rectangle(IRectangleShape):
    def __init__(self, screen: pygame.Surface, color: str, position: other_physics.IGraphPhysics,
                 width: int, height: int):
        self.screen = screen
        self.color = color
        self.position = position
        self.width = width
        self.height = height

    def draw(self, position: other_physics.IGraphPhysics) -> None:
        pygame.draw.rect(self.screen, self.color, pygame.Rect(position.x, position.y, self.width, self.height))

    def get_position(self) -> other_physics.IGraphPhysics:
        return self.position

    def get_width(self) -> int:
        return self.width

    def get_height(self) -> int:
        return self.height

    def get_screen(self) -> pygame.Surface:
        return self.screen


class ITextShape(IShape):
    @abc.abstractmethod
    def change_text(self, text: str) -> None: ...

    @abc.abstractmethod
    def change_font(self, font: freetype.Font) -> None: ...


class Text(ITextShape):
    def __init__(self, screen: pygame.Surface, color: tuple[int, int, int],
                 position: other_physics.IGraphPhysics, font: freetype.Font, text: str,
                 centered: bool = False):
        self.screen = screen
        self.color = color
        self.position = position
        self.font = font
        self.text = text
        self.centered = centered

    def draw(self, position: other_physics.IGraphPhysics) -> None:
        text, rect = self.font.render(self.text, self.color)
        position = (self.position.x, self.position.y)
        if self.centered:
            position = text.get_rect(center=(self.position.x, self.position.y))
        self.screen.blit(text, position)

    def change_text(self, text) -> None:
        self.text = text

    def change_font(self, font: freetype.Font) -> None:
        self.font = font

    def get_position(self) -> other_physics.IGraphPhysics:
        return self.position

    def get_screen(self) -> pygame.Surface:
        return self.screen
