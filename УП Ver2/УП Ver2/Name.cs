//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace УП_Ver2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Name
    {
        public int ID_Названия { get; set; }
        public string Название { get; set; }
        public string Класс_ПО { get; set; }
        public System.DateTime Дата { get; set; }
    
        public virtual Title Title { get; set; }
    }
}
