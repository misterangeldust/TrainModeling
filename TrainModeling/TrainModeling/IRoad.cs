namespace TrainModeling
{
	public interface IRoad
	{
		Coordinate GetCoordinateBegin();
		Coordinate GetCoordinate(int distance);
	}
}