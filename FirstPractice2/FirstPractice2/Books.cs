//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirstPractice2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Books
    {
        public int ID_Book { get; set; }
        public string BookTittle { get; set; }
        public string GenreOfbOOK { get; set; }
        public int PublicationYear { get; set; }
        public Nullable<bool> AvailabilityOfBook { get; set; }
        public int Author_ID { get; set; }
    
        public virtual Authors Authors { get; set; }
    }
}
