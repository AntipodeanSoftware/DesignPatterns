using System;

public class MessageObserver : IObserver<String>
{
	private IDisposable unsubscriber;

	public virtual void Subscribe(IObservable<string> provider)
	{
		unsubscriber = provider.Subscribe(this);
	}

	public virtual void Unsubscribe()
	{
		unsubscriber.Dispose();
	}

	public void OnNext (string value)
	{
		Console.WriteLine (value);
	}

	public void OnError (Exception error)
	{
		//throw new NotImplementedException ();
	}

	public void OnCompleted ()
	{
		Console.WriteLine ("No Further Messges");
	}
}