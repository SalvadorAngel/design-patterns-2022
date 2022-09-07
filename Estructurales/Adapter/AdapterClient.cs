public class AdapterClient : IConsumer
{
    // TODO implementa el patron de diseño Adapter
    // TODO Crear un nuevo adapter JsonNewtonsoftAdapter
    public void runClient()
    {

        Console.WriteLine("Ejecución AdapterClient.");

        string jsonString = 
        @"
        {
           'name': 'Player 1',
           'leve': 137 
        }
        ";

        JsonSystemAdapter jsonSystemAdapter = new JsonSystemAdapter();

        jsonSystemAdapter.Deserialize(jsonString);

        // TODO agregar menu para seleccionar cual adapter utilizar
        
    }
}