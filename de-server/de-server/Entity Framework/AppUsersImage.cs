//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace de_server.Entity_Framework
{
    using System;
    using System.Collections.Generic;
    
    public partial class AppUsersImage
    {
        public int AppUserID { get; set; }
        public byte[] ImageData { get; set; }
    
        public virtual AppUser AppUser { get; set; }
    }
}
