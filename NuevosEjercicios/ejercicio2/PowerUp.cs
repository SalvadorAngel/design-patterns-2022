// Refactoriza para implementar el patron de diseño mas adecuado
public class Powerup{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Texture { get; set; }
    public string Effect { get; set; }
    public float Duration { get; set; }
    public List<int> Incompatible { get; set; }
}