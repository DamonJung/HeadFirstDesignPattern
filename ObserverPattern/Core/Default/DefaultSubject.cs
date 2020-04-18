using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Core.Default
{
    public class DefaultSubject : ISubject
    {
        List<IObserver> observers = new List<IObserver>();
        // First, I think a subject should have an inmemory list for subscribers.
        // When publish, iterating the list and send each one of them the weather data.
        // When somebody unsubscribes, then remove him from the inmemory list.

        // This is pretty much what a subject does.
        // Publish is problemetic though...
        // Does it send via TCP ? or other network methods?
        // Or just registering event handler like INotifyProperyChanged interface ... ?

        public void Publish(double temperature, double humidity, double barometricPressure)
        {
            observers.ForEach(x => x.UpdateNotified(temperature, humidity, barometricPressure));
        }

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
