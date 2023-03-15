"use strict";
// tsc Basics.js to convert to js

import { hi } from "./exmod.js" //imports do not get converted well

console.log(hi)

console.log("Hello World")
var Question2 = /** @class */ (function () {
    function Question2() {
        this.resultLabel = document.getElementById("resultLabel2");
    }
    Question2.prototype.ValidAnswer = function (userInput) {
        switch (userInput) {
            case "1":
                this.resultLabel.innerHTML = "I'm doing good!";
                break;
            case "2":
                this.resultLabel.innerHTML = "Sorry to hear that. I hope your day gets better!";
                break;
            default:
                this.resultLabel.innerHTML = "Invalid response";
                break;
        }
    };
    Question2.prototype.main = function () {
        var options = ["1. I'm doing good! How are you?", "2. Horrible"];
        for (var index = 0; index <= 1; index++) {
            document.getElementById("listLabel".concat(index + 1)).innerHTML += options[index];
        }
    };
    return Question2;
}());
var Question1 = /** @class */ (function () {
    function Question1() {
        this.resultLabel = document.getElementById("resultLabel");
    }
    Question1.prototype.ValidAnswer = function (userInput) {
        if (userInput == "1") {
            this.resultLabel.innerHTML = "I'm doing good!";
        }
        else if (userInput == "2") {
            this.resultLabel.innerHTML = "Sorry to hear that. I hope your day gets better!";
        }
        else {
            this.resultLabel.innerHTML = "Invalid response";
        }
    };
    Question1.prototype.main = function () {
        var options = ["1. I'm doing good! How are you?", "2. Horrible"];
        var index = 1;
        options.forEach(function (option) {
            document.getElementById("arrayLabel".concat(index)).innerHTML += option;
            index += 1;
        });
    };
    return Question1;
}());
function submitQ1() {
    var userInput = document.getElementById("userInput");
    question1.ValidAnswer(userInput.value);
}
window.submitQ1 = submitQ1;
function submitQ2() {
    var userInput = document.getElementById("userInput2");
    question2.ValidAnswer(userInput.value);
}
window.submitQ2 = submitQ2;
var question1 = new Question1;
question1.main();
var question2 = new Question2;
question2.main();
