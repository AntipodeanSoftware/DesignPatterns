using System;

namespace DesignPatterns.StatePattern
{
	public class ScrumBoardClient
	{
		public ScrumBoardClient ()
		{
		}

		public static void RunScrumBoardClient()
		{
			Console.WriteLine ("Example of the State Pattern");
			Console.WriteLine ("Welcome to the Scrum Board!");

			Task task = new Task ();
			task.Name = "Build DB";
			task.SetInProgress ();

			bool runLoop = true;

			while (runLoop) {
				var input = Console.ReadKey ();

				switch (input.KeyChar.ToString ()) {
				case "T":
					task.SetToDo ();
					break;
				case "I":
					task.SetInProgress ();
					break;
				case "D":
					task.SetDone ();
					break;
				case "Q":
					runLoop = false;
					Console.WriteLine ("Goodbye");
					break;
				default:
					Console.WriteLine ("Enter T for To Do. I for Inprogress, D for Done. Q to quit");
					break;
				}
			}
		}
	}
}

