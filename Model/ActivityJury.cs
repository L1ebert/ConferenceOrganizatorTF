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
    
    public partial class ActivityJury
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public int JuryId { get; set; }
    
        public virtual User User { get; set; }
    }
}
