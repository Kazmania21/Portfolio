import abc
from data import quest as q
from file_system import interfaces as fs


class IQuestFactory(metaclass=abc.ABCMeta):
    def __init__(self, file_system: fs.IFileSystem):
        self.file_system = file_system

    @abc.abstractmethod
    def create(self) -> list[q.IQuestComposite]:
        ...


class NormalQuestFactory(IQuestFactory):
    def create(self) -> list[q.IQuestComposite]:
        quests = self.file_system.read()
        print(str(quests))
        quests_hash = {}
        roots = []
        for index, quest in enumerate(quests):
            name = quest[0]
            description = quest[1]
            parent = quest[2]
            level = quest[3]
            active = quest[4]
            quests_hash[name] = {"OBJ": q.NormalQuestComposite(name, description, level, active, self.file_system)
                                 , "Parent": parent}
        for key, value in quests_hash.items():
            if value["Parent"] != "":
                value["OBJ"].parent = quests_hash[value["Parent"]]["OBJ"]
                value["OBJ"].parent.add_quest(value["OBJ"])
            roots.append(value["OBJ"])

        return roots
