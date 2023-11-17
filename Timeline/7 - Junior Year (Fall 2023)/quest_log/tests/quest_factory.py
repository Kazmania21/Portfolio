import parameterized
import unittest
import sys
import os
sys.path.append(os.path.dirname(os.path.realpath(__file__)) + "/../quest_log")
from data import quest as q


params = [((("n1", "d1", "", 1, True),), q.NormalQuestComposite("n1", "d1", 1, True, None)),
          ((("n2", "d2", "", 2, False),), q.NormalQuestComposite("n2", "d2", 2, False, None)),
          ((("n3", "d3", "", 3, True),), q.NormalQuestComposite("n3", "d3", 3, True, None))]


class NormalQuestFactory(unittest.TestCase):
    @parameterized.parameterized.expand(params)
    def test_create(self, quests, expected) -> list[q.IQuestComposite]:
        print(str(quests))
        quests_hash = {}
        roots = []
        for index, quest in enumerate(quests):
            name = quest[0]
            description = quest[1]
            parent = quest[2]
            level = quest[3]
            active = quest[4]
            quests_hash[name] = {"OBJ": q.NormalQuestComposite(name, description, level, active, None)
                                 , "Parent": parent}
        for key, value in quests_hash.items():
            if value["Parent"] != "":
                value["OBJ"].parent = quests_hash[value["Parent"]]["OBJ"]
                value["OBJ"].parent.add_quest(value["OBJ"])
            roots.append(value["OBJ"])
            # converts attributes into a dictionary before comparing
            self.assertDictEqual(vars(expected), vars(value["OBJ"]))

        return roots


# unittest.main()
