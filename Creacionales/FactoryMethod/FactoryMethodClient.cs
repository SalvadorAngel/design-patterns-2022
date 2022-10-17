public class FactoryMethodClient : IConsumer
{
    // TODO implementa el patron de diseño factory method
    public void runClient()
    {

        Console.WriteLine("Ejecución Factory method.");

        string player = "Player 1";

        PowerUpFactory factory = new PowerUpFactory();

        //TODO refactorizar para no utilizar clases concretas 
        IPowerUp fireFlowePoweUp = factory.GetPowerUp(PowerUpType.FireFlower);
        IPowerUp mushroomPowerUp = factory.GetPowerUp(PowerUpType.Mushroom);
        IPowerUp starPowerUp = factory.GetPowerUp(PowerUpType.Star);

        fireFlowePoweUp.applyPowerUp(player);
        mushroomPowerUp.applyPowerUp(player);
        starPowerUp.applyPowerUp(player);

    }
}