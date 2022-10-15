public class ItemBuilder{

    private Item item = new Item();

    public ItemBuilder setId(int id){
        item.Id = id;
        return this;
    }

    public ItemBuilder setName(string name){
        item.Name = name;
        return this;
    }

    public ItemBuilder setTexture(string texture){
        item.Texture = texture;
        return this;
    }

    public ItemBuilder setSize(int size){
        item.Size = size;
        return this;
    }


    public Item build(){
        if(item.Id <0){
            Console.WriteLine("El Id no es valido");
        }
        return item;
    }


}