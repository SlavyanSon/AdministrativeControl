using AdministrativeControlLogic;

namespace AdministrativeControlConsole
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var timeController = new TimeController();
			var thr = new Thread(() => timeController.Runner());
			thr.Start();

			while (true)
			{
				var isUserIdle = timeController.IsUserIdle;
				var ticks = IdleTimeFinder.GetIdleTime();
				var userActiveSeconds = timeController.UserActiveSeconds;
				Console.WriteLine($"{isUserIdle}:{ticks}:{userActiveSeconds}");
				Thread.Sleep(1000);
			}
		}
	}
}