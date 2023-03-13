from tkinter import *

def translate():

    code = str(coded.get())
    UserInput1 = str(input1.get())
    UserInput2 = str(input2.get())
    UserInput3 = str(input3.get())

    table = code.maketrans(UserInput1, UserInput2, UserInput3)

    resultBox.delete(0.0, END)
    resultBox.insert(END, code.translate(table))

window = Tk()
window.geometry("800x500")
window.title("Code Translator")

progName = Label(window, font = ("Kristen ITC", 15, "bold"), text = "Code Translator", fg = "red")
progName.grid(row = 1, column = 3, padx = 300, pady = 30)

CodedOutput = Label(window, font = ("Kristen ITC", 15, "bold"), text = "Coded text that needs to be translated.", fg = "red")
CodedOutput.place(relx = .03, rely = .15)

coded = Entry(window, font = ("Kristen ITC", 15, "bold"), fg = "red")
coded.place(relx = .03, rely = .21)

Output1 = Label(window, font = ("Kristen ITC", 15, "bold"), text = "Characters in the code that needs to be translated.", fg = "red")
Output1.place(relx = .03, rely = .45)

input1 = Entry(window, font =("Kristen ITC", 15, "bold"), fg = "red")
input1.place(relx=.03, rely=.51)

Output2 = Label(window, font=("Kristen ITC", 15, "bold"), text="What the characters in the code will translate to.", fg="red")
Output2.place(relx=.03, rely=.6)

input2 = Entry(window, font=("Kristen ITC", 15, "bold"), fg="red")
input2.place(relx=.03, rely=.66)

Output3 = Label(window, font=("Kristen ITC", 15, "bold"), text="Characters to remove from the code.", fg="red")
Output3.place(relx=.03, rely=.3)

input3 = Entry(window, font=("Kristen ITC", 15, "bold"), fg="red")
input3.place(relx=.03, rely=.36)

submit = Button(window, text="Translate", command=translate)
submit.place(relx=.45, rely=.75)

resultBox = Text(window, height=6, width=70)
resultBox.place(relx=.125, rely=.8)

window.mainloop()
