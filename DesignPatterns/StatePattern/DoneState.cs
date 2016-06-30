using System;

namespace DesignPatterns.StatePattern
{
	public class DoneState : ScrumBoardState
	{
		public DoneState(Task task, MessageProvider messsageProvider) : base(task, messsageProvider){}

		public override void SetToDo()
		{
			//TODO This seems wrong. I want to set a string in this class, that when changed is picked up and written to the output
			base._messageProvider.PublishMessage((String.Format("{0} Cannot go from Done to To Do", base._task.Name)));
		}

		public override void SetInProgress()
		{
			base._messageProvider.PublishMessage((String.Format("{0} is In Progress",base._task.Name)));
			_task.SetState(_task.GetInProgressState ());
		}

		public override void SetDone()
		{
			base._messageProvider.PublishMessage((String.Format("{0} is already Done", base._task.Name)));
		}
	}
}

