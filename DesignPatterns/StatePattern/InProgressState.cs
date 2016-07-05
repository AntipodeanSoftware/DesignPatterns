using System;

namespace DesignPatterns.StatePattern
{
	public class InProgressState : ScrumBoardState
	{
		public InProgressState(Task task) : base(task){}

		public override void SetToDo()
		{
			Message =  String.Format("{0} is To Do", task.Name);
			task.SetState(task.GetToDoState());
		}

		public override void SetInProgress()
		{
			Message = String.Format("{0} is already In Progress", task.Name);
		}

		public override void SetDone()
		{
			Message = String.Format("{0} is Done", task.Name);
			task.SetState(task.GetDoneState());
		}

	}
}

