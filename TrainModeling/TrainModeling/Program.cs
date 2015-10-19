using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace TrainModeling
{
	class Program
	{
		private static readonly ILog log = LogManager.GetLogger(typeof(Program));

		static void Main(string[] args)
		{
			// Set up a simple configuration that logs on the console.
			BasicConfigurator.Configure();
			Vehicle v=new Vehicle();
			Position pos = new Position {ValueCoordinate = new Coordinate {X = 0, Y = 0}};
			v.Position = pos;
			IMovingStrategy ms=new SimpleTrainMovingStrategy(v);
			v.MovingStrategy = ms;
			Task t=new Task(() => v.StartMoving());
			t.Start();

			Thread.Sleep(10000);
			v.StopMoving();
			Console.Read();
		}
	}
}
