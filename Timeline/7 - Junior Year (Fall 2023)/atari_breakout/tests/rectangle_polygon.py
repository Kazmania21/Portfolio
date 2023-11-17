import parameterized
import unittest
import sys
import os
sys.path.append(os.path.dirname(os.path.realpath(__file__)) + "/../atari_breakout")
import entities
import collision_physics
import other_physics
import shapes
import actions


positions = [[0, 0], [0, 0], [0, 0], [0, 0]]
class_params = []

for index, position in enumerate(positions):
    shape = shapes.Rectangle(None, None, None, 160, 80)
    slider = entities.Slider(shape, other_physics.Position(position[0], position[1]))
    class_params.append((slider, None))


# positions = [[150, -60], [-70, -56], [-177, -30], [-10, -79]]
# collides = [False, True, False, True]
positions = [[150, 60], [-70, 56], [137, 30], [-10, 79]]
sides_hit = ["left", "top", "left", "top"]
horizontal_sides_hit = ["left", "right", "left", "right"]
method_params = []

for index, position in enumerate(positions):
    shape = shapes.Rectangle(None, None, None, 160, 80)
    slider = entities.Slider(shape, other_physics.Position(position[0], position[1]))
    polygon = collision_physics.RectanglePolygon(slider)
    method_params.append((polygon, sides_hit[index], horizontal_sides_hit[index]))


@parameterized.parameterized_class(('entity', 'action'), class_params)
class RectanglePolygon(unittest.TestCase):
    def top(self) -> float:
        return self.entity.get_position().y

    def right(self) -> float:
        return self.entity.get_position().x + self.entity.get_shape().get_width()

    def bottom(self) -> float:
        return self.entity.get_position().y + self.entity.get_shape().get_height()

    def left(self) -> float:
        return self.entity.get_position().x

    def side_hit(self, obj: collision_physics.IPolygon) -> str:
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

    def horizontal_side_hit(self, obj: collision_physics.IPolygon) -> str:
        return "right" if (abs(self.left() - obj.right()) < abs(self.right() - obj.left())) else "left"

    @parameterized.parameterized.expand(method_params)
    def test_collides_with(self, obj: collision_physics.IPolygon, side_hit, horizontal_side_hit) -> None:
        self.assertEqual(side_hit, self.side_hit(obj))
        self.assertEqual(horizontal_side_hit, self.horizontal_side_hit(obj))
        if self.action is not None:
            self.action.perform()

    def get_entity(self) -> entities.IEntity:
        return self.entity
