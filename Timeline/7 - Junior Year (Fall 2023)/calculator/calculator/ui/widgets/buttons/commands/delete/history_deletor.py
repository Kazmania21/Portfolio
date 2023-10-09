from .. import interfaces
from .....info import interfaces as info


class DeleteHistoryCommand(interfaces.IHistoryCommand):
    def perform(self, history_info: info.IHistoryInfo):
        self.history_database.delete(history_info.pid)
