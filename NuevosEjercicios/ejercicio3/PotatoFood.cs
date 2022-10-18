// Refactoriza para implementar el patron de diseño mas adecuado
public class PotatoFood{

    public void EatFood(string player){
        Console.WriteLine($"{player} -> {this.GetType().Name}");
    }

}