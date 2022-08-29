

namespace LambdaExprestionsProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            AddingPersonDetailsIntoList(list);
            Console.ReadLine();
        }

        public static void AddingPersonDetailsIntoList(List<Person> list)
        {
            list.Add(new Person() { SSN = 1, Age = 23, Name = "Ram", Address = "TamilNadu"});
            list.Add(new Person() { SSN = 2, Age = 20, Name = "Naveen", Address = "Karnataka" });
            list.Add(new Person() { SSN = 3, Age = 30, Name = "Karthik", Address = "Andhra" });
            list.Add(new Person() { SSN = 4, Age = 50, Name = "Moorthy", Address = "Kerala" });
            list.Add(new Person() { SSN = 5, Age = 40, Name = "Pradeep", Address = "Pondicherry" });
            list.Add(new Person() { SSN = 2, Age = 35, Name = "Sam", Address = "Goa" });
            list.Add(new Person() { SSN = 2, Age = 25, Name = "Arun", Address = "Delhi" });
            DisplayPersonDeails(list);
        }
        public static void DisplayPersonDeails(List<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine(person);
            }
        }
    }
}
