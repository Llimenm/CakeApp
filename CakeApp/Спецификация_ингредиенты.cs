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
    
    public partial class Спецификация_ингредиенты
    {
        public string Изделие { get; set; }
        public string Ингредиент { get; set; }
        public int Кол_во { get; set; }
    
        public virtual Изделие Изделие1 { get; set; }
        public virtual Ингредиенты Ингредиенты { get; set; }
    }
}
