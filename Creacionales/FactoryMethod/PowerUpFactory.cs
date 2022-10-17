public class PowerUpFactory
{

    public IPowerUp? GetPowerUp(PowerUpType type)
    {
        switch (type)
        {
            case PowerUpType.FireFlower:
                return new FireFlowerPowerUp();
            case PowerUpType.Mushroom:
                return new MushroomPowerUp();
            case PowerUpType.Star:
                return new StarPowerUp();
        }

        return null;

    }

}

public enum PowerUpType
{
    FireFlower,
    Mushroom,
    Star
}