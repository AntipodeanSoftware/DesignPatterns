using System;

namespace DesignPatterns.StatePattern
{
	public class DoneState : ScrumBoardState
	{
		public DoneState(Task task) : base(task){}

		public override void SetToDo()
		{
			Message = String.Format("{0} Cannot go from Done to To Do", task.Name);
		}

		public override void SetInProgress()
		{
			Message = String.Format("{0} is In Progress", task.Name);
			task.SetState(task.GetInProgressState ());
		}

		public override void SetDone()
		{
			Message = String.Format("{0} is already Done", task.Name);
		}
	}
}

