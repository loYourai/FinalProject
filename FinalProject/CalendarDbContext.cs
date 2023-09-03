using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;

namespace FinalProject
{
    public class CalendarDbContext : DbContext
    {
        public virtual DbSet<Meeting> Meetings { get; set; }
        // public virtual DbSet<Room> Rooms { get; set; }
        //public virtual DbSet<RecurrencySetting> RecurrencySettings { get; set; }

        public CalendarDbContext(DbContextOptions<CalendarDbContext> options) : base(options)
        {
        }
    }
}