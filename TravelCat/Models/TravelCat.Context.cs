﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbTravelCat : DbContext
    {
        public dbTravelCat()
            : base("name=dbTravelCat")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<activity> activity { get; set; }
        public virtual DbSet<admin> admin { get; set; }
        public virtual DbSet<badge> badge { get; set; }
        public virtual DbSet<badge_details> badge_details { get; set; }
        public virtual DbSet<comment> comment { get; set; }
        public virtual DbSet<comment_emoji_details> comment_emoji_details { get; set; }
        public virtual DbSet<emoji> emoji { get; set; }
        public virtual DbSet<follow_list> follow_list { get; set; }
        public virtual DbSet<hotel> hotel { get; set; }
        public virtual DbSet<issue_type> issue_type { get; set; }
        public virtual DbSet<member> member { get; set; }
        public virtual DbSet<member_profile> member_profile { get; set; }
        public virtual DbSet<message> message { get; set; }
        public virtual DbSet<message_emoji_details> message_emoji_details { get; set; }
        public virtual DbSet<restaurant> restaurant { get; set; }
        public virtual DbSet<spot> spot { get; set; }
        public virtual DbSet<tourism_photo> tourism_photo { get; set; }
        public virtual DbSet<collection_type> collection_type { get; set; }
        public virtual DbSet<collections_detail> collections_detail { get; set; }
        public virtual DbSet<issue> issue { get; set; }
    }
}
