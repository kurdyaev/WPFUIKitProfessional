//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFUIKitProfessional.DataFolder
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int IdUser { get; set; }
        public string LoginUser { get; set; }
        public string PasswordUser { get; set; }
        public int IdRole { get; set; }
        public int IdStaff { get; set; }
    
        public virtual Role Role { get; set; }
        public virtual Staff Staff { get; set; }
    }
}