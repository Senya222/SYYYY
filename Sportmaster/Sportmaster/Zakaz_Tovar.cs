//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sportmaster
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zakaz_Tovar
    {
        public int ID { get; set; }
        public int IDZakaz { get; set; }
        public int IDTovar { get; set; }
        public int Kolichesto { get; set; }
    
        public virtual Tovar Tovar { get; set; }
        public virtual Zakaz Zakaz { get; set; }
    }
}