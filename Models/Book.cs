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
    
    public partial class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookLocation { get; set; }
        public Nullable<int> BooksCount { get; set; }

        public LendedBook LendedBook
        {
            get => default;
            set
            {
            }
        }
    }
}
