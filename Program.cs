using System;

namespace Lab5
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            TransportManager manager = new TransportManager();


            BaseInform infoCar = new BaseInform("Toyota Camry", 2020, "Black", 25000, "Sedan");
            Transport car = new Car(infoCar, 5, "Gasoline", "Camry XSE");

            BaseInform infoBicycle = new BaseInform("Trek FX 3 Disc", 2021, "Blue", 800, "Hybrid bike");
            Transport bicycle = new Bicycle(infoBicycle, 24, true);

            BaseInform infoCart = new BaseInform("Horse - drawn cart", 1987, "Brown", 500, "Vintage");
            Transport cart = new Cart(infoCart, 2, "Wood");

            // добавление транспорта
            manager.AddTransport(car);
            manager.AddTransport(bicycle);
            manager.AddTransport(cart);

            // вывод всего списка
            Console.WriteLine("Initial transport list:");
            manager.DisplayAllTransports();

            // редактирование
            BaseInform infoEditCar = new BaseInform("Toyota Prado", 2020, "Black", 23000, "SUV");
            Car editedCar = new Car(infoEditCar, 5, "Gasoline", "Prado 123");
            manager.EditTransport(0, editedCar); // Предполагается, что car находится на позиции 0

            // после редактирования
            Console.WriteLine("\nTransport list after editing:");
            manager.DisplayAllTransports();

            // удаление
            manager.RemoveTransport(cart);

            // после удаления
            Console.WriteLine("\nTransport list after removal:");
            manager.DisplayAllTransports();
        }

    }
}
