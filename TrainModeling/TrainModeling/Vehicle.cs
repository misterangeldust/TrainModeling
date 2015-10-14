namespace TrainModeling
{
	public class Vehicle : IVehicle
	{
		private IMovingStrategy _movingStrategy;

		public IMovingStrategy MovingStrategy
		{
			protected get { return _movingStrategy; }
			set { _movingStrategy = value; }
		}


		public Position Position { get; set; }

		public bool StartMoving()
		{
			if (_movingStrategy == null) return false;
			return _movingStrategy.Start();
		}

		public bool StopMoving()
		{
			if (_movingStrategy == null) return false;
			return _movingStrategy.Stop();
		}
	}
}