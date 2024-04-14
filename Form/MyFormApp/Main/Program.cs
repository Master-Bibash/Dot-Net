using System;
using System.Windows.Forms;

namespace MyFormApp
{
     public static class Program
     {
          [STAThread]
          static void Main()
          {
               Console.WriteLine("asdasd");

               Application.EnableVisualStyles();
               Application.SetCompatibleTextRenderingDefault(false);
               Application.Run(new Form1());
          }
     }

     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          private void InitializeComponent()
          {
               // Initialization code here
          }
     }
}
