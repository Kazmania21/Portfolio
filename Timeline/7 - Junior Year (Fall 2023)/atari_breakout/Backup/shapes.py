import pygame
from abc import ABCMeta, abstractmethod

from pygame.freetype import Font

from physics import Position


class IShape(metaclass=ABCMeta):
    @abstractmethod
    def __init__(self): ...

    @abstractmethod
    def draw(self, position): ...


class Circle(IShape):
    def __init__(self, screen: pygame.Surface, color: str, position: Position, radius: int):
        self.screen = screen
        self.color = color
        self.position = position
        self.radius = radius

    def draw(self, position):
        pygame.draw.circle(self.screen, self.color, pygame.Vector2(self.position.x, self.position.y), self.radius)


class Rectangle(IShape):
    def __init__(self, screen: pygame.Surface, color: str, position: Position, width: int, height: int):
        self.screen = screen
        self.color = color
        self.position = position
        self.width = width
        self.height = height

    def draw(self, position):
        pygame.draw.rect(self.screen, self.color, pygame.Rect(position.x, position.y, self.width, self.height))


class Text(IShape):
    def __init__(self, screen: pygame.Surface, color: tuple[int], position: Position, font: Font, text: str):
        self.screen = screen
        self.color = color
        self.position = position
        self.font = font
        self.text = text

    def draw(self, position):
        text, rect = self.font.render(self.text, self.color)
        self.screen.blit(text, (150, self.screen.get_height() / 4 * 3 + 75))
