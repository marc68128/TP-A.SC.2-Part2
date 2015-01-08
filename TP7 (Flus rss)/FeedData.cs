using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP7__Flus_rss_
{
    public class FeedData
    {
        public FeedData()
        {
            Items = new List<FeedItem>();
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PubDate { get; set; }
        public List<FeedItem> Items { get; set; }
    }
}
