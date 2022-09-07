public class CompositeClient : IConsumer
{
    // TODO implementa el patron de diseño Composite
    public void runClient()
    {

        Console.WriteLine("Ejecución CompositeClient.");

        // TODO Se require poder agrupar elementos Button que heredan de View para optimizar el dibujado de los mismo y tener mejor control de sus funciones.
        // TODO No puedes modificar la función que realiza el dibujado "ViewDrawer" 

        Button btnRight = new Button("Derecha"); 
        Button btnLeft = new Button("Izquierda"); 
        Button btnUp = new Button("Arriba"); 
        Button btnBottom = new Button("Abajo"); 

        Image background = new Image("ui-background.png");
        TextView title = new TextView("Titulo de la ventana");
        
        ViewDrawer(background);
        ViewDrawer(title);

        ViewDrawer(btnRight);
        ViewDrawer(btnLeft);
        ViewDrawer(btnUp);
        ViewDrawer(btnBottom);

    }


    // No la deberías modificar
    private void ViewDrawer(View view){
        view.Draw();
    }

}