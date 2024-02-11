using System;
namespace DaySeven.One{
     class Book : LibraryItem
     {
          public string Author { get; }
          public int Pages { get; }

          public Book(int id, string title, string author, int pages) : base(id, title)
          {
               Author = author;
               Pages = pages;
          }

          public override void DisplayInfo()
          {
               base.DisplayInfo();
               Console.WriteLine($"Author: {Author}, Pages: {Pages}");
          }
     }
}