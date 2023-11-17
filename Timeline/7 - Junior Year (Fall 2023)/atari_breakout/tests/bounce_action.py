import parameterized
import unittest
import sys
import os
sys.path.append(os.path.dirname(os.path.realpath(__file__)) + "/../atari_breakout")
import entities
import other_physics
import abc


velocities = [[300, 300], [-300, -300], [-300, 300], [300, -300]]
class_params = []

for index, velocity in enumerate(velocities):
    class_params.append((entities.Ball(None, None, other_physics.Velocity(velocity[0], velocity[1])), None))

sides = [["left", "top"], ["right", "top"], ["left", "bottom"], ["right", "bottom"]]
method_params = []

for index, side in enumerate(sides):
    class_params.append((entities.Slider(None, None), side[0], side[1]))

method_params = [(entities.Slider(None, None), "left", "top"),
                 (entities.Slider(None, None), "right", "top"),
                 (entities.Slider(None, None), "left", "bottom"),
                 (entities.Slider(None, None), "right", "bottom")]


class IColliderAction(metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def test_perform(self, entity: entities.IEntity, horizontal_side_hit: str, side_hit: str): ...


@parameterized.parameterized_class(('entity'), class_params)
class Bounce(unittest.TestCase):

    @parameterized.parameterized.expand(method_params)
    def test_perform(self, entity_hit: entities.IEntity, horizontal_side_hit: str, side_hit: str):
        x = self.entity.get_velocity().x
        y = self.entity.get_velocity().y
        if isinstance(entity_hit, entities.Slider):
            self.entity.get_velocity().y *= -1
            if horizontal_side_hit == "left" and self.entity.get_velocity().x >= 0:
                self.entity.get_velocity().x *= -1
                self.assertEqual([-x, -y], [self.entity.get_velocity().x, self.entity.get_velocity().y])
            elif horizontal_side_hit == "right" and self.entity.get_velocity().x <= 0:
                self.entity.get_velocity().x *= -1
                self.assertEqual([-x, -y], [self.entity.get_velocity().x, self.entity.get_velocity().y])
        else:
            if side_hit == "top" or side_hit == "bottom":
                self.entity.get_velocity().y *= -1
                self.assertEqual([x, -y], [self.entity.get_velocity().x, self.entity.get_velocity().y])
            else:
                self.entity.get_velocity().x *= -1
                self.assertEqual([-x, y], [self.entity.get_velocity().x, self.entity.get_velocity().y])
        self.assertNotEqual([x, y], [self.entity.get_velocity().x, self.entity.get_velocity().y])


# unittest.main()
