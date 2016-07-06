using System;

namespace DesignPatterns.StatePattern
{
	public abstract class ScrumBoardState
	{
		public Task task;

		public ScrumBoardState(Task task)
		{
			this.task = task;
		}

		public abstract void SetToDo();
		public abstract void SetInProgress();
		public abstract void SetDone();

	}
}


