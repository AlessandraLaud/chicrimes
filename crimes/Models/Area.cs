//
// One Area
//

namespace crimes.Models
{
  public class Area
	{
		// data members with auto-generated getters and setters:
        public string AreaName { get; set; }
        public int AreaNum { get; set; }
        public int NumCrimes { get; set; }
        public float CrimePercentage { get; set; }
		
        // default constructor:
		public Area()
		{ }
		
		// constructor:
		public Area(string area, int num, int numCrimes, float percentage)
		{
			AreaName = area;
            AreaNum = num;
            NumCrimes = numCrimes;
            CrimePercentage = percentage;
		}
		
	}//class
}//namespace