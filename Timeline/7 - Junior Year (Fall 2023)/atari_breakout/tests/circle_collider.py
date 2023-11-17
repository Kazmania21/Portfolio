import parameterized
import unittest
import sys
import os
sys.path.append(os.path.dirname(os.path.realpath(__file__)) + "/../atari_breakout")
import entities
import collision_physics
import other_physics
import shapes

positions = [[0, 0], [0, 0], [0, 0], [0, 0]]
class_params = []

for index, position in enumerate(positions):
    shape = shapes.Circle(None, None, None, 40)
    ball = entities.Ball(shape, other_physics.Position(position[0], position[1]), None)
    class_params.append((ball, collision_physics.CirclePolygon(None), None))

positions = [[-63, 86], [30, -27], [81, 96], [-2, -38]]
collides = [False, True, False, True]
method_params = []

for index, position in enumerate(positions):
    shape = shapes.Circle(None, None, None, 40)
    ball = entities.Ball(shape, other_physics.Position(position[0], position[1]), None)
    method_params.append((collision_physics.CircleCollider(ball, collision_physics.CirclePolygon(None)), collides[index]))


@parameterized.parameterized_class(('entity', 'polygon'), class_params)
class CircleCollider(unittest.TestCase):
    def top(self) -> float:
        return self.entity.get_position().y - self.entity.get_shape().get_radius()

    def right(self) -> float:
        return self.entity.get_position().x + self.entity.get_shape().get_radius()

    def bottom(self) -> float:
        return self.entity.get_position().y + self.entity.get_shape().get_radius()

    def left(self) -> float:
        return self.entity.get_position().x - self.entity.get_shape().get_radius()

    def below_top(self, collider: collision_physics.ICollider) -> bool:
        return collider.top() <= self.bottom()

    def left_of_right_side(self, collider: collision_physics.ICollider) -> bool:
        return self.left() <= collider.right()

    def above_bottom(self, collider: collision_physics.ICollider) -> bool:
        return self.top() <= collider.bottom()

    def right_of_left_side(self, collider: collision_physics.ICollider) -> bool:
        return collider.left() <= self.right()

    @parameterized.parameterized.expand(method_params)
    def test_collides_with(self, collider: collision_physics.ICollider, collides: bool) -> None:
        if self.below_top(collider) and self.above_bottom(collider):
            if self.left_of_right_side(collider) and self.right_of_left_side(collider):
                self.assertEqual(True, collides)
                return
        self.assertEqual(False, collides)

    def get_polygon(self) -> collision_physics.IPolygon:
        return self.polygon


# unittest.main()
