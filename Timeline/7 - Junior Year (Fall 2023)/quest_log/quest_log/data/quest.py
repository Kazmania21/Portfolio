import abc
import typing

from file_system import interfaces as fs


class IQuest(metaclass=abc.ABCMeta):
    def __init__(self, name: str, description: str, level: int, active: bool, file_system: fs.IFileSystem):
        self.name = name
        self.description = description
        self.level = level
        self.active = active
        self.file_system = file_system

    @abc.abstractmethod
    def complete(self) -> None: ...

    @abc.abstractmethod
    def undo_complete(self) -> None: ...

    @abc.abstractmethod
    def activate(self) -> None: ...

    @abc.abstractmethod
    def deactivate(self) -> None: ...


class IQuestLeaf(IQuest, metaclass=abc.ABCMeta):
    def __init__(self, name: str, description: str, parent: IQuest, level: int, active: bool, file_system: fs.IFileSystem):
        super().__init__(name, description, level, active, file_system)
        self.parent = parent


class IQuestComposite(IQuest, metaclass=abc.ABCMeta):
    def __init__(self, name: str, description: str, level: int, active: bool, file_system: fs.IFileSystem,
                 parent: "IQuestComposite" = None, quests: list[IQuest] = None):
        super().__init__(name, description, level, active, file_system)
        self.parent = parent
        if quests is None:
            quests: typing.Optional[list[IQuest]] = []
        self.quests = quests
        print(quests)
        self.active_quests = []

    @abc.abstractmethod
    def add_quest(self, quest: IQuest) -> None: ...

    @abc.abstractmethod
    def remove_quest(self, quest: IQuest) -> None: ...


class NormalQuestComposite(IQuestComposite):
    def add_quest(self, quest: IQuest) -> None:
        self.quests.append(quest)
        if quest.active:
            self.active_quests.append(quest)

    def remove_quest(self, quest: IQuest) -> None:
        self.quests.remove(quest)

    def complete(self) -> None:
        self.deactivate()
        if self.parent:
            if not self.parent.active_quests:
                self.parent.activate()

    def undo_complete(self) -> None:
        self.activate()

    def activate(self) -> None:
        self.file_system.update(self.name, "ACTIVE", "1")

    def deactivate(self) -> None:
        self.file_system.update(self.name, "ACTIVE", "0")
        if self.parent:
            self.parent.active_quests.remove(self)
