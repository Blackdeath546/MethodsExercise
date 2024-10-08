namespace MethodsExercise
{
    public class Program
    {
        
        public static void ThingsIHate()
        {
             Console.WriteLine("What is your name?");
             string name = Console.ReadLine();
                        
             Console.WriteLine("What is your fav colour?");
             string color = Console.ReadLine();
                        
                        
                        
                        
             Console.WriteLine($"My name is {name} and I hate the colour {color}." +
                               $"\nI wish {color} never existed." +
                               $"\nOf all the colors, none is quite as overrated and obnoxious as {color}." +
                               $"\nIt tries so hard to stand out, yet {color} lacks any real depth or character." +
                               $"\n{color} is the kind of shade that pretends to be bold but falls flat in any" +
                               $"\nmeaningful context." +
                               $"\nIt’s the choice for those with no taste, clinging to it as if it represents" +
                               $"\nsome unique flair, when in reality, it’s just a lazy excuse for real creativity." +
                               $"\nEven worse, {color} seems to dominate spaces where it’s least wanted, turning" +
                               $"\notherwise pleasant scenes into an eyesore." +
                               $"\nI really hate the color {color}.");
             
        }
        static void Main(string[] args)
        {
           ThingsIHate();

        }
    }
}
