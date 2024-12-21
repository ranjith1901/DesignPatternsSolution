using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    // The IObserver interface declares the Update method, which is called to notify the observer of changes.
    public interface IObserver
    {
        void Update(string message);
    }

    // The ConcreteObserver class implements the IObserver interface and defines the Update method.
    public class EmailSubscriber : IObserver
    {
        private string _email;

        public EmailSubscriber(string email)
        {
            _email = email;
        }

        // The Update method is called when the subject's state changes.
        public void Update(string message)
        {
            Console.WriteLine($"Email sent to {_email}: {message}");
        }
    }

    // The Subject class maintains a list of observers and notifies them of any state changes.
    public class Newsletter
    {
        private List<IObserver> _subscribers = new List<IObserver>();
        private string _latestIssue;

        // The Attach method adds an observer to the list.
        public void Subscribe(IObserver subscriber)
        {
            _subscribers.Add(subscriber);
        }

        // The Notify method calls the Update method on each observer.
        public void NotifySubscribers()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(_latestIssue);
            }
        }

        // The Publish method sets the latest issue and notifies subscribers.
        public void Publish(string issue)
        {
            _latestIssue = issue;
            NotifySubscribers();
        }
    }

    public class ObserverExample
    {
        public static void Run()
        {
            // Create a newsletter (subject)
            Newsletter newsletter = new Newsletter();

            // Create subscribers (observers)
            IObserver subscriber1 = new EmailSubscriber("subscriber1@example.com");
            IObserver subscriber2 = new EmailSubscriber("subscriber2@example.com");

            // Subscribe to the newsletter
            newsletter.Subscribe(subscriber1);
            newsletter.Subscribe(subscriber2);

            // Publish a new issue and notify subscribers
            newsletter.Publish("New issue of the newsletter is out!");
        }
    }

}