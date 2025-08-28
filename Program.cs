//Create a  class "CharacterInfo" with at least five information of properties 
//name, age, height, job, favorite activities 


class CharacterInfo
{
    private int __age; //backing field
    public string Name { get; set; } = " ";

    public int age
    {
        get => __age;
        set
        {
            if (value > 0 && value < 130)
            {
                __age = value;
            }
            else
            {
                Console.WriteLine("Age must be between 0 - 100");
            }
        }
    }

    public double height{  get; set; }
    public string Job { get; set; } = "";
    public string yourfavword { get; set; } = "";
    public string[] Fear { get; set; } = Array.Empty<string>();
    
    public void Storytelling(string title) //method
    {
        Console.WriteLine(" --- {Story about a stranger} ---");
        Console.WriteLine(Name + " has been working as an " + Job + " for a while now");
        Console.WriteLine("As " + Name + " walks by the street of " + yourfavword + " Rd, he sees a homeless approaching him");
        Console.WriteLine("Homeless guy stood in front of" + Name + " and asks, How old are you?");
        Console.WriteLine(Name + " replies, I am " + age);
        Console.WriteLine("Homeless guy whispers .. " + Name + "..." + age + "...");
        Console.WriteLine("I know a dirty little secret about you..");
        Console.WriteLine("As " + Name + " feels shiver in this hand, he runs off from the " + yourfavword + " Rd. ");

        Console.WriteLine($"\n The secret that {Name} hides.... : ");
        if (Fear.Length == 0)
        {
            Console.WriteLine(" - (none listed)");

        }
        else
          
       
            foreach (string secret in Fear)
            {
                Console.WriteLine(" - " + secret);
                
            }
      
    }
}
class Program
    {
    static void Main()
    {
        CharacterInfo character = new();

        //menu
        bool running = true;
        while (running)
        {

            Console.WriteLine("\n ---Create your Character----");
            Console.WriteLine("1. Enter Name");
            Console.WriteLine("2. Enter Age");
            Console.WriteLine("3. Enter Height");
            Console.WriteLine("4. Enter your Fear");
            Console.WriteLine("5. Enter your Favoriteword");
            Console.WriteLine("6. Enter Character's Job");
            Console.WriteLine("7. Story");
            Console.WriteLine("Exit");





            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter Character name: ");
                    character.Name = Console.ReadLine() ?? "";
                    break;

                case "2":
                    Console.WriteLine("Enter Character Age: ");
                    character.age = Convert.ToInt32(Console.ReadLine());
                    break;

                case "3":
                    Console.WriteLine("Enter Character Height(e.g., 5.11): ");
                    character.height = Convert.ToDouble(Console.ReadLine());
                    break;

                case "4":
                    Console.WriteLine("How many fears do you have: ");
                    int count = Convert.ToInt32(Console.ReadLine());

                    character.Fear = new string[count]; //make array

                    for(int i = 0; i < count; i++)
                    {
                        Console.Write($"Enter fear {i + 1}: ");
                        character.Fear[i] = Console.ReadLine() ?? "";

                    }
                    

                    break;

                case "5":
                    Console.WriteLine("Enter your Favorite word: ");
                    character.yourfavword = Console.ReadLine() ?? "";
                    break;

                case "6":
                    Console.WriteLine("Enter Charcter's Job: ");
                    character.Job = Console.ReadLine() ?? "";
                    break;

                case "7":
                    character.Storytelling("Story");
                    break;

                case "8":
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice, Try again.");
                    break;
            }


        }


    }

}
