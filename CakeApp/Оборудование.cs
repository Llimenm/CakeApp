//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CakeApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Оборудование
    {
        public string Маркировка { get; set; }
        public string Тип_оборудования { get; set; }
        public string Характеристики { get; set; }
    
        public virtual Тип_оборудования Тип_оборудования1 { get; set; }
    }
}
