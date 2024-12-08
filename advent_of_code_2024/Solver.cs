namespace advent_of_code_2024;

public class Solver
{
    public static void Solve(Type type, string file, string name)
    {
        if (!InheritsFromGenericAbstractClass(type, typeof(ASolution<>)))
        {
            throw new InvalidOperationException($"{type.Name} does not inherit from MyAbstractClass.");
        }

        var instance = Activator.CreateInstance(type, []) as dynamic;

        if(instance == null)
        {
            throw new InvalidOperationException($"Could not create an instance of {type.Name}.");
        }

        instance.InputFile = file;

        var result = instance.Solve();
        Console.WriteLine($"{name} solution: {result}");

    }
    private static bool InheritsFromGenericAbstractClass(Type? type, Type genericAbstractClass)
    {
        while (type != null && type != typeof(object))
        {
            var baseType = type.BaseType;

            if (baseType != null && baseType.IsGenericType &&
                baseType.GetGenericTypeDefinition() == genericAbstractClass)
            {
                return true;
            }

            type = baseType;
        }

        return false;
    }
}