import abc

import collision_physics
import other_physics
import entities
import pygame

import shapes
import state
import actions
import typing
import hud


# TODO: fix return typing issue with interfaces method
class IBrickFactory(metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def create(self, brick_mediator: "IBrickMediator", x: int = 20, y: int = 20): ...


class NormalBrickFactory(IBrickFactory):
    def __init__(self, screen: pygame.Surface, collision_checker: collision_physics.ICollisionChecker):
        self.screen = screen
        self.collision_checker = collision_checker

    def create(self, brick_mediator: "IBrickMediator", x: int = 20, y: int = 20) -> entities.IVisibleEntity:
        shape = shapes.Rectangle(self.screen, "blue", other_physics.Position(x, y), 160, 80)
        brick = entities.Brick(shape, other_physics.Position(x, y), brick_mediator)
        brick_collider_action = actions.Break(brick)
        brick_polygon = collision_physics.RectanglePolygon(brick,  action=brick_collider_action)
        brick_collider = collision_physics.SquareCollider(brick, brick_polygon)
        self.collision_checker.register(brick_collider)
        brick.change_collision_checker(self.collision_checker)
        brick.change_collider(brick_collider)
        return brick


class CoverScreenBrickFactory(IBrickFactory):
    def __init__(self, screen: pygame.Surface, brick_factory: IBrickFactory):
        self.screen = screen
        self.brick_factory = brick_factory

    def create(self, brick_mediator: "IBrickMediator", x: int = 20, y: int = 20) -> list[entities.IVisibleEntity]:
        bricks = []
        for i in range(3):
            x = 20
            while x < self.screen.get_width():
                print(x)
                bricks.append(self.brick_factory.create(brick_mediator, x=x, y=y))
                x += 180
            print(x)
            y += 100

        return bricks


class IBrickMediator(metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def add_bricks(self, brick: entities.IEntity) -> None: ...

    @abc.abstractmethod
    def remove_brick(self, brick: entities.IVisibleEntity) -> None: ...

    @abc.abstractmethod
    def set_bricks(self, bricks: list[entities.IVisibleEntity]) -> None: ...


class IDestroyedBrickMediator(metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def add_bricks(self, brick: entities.IEntity) -> None: ...

    @abc.abstractmethod
    def return_bricks(self) -> None: ...


class CurrentBricks(IBrickMediator):
    def __init__(self, destroyed_bricks: IDestroyedBrickMediator, state_manager: state.IStateManager):
        self.bricks: typing.Optional[list[entities.IBrickEntity]] = None
        # self.brick_factory = brick_factory
        self.destroyed_bricks = destroyed_bricks
        self.state_manager = state_manager

    def add_bricks(self, brick: entities.IBrickEntity) -> None:
        self.bricks.append(brick)

    def set_bricks(self, bricks: list[entities.IVisibleEntity]) -> None:
        self.bricks = bricks

    def remove_brick(self, brick: entities.IBrickEntity) -> None:
        self.destroyed_bricks.add_bricks(brick)
        self.bricks.remove(brick)
        if len(self.bricks) == 0:
            self.state_manager.win()


class DestroyedBricks(IDestroyedBrickMediator):
    def __init__(self, collision_checker: collision_physics.ICollisionChecker, score: "hud.INumberHUD"):
        self.collision_checker = collision_checker
        self.score = score
        self.bricks: list[entities.IBrickEntity] = []
        self.current_bricks: typing.Optional[IBrickMediator] = None

    def add_bricks(self, brick: entities.IBrickEntity) -> None:
        self.bricks.append(brick)
        self.score.add(10)

    def return_bricks(self) -> None:
        for brick in self.bricks:
            self.current_bricks.add_bricks(brick)
            collider = brick.get_collider()
            self.collision_checker.register(collider)
        self.bricks = []

    def change_bricks(self, bricks: IBrickMediator) -> None:
        self.current_bricks = bricks
