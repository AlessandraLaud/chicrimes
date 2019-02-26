//
// One crime
//

namespace crimes.Models
{
  public class Crime
	{
		// data members with auto-generated getters and setters:
		public string IUCR { get; set; }
        public string PrimaryDesc { get; set; }
        public string SecondaryDesc { get; set; }
        public int NumTimes { get; set; }
        public float CrimePercentage { get; set; }
        public float ArrestPercentage { get; set; }
        public string AreaName { get; set; }
        public int AreaNum { get; set; }
        public int Year { get; set; }
	
		// default constructor:
		public Crime()
		{ }
		
		// constructor:
		public Crime(string iucr, string primary, string secondary, int numTimes, float crimePercentage, 
                     float arrestPercentage, int areaNum, string areaName, int year)
		{
			IUCR = iucr;
			PrimaryDesc = primary;
			SecondaryDesc = secondary;
			NumTimes = numTimes;
			CrimePercentage = crimePercentage;
            ArrestPercentage = arrestPercentage;
            AreaName = areaName;
            AreaNum = areaNum;
            Year = year;
		}
	}//class
}//namespace