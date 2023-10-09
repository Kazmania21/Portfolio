import tkinter as tk


class ScrollableFrame(tk.LabelFrame):
    def __init__(self, master, window, row=0, column=0, rows=1, columns=1):
        self.window = window
        screen_height = window.window.winfo_height()
        self.in_frame = False
        super().__init__(master)
        super().grid(row=row, column=column, sticky="NSEW")
        self.columnconfigure(0, weight=1)
        self.rowconfigure(0, weight=1)
        self.canvas = tk.Canvas(self, width=100)
        self.canvas.grid(sticky="NSEW")
        self.canvas.columnconfigure(0, weight=1)
        self.canvas.rowconfigure(0, weight=1)
        self.frame = tk.Frame(self.canvas)
        self.frame.grid(sticky="NSEW")
        self.frame.columnconfigure(0, weight=2)
        self.frame.columnconfigure(1, weight=1)
        self.frame.rowconfigure(0, weight=1)
        self.sb = tk.Scrollbar(self, orient=tk.VERTICAL)
        self.canvas.config(yscrollcommand=self.sb.set)
        self.sb.grid(row=0, column=1000, sticky="NS", columnspan=2)
        # , columnspan=column_span
        self.sb.config(command=self.canvas.yview)

        self.canvas.bind("<Configure>", lambda e: self.config())
        self.frame_id = self.canvas.create_window((0, 0), window=self.frame, anchor=tk.NW)

        self.bind("<Enter>", self.enter)
        self.bind("<Leave>", self.leave)
        self.canvas.bind_all("<MouseWheel>", self.scroll)

    def enter(self, event):
        self.in_frame = True

    def leave(self, event):
        self.in_frame = False

    def scroll(self, event):
        if self.in_frame:
            self.canvas.yview_scroll(int(-1 * (event.delta / 120)), "units")

    def set_window(self, frame):
        self.canvas.create_window((0, 0), window=frame, anchor=tk.NW)

    def config(self):
        bbox = self.canvas.bbox("all")
        height = self.canvas.winfo_height()
        width = self.canvas.winfo_width()
        self.canvas.configure(scrollregion=bbox)
        self.canvas.itemconfig(self.frame_id, width=width)
