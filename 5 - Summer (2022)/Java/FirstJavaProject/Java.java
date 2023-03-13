import java.util.*;
import java.util.stream.Collectors;
import java.util.stream.Stream;

public class Java {

    public static Scanner input = new Scanner(System.in);

    public static void main (String[] args){
        Question1.main(args);
        Question2.main(args);
        input.close();
    }
}

class Question1 {
    
    private static boolean respondedCorrectly (String userInput){
        
        boolean respondedCorrectly = true;

        if (userInput.equals("1")){
            System.out.println("I'm doing good!");
        }

        else if (userInput.equals("2")){
            System.out.println("Sorry to hear that. I hope your day gets better!");
        }

        else {
            System.out.println("Invalid answer. Try again.");
            respondedCorrectly = false;
        }

        return respondedCorrectly;
    }

    static void main (String[] args){

        String[] options = {"1. I'm doing good! How are you?", "2. Horrible"};

        String firstInput;

        System.out.println("Hello! How are you?\nOptions:");

        for (String option : options) {
            System.out.println(String.format("%s", option));
        }

        do {
            firstInput = Java.input.next();;
        } while (!respondedCorrectly(firstInput));
    }
}

class Question2 {

    private static boolean respondedCorrectly (String userInput){
        boolean respondedCorrectly = true;

        switch (userInput){
            case "1":
                System.out.println("I'm doing good!");
                break;

            case "2":
                System.out.println("Sorry to hear that. I hope your day gets better!");
                break;

            default:
                System.out.println("Invalid answer. Try again.");
                respondedCorrectly = false;
                break;
        }

        return respondedCorrectly;
    }

    static void main (String[] args){
        List <String> options = Stream.of("1. I'm doing good! How are you?", "2. Horrible").collect(Collectors.toList());

        System.out.println("Hello! How are you?\nOptions:");

        for (int index = 0; index <= 1; index++) {
            System.out.println(String.format("%s", options.get(index)));
        }

        String secondInput = Java.input.next();

        while (!respondedCorrectly(secondInput)){
            secondInput = Java.input.next();
        }
    }
}
