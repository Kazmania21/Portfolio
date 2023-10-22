import abc

import entities
import other_physics
import actions


class ICollider(metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def __init__(self): ...

    @abc.abstractmethod
    def collides_with(self, collider: "ICollider") -> None: ...

    @abc.abstractmethod
    def top(self) -> float: ...

    @abc.abstractmethod
    def right(self) -> float: ...

    @abc.abstractmethod
    def bottom(self) -> float: ...

    @abc.abstractmethod
    def left(self) -> float: ...

    @abc.abstractmethod
    def get_polygon(self) -> "IPolygon": ...

    # @abstractmethod
    # def


class ICollisionChecker(metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def register(self, collider: ICollider) -> None: ...

    @abc.abstractmethod
    def remove(self, collider: ICollider) -> None: ...


class CollisionChecker(ICollisionChecker):
    def __init__(self):
        self.colliders: list[ICollider] = []

    def register(self, collider: ICollider) -> None:
        self.colliders.append(collider)

    def remove(self, collider: ICollider) -> None:
        self.colliders.remove(collider)

    def check(self) -> None:
        for collider1 in self.colliders:
            for collider2 in self.colliders:
                if collider1 != collider2:
                    collider1.collides_with(collider2)


class IPolygon(metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def __init__(self): ...

    @abc.abstractmethod
    def collides_with(self, polygon: "IPolygon") -> None: ...

    @abc.abstractmethod
    def top(self) -> float: ...

    @abc.abstractmethod
    def right(self) -> float: ...

    @abc.abstractmethod
    def bottom(self) -> float: ...

    @abc.abstractmethod
    def left(self) -> float: ...

    @abc.abstractmethod
    def get_entity(self) -> entities.IEntity: ...


class CircleCollider(ICollider):
    def __init__(self, entity: entities.ICircleEntity, polygon: IPolygon):
        self.entity = entity
        self.polygon = polygon

    def top(self) -> float:
        return self.entity.get_position().y - self.entity.get_shape().get_radius()

    def right(self) -> float:
        return self.entity.get_position().x + self.entity.get_shape().get_radius()

    def bottom(self) -> float:
        return self.entity.get_position().y + self.entity.get_shape().get_radius()

    def left(self) -> float:
        return self.entity.get_position().x - self.entity.get_shape().get_radius()

    def below_top(self, collider: ICollider) -> bool:
        return collider.top() <= self.bottom()

    def left_of_right_side(self, collider: ICollider) -> bool:
        return self.left() <= collider.right()

    def above_bottom(self, collider: ICollider) -> bool:
        return self.top() <= collider.bottom()

    def right_of_left_side(self, collider: ICollider) -> bool:
        return collider.left() <= self.right()

    def collides_with(self, collider: ICollider) -> None:
        if self.below_top(collider) and self.above_bottom(collider):
            if self.left_of_right_side(collider) and self.right_of_left_side(collider):
                self.polygon.collides_with(collider.get_polygon())

    def get_polygon(self) -> IPolygon:
        return self.polygon


class SquareCollider(ICollider):
    def __init__(self, entity: entities.IRectangleEntity, polygon: IPolygon):
        self.entity = entity
        self.polygon = polygon

    def top(self) -> float:
        return self.entity.get_position().y

    def right(self) -> float:
        return self.entity.get_position().x + self.entity.get_shape().get_width()

    def bottom(self) -> float:
        return self.entity.get_position().y + self.entity.get_shape().get_height()

    def left(self) -> float:
        return self.entity.get_position().x

    def below_top(self, collider: ICollider) -> bool:
        #print(f'{obj}: {obj.collider}')
        return collider.top() <= self.bottom()

    def left_of_right_side(self, collider: ICollider) -> bool:
        return self.left() <= collider.right()

    def above_bottom(self, collider: ICollider) -> bool:
        return self.top() <= collider.bottom()

    def right_of_left_side(self, collider: ICollider) -> bool:
        return collider.left() <= self.right()

    def collides_with(self, collider: ICollider) -> None:
        if self.below_top(collider) and self.above_bottom(collider):
            if self.left_of_right_side(collider) and self.right_of_left_side(collider):
                self.polygon.collides_with(collider.get_polygon())

    def side_hit(self, obj: ICollider) -> str:
        distances = {"top": abs(self.bottom() - obj.top()),
                     "right": abs(self.left() - obj.right()),
                     "bottom": abs(self.top() - obj.bottom()),
                     "left": abs(self.right() - obj.left())}

        min_distance = distances["top"]
        side_hit = "top"

        for distance in distances:
            if distances[distance] < min_distance:
                side_hit = distance
                min_distance = distances[distance]

        return side_hit

    def horizontal_side_hit(self, obj) -> str:
        return "right" if (abs(self.left() - obj.collider.right()) < abs(self.right() - obj.collider.left())) else "left"

    def get_polygon(self) -> IPolygon:
        return self.polygon


class CirclePolygon(IPolygon):
    def __init__(self, entity: entities.ICircleEntity, action: actions.IColliderAction = None):
        self.entity = entity
        self.action = action

    def top(self) -> float:
        return self.entity.get_position().y - self.entity.get_shape().get_radius()

    def right(self) -> float:
        return self.entity.get_position().x + self.entity.get_shape().get_radius()

    def bottom(self) -> float:
        return self.entity.get_position().y + self.entity.get_shape().get_radius()

    def left(self) -> float:
        return self.entity.get_position().x - self.entity.get_shape().get_radius()

    def side_hit(self, obj: IPolygon) -> str:
        distances = {"top": abs(self.bottom() - obj.top()),
                     "right": abs(self.left() - obj.right()),
                     "bottom": abs(self.top() - obj.bottom()),
                     "left": abs(self.right() - obj.left())}

        min_distance = distances["top"]
        side_hit = "top"

        for distance in distances:
            if distances[distance] < min_distance:
                side_hit = distance
                min_distance = distances[distance]

        return side_hit

    def horizontal_side_hit(self, obj: IPolygon) -> str:
        return "right" if (abs(self.left() - obj.right()) < abs(self.right() - obj.left())) else "left"

    def collides_with(self, obj: IPolygon) -> None:
        self.action.perform(obj.get_entity(), self.horizontal_side_hit(obj), self.side_hit(obj))

    def get_entity(self) -> entities.IEntity:
        return self.entity


class RectanglePolygon(IPolygon):
    def __init__(self, entity: entities.IRectangleEntity, action: actions.IAction = None):
        self.entity = entity
        self.action = action

    def top(self) -> float:
        return self.entity.get_position().y

    def right(self) -> float:
        return self.entity.get_position().x + self.entity.get_shape().get_width()

    def bottom(self) -> float:
        return self.entity.get_position().y + self.entity.get_shape().get_height()

    def left(self) -> float:
        return self.entity.get_position().x

    def side_hit(self, obj: IPolygon) -> str:
        distances = {"top": abs(self.bottom() - obj.top()),
                     "right": abs(self.left() - obj.right()),
                     "bottom": abs(self.top() - obj.bottom()),
                     "left": abs(self.right() - obj.left())}

        min_distance = distances["top"]
        side_hit = "top"

        for distance in distances:
            if distances[distance] < min_distance:
                side_hit = distance
                min_distance = distances[distance]

        return side_hit

    def horizontal_side_hit(self, obj: IPolygon) -> str:
        return "right" if (abs(self.left() - obj.right()) < abs(self.right() - obj.left())) else "left"

    def collides_with(self, obj: IPolygon) -> None:
        if self.action is not None:
            self.action.perform()

    def get_entity(self) -> entities.IEntity:
        return self.entity


class BarrierCollider(ICollider):
    def __init__(self, barrier: entities.Border, polygon: IPolygon):
        self.barrier = barrier
        self.polygon = polygon

    def top(self) -> float:
        return self.barrier.get_position().y

    def right(self) -> float:
        return self.barrier.get_position().x + self.barrier.width

    def bottom(self) -> float:
        return self.barrier.get_position().y + self.barrier.height

    def left(self) -> float:
        return self.barrier.get_position().x

    def below_top(self, collider: ICollider) -> bool:
        # print(f'{obj}: {obj.collider}')
        return collider.top() <= self.bottom()

    def left_of_right_side(self, collider: ICollider) -> bool:
        return self.left() <= collider.right()

    def above_bottom(self, collider: ICollider) -> bool:
        return self.top() <= collider.bottom()

    def right_of_left_side(self, collider: ICollider) -> bool:
        return collider.left() <= self.right()

    def collides_with(self, collider: ICollider) -> None:
        if self.below_top(collider) and self.above_bottom(collider):
            if self.left_of_right_side(collider) and self.right_of_left_side(collider):
                self.polygon.collides_with(collider.get_polygon())

    def get_polygon(self) -> IPolygon:
        return self.polygon


class BarrierPolygon(IPolygon):
    def __init__(self, barrier: entities.IInvisibleEntity, action = None):
        self.entity = barrier
        self.action = action

    def top(self) -> float:
        return self.entity.get_position().y

    def right(self) -> float:
        return self.entity.get_position().x + self.entity.get_width()

    def bottom(self) -> float:
        return self.entity.get_position().y + self.entity.get_height()

    def left(self) -> float:
        return self.entity.get_position().x

    def side_hit(self, obj: IPolygon) -> str:
        distances = {"top": abs(self.bottom() - obj.top()),
                     "right": abs(self.left() - obj.right()),
                     "bottom": abs(self.top() - obj.bottom()),
                     "left": abs(self.right() - obj.left())}

        min_distance = distances["top"]
        side_hit = "top"

        for distance in distances:
            if distances[distance] < min_distance:
                side_hit = distance
                min_distance = distances[distance]

        return side_hit

    def horizontal_side_hit(self, obj: IPolygon) -> str:
        return "right" if (abs(self.left() - obj.right()) < abs(self.right() - obj.left())) else "left"

    def collides_with(self, obj: IPolygon) -> None:
        if self.action is not None:
            self.action.perform(obj.get_entity())

    def get_entity(self) -> entities.IEntity:
        return self.entity
