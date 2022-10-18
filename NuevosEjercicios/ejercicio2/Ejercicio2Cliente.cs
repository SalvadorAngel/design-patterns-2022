public class Ejercicio2Cliente : IConsumer
{

    public void runClient()
    {
// Refactoriza para implementar el patron de diseño mas adecuado
       Powerup powerup = new Powerup();
       powerup.Id = 1;
       powerup.Name = "Fire flower";
       powerup.Description = "Descripcion de Fire flower";
       powerup.Duration = 100;
       powerup.Incompatible = new List<int>{1,4,6};
       powerup.Texture = "FireFlower.png";
       powerup.Effect = "fire.png";

    }
}