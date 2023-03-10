<?php

//php -f Basics.php to run file

class question2 {
    function validAnswer($userInput) {
        $validAnswer = TRUE;

        switch($userInput) {
            case "1":
                echo "I'm doing good!\n";
                break;

            case "2":
                echo "Sorry to hear that. I hope your day gets better!\n";
                break;

            default:
                echo "Invalid response.\n";
                $validAnswer = FALSE;
        }
    
        return $validAnswer;
    }
    
    public function main() {
        echo "hello world\n";
    
        $options = array("1. I'm doing good! How are you?", "2. Horrible");
    
        for ($index = 0; $index <= 1; $index++) {
            echo "{$options[$index]}\n";
        }

        $userInput = readline(); //readline can also print a string argument to console
    
        while (!$this->validAnswer($userInput)) { //the word this represents the current class 
            $userInput = readline();
        } 
    }
}

class question1 {
    function validAnswer($userInput) {
        $validAnswer = TRUE;
    
        if ($userInput == "1") {
            echo "I'm doing good!\n";
        }
    
        elseif ($userInput == "2") {
            echo "Sorry to hear that. I hope your day gets better!\n";
        }
    
        else {
            echo "Invalid response.\n";
            $validAnswer = FALSE;
        }
    
        return $validAnswer;
    }
    
    public function main() {
        echo "hello world\n";
    
        $options = array("1. I'm doing good! How are you?", "2. Horrible");
    
        foreach ($options as $option) {
            echo "{$option}\n";
        }
    
        do {
            $userInput = readline(); //readline can also print a string argument to console
        } while (!$this->validAnswer($userInput)); //the word this represents the current class
    }
}

$question1 = new question1();

$question1->main();

$question2 = new question2();

$question2->main();

?>