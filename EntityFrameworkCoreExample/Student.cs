﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreExample
{
	public class Student
	{
		[Key] // Make Id Primary Key
		public int Id { get; set; }

		public string FullName { get; set; }

		public DateTime DateOfBirth { get; set; }
	}
}
