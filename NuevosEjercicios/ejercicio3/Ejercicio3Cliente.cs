public class Ejercicio3Cliente : IConsumer
{

    public void runClient()
    {

        string player ="Steve";

       // Refactoriza para implementar el patron de diseño mas adecuado
       AppleFood appleFood = new AppleFood();
       BreadFood breadFood = new BreadFood();
       CowMeatFood cowMeatFood = new CowMeatFood();
       PotatoFood potatoFood = new PotatoFood();


       appleFood.EatFood(player);
       breadFood.EatFood(player);
       cowMeatFood.EatFood(player);
       potatoFood.EatFood(player);

    }
}