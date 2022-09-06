public class BuilderClient : IConsumer
{
    // TODO refactorizar para implementar uso de builder
    public void runClient()
    {

        Console.WriteLine("Ejecución Builder.");

        Item swordItem = new Item();
        swordItem.Id = 1;
        swordItem.Name = "Sword Item";
        swordItem.Texture = "sword.png";
        swordItem.Size = 32;
        
        Console.WriteLine($"Item creado = {swordItem.Name}");

    }
}