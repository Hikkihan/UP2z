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
    
    public partial class Заметки_пользователя
    {
        public int Номер_заметки { get; set; }
        public string Логин { get; set; }
        public string Класс_ПО { get; set; }
    
        public virtual Title Title { get; set; }
        public virtual UserData UserData { get; set; }
    }
}
