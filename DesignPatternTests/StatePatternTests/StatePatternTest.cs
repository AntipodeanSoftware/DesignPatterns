using DesignPatterns.StatePattern;
using NUnit.Framework;
using System;

namespace DesignPatternTests
{
	[TestFixture ()]
	public class StatePatternTest
	{
		string taskName = "Make all the codes";

		[Test ()]
		public void IntialStateTest ()
		{
			Task task = new Task ();
			task.Name = taskName;

			Assert.AreEqual ("DesignPatterns.StatePattern.ToDoState", task.CurrentState.ToString());
		}

		[Test ()]
		public void SetInProgressThroughToDoneTest ()
		{
			Task task = new Task ();
			task.Name = taskName;

			task.SetInProgress ();
			Assert.AreEqual ("DesignPatterns.StatePattern.InProgressState", task.CurrentState.ToString());

			task.SetDone ();
			Assert.AreEqual ("DesignPatterns.StatePattern.DoneState", task.CurrentState.ToString());
		}

		[Test ()]
		public void SetToDoStateToDoneStateTest ()
		{
			Task task = new Task ();
			task.Name = taskName;

			task.SetDone ();
			Assert.AreEqual ("DesignPatterns.StatePattern.ToDoState", task.CurrentState.ToString());
		}

		[Test ()]
		public void SetDoneStateToToDoStateTest ()
		{
			Task task = new Task ();
			task.Name = taskName;

			task.SetInProgress ();
			task.SetDone ();

			task.SetToDo ();
			Assert.AreEqual ("DesignPatterns.StatePattern.DoneState", task.CurrentState.ToString());
		}


	}
}