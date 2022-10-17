// TODO refactorizar para implementar uso de factory method
public class FireFlowerPowerUp : IPowerUp{

    public void applyPowerUp(string player){
        Console.WriteLine($"Se aplico FireFlowerPowerUp a {player}");
    }

}