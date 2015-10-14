namespace TrainModeling
{
	public class SimpleTrainMovingStrategy :IMovingStrategy
	{
		
		public bool Start()
		{
			return true;
		}

		public bool Stop()
		{
			return false;
		}
	}
}