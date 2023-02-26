using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assign02_New.Models
{
    public class Tweet
    {
        private int _current_id = 10001;

        public string from;
        public string to;
        public string body;
        public string tag;
        public string id;

        public string From
        {
            get { return from; }
        }
        public string To
        {
            get { return to; }
        }
        public string Body
        {
            get { return body; }
        }
        public string Tag
        {
            get { return tag; }
        }
        public string Id
        {
            get { return id; }
        }
        public Tweet(string from, string to, string body, string tag)
        {
            this.from = from;
            this.to = to;
            this.body = body;
            this.tag = tag;
            this.id = _current_id.ToString();

            ++_current_id;
        }
        public Tweet(string from, string to, string body, string tag, string id)
        {
            this.from = from;
            this.to = to;
            this.body = body;
            this.tag = tag;
            this.id = id;
        }
        public override string ToString()
        {
            string body = Body;
            if (body.Length > 40)
            {
                body.Substring(0, 40);
            }
            return $"TO: {this.to} \n" +
                $"FROM: {this.from} \n" +
                $"BODY: {this.body} \n" +
                $"TAG: {this.tag} \n" +
                $"ID: {this.id}";
        }
        public static Tweet Parse(string line)
        {
            string[] tweet = line.Split(new char[] { '\t' });
            return new Tweet(tweet[0], tweet[1], tweet[2], tweet[3]);
        }
    }
}
