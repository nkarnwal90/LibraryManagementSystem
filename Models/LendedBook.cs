//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManagmentSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LendedBook
    {
        public int LendedBooksID { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }
    }
}
