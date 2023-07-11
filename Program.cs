
using FacadeDesignPattern;

Console.WriteLine("Facade Design Pattern");


CarFacade facade = new CarFacade();

facade.CreateCompleteCar();

Console.ReadKey();