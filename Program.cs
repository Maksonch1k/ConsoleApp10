namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Employee employee = new Employee("Бабчинецкий", "Андрей", 80000, 1.2);
            employee.DisplayInfo();

            Engineer engineer = new Engineer("Коробка", "Максим", 50000, 1.5, 15);
            engineer.DisplayInfo();

            Bus bus = new Bus("Mercedes", 40, 50);
            Console.WriteLine($"общ. стоимость всех мест в обычном автобусе: {bus.CalculateTotalCost()}\n");

            Tourist touristBus = new Tourist("Volkswagen", 30, 70, 20);
            Console.WriteLine($"общ.стоимость всех мест в туристическом автобусе: {touristBus.CalculateTotalCost()}\n");
            Console.ReadKey ();
        }
    }
}
    
