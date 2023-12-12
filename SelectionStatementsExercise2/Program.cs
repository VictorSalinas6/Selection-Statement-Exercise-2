namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please tell me your favorite school subject! (Math, Art, History, Music, Biology)");
            string answer = Console.ReadLine();
            Console.WriteLine(); //Just to add the Line

            switch (answer)
            {
                case "Math":
                case "math":
                    Console.WriteLine("You chose Math!\n");
                    Console.WriteLine("Did you know that there is no Roman numeral for zero! Check the roman numerals of 10, 20, 30, 100, 500…" +
                        " You do not have a zero in roman numerals!");
                break;
                case "Art":
                case "art":
                    Console.WriteLine("You chose Art!\n");
                    Console.WriteLine("Did you know that The Mona Lisa has her own mailbox in the Louvre because of all the love letters she receives!");
                    break;
                case "History":
                case "history":
                    Console.WriteLine("You chose History!\n");
                    Console.WriteLine("Did you know Alexander the Great was accidentally buried alive. Scientists believe Alexander suffered" +
                        " from a\nneurological disorder called Guillain-Barré Syndrome.\nThey believe that when he died, he was actually just paralyzed" +
                        " and mentally aware!");
                    break;
                case "Music":
                case "music":
                    Console.WriteLine("You chose Music!\n");
                    Console.WriteLine("Did you know none of The Beatles Could Write or Read Music." +
                        "\nPaul McCartney finally admitted that neither he nor any of his Beatles bandmates were able to read or write music" +
                        "\nduring a 2018 interview");
                    break;
                case "Biology":
                case "biology":
                    Console.WriteLine("You chose Biology!\n");
                    Console.WriteLine("Did you know The word “muscle” comes from Latin term meaning “little mouse“," +
                        "\nwhich is what Ancient Romans thought flexed bicep muscles resembled.");
                    break;
                default:
                    Console.WriteLine("Please enter a valid school subject or the spelling!");
                    break;
            }
        }
    }
}