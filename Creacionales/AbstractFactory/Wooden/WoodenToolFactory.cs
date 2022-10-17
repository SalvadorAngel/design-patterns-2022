public class WoodenToolFactory : IToolFactory
{
    IAxe IToolFactory.GetAxe()
    {
        return new WoodenAxe();
    }

    IPickAxe IToolFactory.GetPickAxe()
    {
        return new WoodenPickAxe();
    }

    ISword IToolFactory.GetSword()
    {
        return new WoodenSword();
    }
}