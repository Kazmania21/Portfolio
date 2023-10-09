from .. import interfaces


#324w X 217h

class Font(interfaces.IFont):
    def configure(self):
        window = self.window.window

        # Base size
        normal_width = 324
        normal_height = 217

        # Screen
        screen_width = window.winfo_width()
        screen_height = window.winfo_height()

        # Get percentage of screen size from Base size
        percentage_width = screen_width / (normal_width / 100)
        percentage_height = screen_height / (normal_height / 100)

        scale_factor = ((screen_width + screen_height) / 2) / 100
        if screen_width != self.prev_screen_width or screen_height != self.prev_screen_height:
            if scale_factor <= self.size:
                size = self.size
            else:
                size = int(scale_factor * self.size / 3)
            print(f"{screen_width}: {self.prev_screen_width}")
            self.prev_screen_width = screen_width
            self.prev_screen_height = screen_height
            self.font.configure(size=size)
