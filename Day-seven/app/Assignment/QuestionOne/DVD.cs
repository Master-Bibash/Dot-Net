using System;
namespace DaySeven.One
{
     class DVD : LibraryItem
     {
          public string Director { get; }
          public int Duration { get; }

          public DVD(int id, string title, string director, int duration) : base(id, title)
          {
               Director = director;
               Duration = duration;
          }

          public override void DisplayInfo()
          {
               base.DisplayInfo();
               Console.WriteLine($"Director: {Director}, Duration: {Duration} minutes");
          }
     }
}