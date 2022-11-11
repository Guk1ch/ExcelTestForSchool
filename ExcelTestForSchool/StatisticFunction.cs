using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelTestForSchool.DataBase;


namespace ExcelTestForSchool
{
	public class StatisticFunction
	{
		public class TeacherWork 
		{
			public int IdTeach { get; set;}
			public int CountWork { get; set;}
		};
		public static  List<TeacherWork> TeacherWorkIsHard() 
		{
			var teachers = BdConnection.connection.Teacher.ToList();
			var lessons = BdConnection.connection.Lesson.ToList();
			List<TeacherWork> teacherWorks = new List<TeacherWork>();
			foreach(var i in teachers) 
			{
				TeacherWork teacher = new TeacherWork();
				teacher.IdTeach = i.ID;
				teacher.CountWork = 0;
				foreach (var j in lessons)
				{
					if(i.ID == j.IDTeacher) 
					{
						teacher.CountWork++;
					}
				}
				teacherWorks.Add(teacher);
			}
			return teacherWorks;
			
		}

	}
}
