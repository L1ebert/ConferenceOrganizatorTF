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
    
    public partial class City
    {
        public City()
        {
            this.Event = new HashSet<Event>();
            this.User = new HashSet<User>();
        }
    
        public int Id { get; set; }
        public string CoatOfArms { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual ICollection<Event> Event { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
