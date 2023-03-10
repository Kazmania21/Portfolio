import java.util.Scanner;

public class FirstJavaProgram {
    public static void main (String[] args){
        Boolean loop = true;
        int loopNumber = 0;
        while (loop == true) {
            Scanner input = new Scanner(System.in);
            String inputVariable = input.nextLine();
            if (inputVariable.equals("hello")){
                System.out.print("Hello World!");
                loop = false;
                input.close();
            }

            else {
                System.out.print(":(\n");
            }

            loopNumber += 1;
        }
        for (int loop2 = 0; loop2 <= loopNumber; loop2 += 1) {
            String attempt = String.format("\nAttempts: %o", loop2);
            System.out.print(attempt);
        }
    }
}