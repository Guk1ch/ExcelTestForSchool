using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Excel = Microsoft.Office.Interop.Excel;
using ExcelTestForSchool.DataBase;

namespace ExcelTestForSchool
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			
		}

		private void btn_Click(object sender, RoutedEventArgs e)
		{
			var teach = StatisticFunction.TeacherWorkIsHard();
			var teachBd = BdConnection.connection.Teacher.ToList();
			foreach(var i in teach)
			{
				Teacher teacher = teachBd.Where(x => x.ID == i.IdTeach).FirstOrDefault();
				var application = new Excel.Application();
			}
			
		}
	}
}
