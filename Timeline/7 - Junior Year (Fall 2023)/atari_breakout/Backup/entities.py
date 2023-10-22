from abc import ABCMeta, abstractmethod
import pygame
from physics import *
from shapes import IShape


class IEntity(metaclass=ABCMeta):
    @abstractmethod
    def __init__(self): ...

    @abstractmethod
    def draw(self, time): ...


class Ball(IEntity):
    def __init__(self, shape: IShape, position: IGraphPhysics, velocity: IGraphPhysics):
        self.shape = shape
        self.position = position
        self.collider = CircleCollider(self.position, self.shape.radius)
        self.prev_collision = None
        self.velocity = velocity

    def draw(self, time):
        if not self.check_collision():
            self.move(time)
        self.shape.draw(self.position)

    def move(self, dt):
        self.position.x += self.velocity.x * dt
        self.position.y += self.velocity.y * dt
        self.collider = CircleCollider(self.position, self.shape.radius)

    def check_collision(self):
        for collision in self.collider.collisions.values():
            print(collision)
            if collision["obj"] != self.prev_collision:
                if isinstance(collision["obj"], Slider):
                    print("hi")
                    self.velocity.y *= -1
                    if collision["horizontal_side"] == "left" and self.velocity.x >= 0:
                        self.velocity.x *= -1
                    elif collision["horizontal_side"] == "right" and self.velocity.x <= 0:
                        self.velocity.x *= -1
                else:
                    if collision["side"] == "top" or collision["side"] == "bottom":
                        self.velocity.y *= -1
                    else:
                        self.velocity.x *= -1
                self.prev_collision = collision["obj"]


class Slider(IEntity):
    def __init__(self, shape: IShape, position: IGraphPhysics):
        self.shape = shape
        self.position = position
        self.collider = SquareCollider(self.position, self.shape.width, self.shape.height)

    def draw(self, time):
        self.move(time)
        self.shape.draw(self.position)

    def move(self, dt):
        keys = pygame.key.get_pressed()
        if keys[pygame.K_a] and self.position.x > 0:
            self.position.x -= 350 * dt
        if keys[pygame.K_d] and self.position.x + self.shape.width < self.shape.screen.get_width():
            self.position.x += 350 * dt
        self.collider = SquareCollider(self.position, self.shape.width, self.shape.height)


class Brick(IEntity):
    def __init__(self, shape: IShape, position: IGraphPhysics):
        self.shape = shape
        self.position = position
        self.collider = SquareCollider(self.position, self.shape.width, self.shape.height)
        self.collisions = {}
        self.destroyed = False

    def draw(self, time):
        self.check_collision()
        self.shape.draw(self.position)

    def check_collision(self):
        for collision in self.collider.collisions.values():
            print(collision)
            self.destroyed = True


class Border:
    def __init__(self, position: IGraphPhysics, width: int, height: int):
        self.collider = SquareCollider(position, width, height)
