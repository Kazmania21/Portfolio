from .interfaces import *


class NullQuestPage(IQuestLogPage):
    def load(self): ...
