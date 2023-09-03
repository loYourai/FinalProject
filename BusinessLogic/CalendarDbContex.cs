using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class CalendarDbContex : DbContext
    {
        public virtual DbSet<Meeting> Meetings { get; set; }
       // public virtual DbSet<Room> Rooms { get; set; }
        //public virtual DbSet<RecurrencySetting> RecurrencySettings { get; set; }

        public CalendarDbContex(DbContextOptions<CalendarDbContex> options) : base(options)
        {
        }
    }
}