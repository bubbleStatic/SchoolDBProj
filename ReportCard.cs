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
    
    public partial class ReportCard
    {
        public ReportCard()
        {
            this.Mark = new HashSet<Mark>();
        }
    
        public int ID { get; set; }
        public Nullable<int> PupilFK { get; set; }
    
        public virtual ICollection<Mark> Mark { get; set; }
        public virtual Pupil Pupil { get; set; }
    }
}
