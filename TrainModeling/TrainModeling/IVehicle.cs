namespace TrainModeling
{
	public interface IVehicle
	{
		Position Position { get; set; }
		bool StartMoving();
		bool StopMoving();
	}
}