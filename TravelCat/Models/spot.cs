//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TravelCat.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class spot
    {
        public string spot_id { get; set; }
        public string spot_title { get; set; }
        public string spot_tel { get; set; }
        public string spot_intro { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }
        public string addition_note { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string address_detail { get; set; }
        public string open_time { get; set; }
        public string ticket_info { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public bool page_status { get; set; }
    }
}
