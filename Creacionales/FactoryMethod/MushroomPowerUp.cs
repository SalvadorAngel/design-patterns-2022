// TODO refactorizar para implementar uso de factory method
public class MushroomPowerUp : IPowerUp{

    public void applyPowerUp(string player){
        Console.WriteLine($"Se aplico MushroomPowerUp a {player}");
    }

}