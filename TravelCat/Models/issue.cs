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
    
    public partial class issue
    {
        public int id { get; set; }
        public string member_id { get; set; }
        public int admin_id { get; set; }
        public int issue_id { get; set; }
        public System.DateTime report_date { get; set; }
        public string issue_content { get; set; }
        public string issue_result { get; set; }
        public string issue_status { get; set; }
        public Nullable<System.DateTime> resolve_date { get; set; }
        public string problem_id { get; set; }
    
        public virtual admin admin { get; set; }
        public virtual issue_type issue_type { get; set; }
        public virtual member member { get; set; }
    }
}
