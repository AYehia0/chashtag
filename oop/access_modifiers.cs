/*
Access specifiers, or access modifiers, are some reserved keywords that determine the
accessibility of a class, method, property, or other entity.
The object-oriented principle of encapsulation is achieved by using these access specifiers in C#. In total, there are five
access specifiers.

1. Public : The public access specifier allows a class to be accessible by any other class.
it can be accessed by other classes or programs in the same assembly, other assemblies, and even other programs that are
installed in the operating system that the program is running in.

2. Private : The private access specifier allows a class to be accessible only by that class only.
For example, if you create a private field, that field
can't be accessed outside the class. That private field can only be used internally in that class.

3. Internal : The internal access specifier allows a class to be accessible only by classes in the same assembly.

4. Protected : Protected members are accessible by the class itself, as well as the child classes that inherit
the class. Other than that, no other class can access a protected member. The protected
access modifier is very useful when inheritance takes place.The rotectepecifier al class to

5. Protected internal : The protected internal access specifier allows the class to be accessible by classes in the same assembly as well as by any class that inherits it, regardless of the assembly
*/


namespace AnimalProject
{
    // it's by default internal
    internal class AnimalDog
    {
        string GetName()
        {
            return "doggy";
        }
    }

    class AnimalCat : Animal
    {
        protected string GetName()
        {
            return "kitty";
        }

        public override void Eat()
        {
            Console.WriteLine("Eating");
        }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
