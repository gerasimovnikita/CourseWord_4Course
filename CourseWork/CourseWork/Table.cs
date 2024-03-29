//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseWork
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table()
        {
            this.Table_Reservation = new HashSet<Table_Reservation>();
        }
    
        public int id_table { get; set; }
        public int table_number { get; set; }
        public int number_of_seats { get; set; }
        public int color_id { get; set; }
        public int material_id { get; set; }
        public int form_id { get; set; }
        public byte[] img { get; set; }
    
        public virtual Color Color { get; set; }
        public virtual Form_Factor Form_Factor { get; set; }
        public virtual Material Material { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Reservation> Table_Reservation { get; set; }
    }
}
