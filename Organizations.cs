//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EducationalOrganizationsApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Organizations
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string INN { get; set; }
        public string Address { get; set; }
        public string Website { get; set; }
        public int ID_Region { get; set; }
        public Nullable<int> ID_Type { get; set; }
        public Nullable<int> ID_Director { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    
        public virtual Directors Directors { get; set; }
        public virtual Regions Regions { get; set; }
        public virtual Types Types { get; set; }
    }
}
