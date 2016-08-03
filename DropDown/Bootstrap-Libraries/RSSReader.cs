using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml.Linq;

namespace Bootstrap_Libraries
{
    public class RSSReader
    {
        private static string _blogURL = "http://www.espncricinfo.com/rss/content/story/feeds/0.xml";
        public static IEnumerable<RSS> GetRssFeed()
        {
            XDocument feedXml = XDocument.Load(_blogURL);
            var feeds = from feed in feedXml.Descendants("item")
                        select new RSS
                        {
                            Title = feed.Element("title").Value,
                            Link = feed.Element("link").Value,
                            Description = Regex.Match(feed.Element("description").Value, @"^.{1,180}\b(?<!\s)").Value
                        };
            return feeds;
        }
    }
}