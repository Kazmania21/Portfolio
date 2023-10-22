import pygame
from abc import ABCMeta, abstractmethod

from physics import IGraphPhysics
from shapes import IShape


class IHUD(metaclass=ABCMeta):
    @abstractmethod
    def __init__(self): ...

    @abstractmethod
    def draw(self, time): ...


class Background(IHUD):
    def __init__(self, shape: IShape, position: IGraphPhysics):
        self.shape = shape
        self.position = position

    def draw(self, time):
        self.shape.draw(self.position)


class Lives(IHUD):
    def __init__(self, logo, lives, shape: IShape):
        self.logo = logo
        self.lives = lives
        self.shape = shape

    def draw(self, time):
        self.shape.draw(self.logo.position)

