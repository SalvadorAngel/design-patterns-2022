// TODO implementa el patron de diseño State
public class StateClient : IConsumer
{

    // TODO agregar estados extra EAT, JUMP, agrega nuevas combinaciones de condiciones nuevas entre estados, ejemplo de SLEEP no puede pasar a JUMP, 
    public const string WALK = "Walk";
    public const string ATTACK = "Attack";
    public const string SLEEP = "Sleep";
    public const string SWIM = "Swim";

    private string state = WALK;

    public void runClient()
    {

        Console.WriteLine("Ejecución StateClient.");

        doAction(ATTACK);
        doAction(SLEEP);
        doAction(ATTACK);
        doAction(SWIM);
        doAction(WALK);


        // TODO Agregar menu de opciones para poder cambiar entre estados

    }

    private void doAction(string action)
    {

        switch (action)
        {
            case WALK:
                Console.WriteLine($"Cambio de estado de {state} -> {action}");
                state = action;
                break;
            case ATTACK:
                if (state == SLEEP || state == SWIM)
                {
                    Console.WriteLine($"No puedes cambiar estado de {state} a {action}");
                }
                else
                {
                    Console.WriteLine($"Cambio de estado de {state} -> {action}");
                    state = action;
                }
                break;
            case SLEEP:
                if (state == ATTACK )
                {
                    Console.WriteLine($"No puedes cambiar estado de {state} a {action}");
                }
                else
                {
                    Console.WriteLine($"Cambio de estado de {state} -> {action}");
                    state = action;
                }
                break;
            case SWIM:
                if (state == SLEEP || state == ATTACK)
                {
                    Console.WriteLine($"No puedes cambiar estado de {state} a {action}");
                }
                else
                {
                    Console.WriteLine($"Cambio de estado de {state} -> {action}");
                    state = action;
                }
                break;
        }

    }

}
