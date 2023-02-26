using System;
using COMP123_Assign02_New.Models;
using COMP123_Assign02_New.Manager;

namespace COMP123_Assign02_New
{
    public class Program
    {
        static void Main(string[] args)
        {
            TweetManager.Initialize();
            TweetManager.ShowAll();

            TweetManager.ShowAll("Stressed");
        }
    }
}
