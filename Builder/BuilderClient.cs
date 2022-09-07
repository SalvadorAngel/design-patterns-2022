public class BuilderClient : IConsumer
{
    // TODO implementa el patron de diseño Builder
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