//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenKO_WEB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTicket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string tContent { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string Sender { get; set; }
        public int StatusId { get; set; }
        public System.DateTime Date { get; set; }
        public string Replied { get; set; }
        public Nullable<System.DateTime> ReplyDate { get; set; }
        public Nullable<int> AnswerId { get; set; }
    }
}