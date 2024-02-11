using System;
namespace DaySeven.One{
     class LibraryItem
     {
          public int Id { get; }
          public string Title { get; }
          public bool IsCheckedOut { get; protected set; }

          public LibraryItem(int id, string title)
          {
               Id = id;
               Title = title;
               IsCheckedOut = false;
          }

          public virtual void DisplayInfo()
          {
               Console.WriteLine($"ID: {Id}, Title: {Title}, IsCheckedOut: {IsCheckedOut}");
          }

          public void CheckOut()
          {
               IsCheckedOut = true;
          }

          public void Return()
          {
               IsCheckedOut = false;
          }
     }
}