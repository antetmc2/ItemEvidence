using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEvidence.Model
{
    public abstract class Subject
    {
        List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver o)
        {
            _observers.Add(o);
        }

        public void Detach(IObserver o)
        {
            _observers.Remove(o);
        }

        public void Notify()
        {
            _observers.ForEach(x => x.UpdateView());
        }
    }
}
