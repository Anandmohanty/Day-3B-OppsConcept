using static Day_3B_OppsConcept.TypesOfConstructor;

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


            //Interface//
            BankManager bankManager = new BankManager();
            bankManager.GetBankDetails();

            //Access Modifier//
            AccessModifier accessModifier = new AccessModifier();
            Console.WriteLine("We can access bank account number variable due to Public access modifier\n Bank Account number is " + accessModifier.bankAccountNumber);
            BankAccount bankAccount = new BankAccount();
            Console.WriteLine("This is Example of Private Access modifier \n like now we can not get balance directly but \n we can use this by public method with same class " + bankAccount.GetBalance());

            Rectangle rectangle = new Rectangle(25, 60);

            int area = rectangle.GetArea();

            Console.WriteLine("Area of the given value is = " + area);
        }
    }
}