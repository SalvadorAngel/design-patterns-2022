public class AbstractFactoryClient : IConsumer
{
    // TODO implementa el patron de diseño Abstract Factory
    public void runClient()
    {

        Console.WriteLine("Ejecución Abstract Factory.");


        IToolFactory toolFactory = new WoodenToolFactory();

        ISword woodenSword = toolFactory.GetSword();
        IAxe woodenAxe = toolFactory.GetAxe();
        IPickAxe woodenPickAxe = toolFactory.GetPickAxe();

        woodenAxe.Cut();
        woodenPickAxe.Pick();
        woodenSword.Attack();

        // TODO Agregar menu de opciones para poder seleccionar cual tipo de herramienta utilizar

    }
}