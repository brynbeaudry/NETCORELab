using SQLiteWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQLiteWeb.Models
{
    public class DummyData
    {
		public static void Initialize(ApplicationDbContext db)
		{
			if (!db.Students.Any())
			{
				db.Students.Add(new Student
				{
					FirstName = "Bob",
					LastName = "Doe",
					School = "Engineering",
					StartDate = Convert.ToDateTime("2015/09/09")
				});
				db.Students.Add(new Student
				{
					FirstName = "Ann",
					LastName = "Lee",
					School = "Medicine",
					StartDate = Convert.ToDateTime("2014/09/09")
				});
				db.Students.Add(new Student
				{
					FirstName = "Sue",
					LastName = "Douglas",
					School = "Pharmacy",
					StartDate = Convert.ToDateTime("2016/01/01")
				});
				db.Students.Add(new Student
				{
					FirstName = "Tom",
					LastName = "Brown",
					School = "Business",
					StartDate = Convert.ToDateTime("2015/09/09")
				});
				db.Students.Add(new Student
				{
					FirstName = "Joe",
					LastName = "Mason",
					School = "Health",
					StartDate = Convert.ToDateTime("2015/01/01")
				});
				db.SaveChanges();
			}
		}
	}
}
