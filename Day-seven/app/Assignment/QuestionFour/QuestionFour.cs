namespace DaySeven.Four
{
     class EnumMain
     {
          static void Main(String[] args)
          {

               DayOfWeek currentLight = DayOfWeek.Wednesday;


               int ttoday = (int)DaysOfWeek.Thrusday;// type casting we use (int)

               Console.WriteLine($"Current traffic light : {ttoday}");
               Console.WriteLine($"currentlight is " + ((int)currentLight));


          }
          public enum DaysOfWeek
          {
               Monday,
               Tuesday,
               Wednesday,
               Thrusday,
               Friday,
               Saturday,
               Sunday
          }



     }


}