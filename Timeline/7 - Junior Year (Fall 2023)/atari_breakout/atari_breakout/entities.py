import abc
import pygame
import other_physics
import shapes
import typing
import state

if typing.TYPE_CHECKING:
    import bricks
    import collision_physics


class IEntity(metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def __init__(self): ...

    @abc.abstractmethod
    def get_position(self) -> other_physics.IGraphPhysics: ...


class IVisibleEntity(IEntity, metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def draw(self, time: float) -> None: ...


class ICircleEntity(IEntity, metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def get_shape(self) -> shapes.ICircleShape: ...


class IMovingEntity(IEntity, metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def get_velocity(self) -> other_physics.IGraphPhysics: ...


class Ball(ICircleEntity, IMovingEntity, IVisibleEntity):
    def __init__(self, shape: shapes.ICircleShape, position: other_physics.IGraphPhysics,
                 velocity: other_physics.IGraphPhysics):
        self.shape = shape
        self.position = position
        self.prev_collision = None
        self.velocity = velocity

    def draw(self, time: float) -> None:
        self.move(time)
        self.shape.draw(self.position)

    def move(self, dt: float) -> None:
        self.position.x += self.velocity.x * dt
        self.position.y += self.velocity.y * dt

    def bounce(self, obj: IEntity, horizontal_side: str, side: str) -> None:
        print(obj)
        print(side)
        print(horizontal_side)
        if isinstance(obj, Slider):
            self.velocity.y *= -1
            if horizontal_side == "left" and self.velocity.x >= 0:
                self.velocity.x *= -1
            elif horizontal_side == "right" and self.velocity.x <= 0:
                self.velocity.x *= -1
        else:
            if side == "top" or side == "bottom":
                self.velocity.y *= -1
            else:
                self.velocity.x *= -1

    def get_position(self) -> other_physics.IGraphPhysics:
        return self.position

    def get_shape(self) -> shapes.ICircleShape:
        return self.shape

    def get_velocity(self) -> other_physics.IGraphPhysics:
        return self.velocity

    """def check_collision(self):
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
                self.prev_collision = collision["obj"]"""


class IRectangleEntity(IEntity, metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def get_shape(self) -> shapes.IRectangleShape: ...


class Slider(IRectangleEntity, IVisibleEntity):
    def __init__(self, shape: shapes.IRectangleShape, position: other_physics.IGraphPhysics):
        self.shape = shape
        self.position = position
        self.state_manager: typing.Optional[state.IStateManager] = None

    def draw(self, time: float) -> None:
        self.move(time)
        self.shape.draw(self.position)

    def move(self, dt: float) -> None:
        keys = pygame.key.get_pressed()
        if keys[pygame.K_a] and self.position.x > 0 and isinstance(self.state_manager.get_state(), state.PlayState):
            self.position.x -= 350 * dt
        if keys[pygame.K_d] and self.position.x + self.shape.get_width() < self.shape.get_screen().get_width() and \
                isinstance(self.state_manager.get_state(), state.PlayState):
            self.position.x += 350 * dt

    def get_position(self) -> other_physics.IGraphPhysics:
        return self.position

    def get_shape(self) -> shapes.IRectangleShape:
        return self.shape


class IBrickEntity(IVisibleEntity, metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def get_collision_checker(self) -> "collision_physics.ICollisionChecker": ...

    @abc.abstractmethod
    def get_collider(self) -> "collision_physics.ICollider": ...

    @abc.abstractmethod
    def get_mediator(self) -> "bricks.IBrickMediator": ...


class Brick(IRectangleEntity, IBrickEntity, IVisibleEntity):
    def __init__(self, shape: shapes.IRectangleShape, position: other_physics.IGraphPhysics,
                 brick_mediator: "bricks.IBrickMediator"):
        self.shape = shape
        self.position = position
        self.collisions = {}
        self.brick_mediator = brick_mediator
        self.collision_checker: typing.Optional["collision_physics.ICollisionChecker"] = None
        self.collider = None

    def draw(self, time: float) -> None:
        self.shape.draw(self.position)

    def check_collision(self) -> None:
        self.collision_checker.remove(self.collider)
        self.brick_mediator.remove_brick(self)
        # del bricks[index]

    def change_collision_checker(self, collision_checker: "collision_physics.ICollisionChecker") -> None:
        self.collision_checker = collision_checker

    def change_collider(self, collider: "collision_physics.ICollider") -> None:
        self.collider = collider

    def get_position(self) -> other_physics.IGraphPhysics:
        return self.position

    def get_shape(self) -> shapes.IRectangleShape:
        return self.shape

    def get_collision_checker(self) -> "collision_physics.ICollisionChecker":
        return self.collision_checker

    def get_collider(self) -> "collision_physics.ICollider":
        return self.collider

    def get_mediator(self) -> "bricks.IBrickMediator":
        return self.brick_mediator


class IInvisibleEntity(IEntity, metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def get_width(self) -> int: ...

    @abc.abstractmethod
    def get_height(self) -> int: ...


class Border(IInvisibleEntity):
    def __init__(self, position: other_physics.IGraphPhysics, width: int, height: int):
        self.position = position
        self.width = width
        self.height = height

    def get_position(self) -> other_physics.IGraphPhysics:
        return self.position

    def get_width(self) -> int:
        return self.width

    def get_height(self) -> int:
        return self.height
