using System.Reflection;
namespace DesignProgram.FactoryMethod;

public class FactoryProvider
{
    public static ICarFactory Instance(string className)
    {
        ICarFactory carFactory = (ICarFactory)Assembly.Load("DesignProgram").CreateInstance($"DesignProgram.FactoryMethod.{className}");
        return carFactory;
    }
}
