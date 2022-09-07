public abstract class View {

    public string Name { get; set; }

    public View(string name)
    {
        Name = name;
    }

    public void Draw(){
        Console.WriteLine($"Dibujando {this.GetType().Name} nombre={Name}");
    }

}