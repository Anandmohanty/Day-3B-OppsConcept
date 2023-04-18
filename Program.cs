namespace Day_3B_OppsConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 3B Practice Problem ");

            //Type of Constructor//
            TypeOfConstructor typeOfConstructor = new TypeOfConstructor();

            TypeOfConstructor parameterConstructor = new TypeOfConstructor("Mahesh", 30);

            TypeOfConstructor copyConstructor = new TypeOfConstructor(parameterConstructor);

            TypeOfConstructor.SampleMessage();
        }
    }
}