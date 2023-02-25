namespace DesignProgram.FactoryMethod;

public class SportCarFactory : ICarFactory
{
    public ICar CreateCar()
    {
        return new SportCar();
    }
}

public class JeepCarFactory : ICarFactory
{
    public ICar CreateCar()
    {
        return new JeepCar();
    }
}
