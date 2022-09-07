public class AbstractFactoryClient : IConsumer
{
    // TODO implementa el patron de diseño Abstract Factory
    public void runClient()
    {

        Console.WriteLine("Ejecución Abstract Factory.");

        WoodenSword woodenSword = new WoodenSword();
        WoodenAxe woodenAxe = new WoodenAxe();
        WoodenPickAxe woodenPickAxe = new WoodenPickAxe();

        woodenAxe.Cut();
        woodenPickAxe.Pick();
        woodenSword.Attack();

        // TODO Agregar menu de opciones para poder seleccionar cual tipo de herramienta utilizar

    }
}