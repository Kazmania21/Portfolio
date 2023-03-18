use std::{io, collections::LinkedList};

fn main(){
    question1();
    question2();
}

fn question2(){
    fn is_valid(user_input: &String) -> bool {
        let mut valid = true;

        match user_input.as_str() {
            "1\r\n" => println!("I'm doing good!"),
            "2\r\n" => println!("Sorry to hear that. I hope your day gets better!"),
            _ => {println!("Invalid response.");
                  valid = false;}
        }
    
        return valid;
    }
    
    fn main() {
        let options = LinkedList::from(["1. I'm doing good! How are you?", "2. Horrible"]);
    
        let mut user_input = String::new();
    
        println!("Hello! How are you?\nOptions:");

        for option in options{
            println!("{}", option);
        };
    
        io::stdin().read_line(&mut user_input).expect("Failed to read input");
    
        while !is_valid(&user_input) {
            user_input = String::new();
            io::stdin().read_line(&mut user_input).expect("Failed to read input");
        }
    }

    main()
}

fn question1(){
    fn is_valid(user_input: &String) -> bool {
        let mut valid = true;
    
        //print!("{:?}", user_input);
    
        if user_input == "1\r\n"{
            println!("I'm doing good!");
        }
    
        else if user_input.eq("2\r\n") {
            println!("Sorry to hear that. I hope your day gets better!");
        }
    
        else {
            println!("Invalid response.");
            valid = false;
        }
    
        return valid;
    }
    
    fn main() {
        let options = ["1. I'm doing good! How are you?", "2. Horrible"];
    
        let mut user_input = String::new();
    
        println!("Hello! How are you?\nOptions:");

        for index in 0..2{
            println!("{}", options[index]);
        };
    
        io::stdin().read_line(&mut user_input).expect("Failed to read input");
    
        while !is_valid(&user_input) {
            user_input = String::new();
            io::stdin().read_line(&mut user_input).expect("Failed to read input");
        }
    }

    main()
}


