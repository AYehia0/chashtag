// interfaces can't have a method body, only signatures
// interfaces can have methods, properties, events, and indexers
// interfaces can't be instantiated
// one class can extend multiple interfaces

interface IBankAccount
{
    void PayIn(decimal amount);
    bool Withdraw(decimal amount);
}

class BankAccount : IBankAccount
{
    private decimal balance = 0;

    public void PayIn(decimal amount)
    {
        balance += amount;
    }

    // Explicitly implement interface method with private access
    bool IBankAccount.Withdraw(decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }
}

abstract class Animal
{
    public string? name;
    public int? age;
    public abstract void MakeSound();
    public abstract void Eat();
}

class Dog : Animal
{
    public Dog(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }

    public override void Eat()
    {
        Console.WriteLine("Eating dog food...");
    }
}
