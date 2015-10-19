using System;

namespace TrainModeling
{
	public class SimpleTrainMovingStrategy :IMovingStrategy
	{
		private IVehicle _vehicle;
		private bool _isAction = false;

		public SimpleTrainMovingStrategy(IVehicle vehicle)
		{
			_vehicle = vehicle;
		}

		public bool Start()
		{

			_isAction = true;
			while (_isAction)
			{
				_vehicle.Position.ValueCoordinate.X += 1;
				Console.WriteLine("Train is started. Position ["+_vehicle.Position+"]");
			}
			return true;
		}

		public bool Stop()
		{
			_isAction = false;
			Console.WriteLine("Train is stoped.");
			return true;
		}
	}
}