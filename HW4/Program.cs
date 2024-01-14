namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.salary = 200;
            Employee employee2 = new Employee();
            employee2.salary = 400;

            Command.Change(employee1, 50);
            Console.WriteLine(employee1.salary);

            Command.Change(employee2, 50f);
            Console.WriteLine(employee2.salary);

            Console.WriteLine(Command.Change(employee1._value, employee2._value));
            Console.WriteLine(Command.Change(employee1,300, false));
            Console.WriteLine(Command.Change(employee1,employee2));


        }
    }
}

public abstract class Value
{
    public int _value;
}

public class Employee : Value
{
    public int salary { get { return _value; } set { _value = value; } }
}

public static class Command
{
    public static void Change(Value v, int x)
    {
        v._value += x;
    }
    public static void Change(Value v, float x)
    {
        v._value -= (int)x;
    }
    public static bool Change(int v_1, int v_2)
    {
        return v_1 == v_2 ? true : false;
    }
    public static bool Change(Value v, int  salary, bool type)
    {
        if(type == true)
        {
            return v._value > salary ? true : false;
        }
        else
        {
            return v._value < salary ? true : false;
        }
    }
    public static bool Change(Value v_1, Value v_2)
    {
        return v_1 == v_2 ? true : false;
    }
}