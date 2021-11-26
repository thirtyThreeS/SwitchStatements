namespace SwitchStatements
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school? Note: Make your first letter capital followed by lowercase letters while spelling out your favorite subject!");
            string subject = Console.ReadLine();

            switch (subject)
            {
                case "Math":
                    Console.WriteLine("Math! letters and numbers and paradigms.. oh my..");
                    break;
                case "English":
                    Console.WriteLine("English! I ponder how we can fail our own language..");
                    break;
                case "Science":
                    Console.WriteLine("Science! the study of how things work in this world.. very interesting indeed");
                    break;
                case "Art":
                    Console.WriteLine("Art! May I see some of your artwork?");
                    break;
                case "Gym":
                    Console.WriteLine("Gym! Do you even lift?");
                    break;
                default:
                    Console.WriteLine("Oh, very nice!");
                    break;
                                          
            }
        }
    }
}
