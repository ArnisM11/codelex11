using System;
using System.Collections;
using System.Globalization;

public class Date
{
	public string WeekdayInDutch(int year,int month,int day)
	{
		DateTime result = new DateTime(year,month,day);
		CultureInfo nlCulture = new CultureInfo("nl-NL");
		return (nlCulture.DateTimeFormat.GetDayName(result.DayOfWeek)).ToString();
    }
}
