import webbrowser
from tkinter import *
import pyperclip


def callback(event):
    webbrowser.open_new(event.widget.cget("text"))


def copy(event):
    window.clipboard_clear()
    pyperclip.copy(str(resultBox.get(0.0, END)))


def submit():
    resultBox.delete(0.0, END)

    name = str(aName.get(0.0, END))

    resultBox.insert(END, f"""UGN {name} GO CHECK OUT THE HOST OF THIS CONTENT / UGN {name} / SOCIAL LINKS BELOW 
🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽\n""")

    loopNumber = 0

    for items in loop2:

        result = str(answer[loopNumber].get(0.0, END))

        if result != "\n":

            resultBox.insert(END, f"{items}{result}")

        loopNumber += 1


window = Tk()
window.attributes("-fullscreen", True)
window.title = "Member Links"

loop = ['YouTube', 'Twitch', 'DLive', 'Sliver', 'Twitter', 'Instagram', 'SnapChat', 'Facebook', 'Spotify', 'TikTok']

question = ['', '', '', '', '', '', '', '', '', '']

answer = ['', '', '', '', '', '', '', '', '', '']

link = ['https://www.youtube.com', 'https://www.twitch.tv', 'https://www.dlive.tv', '', 'https://www.twitter.com',
        'https://www.instagram.com', 'https://www.snapchat.com', 'https://www.facebook.com',
        'https://www.open.spotif.com', 'https://www.tiktok.com']

loop2 = ['🔴 YOUTUBE | ', '🔴 TWITCH | ', '🔴 DLIVE | ', '🔴 SLIVER | ', '💻 TWITTER | ', '📲 INSTAGRAM | ', '📲 SNAPCHAT | ',
         '😜 FACEBOOK | ', '🎶SPOTIFY : ', '🕑 TIKTOK | ']

qName = Label(window, text=f"What is the streamer's name? ")
qName.place(relx=0, rely=0)
aName = Text(window, font=("Calibri", 12), height=1.25, width=50, fg='red')
aName.place(relx=.11, rely=0)

loopNumber = 0

locationY = .05

for i in loop:
    question[loopNumber] = Label(window, text=f"What is their {i}? ")
    question[loopNumber].place(relx=0, rely=locationY)

    answer[loopNumber] = Text(window, font=("Calibri", 12), height=1.25, width=50, fg='red')
    answer[loopNumber].place(relx=.1, rely=locationY)

    link[loopNumber] = Label(window, text=f'{link[loopNumber]}')
    link[loopNumber].bind('<Button-1>', callback)
    link[loopNumber].place(relx=.4, rely=locationY)

    loopNumber += 1
    locationY += .05

submit = Button(window, text="submit", command=submit)
submit.place(relx=.55, rely=.94)

resultBox = Text(window, height=23, width=100)
resultBox.place(relx=0, rely=.55)

window.bind("<Control-Key-c>", copy)

window.mainloop()
