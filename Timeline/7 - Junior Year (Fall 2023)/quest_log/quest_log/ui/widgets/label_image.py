import tkinter as tk
from PIL import Image, ImageTk


class LabelImage(tk.Label):
    def __init__(self, window, location, text_color: str = None, background_color: str = None, text: str = None):
        self.img = Image.open(location)
        self.photo_img = ImageTk.PhotoImage(self.img)
        self.text_color = text_color
        self.background_color = background_color
        self.text = text
        super().__init__(window, image=self.photo_img, fg=text_color, bg=background_color, text=text)
