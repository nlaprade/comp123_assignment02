using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP123_Assign02_New.Models;

namespace COMP123_Assign02_New.Manager
{
    public class TweetManager
    {
        private static List<Tweet> s_tweets;
        private static string s_filename = @"Assignment_02_TweetFile.txt";

        static TweetManager()
        {
            s_tweets = new List<Tweet>();

            try
            {
                var lines = File.ReadLines(s_filename);

                foreach (var t in lines)
                {
                    if (lines != null)
                    {
                        s_tweets.Add(Tweet.Parse(t));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
        }
        public static void Initialize()
        {
            s_tweets.Add(new Tweet("Afraid Student", "C# Program", "Please work, oh please work...", "Stressed"));

            s_tweets.Add(new Tweet("Happy Person", "Unhappy Person", "Why so mad?", "Here's a mars bar"));

            s_tweets.Add(new Tweet("Tall Man", "Everyone Else", "The air up here is better", "Skys the limit"));

            s_tweets.Add(new Tweet("Unknown", "Whomever", "Hullo", "Huh?"));

            s_tweets.Add(new Tweet("Student", "Self", "I am running out of ideas", "Unimaginative"));
        }
        public static void ShowAll()
        {
            foreach(Tweet tweet in s_tweets)
            {
                Console.WriteLine($"{tweet} \n");
            }
        }
        public static void ShowAll(string tag)
        {
            foreach (Tweet tweet in s_tweets)
            {
                if (tweet.tag.Equals(tag))
                {
                    Console.WriteLine($"{tweet} \n");
                }
            }
        }
    }
}
