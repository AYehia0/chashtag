/*
Object collaboration is one of the most important concepts in object-oriented programming. If the objects don't collaborate with each other nothing can be achieved

Dependency, Association and Inheritance.

*/



/*
In the following code, we can see that the FoodRepository class has two methods. One
method is SaveFood and the other is GetFood.

The SaveFood method involves taking one Food object and saving it in the database.

After saving the food item in the database, it returns the newly created foodId back to the
FoodRepository.

The FoodRepository then passes the newly created FoodId to the UI
to inform the user that the food item creation was successful


The FoodRepository needs to use the Food object, this type of relationship is called dependency relationship.

*/
partial class Food
{
    public int? FoodId { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
}

partial class FoodRepository
{
    public int SaveFood(Food food)
    {
        int result = SaveFoodInDatabase(food);
        return result;
    }

    public Food GetFood(int foodId)
    {
        Food result = new Food();
        result = GetFoodFromDatabaseById(foodId);
        return result;
    }

    public int SaveFoodInDatabase(Food food)
    {
        // Save food in database
        return 0;
    }

    public Food GetFoodFromDatabaseById(int foodId)
    {
        // Get food from database
        return new Food();
    }
}

/*
Association is a relationship between two objects, in this type of relationship, one object knows another
object and is associated with it. This relationship is achieved by having one object as a
property of another object.

For example, a car has an engine.
If you think of any objects that you can relate to each other using the phrase has a, then that relationship is
an association relationship.


Association can be divlided into two types:
    1. Aggregation
    2. Composition

1. Aggregation
Now let's look at the example of our restaurant management software. If we analyze the
relationship between the Food and Chef objects, it is clear that no food can exist without a
chef. Someone has to cook, bake, and prepare the food, the food cannot do this itself.
Consequently, we can say that the food has a chef. This means that the Food object should
have a property named Chef

2. Composition
A composition relationship is a type of association relationship. This means that one object
will have another object as its property, but where it differs from aggregation is that, in
composition, the object that is used as a property can't exist independently; it must have the
help of another object in order to be functional.
*/

// the Chef exists independently without the Food object. This type of relationship is called Aggregation
partial class Chef
{
    public int? ChefId { get; set; }
    public string? Name { get; set; }
    public string? Speciality { get; set; }
}

partial class Food
{
    public Chef? Chef { get; set; }
}

// Composition
// OrderItem can't exist without the Order object. This type of relationship is called Composition
public class Order
{
    public int OrderId { get; set; }
    public List<OrderItem>? OrderItems { get; set; }
    public DateTime OrderTime { get; set; }
}

public class OrderItem
{
    public int OrderItemId { get; set; }
    public int OrderId { get; set; }
    public int FoodId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}

/*
Inheritance is a type of relationship between two objects where one object inherits the properties and methods of another object. The object that inherits the properties and methods is called the child object, and the object from which the properties and methods are inherited is called the parent object.(base)
*/

class Human
{
    public string? Name { get; set; }
}

partial class Chef : Human
{
    //...
}
