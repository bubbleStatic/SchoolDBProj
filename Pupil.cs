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
    
    public partial class Pupil
    {
        public Pupil()
        {
            this.ReportCard = new HashSet<ReportCard>();
        }
    
        public int ID { get; set; }
        public string PupilName { get; set; }
        public int Grade { get; set; }
        public Nullable<int> PupilFK { get; set; }
    
        public virtual Lesson Lesson { get; set; }
        public virtual ICollection<ReportCard> ReportCard { get; set; }
    }
}