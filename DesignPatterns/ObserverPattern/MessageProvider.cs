using System;
using System.Collections.Generic;

namespace DesignPatterns
{
	public class MessageProvider : IObservable<string>
	{
		private List<IObserver<string>> observers = new List<IObserver<string>> ();

		public IDisposable Subscribe (IObserver<string> observer)
		{
			if (! observers.Contains(observer)) 
				observers.Add(observer);
			
			return new Unsubscriber(observers, observer);
		}

		private class Unsubscriber : IDisposable
		{
			private List<IObserver<string>>_observers;
			private IObserver<string> _observer;

			public Unsubscriber(List<IObserver<string>> observers, IObserver<string> observer)
			{
				this._observers = observers;
				this._observer = observer;
			}

			public void Dispose()
			{
				if (_observer != null && _observers.Contains(_observer))
					_observers.Remove(_observer);
			}
		}

		public void PublishMessage(string message)
		{
			foreach (var observer in observers) {
				if (string.IsNullOrEmpty(message))
					observer.OnError(new Exception());
				else
					observer.OnNext(message);
			}
		}

		public void EndTransmission()
		{
			foreach (var observer in observers.ToArray())
				if (observers.Contains(observer))
					observer.OnCompleted();

			observers.Clear();
		}
	}
}

