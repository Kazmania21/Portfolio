import tkinter as tk


class ScrollableFrame(tk.LabelFrame):
    def __init__(self, master, row=0, column=0, rows=1, columns=1, background_color=None):
        self.in_frame = False
        super().__init__(master)
        super().grid(row=row, column=column, sticky="NSEW")
        self.columnconfigure(0, weight=1)
        self.rowconfigure(0, weight=1)
        self.canvas = tk.Canvas(self, width=500, bg=background_color)
        self.canvas.grid(sticky="NSEW")
        self.canvas.columnconfigure(0, weight=1)
        self.canvas.rowconfigure(0, weight=1)
        self.frame = tk.Frame(self.canvas, bg=background_color)
        self.frame.grid(sticky="NSEW")
        self.sb = tk.Scrollbar(self, orient=tk.VERTICAL)
        self.hsb = tk.Scrollbar(self, orient=tk.HORIZONTAL)
        self.canvas.config(yscrollcommand=self.sb.set, xscrollcommand=self.hsb.set)
        self.sb.grid(row=0, column=1000, sticky="NS", columnspan=2)
        self.hsb.grid(row=1000, column=0, sticky="WE", rowspan=2)
        # , columnspan=column_span
        self.sb.config(command=self.canvas.yview)
        self.hsb.config(command=self.canvas.xview)

        self.frame.bind("<Configure>", lambda e: self.config())
        self.frame_id = self.canvas.create_window((0, 0), window=self.frame, anchor=tk.NW)

        self.bind("<Enter>", self.enter)
        self.bind("<Leave>", self.leave)
        self.canvas.bind_all("<MouseWheel>", self.scroll)
        self.canvas.bind_all("<Shift-MouseWheel>", self.h_scroll)

    def enter(self, event):
        self.in_frame = True

    def leave(self, event):
        self.in_frame = False

    def scroll(self, event):
        if self.in_frame:
            self.canvas.yview_scroll(int(-1 * (event.delta / 120)), "units")

    def h_scroll(self, event):
        if self.in_frame:
            self.canvas.xview_scroll(int(-1 * (event.delta / 120)), "units")

    def set_window(self, frame):
        self.canvas.create_window((0, 0), window=frame, anchor=tk.NW)

    def config(self):
        bbox = self.canvas.bbox("all")
        height = self.canvas.winfo_height()
        width = self.canvas.winfo_width()
        self.canvas.configure(scrollregion=bbox)
        if width > self.frame.winfo_width():
            self.canvas.itemconfig(self.frame_id, width=width)
            self.hsb.grid_forget()
        if width > self.frame.winfo_height():
            self.canvas.itemconfig(self.frame_id, height=height)
