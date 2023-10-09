from . import interfaces
import tkinter as tk


class Fonts(interfaces.IFonts):
    def configure(self, event: tk.Event):
        for font in self.fonts:
            font.configure()

    def add(self, font: interfaces.IFont):
        self.fonts.append(font)
