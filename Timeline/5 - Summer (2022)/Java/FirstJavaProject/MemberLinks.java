import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.ListIterator;
import java.util.Scanner;

public class MemberLinks {
    public static void main (String[] args){
        System.out.print("What is the streamer's name: ");
        Scanner input = new Scanner(System.in);
        String name = input.nextLine();
        
        String [] socials = {"YouTube", "Twitch", "DLive", "Sliver", "Twitter", "Instagram", "SnapChat", "Facebook", "Spotify", "TikTok"};
        List<String> inputs = new ArrayList<>();
        
        for (String social : socials){
            System.out.print(String.format("What is their %s?\n", social));

            String link = input.nextLine();
            inputs.add(link);
        };
        input.close();

        System.out.println("\nUGN " + name);

        List<String> labels = Arrays.asList("🔴 YOUTUBE | ", "🔴 TWITCH | ", "🔴 DLIVE | ", "🔴 SLIVER | ", "💻 TWITTER | ", "📲 INSTAGRAM | ", "📲 SNAPCHAT | ",
        "😜 FACEBOOK | ", "🎶 SPOTIFY : ", "🕑 TIKTOK | ");

        ListIterator<String> label = labels.listIterator();
        while (label.hasNext()) {
            String nextInput = inputs.get(label.nextIndex());
            if (nextInput != ""){
                System.out.println(String.format("%s %s", label.next(), nextInput));
            }
        }
    }
}
