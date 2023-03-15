var answerBoxEl = document.getElementById("answerBox-El")
let characterSlot = ""
let count = 1
let lastCharacter = ""
let secondToLastCharacter = ""

function answer() {
    if (count = 1) {
        answerBoxEl.textContent += characterSlot
    }

    else {
        answerBoxEl.textContent += " " + characterSlot
    }

    count += 1
}

function button7() {
    characterSlot = "7"
    answer()
}

function button8() {
    characterSlot = "8"
    answer()
}

function button9() {
    characterSlot = "9"
    answer()
}

function button4() {
    characterSlot = "4"
    answer()
}

function button5() {
    characterSlot = "5"
    answer()
}

function button6() {
    characterSlot = "6"
    answer()
}

function button1() {
    characterSlot = "1"
    answer()
}

function button2() {
    characterSlot = "2"
    answer()
}

function button3() {
    characterSlot = "3"
    answer()
}

function plus() {
    lastCharacter = answerBoxEl.textContent[answerBoxEl.textContent.length-1]
    if (lastCharacter == "+" || lastCharacter == "*" || lastCharacter == "/") {
        answerBoxEl.textContent = answerBoxEl.textContent.slice(0, answerBoxEl.textContent.length-1)
    }
    characterSlot = "+"
    answer()
}

function minus() {
    lastCharacter = answerBoxEl.textContent[answerBoxEl.textContent.length-1]
    if (lastCharacter == "-" ||lastCharacter == "*" || lastCharacter == "/") {
        answerBoxEl.textContent = answerBoxEl.textContent.slice(0, answerBoxEl.textContent.length-1)
    }
    characterSlot = "-"
    answer()
}

function multiply() {
    secondToLastCharacter = answerBoxEl.textContent[answerBoxEl.textContent.length-2]
    lastCharacter = answerBoxEl.textContent[answerBoxEl.textContent.length-1]
    if (secondToLastCharacter == "+" || secondToLastCharacter == "-") {
        answerBoxEl.textContent = answerBoxEl.textContent.slice(0, answerBoxEl.textContent.length-2)
    }
    if (lastCharacter == "+" || lastCharacter == "-" || lastCharacter == "*" || lastCharacter == "/") {
        answerBoxEl.textContent = answerBoxEl.textContent.slice(0, answerBoxEl.textContent.length-1)
    }
    characterSlot = "*"
    answer()
}

function divide() {
    characterSlot = "/"
    answer()
}

function clearAnswer() {
    answerBoxEl.textContent = ""
}

function zero() {
    characterSlot = "0"
    answer()
}

function decimal() {
    characterSlot = "."
    answer()
}

function equals() {
    answerBoxEl.textContent = eval(answerBoxEl.textContent)
}