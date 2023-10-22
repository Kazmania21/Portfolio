from abc import ABCMeta, abstractmethod


class Gravity:
    def __init__(self): ...


class IGraphPhysics(metaclass=ABCMeta):
    @abstractmethod
    def __init__(self, x, y):
        self.x = x
        self.y = y

    @abstractmethod
    def change(self, x, y): ...

    @abstractmethod
    def reset(self): ...


class Position(IGraphPhysics):
    def __init__(self, x: float, y: float):
        self.x = x
        self.y = y
        self.default_x = x
        self.default_y = y

    def change(self, x, y):
        self.x = x
        self.y = y

    def reset(self):
        self.x = self.default_x
        self.y = self.default_y


class Velocity(IGraphPhysics):
    def __init__(self, x: float, y: float):
        self.x = x
        self.y = y
        self.default_x = x
        self.default_y = y

    def change(self, x, y):
        self.x = x
        self.y = y

    def reset(self):
        self.x = self.default_x
        self.y = self.default_y


class CollisionChecker:
    def __init__(self):
        self.objects = set()

    def register(self, obj: object):
        self.objects.add(obj)

    def remove(self, obj: object):
        self.objects.remove(obj)

    def check(self):
        for obj1 in self.objects:
            obj1.collider.collisions = {}
            for obj2 in self.objects:
                if obj1.collider.collides_with(obj2) and obj1 != obj2:
                    obj1.collider.add_collision(obj2)


class ICollider(metaclass=ABCMeta):
    @abstractmethod
    def __init__(self): ...

    # @abstractmethod
    # def


class CircleCollider(ICollider):
    def __init__(self, position, radius):
        self.position = position
        self.radius = radius
        self.top = position.y - radius
        self.right = position.x + radius
        self.bottom = position.y + radius
        self.left = position.x - radius
        self.center = {"x": (self.left + self.right) / 2, "y": (self.top + self.bottom) / 2}
        self.collisions = {}

    def below_top(self, obj):
        return obj.collider.top <= self.bottom

    def left_of_right_side(self, obj):
        return self.left <= obj.collider.right

    def above_bottom(self, obj):
        return self.top <= obj.collider.bottom

    def right_of_left_side(self, obj):
        return obj.collider.left <= self.right

    def collides_with(self, obj):
        if self.below_top(obj) and self.above_bottom(obj):
            if self.left_of_right_side(obj) and self.right_of_left_side(obj):
                return True
        return False

    def side_hit(self, obj):
        distances = {"top": abs(self.bottom - obj.collider.top),
                     "right": abs(self.left - obj.collider.right),
                     "bottom": abs(self.top - obj.collider.bottom),
                     "left": abs(self.right - obj.collider.left)}

        min_distance = distances["top"]
        side_hit = "top"

        for distance in distances:
            if distances[distance] < min_distance:
                side_hit = distance
                min_distance = distances[distance]

        return side_hit

    def horizontal_side_hit(self, obj):
        return "right" if (abs(self.left - obj.collider.right) < abs(self.right - obj.collider.left)) else "left"

    def add_collision(self, obj):
        self.collisions[obj] = {"side": self.side_hit(obj), "horizontal_side": self.horizontal_side_hit(obj), "obj": obj}


class SquareCollider(ICollider):
    def __init__(self, position, width, height):
        self.position = position
        self.width = width
        self.height = height
        self.top = position.y
        self.right = position.x + width
        self.bottom = position.y + height
        self.left = position.x
        self.center = {"x": (self.left + self.right)/2, "y": (self.top + self.bottom)/2}
        self.collisions = {}

    def below_top(self, obj):
        #print(f'{obj}: {obj.collider}')
        return obj.collider.top <= self.bottom

    def left_of_right_side(self, obj):
        return self.left <= obj.collider.right

    def above_bottom(self, obj):
        return self.top <= obj.collider.bottom

    def right_of_left_side(self, obj):
        return obj.collider.left <= self.right

    def collides_with(self, obj):
        if self.below_top(obj) and self.above_bottom(obj):
            if self.left_of_right_side(obj) and self.right_of_left_side(obj):
                return True
        return False

    def side_hit(self, obj):
        distances = {"top": abs(self.bottom - obj.collider.top),
                     "right": abs(self.left - obj.collider.right),
                     "bottom": abs(self.top - obj.collider.bottom),
                     "left": abs(self.right - obj.collider.left)}

        min_distance = distances["top"]
        side_hit = "top"

        for distance in distances:
            if distances[distance] < min_distance:
                side_hit = distance
                min_distance = distances[distance]

        return side_hit

    def horizontal_side_hit(self, obj):
        return "right" if (abs(self.left - obj.collider.right) < abs(self.right - obj.collider.left)) else "left"

    def add_collision(self, obj):
        self.collisions[obj] = {"side": self.side_hit(obj), "horizontal_side": self.horizontal_side_hit(obj), "obj": obj}
