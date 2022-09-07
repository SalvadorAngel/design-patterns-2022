public class DecoratorClient : IConsumer
{
    // TODO implementa el patron de diseño Decorator
    // TODO Generar decoradores necesarios para implementar los cuatro elementos (Agua, tierra, fuego y aire)
    public void runClient()
    {

        Console.WriteLine("Ejecución DecoratorClient.");

        AvatarPlayer avatarPlayer = new AvatarPlayer();
        avatarPlayer.DoBending();
        
        // TODO agregar menu para seleccionar combinación de elementos puede utilizar el Avatar
        // Ejemplo: 1-tierra 2-agua...  entrada -> 1,2, entonces el Avatar solo podría utilizar los elementos seleccionados  
        
    }
}