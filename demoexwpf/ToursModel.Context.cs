﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demoexwpf
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ToursEntities : DbContext
    {
        private static ToursEntities _context;
        public ToursEntities()
            : base("name=ToursEntities")
        {
        }
    
        public static ToursEntities GetContext()
        {
            if (_context == null)
                _context = new ToursEntities();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Hotel> Hotel { get; set; }
        public virtual DbSet<HotelComment> HotelComment { get; set; }
        public virtual DbSet<HotelImage> HotelImage { get; set; }
        public virtual DbSet<Tour> Tour { get; set; }
        public virtual DbSet<Type> Type { get; set; }
    }
}
