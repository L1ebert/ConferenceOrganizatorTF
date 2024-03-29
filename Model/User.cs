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
    
    public partial class User
    {
        public User()
        {
            this.Activity = new HashSet<Activity>();
            this.ActivityJury = new HashSet<ActivityJury>();
            this.Event = new HashSet<Event>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<int> CityId { get; set; }
        public string Phone { get; set; }
        public Nullable<int> DirectionId { get; set; }
        public Nullable<int> EventId { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }
        public int GenderId { get; set; }
        public int RoleId { get; set; }
    
        public virtual ICollection<Activity> Activity { get; set; }
        public virtual ICollection<ActivityJury> ActivityJury { get; set; }
        public virtual City City { get; set; }
        public virtual Direction Direction { get; set; }
        public virtual ICollection<Event> Event { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Role Role { get; set; }
    }
}
