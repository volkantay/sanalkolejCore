using System;
using Microsoft.EntityFrameworkCore;

namespace SanalKolej.Core.Base
{
    public class ContextBase:DbContext
    {
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite("Data Source=SanalKolej.db;");
            // optionsBuilder.UseSqlServer( @"Server = (localdb);Database:SanalKolej;TrustedConneciton:true;" );
        }
    }
}
