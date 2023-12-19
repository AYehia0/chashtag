// Define the EventArgs class for event data
/*
    var pub = new Publisher();
    var sub = new Subscriber();

    // The += operator is used to add the HandleEvent method to the list of methods that will be called when the MyEvent event is raised,
    // -= operator is used to remove the method from the list.
    pub.MyEvent += sub.HandleEvent;

    // trigger the event
    pub.RaiseEvent("Hello World!");
*/
public class MyEventArgs : EventArgs
{
    public string Message { get; set; }

    public MyEventArgs(string message)
    {
        Message = message;
    }
}

// Define the publisher class
public class Publisher
{
    // MyEventHandler as delegate type
    // delegate acts as a function pointer, so we have pointer to a function which takes two parameters and returns void
    public delegate void MyEventHandler(object sender, MyEventArgs e);

    // Define the event using the generic EventHandler<T> event handler
    public event MyEventHandler MyEvent = delegate { };

    // Method to trigger the event
    public void RaiseEvent(string message)
    {
        // Check if there are subscribers
        if (MyEvent != null)
        {
            // Create event arguments
            MyEventArgs eventArgs = new MyEventArgs(message);

            // Trigger the event
            MyEvent(this, eventArgs);
        }
    }
}

public class Subscriber
{
    // Event handler method
    public void HandleEvent(object sender, MyEventArgs e)
    {
        Console.WriteLine($"Subscriber received message: {e.Message}");
    }
}
