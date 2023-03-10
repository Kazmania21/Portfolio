// tsc Basics.js to convert to js

import { hi } from "./exmod.js" //imports do not get converted well

console.log(hi)

console.log("Hello World")

class Question2{

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

        for (var index = 0; index <= 1; index++) {
            document.getElementById(`listLabel${index + 1}`).innerHTML += options[index]
        }
    }
}

class Question1{

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
    
        var index = 1
    
        options.forEach(option => {
            document.getElementById(`arrayLabel${index}`).innerHTML += option
            index += 1
        })
    }
}

function submitQ1(){
    let userInput = document.getElementById("userInput") as HTMLInputElement

    question1.ValidAnswer(userInput.value)
}

window.submitQ1 = submitQ1

function submitQ2(){
    let userInput = document.getElementById("userInput2") as HTMLInputElement

    question2.ValidAnswer(userInput.value)
}

window.submitQ2 = submitQ2

let question1 = new Question1

question1.main()

let question2 = new Question2

question2.main()
