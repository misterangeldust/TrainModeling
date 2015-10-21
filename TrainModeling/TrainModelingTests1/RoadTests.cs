using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrainModeling;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainModeling.Tests
{
	[TestClass()]
	public class RoadTests
	{
		[TestMethod()]
		public void GetPointBeginTest()
		{
			Point[] p = {new Point(3, 3), new Point(5, 3), new Point(5, 5)};
            Road r = new Road(p);
			Assert.AreEqual(p[0], r.GetPointBegin());
		}

		[TestMethod()]
		public void GetPointEndTest()
		{
			Point[] p = {new Point(3, 3), new Point(5, 3), new Point(5, 5)};
            Road r = new Road(p);
			Assert.AreEqual(p[2], r.GetPointEnd());
		}

		[TestMethod()]
		public void GetCoordinateTest()
		{
			Assert.Fail();
		}

		[TestMethod()]
		public void ToStringTest()
		{
			Road r=new Road(new Point[]{new Point(3,3),new Point(5,3), new Point(5,5) });
			Console.WriteLine(r.ToString());
		}
	}
}