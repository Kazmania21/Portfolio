#to run type ruby Basics.ru in terminal

class Question2
    def validAnswer(userInput)
        validAnswer = true
    
        if userInput == "1\n"
            puts "I'm doing good!"
        
        elsif userInput == "2\n"
            puts "Sorry to hear that. I hope your day gets better!"
    
        else
            puts "Invalid response."
            validAnswer = false
        end
    
        return validAnswer
    end

    def main()
        options = Array["1. I'm doing good! How are you?", "2. Horrible"] # declaring that the cariable is an array is not needed but is an option
        
        puts "Hello! How are you?\nOptions:"

        for index in 0..1
            puts options[index]
        end

        userInput = gets
    
        while validAnswer(userInput)
            userInput = gets
        end
    end
end

class Question1
    def validAnswer(userInput)
        validAnswer = true
    
        if userInput == "1\n"
            puts "I'm doing good!"
        
        elsif userInput == "2\n"
            puts "Sorry to hear that. I hope your day gets better!"
    
        else
            puts "Invalid response."
            validAnswer = false
        end
    
        return validAnswer
    end

    def main()

        options = Array["1. I'm doing good! How are you?", "2. Horrible"] # declaring that the cariable is an array is not needed but is an option
        
        puts "Hello! How are you?\nOptions:"

        for option in options
            puts option
        end
    
        loop do
            userInput = gets
            break if validAnswer(userInput)
        end
    end
end

question1 = Question1.new

question1.main()

question2 = Question1.new

question2.main()