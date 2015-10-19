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
			Vehicle v=new SimpleTrain();
			Position pos = new Position {ValueCoordinate = new Coordinate (new []{0, 0})};
			v.Position = pos;
			IMovingStrategy ms=new SimpleTrainMovingStrategy(v);
			v.MovingStrategy = ms;
			v.StartMoving();
			Thread.Sleep(10000);
			v.StopMoving();
			Console.Read();
		}
	}
}
