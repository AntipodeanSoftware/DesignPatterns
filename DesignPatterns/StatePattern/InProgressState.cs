using System;

namespace DesignPatterns.StatePattern
{
	public class InProgressState : ScrumBoardState
	{
		public InProgressState(Task task) : base(task){}

		public override void SetToDo()
		{
			Console.WriteLine(String.Format("{0} is To Do", base._task.Name));
			_task.SetState(_task.GetToDoState());
		}
		public override void SetInProgress()
		{
			Console.WriteLine(String.Format("{0} is already In Progress",base._task.Name));
		}
		public override void SetDone()
		{
			Console.WriteLine(String.Format("{0} is Done", base._task.Name));
			_task.SetState(_task.GetDoneState());
		}

	}
}

