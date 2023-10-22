import abc
import entities
import hud


class IAction(metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def perform(self): ...


class Break(IAction):
    def __init__(self, entity: entities.IBrickEntity):
        self.entity = entity

    def perform(self):
        self.entity.get_collision_checker().remove(self.entity.get_collider())
        self.entity.get_mediator().remove_brick(self.entity)


class IColliderAction(metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def perform(self, entity: entities.IEntity, horizontal_side_hit: str, side_hit: str): ...


class Bounce(IColliderAction):
    def __init__(self, entity: entities.IMovingEntity):
        self.entity = entity

    def perform(self, entity_hit: entities.IEntity, horizontal_side_hit: str, side_hit: str):
        print(entity_hit)
        print(side_hit)
        print(horizontal_side_hit)
        if isinstance(entity_hit, entities.Slider):
            self.entity.get_velocity().y *= -1
            if horizontal_side_hit == "left" and self.entity.get_velocity().x >= 0:
                self.entity.get_velocity().x *= -1
            elif horizontal_side_hit == "right" and self.entity.get_velocity().x <= 0:
                self.entity.get_velocity().x *= -1
        else:
            if side_hit == "top" or side_hit == "bottom":
                self.entity.get_velocity().y *= -1
            else:
                self.entity.get_velocity().x *= -1


class LoseLife():
    def __init__(self, lives: hud.ILivesHUD, ball: entities.IMovingEntity, slider: entities.IVisibleEntity):
        self.lives = lives
        self.ball = ball
        self.slider = slider

    def perform(self, entity: entities.IEntity) -> None:
        if entity == self.ball and self.lives.get_lives() > 0:
            self.ball.get_position().reset()
            self.ball.get_velocity().reset()
            self.slider.get_position().reset()
            self.lives.lose_life()
