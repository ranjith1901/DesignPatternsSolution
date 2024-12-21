using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    // The Component abstract class defines an interface for objects that can have responsibilities added to them dynamically.
    public abstract class Component
    {
        public abstract void Operation();
    }

    // The ConcreteComponent class is a basic implementation of the Component interface.
    public class ConcreteComponent : Component
    {
        // The Operation method performs the basic operation.
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent Operation Added");
        }
    }

    // The Decorator abstract class inherits from Component and contains a reference to a Component object.
    public abstract class Decorator : Component
    {
        protected Component _component;

        // The SetComponent method sets the Component object to be decorated.
        public void SetComponent(Component component)
        {
            _component = component;
        }

        // The Operation method calls the Operation method of the Component object if it exists.
        public override void Operation()
        {
            if (_component != null)
            {
                _component.Operation();
            }
        }
    }

    // The ConcreteDecorator class inherits from Decorator and adds additional behavior to the Component object.
    public class ConcreteDecorator : Decorator
    {
        // The Operation method calls the base Operation method and then adds additional behavior.
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecorator Operation Added");
        }
    }

    public class DecoratorExample
    {
        public static void Run()
        {
            // Create a ConcreteComponent object.
            ConcreteComponent component = new ConcreteComponent();

            // Create a ConcreteDecorator object.
            ConcreteDecorator decorator = new ConcreteDecorator();

            // Set the ConcreteComponent object to be decorated by the ConcreteDecorator.
            decorator.SetComponent(component);

            // Call the Operation method on the ConcreteDecorator, which adds additional behavior to the ConcreteComponent.
            decorator.Operation();
        }
    }
}