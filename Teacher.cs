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
    
    public partial class Teacher
    {
        public Teacher()
        {
            this.Schedule = new HashSet<Schedule>();
        }
    
        public int ID { get; set; }
        public string TeacherName { get; set; }
        public string SubjectName { get; set; }
    
        public virtual ICollection<Schedule> Schedule { get; set; }
    }
}
