from quest_log.data.quest import *
from quest_log.ui.button_commands import interfaces as cmd

class ICommandFactory(metaclass=ABCMeta):
    @abstractmethod
    def create(self, command_class: type[cmd.IAction], ) -> cmd.IAction: ...


class CommandFactory(ICommandFactory):
    def create(self) -> cmd.IAction:

