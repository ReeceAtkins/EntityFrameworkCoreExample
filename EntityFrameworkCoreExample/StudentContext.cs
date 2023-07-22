using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreExample
{
	// Ef Core Getting started
	// https://learn.microsoft.com/en-us/ef/core/get-started/overview/install
	public class StudentContext : DbContext
	{
        public StudentContext()
        {
                
        }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			// Database = The desired name for the database
			// Server = the server we are connection to. LocalDb is included in VS
			// Trusted_Connection - indicates that our windos account should be used
			options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreExample;Trusted_Connection=True;");
		}
	}
}
