using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7__Flus_rss_
{
    public class FeedItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime PubDate { get; set; }
        public Uri Link { get; set; }
    }
}
