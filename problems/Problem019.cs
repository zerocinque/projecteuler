public class Problem019
{
    private static int[] _30DaysMonths = { 4, 6, 9, 11 };
    private static int[] _31DaysMonths = { 1, 3, 5, 7, 8, 10, 12 };

    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public Problem019()
    {
        Day = 1;
        Month = 1;
        Year = 1900;
    }

    public string Run()
    {
        int sundays = 0;

        for (int i = 1; true; i++)
        {
            incrementDate(i == 1);

            if (Year >= 2001) break;

            if (Year > 1900 && Day == 1 && (i - 1) % 7 == 6)
                sundays++;
        }

        return sundays.ToString();
    }

    private void incrementDate(bool firstLoop)
    {
        Day = firstLoop ? Day : ++Day;
        if (Day > getDayPerMonth(Month, Year))
        {
            Day = 1;
            Month++;

            if (Month > 12)
            {
                Month = 1;
                Year++;
            }
        }
    }

    private int getDayPerMonth(int month, int year)
    {
        if (_30DaysMonths.Contains(month)) return 30;
        if (_31DaysMonths.Contains(month)) return 31;
        if (month == 2 && isLeapYear(year)) return 29;
        if (month == 2 && !isLeapYear(year)) return 28;
        else throw new ArgumentOutOfRangeException();
    }

    private bool isLeapYear(int year)
    {
        return year % 100 == 0 ? year % 400 == 0 : year % 4 == 0;
    }

}