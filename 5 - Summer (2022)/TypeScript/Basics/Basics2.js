"use strict";
// tsc Basics.js to convert to js

import { hi } from "./exmod.js" //imports do not get converted well

console.log(hi)

console.log("Hello World")

var Question4 = /** @class */ (function () {
    function Question4() {
        this.resultLabel = document.getElementById("resultLabel2");
    }
    Question4.prototype.ValidAnswer = function (userInput) {
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
    Question4.prototype.main = function () {
        var options = ["1. I'm doing good! How are you?", "2. Horrible"];
        for (var index = 0; index <= 1; index++) {
            document.getElementById("listLabel".concat(index + 3)).innerHTML += options[index];
        }
    };
    return Question4;
}());
var Question3 = /** @class */ (function () {
    function Question3() {
        this.resultLabel = document.getElementById("resultLabel");
    }
    Question3.prototype.ValidAnswer = function (userInput) {
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
    Question3.prototype.main = function () {
        var options = ["1. I'm doing good! How are you?", "2. Horrible"];
        var index = 3;
        options.forEach(function (option) {
            document.getElementById("arrayLabel".concat(index)).innerHTML += option;
            index += 1;
        });
    };
    return Question3;
}());
function submitQ3() {
    var userInput = document.getElementById("userInput3");
    question3.ValidAnswer(userInput.value);
}
window.submitQ3 = submitQ3;
function submitQ4() {
    var userInput = document.getElementById("userInput4");
    question4.ValidAnswer(userInput.value);
}
window.submitQ4 = submitQ4;
var question3 = new Question3;
question3.main();
var question4 = new Question4;
question4.main();
