using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ParkManagementSystem
{
	// declearing class need
	class Need
	{
		// declearing path to store data
		public static string samePath = @"C:\Users\Asus\source\repos\ParkManagementSystem\";

		// declearing paratemerized method groupTypes
		public static int getGroupTypes(string GroupType)
		{
			// initalzing local varianble returnVar
			int returnVar = 0;
			// switching griupType
			switch (GroupType)
			{
				case "Child":
					returnVar = 0;
					break;
				case "Adult":
					returnVar = 1;
					break;
				case "Group of 5":
					returnVar = 2;
					break;
				case "Group of 10":
					returnVar = 3;
					break;
				case "Group of above 10":
					returnVar = 4;
					break;
			}
			// returing returnVar Value
			return returnVar;
		}

		// declearing paratemerized method getColumns
		public static int getColumns(int timePeriod)
		{
			// initalzing local varianble returnVar
			int returnVar = 0;
			// if time period is equal or smaller than 4 hr
			if (timePeriod <= 4)
			{
				// switching timeperiod
				switch (timePeriod)
				{
					case 1:
						returnVar = 0;
						break;
					case 2:
						returnVar = 1;
						break;
					case 3:
						returnVar = 2;
						break;
					case 4:
						returnVar = 3;
						break;
				}
			}
			// elseif timeperiod is greater than 4 hr
			else if (timePeriod > 4)
			{
				returnVar = 4;
			}
			// returing returnVar value
			return returnVar;
		}

		// declearing parameterized method getGrouptypes
		public static string getGrouptype(int totalVisitor)
		{
			// initalizing local groupType variable 
			string groupType = "";
			// if total no of visitor is smaller then 5
			if (totalVisitor < 5)
			{
				// groupType equals Below 5
				groupType = "Below 5";
			}
			// if total no of visitor is equals 5
			if (totalVisitor == 5)
			{
				// groupType equals Group of 5
				groupType = "Group of 5";
			}
			// if total no of visitor is smaller 0r equals 10
			if (totalVisitor > 5 && totalVisitor <= 10)
			{
				// groupType equals Group of 10
				groupType = "Group of 10";
			}
			// if total no of visitor is greather then 10
			if (totalVisitor > 10)
			{
				// groupType equals Group of above 10
				groupType = "Group of above 10";
			}
			// returing group types
			return groupType;
		}
		// declearing getBussinessHour method
		public static (double, double) getBussinessHour()
		{
			// getting current time
			DateTime currentTime = DateTime.Now;
			// setting start time 10 am
			DateTime startTime = DateTime.Parse("10:00:00 AM");
			// setting endTime as 6 pm
			DateTime endTime = DateTime.Parse("06:00:00 PM");
			// comparing current time with start time
			double startTimeCompare = DateTime.Compare(currentTime, startTime);
			// comparing current time with endTime
			double endTimeCompare = DateTime.Compare(currentTime, endTime);
			// returing startTimeCompare and endTimeCompare
			return (startTimeCompare, endTimeCompare);
		}
	}

	// creating TicketPrice Class
	class TicketPrice
	{
		// declearing getter setter for respective time variables
		public int hour1 { get; set; }
		public int hour2 { get; set; }
		public int hour3 { get; set; }
		public int hour4 { get; set; }
		public int wholeDay { get; set; }

		// declearing parameterized getTicketPrice method
		public static List<TicketPrice> getTicketPrice(string filename)
		{
			// initalizing new ticketPrice list variable
			List<TicketPrice> ticketPrice = new List<TicketPrice>();
			// declearing file path
			string filePath = Need.samePath + filename + ".csv";
			// reading the files
			string[] lines = File.ReadAllLines(filePath);
			// looping line
			foreach (string line in lines)
			{
				// splitting line and storing in str list
				string[] str = line.Split(',');
				// checking length of str list
				if (str.Length != 5) continue;
				TicketPrice s = new TicketPrice();
				s.hour1 = int.Parse(str[0]); s.hour2 = int.Parse(str[1]); s.hour3 = int.Parse(str[2]); s.hour4 = int.Parse(str[3]);
				s.wholeDay = int.Parse(str[4]);
				// adding data in individuals(s)
				ticketPrice.Add(s);
			}
			// returing ticketPrice
			return ticketPrice;
		}
		public static int getTicketPrice1(string visitDay, string grp, int timePeriod) {
			List<TicketPrice> ticketPrice = getTicketPrice(visitDay);
			int[][] allTicketPrice = new int[5][];
			// getting groupTypes from getGroupTypes method and storing it on groupType variable
			int GroupType = Need.getGroupTypes(grp);
			// getting timePeriod from getColumns method and storing it on column variable
			int column = Need.getColumns(timePeriod);
			// initalizing variable totalVisitor
			int totalVisitor = 0;
			// looping ticketPrice
			foreach (TicketPrice t in ticketPrice) {
				// storing ticket price in respective rows
				int[] single = new int[5];
				single[0] = t.hour1;
				single[1] = t.hour2;
				single[2] = t.hour3;
				single[3] = t.hour4;
				single[4] = t.wholeDay;
				allTicketPrice[totalVisitor] = single;
				// increasing totalVisitor by 1
				totalVisitor++;
			}
			// storing allTicketPrice in returnTicketPrice variable
			int returnTicketPrice = allTicketPrice[GroupType][column];
			// returing returnTicketPrice
			return returnTicketPrice;
		}
	}

	// serializing visitors class
	[Serializable]
	class Visitors
	{
		// getter setter methof of respectives variables
		public int id { get; set; }
		public string groupType { get; set; }
		public int adultAgeGroup { get; set; }
		public int childAgeGroup { get; set; }
		public string visitorEntryTime { get; set; }
		public string visitorExitTime { get; set; }
		public string dateOfVisit { get; set; }
		public int ticketPrice { get; set; }
		public string visitDay { get; set; }
		public int estimated { get; set; }


		// declearing parameterized getVisitors method
		public static List<Visitors> getVisitors()
		{
			// declearing path to store visitor data
			string filePath = Need.samePath + "visitors.csv";
			List<Visitors> v = new List<Visitors>();
			// reading files
			string[] lines = File.ReadAllLines(filePath);
			// looping line in lines
			foreach (string line in lines)
			{
				// splitting lines and storing in str list
				string[] str = line.Split(',');
				// checking the str length
				if (str.Length != 9) continue;
				// creating new visitors
				Visitors s = new Visitors();
				// updating visitors data
				s.id = int.Parse(str[0]); s.groupType = str[1]; s.adultAgeGroup = int.Parse(str[2]); s.childAgeGroup = int.Parse(str[3]); s.visitorEntryTime = str[4]; s.visitorExitTime = str[5]; s.dateOfVisit = str[6]; s.ticketPrice = int.Parse(str[7]); s.visitDay= str[8];
				// adding data to visitors
				v.Add(s);

			}
			// returing visitor as v
			return v;
		}

		// declearing parameterized getVisitorPerDay method
		public static List<Visitors> getVisitorPerDay(string dateOfVisit)
		{
			// getting visitor data and storing to visitor list
			List<Visitors> visitor = getVisitors();
			// creating new returnVar list
			List<Visitors> returnVar = new List<Visitors>();
			// looping visitors
			foreach (Visitors v in visitor)
			{
				// if visitor dateOfVisit equals dayeOfVisit
				if (v.dateOfVisit == dateOfVisit)
				{
					// add visitors data to returnVar
					returnVar.Add(v);
				}
			}
			// returing returnVar
			return returnVar;
		}

		// declearing parameterized getCombineCount method
		public static (int, int, int) getCombinedCount(string dateOfVisit) {
			// initalizing local group5 variable
			int group5 = 0;
			// initalizing local group10 variable
			int group10 = 0;
			// initalizing local groupAbove10 variable
			int groupAbove15 = 0;
			foreach (Visitors v in Visitors.getVisitorPerDay(dateOfVisit)) {
				// if visitor date of visit matched date of visit
				if (v.dateOfVisit==dateOfVisit) {
					// group type equals group of 5
					if (v.groupType == "Group of 5")
					{
						// increas group5 by 1
						group5 += 1;

					}
					// elseif group type equals Group of 10
					else if (v.groupType == "Group of 10")
					{
						// increas group10 by 1
						group10 += 1;

					}
					// elseif group type equals group of above 10
					else if (v.groupType == "Group of above 10")
					{
						// increas groupAbove15 by 1
						groupAbove15 += 1;

					}
				}
			}
			// return value of group5,group10 and groupAbove15
			return (group5,group10,groupAbove15);
		}

	}
	
	// creating class individual
	class Individual
	{
		// getter setter methods of each variables
		public int id { get; set; }
		public string ageType { get; set; }
		public string visitorEntryTime { get; set; }
		public string visitorExitTime { get; set; }
		public string dateOfVisit { get; set; }
		public int ticketPrice { get; set; }
		public string visitDay { get; set; }

		// declearing paratemarized method getIndividual
		public static List<Individual> getIndividual()
		{
			// declearing path to store individuals data
			string filePath = Need.samePath + "individual.csv";
			List<Individual> v = new List<Individual>();
			// reading files
			string[] lines = File.ReadAllLines(filePath);
			// looping line in lines
			foreach (string line in lines)
			{
				// splitting lines and storing in str list
				string[] str = line.Split(',');
				// checking the str length
				if (str.Length != 7) continue;
				// creating new individuals
				Individual s = new Individual();
				// updating individuals data
				s.id = int.Parse(str[0]); s.ageType = str[1]; s.visitorEntryTime = str[2]; s.visitorExitTime = str[3]; s.dateOfVisit = str[4]; s.ticketPrice = int.Parse(str[5]); s.visitDay=(str[6]);
				// adding data to individuals
				v.Add(s);
			}
			return v;
		}
		public static List<Individual> getVisitorPerDay(string dateOfVisit)
		{
			// getting individual data and storing it to visitor
			List<Individual> visitor = getIndividual();
			// creating new returnVar list
			List<Individual> returnVar = new List<Individual>();
			// looping visitors
			foreach (Individual v in visitor)
			{
				// if visitor date of visit matched date of visit
				if (v.dateOfVisit == dateOfVisit)
				{
					// add visitors to returnVar list
					returnVar.Add(v);
				}
			}
			// returnm returnVar list
			return returnVar;
		}

		// declearing parameterized method getACCount
		public static (int, int) getACCount(string dateOfVisit) {
			// initalizing local adultAgeGroup variable
			int adultAgeGroup = 0;
			// initalizing local childAgeGroup variable
			int childAgeGroup = 0;
			foreach (Individual ind in Individual.getVisitorPerDay(dateOfVisit)) {
				// if individual dateOfVisit matched dateIfVisit
				if (ind.dateOfVisit==dateOfVisit) {
					// if individual ageType equals Child
					if (ind.ageType=="Child") {
						// increas childAgeGroup by 1
						childAgeGroup += 1;
					} else {
						// else increase adultAgeGroup by 1
						adultAgeGroup += 1;
					}
				}
			}
			// return value of adultAgeGroup and ChildAge Group
			return (adultAgeGroup, childAgeGroup);
		}
		// declearing parameterized method getDataPerweek
		public static List<(string, int, int)> getDataPerWeek(DateTime dateOfVisit)
		{
			int sunday = 0;
			int monday = 0;
			int tuesday = 0;
			int wednesday = 0;
			int thursday = 0;
			int friday = 0;
			int saturday = 0;
			int sundayFee = 0;
			int mondayFee = 0;
			int tuesdayFee = 0;
			int wednesdayFee = 0;
			int thursdayFee = 0;
			int fridayFee = 0;
			int saturdayFee = 0;
			foreach (Visitors visit in Visitors.getVisitors())
			{
				// storing visit date of visitors in date variable
				DateTime Date = DateTime.Parse(visit.dateOfVisit);
				// subtracting dateofVisit
				double a = Math.Ceiling(Date.Subtract(dateOfVisit).TotalDays);
				double c = DateTime.Compare(Date, dateOfVisit);
				int b = (int)Math.Ceiling(a);
				if (c <= 0 && b > -6)
				{
					// switch expression
					switch (dateOfVisit.DayOfWeek.ToString())
					{
						// case statements
						case "Sunday":
							sunday += visit.adultAgeGroup + visit.childAgeGroup;
							sundayFee += visit.ticketPrice;
							break;
						case "Monday":
							monday += visit.adultAgeGroup + visit.childAgeGroup;
							mondayFee += visit.ticketPrice;
							break;
						case "Tuesday":
							tuesday += visit.adultAgeGroup + visit.childAgeGroup;
							tuesdayFee += visit.ticketPrice;
							break;
						case "Wednesday":
							wednesday += visit.adultAgeGroup + visit.childAgeGroup;
							mondayFee += visit.ticketPrice;
							break;
						case "Thursday":
							thursday += visit.adultAgeGroup + visit.childAgeGroup;
							thursdayFee += visit.ticketPrice;
							break;
						case "Friday":
							friday += visit.adultAgeGroup + visit.childAgeGroup;
							fridayFee += visit.ticketPrice;
							break;
						case "Saturday":
							saturday += visit.adultAgeGroup + visit.childAgeGroup;
							saturdayFee += visit.ticketPrice;
							break;
					}
				}
			}
			// looping individuals
			foreach (Individual visit in Individual.getIndividual())
			{
				// storing visit date of visitors in date variable
				DateTime Date = DateTime.Parse(visit.dateOfVisit);
				// subtracting dateofVisit
				double a = Math.Ceiling(Date.Subtract(dateOfVisit).TotalDays);
				double c = DateTime.Compare(Date, dateOfVisit);
				int b = (int)Math.Ceiling(a);
				if (c <= 0 && b > -6)
				{
					// switch expression
					switch (dateOfVisit.DayOfWeek.ToString())
					{
						// case statement
						case "Sunday":
							sunday +=1;
							sundayFee += visit.ticketPrice;
							break;
						case "Monday":
							monday +=1;
							mondayFee += visit.ticketPrice;
							break;
						case "Tuesday":
							tuesday +=1;
							tuesdayFee += visit.ticketPrice;
							break;
						case "Wednesday":
							wednesday +=1;
							mondayFee += visit.ticketPrice;
							break;
						case "Thursday":
							thursday +=1;
							thursdayFee += visit.ticketPrice;
							break;
						case "Friday":
							friday +=1;
							fridayFee += visit.ticketPrice;
							break;
						case "Saturday":
							saturday +=1;
							saturdayFee += visit.ticketPrice;
							break;
					}
				}
			}
			// storing data in list variable type2
			List<(string, int, int)> type2 = new List<(string, int, int)> { ("Sunday", sunday, sundayFee), ("Monday", monday, mondayFee), ("Tuesday", tuesday, tuesdayFee), ("Wednesday", wednesday, wednesdayFee), ("Thursday", thursday, thursdayFee), ("Friday", friday, fridayFee), ("Saturday", saturday, saturdayFee) };
			// returing type2
			return type2;
		}
	}
}
