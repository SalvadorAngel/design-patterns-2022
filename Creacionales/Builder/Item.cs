// TODO refactorizar para implementar uso de builder
public class Item{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Texture { get; set; }
    public int Size { get; set; }


    public static ItemBuilder GetBuilder() => new ItemBuilder();

}