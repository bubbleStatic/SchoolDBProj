//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mark
    {
        public int ID { get; set; }
        public int Mark1 { get; set; }
        public System.DateTime DateOfMark { get; set; }
        public Nullable<int> ReportCardFK2 { get; set; }
    
        public virtual ReportCard ReportCard { get; set; }
    }
}
