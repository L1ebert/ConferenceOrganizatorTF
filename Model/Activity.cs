//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConferenceOrganizatorTF.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Day { get; set; }
        public System.TimeSpan BeginTime { get; set; }
        public int EventId { get; set; }
        public int ModeratorId { get; set; }
    
        public virtual Event Event { get; set; }
        public virtual User User { get; set; }
    }
}
