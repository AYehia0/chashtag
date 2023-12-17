/*
var seasonsOfYears = Color.Spring | Color.Summer;
var allSeasons = Color.All;
*/
[Flags]
public enum Color
{
    // seasons
    None = 0,
    Spring = 1,
    Summer = 2,
    Autumn = 4,
    Winter = 8,
    All = Spring | Summer | Autumn | Winter
}
