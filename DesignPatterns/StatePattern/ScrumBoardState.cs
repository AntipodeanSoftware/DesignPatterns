
using System;

namespace DesignPatterns.StatePattern
{
	public abstract class ScrumBoardState
	{	
		public Task _task;

		public ScrumBoardState(Task task)
		{
			_task = task;
		}

		public abstract void SetToDo();
		public abstract void SetInprogress();
		public abstract void SetDone();
	}
}


