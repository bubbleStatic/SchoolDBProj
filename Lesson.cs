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
    
    public partial class Lesson
    {
        public Lesson()
        {
            this.Pupil = new HashSet<Pupil>();
        }
    
        public int ID { get; set; }
        public string LessonName { get; set; }
        public Nullable<int> PalorFK { get; set; }
        public Nullable<int> ScheduleFK { get; set; }
    
        public virtual Schedule Schedule { get; set; }
        public virtual ICollection<Pupil> Pupil { get; set; }
        public virtual Palor Palor { get; set; }
    }
}
