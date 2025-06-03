namespace DictionaryHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            bool answered = false;
            do
            {
                Console.Write("Enter ID: ");
                string answer = Console.ReadLine();
                if (answer == "")
                {
                    answered = false;
                    break;
                }
                bool isValidInt = int.TryParse(answer, out int ID);
                if (isValidInt != true)
                {
                    Console.WriteLine("Try again.");
                    continue;
                }
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                students.Add(ID, name);
            }
            while (answered != true);
            Console.Write("Please enter ID: ");
            bool isValid = int.TryParse(Console.ReadLine(), out int LookupId);
            if (isValid) {
                Console.WriteLine($"Your name is {students[LookupId]}");
            }
        }
    }
}
