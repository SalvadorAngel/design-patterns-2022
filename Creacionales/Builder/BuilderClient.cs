public class BuilderClient : IConsumer
{
    public void runClient()
    {

        Console.WriteLine("Ejecución Builder.");

        // Item swordItem = new Item();
        // swordItem.Id = 1;
        // swordItem.Name = "Sword Item";
        // swordItem.Texture = "sword.png";
        // swordItem.Size = 32;

        ItemBuilder builder = Item.GetBuilder().setId(1)
                                               .setName("Sword Item")
                                               .setTexture("sword.png")
                                               .setSize(32);

         Item swordItem = builder.build();

        
        Console.WriteLine($"Item creado = {swordItem.Name}");

    }
}