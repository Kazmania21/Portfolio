from tkinter import *

def num7():
    resultBox.insert(END, "7")

def num4():
    resultBox.insert(END, "4")

def num1():
    resultBox.insert(END, "1")

def num8():
    resultBox.insert(END, "8")

def num5():
    resultBox.insert(END, "5")

def num2():
    resultBox.insert(END, "2")

def num0():
    resultBox.insert(END, "0")

def num9():
    resultBox.insert(END, "9")

def num6():
    resultBox.insert(END, "6")

def num3():
    resultBox.insert(END, "3")

def divide():
    resultBox.insert(END, "/")

def multiply():
    resultBox.insert(END, "*")

def subtract():
    resultBox.insert(END, "-")

def add():
    resultBox.insert(END, "+")

def equals():
    answer = str(resultBox.get(0.0, END))
    fro = ""
    to = ""
    remove = "\n"
    table = answer.maketrans(fro, to, remove)
    answer = eval(answer.translate(table))
    resultBox.delete(0.0, END)
    resultBox.insert(END, answer)

def clear():
    resultBox.delete(0.0, END)

def point():
    resultBox.insert(END, ".")

window = Tk()
window.geometry("550x500")
window.title("Calculator")

resultBox = Text(window, height=6, width=48)
resultBox.place(relx=0, rely=0)

seven = Button(window, text="7", height=6, width=17, command=num7)
seven.place(relx=0, rely=.2)

four = Button(window, text="4", height=6, width=17, command=num4)
four.place(relx=0, rely=.4)

one = Button(window, text="1", height=6, width=17, command=num1)
one.place(relx=0, rely=.6)

eight = Button(window, text="8", height=6, width=17, command=num8)
eight.place(relx=.235, rely=.2)

five = Button(window, text="5", height=6, width=17, command=num5)
five.place(relx=.235, rely=.4)

two = Button(window, text="2", height=6, width=17, command=num2)
two.place(relx=.235, rely=.6)

zero = Button(window, text="0", height=6, width=17, command=num0)
zero.place(relx=.235, rely=.8)

nine = Button(window, text="9", height=6, width=17, command=num9)
nine.place(relx=.470, rely=.2)

six = Button(window, text="6", height=6, width=17, command=num6)
six.place(relx=.470, rely=.4)

three = Button(window, text="3", height=6, width=17, command=num3)
three.place(relx=.470, rely=.6)

divide = Button(window, text="/", height=6, width=22, command=divide)
divide.place(relx=.705, rely=0)

multiply = Button(window, text="*", height=6, width=22, command=multiply)
multiply.place(relx=.705, rely=.2)

subtract = Button(window, text="-", height=6, width=22, command=subtract)
subtract.place(relx=.705, rely=.4)

add = Button(window, text="+", height=6, width=22, command=add)
add.place(relx=.705, rely=.6)

equals = Button(window, text="=", height=6, width=22, command=equals)
equals.place(relx=.705, rely=.8)

clear = Button(window, text="C", height=6, width=17, command=clear)
clear.place(relx=0, rely=.8)

point = Button(window, text=".", height=6, width=17, command=point)
point.place(relx=.470, rely=.8)

window.mainloop()
