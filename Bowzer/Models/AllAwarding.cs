using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowzer.Models
{
    public class AllAwarding
    {
        public object giver_coin_reward { get; set; }
        public object subreddit_id { get; set; }
        public bool is_new { get; set; }
        public object days_of_drip_extension { get; set; }
        public int coin_price { get; set; }
        public string id { get; set; }
        public object penny_donate { get; set; }
        public string award_sub_type { get; set; }
        public int coin_reward { get; set; }
        public string icon_url { get; set; }
        public object days_of_premium { get; set; }
        public object tiers_by_required_awardings { get; set; }
        public List<ResizedIcon> resized_icons { get; set; }
        public int icon_width { get; set; }
        public int static_icon_width { get; set; }
        public object start_date { get; set; }
        public bool is_enabled { get; set; }
        public object awardings_required_to_grant_benefits { get; set; }
        public string description { get; set; }
        public object end_date { get; set; }
        public object sticky_duration_seconds { get; set; }
        public int subreddit_coin_reward { get; set; }
        public int count { get; set; }
        public int static_icon_height { get; set; }
        public string name { get; set; }
        public List<ResizedStaticIcon> resized_static_icons { get; set; }
        public string icon_format { get; set; }
        public int icon_height { get; set; }
        public int? penny_price { get; set; }
        public string award_type { get; set; }
        public string static_icon_url { get; set; }
    }
}
