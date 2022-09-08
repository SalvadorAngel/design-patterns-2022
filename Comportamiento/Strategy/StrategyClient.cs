// TODO implementa el patron de diseño Strategy
public class StrategyClient : IConsumer
{

    // TODO agregar un nuevo algoritmo "CubicNoise" usando el patron Strategy

    public void runClient()
    {

        Console.WriteLine("Ejecución StrategyClient.");

        SimplexNoise();
        PerlinNoise();


        // TODO Agregar menu de opciones para poder cambiar entre diferentes algoritmos

    }

    private void SimplexNoise(){
        Console.WriteLine("Generando terreno con SimplexNoise");
    }

    private void PerlinNoise(){
        Console.WriteLine("Generando terreno con PerlinNoise");
    }

}
