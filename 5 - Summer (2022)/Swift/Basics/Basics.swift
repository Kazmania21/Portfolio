//"swift Basics.swift" in terminal to run

class Question2 {
    func validAnswer(userInput: String) -> Bool{
        var validAnswer = true

        //debugPrint(userInput)

        switch (userInput) {
            case "1":
                print("I'm doing good!")
                break

            case "2":
                print("Sorry to hear that. I hope your day gets better!")
                break

            default:
                print("Invalid response")
                validAnswer = false
        }

        return validAnswer
    }

    func main() {
        print("Hello! How are you?\nOptions:")

        var options = ["1. I'm doing good! How are you?", "2. Horrible"]

        for option in options {
            print(option)
        }

        var userInput = readLine()!

        while (!validAnswer(userInput: userInput)) {
            userInput = readLine()!
        }
    }
} 

class Question1 {
    func validAnswer(userInput: String) -> Bool{
        var validAnswer = true

        //debugPrint(userInput)

        if (userInput == "1"){
        print("I'm doing good!")
        }

        else if (userInput == "2"){
            print("Sorry to hear that. I hope your day gets better!")
        }

        else {
            print("Invalid response")
            validAnswer = false
        }

        return validAnswer
    }

    func main() {
        print("Hello! How are you?\nOptions:")

        var options = ["1. I'm doing good! How are you?", "2. Horrible"]

        for index in 0...1 {
            print(options[index])
        }

        var userInput = ""

        repeat {
            userInput = readLine()!
        } while (!validAnswer(userInput: userInput))
    }
} 

var question1 = Question1()
question1.main()

var question2 = Question2()
question2.main()