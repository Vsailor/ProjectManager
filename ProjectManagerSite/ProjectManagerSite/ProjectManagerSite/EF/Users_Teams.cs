//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManagerSite.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users_Teams
    {
        public System.Guid Id { get; set; }
        public System.Guid TeamId { get; set; }
        public System.Guid UserId { get; set; }
        public System.Guid PositionId { get; set; }
        public bool IsLeader { get; set; }
    
        public virtual Positions Positions { get; set; }
        public virtual Teams Teams { get; set; }
        public virtual Users Users { get; set; }
    }
}
