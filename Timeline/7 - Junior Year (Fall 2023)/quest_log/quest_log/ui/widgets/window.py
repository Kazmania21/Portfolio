from . import interfaces
import tkinter as tk
from ..pages import interfaces as pages


class Window(interfaces.IWindow):
    def __init__(self, background_color: str = None):
        window = tk.Tk()
        window.title("Quest Log")
        frame = tk.Frame(window, bg=background_color)
        frame.grid()
        self.background_color = background_color
        super().__init__(window, frame)

    def reset_window(self) -> None:
        self.frame.destroy()
        self.frame = tk.Frame(self.window, bg=self.background_color)
        self.frame.grid()

    def set_state(self, state: pages.IPage) -> None:
        if self.current != state:
            self.previous = self.current
            self.current = state
        self.pages.append(self.current)
        self.reset_window()
        state.frame = self.frame

    def load(self, page: pages.IPage) -> None:
        self.set_state(page)
        page.load(self.frame)

    def reload(self) -> None:
        self.load(self.current)

    def get_previous(self) -> pages.IPage:
        del self.pages[len(self.pages) - 1]
        self.reset_window()
        self.current = self.previous
        self.previous = self.pages[len(self.pages) - 2]
        self.current.frame = self.frame
        return self.current

    def load_previous(self) -> None:
        self.get_previous().load(self.frame)
