//type "go run Basics.go" in terminal to run program

package main

import (
	"fmt"
)

func main() {
	question1()
	question2()
}

func question2() {
	validAnswer2 := func(userInput string) bool {
		isValid := true

		switch userInput {
		case "1":
			fmt.Println("I'm doing good!")
			break

		case "2":
			fmt.Println("Sorry to hear that. I hope your day gets better!")
			break

		default:
			fmt.Println("Invalid response. Try again.")
			isValid = false
			break
		}

		return isValid
	}

	main := func() {
		options := [2]string{"1. I'm doing good! How are you?", "2. Horrible"}

		var userInput string

		fmt.Println("Hello! How are you?\nOptions:")

		for index := 0; index <= 1; index++ {
			fmt.Printf("%s\n", options[index])
		}

		fmt.Scanln(&userInput)

		for !validAnswer2(userInput) {
			fmt.Scanln(&userInput)
		}
	}

	main()
}

func question1() {
	validAnswer := func(userInput string) bool {
		isValid := true

		if userInput == "1" {
			fmt.Println("I'm doing good!")
		} else if userInput == "2" {
			fmt.Println("Sorry to hear that. I hope your day gets better!")
		} else {
			fmt.Println("Invalid response. Try again.")
			isValid = false
		}

		return isValid
	}

	main := func() {
		options := [2]string{"1. I'm doing good! How are you?", "2. Horrible"}

		var userInput string

		fmt.Println("Hello! How are you?\nOptions:")

		for _, option := range options {
			fmt.Printf("%s\n", option)
		}

		fmt.Scanln(&userInput)

		for !validAnswer(userInput) {
			fmt.Scanln(&userInput)
		}
	}

	main()
}
