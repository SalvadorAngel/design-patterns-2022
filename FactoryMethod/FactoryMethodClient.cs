public class FactoryMethodClient : IConsumer
{
    // TODO refactorizar para implementar uso de factory method
    public void runClient()
    {

        Console.WriteLine("Ejecución Factory method.");

        string player = "Player 1";

        //TODO refactorizar para no utilizar clases concretas 
        FireResistancePotion fireResistancePotion = new FireResistancePotion();
        HealingPotion healingPotion = new HealingPotion();
        StrengthPotion strengthPotion = new StrengthPotion();

        fireResistancePotion.applyPotion(player);
        healingPotion.applyPotion(player);
        strengthPotion.applyPotion(player);

    }
}