namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of  do you want?");
            Console.WriteLine("Toyota or Subaru");
            Console.WriteLine();
            string userInput = Console.ReadLine();

            IOrderable carInstance = CarFactory.OrderCar(userInput);

            carInstance.Description();
        }
    }
}
