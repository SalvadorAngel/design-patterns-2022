// Refactoriza para implementar el patron de diseño mas adecuado
public class BreadFood{

    public void EatFood(string player){
        Console.WriteLine($"{player} -> {this.GetType().Name}");
    }

}