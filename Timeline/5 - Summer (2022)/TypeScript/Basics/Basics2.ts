"use strict";
// tsc Basics.js to convert to js

import { hi } from "./exmod.js" //imports do not get converted well

console.log(hi)

console.log("Hello World")

class Question4{

    private resultLabel = document.getElementById("resultLabel2")

    public ValidAnswer(userInput){
        switch(userInput){
            case "1":
                this.resultLabel.innerHTML = "I'm doing good!"
                break

            case "2":
                this.resultLabel.innerHTML = "Sorry to hear that. I hope your day gets better!"
                break

            default:
                this.resultLabel.innerHTML = "Invalid response"
                break
        }
    }
    
    public main(){
    
        var options = ["1. I'm doing good! How are you?", "2. Horrible"]

        let index = 0

        while (index <= 1) {
            document.getElementById(`listLabel${index + 3}`).innerHTML += options[index]

            index ++
        }
    }
}

class Question3{

    private resultLabel = document.getElementById("resultLabel")

    public ValidAnswer(userInput){
        if (userInput == "1"){
            this.resultLabel.innerHTML = "I'm doing good!"
        }
    
        else if (userInput == "2"){
            this.resultLabel.innerHTML = "Sorry to hear that. I hope your day gets better!"
        }
    
        else {
            this.resultLabel.innerHTML = "Invalid response"
        }
    }
    
    public main(){
    
        var options = ["1. I'm doing good! How are you?", "2. Horrible"]
    
        var index = 0

        while (index <= 1) {
            document.getElementById(`listLabel${index + 3}`).innerHTML += options[index]

            index ++
        }
    }
}

function submitQ3(){
    let userInput = document.getElementById("userInput3") as HTMLInputElement

    question3.ValidAnswer(userInput.value)
}

window.submitQ3 = submitQ3

function submitQ4(){
    let userInput = document.getElementById("userInput4") as HTMLInputElement

    question4.ValidAnswer(userInput.value)
}

window.submitQ4 = submitQ4

let question3 = new Question3

question3.main()

let question4 = new Question4

question4.main()
