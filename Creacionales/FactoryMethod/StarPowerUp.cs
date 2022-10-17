// TODO refactorizar para implementar uso de factory method
public class StarPowerUp : IPowerUp{

    public void applyPowerUp(string player){
        Console.WriteLine($"Se aplico StarPowerUp a {player}");
    }

}