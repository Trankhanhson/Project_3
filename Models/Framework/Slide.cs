//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Slide
    {
        public int SlideId { get; set; }
        public Nullable<bool> Image { get; set; }
        public string Link { get; set; }
        public Nullable<int> PageId { get; set; }
    
        public virtual Page Page { get; set; }
    }
}
