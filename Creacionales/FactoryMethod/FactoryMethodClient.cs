public class FactoryMethodClient : IConsumer
{
    // TODO implementa el patron de diseño factory method
    public void runClient()
    {

        Console.WriteLine("Ejecución Factory method.");

        string player = "Player 1";

        //TODO refactorizar para no utilizar clases concretas 
        MushroomPowerUp fireResistancePotion = new MushroomPowerUp();
        FireFlowerPowerUp healingPotion = new FireFlowerPowerUp();
        StarPowerUp strengthPotion = new StarPowerUp();

        fireResistancePotion.applyPotion(player);
        healingPotion.applyPotion(player);
        strengthPotion.applyPotion(player);

    }
}