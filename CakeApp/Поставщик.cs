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
    
    public partial class Поставщик
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Поставщик()
        {
            this.Ингредиенты = new HashSet<Ингредиенты>();
            this.Украшения_для_торта = new HashSet<Украшения_для_торта>();
        }
    
        public string Название_поставщика { get; set; }
        public string Адрес { get; set; }
        public System.DateTime Срок_доставки { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ингредиенты> Ингредиенты { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Украшения_для_торта> Украшения_для_торта { get; set; }
    }
}
