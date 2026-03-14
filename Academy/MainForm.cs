using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DBtools;

namespace Academy
{
    public partial class MainForm : Form
    {
        Connector connector;
        //Connector movies_connector;
        public MainForm()
        {
            InitializeComponent();
            connector = new Connector("Data Source=DESKTOP-MU2UJAA\\SQLEXPRESS;"
                                        +"Initial Catalog=SPU_411_Import;"
                                        +"Integrated Security=True;"
                                        +"Connect Timeout=30;"
                                        +"Encrypt=True;"
                                        +"TrustServerCertificate=True;"
                                        +"ApplicationIntent=ReadWrite;"
                                        +"MultiSubnetFailover=False");
            //movies_connector = new Connector("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Movies_SPU_411;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //dgvDirections.DataSource = movies_connector.Select("SELECT [№\nп/п] = movie_id,[Название фильма] = title,[Режиссер] = FORMATMESSAGE(N'%s %s', first_name,last_name) FROM Movies, Directors WHERE director = director_id ORDER BY movie_id");
            //dgvDirections.DataSource = movies_connector.Select("SELECT * FROM Movies");
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            string cmdStudents = "SELECT [№\nп/п] = ROW_NUMBER() OVER (ORDER BY last_name)"
                                  + ",[ФИО студента] = FORMATMESSAGE(N'%s %s %s', last_name,first_name,middle_name)"
                                  + ",[Дата рождения] = FORMAT(birth_date, 'dd.MM.yyyy')"
                                  + ",[Возраст] = CAST(DATEDIFF(DAY, birth_date, GETDATE())/365.25 AS INT)"
                                  + ",[Группа] = group_name"
                                  + ",[Направление] = direction_name"
                                  + " FROM Students,Groups,Directions"
                                  + " WHERE [group] = group_id AND direction = direction_id"
                                  + " ORDER BY last_name";
            string cmdGroups = "SELECT [№\nп/п] = ROW_NUMBER() OVER (ORDER BY group_name)"
                                  + ",[Группа] = group_name"
                                  + ",[Направление] = direction_name"
                                  + ",[Количество студентов] = COUNT(stud_id)"
                                  + " FROM Students"
                                  + " RIGHT JOIN Groups ON [group] = group_id"
                                  + " JOIN Directions ON direction = direction_id"
                                  + " GROUP BY group_name,direction_name";
            string cmdDirections = "SELECT [№\nп/п] = ROW_NUMBER() OVER (ORDER BY direction_name)"
                                  + ",[Направление] = direction_name"
                                  + ",[Количество групп] = COUNT(DISTINCT group_id)"
                                  + ",[Количество студентов] = COUNT(stud_id)"
                                  + " FROM Students"
                                  + " RIGHT JOIN Groups ON [group] = group_id"
                                  + " RIGHT JOIN Directions ON direction = direction_id"
                                  + " GROUP BY direction_name";
            string cmdDisciplines = "SELECT [№\nп/п] = discipline_id"
                                  + ",[Наименование дисциплины] = discipline_name"
                                  + ",[Количество часов] = number_of_lessons"
                                  + ",[Количество преподавателей по дисциплине] = COUNT(teacher_id)"
                                  + " FROM Disciplines"
                                  + " LEFT JOIN TeachersDisciplinesRelation ON discipline = discipline_id"
                                  + " LEFT JOIN Teachers ON teacher = teacher_id"
                                  + " GROUP BY discipline_id, discipline_name, number_of_lessons";
            string cmdTeachers = "SELECT [№\nп/п] = teacher_id"
                                  + ",[ФИО преподавателя] = FORMATMESSAGE(N'%s %s %s',last_name,first_name,middle_name)"
                                  + ",[Дата рождения] = FORMAT(birth_date, 'dd.MM.yyyy')"
                                  + ",[Возраст] = CAST(DATEDIFF(DAY, birth_date, GETDATE())/365.25 AS INT)"
                                  + ",[Стаж работы] = CAST(DATEDIFF(DAY, work_since, GETDATE())/365.25 AS INT)"
                                  + ",[Количество читаемых дисциплин] = COUNT(discipline)"
                                  + ",[Ставка] = rate"
                                  + " FROM Teachers"
                                  + " LEFT JOIN TeachersDisciplinesRelation ON teacher = teacher_id"
                                  + " LEFT JOIN Disciplines ON discipline = discipline_id"
                                  + " GROUP BY teacher_id,last_name,first_name,middle_name,birth_date,work_since,rate";
            dgvStudents.DataSource = connector.Select(cmdStudents);
            toolStripStatusLabel.Text = $"Количество студентов: {dgvStudents.RowCount - 1}";
            dgvStudents.DataSource = connector.Select(cmdStudents);
            //dgvStudents.DataSource = connector.Select("SELECT * FROM Students");
            dgvGroups.DataSource = connector.Select(cmdGroups);
            dgvDirections.DataSource = connector.Select(cmdDirections);
            dgvDisciplines.DataSource = connector.Select(cmdDisciplines);
            dgvTeachers.DataSource = connector.Select(cmdTeachers);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    toolStripStatusLabel.Text = $"Количество студентов: {dgvStudents.RowCount - 1}";
                    break;
                case 1:
                    toolStripStatusLabel.Text = $"Количество групп: {dgvGroups.RowCount - 1}";
                    break;
                case 2:
                    toolStripStatusLabel.Text = $"Количество направлений обучения: {dgvDirections.RowCount - 1}";
                    //toolStripStatusLabel.Text = $"Количество направлений обучения: {connector.Scalar("SELECT COUNT(*) FROM Directions")}";
                    break;
                case 3:
                    toolStripStatusLabel.Text = $"Количество дисциплин: {dgvDisciplines.RowCount - 1}";
                    break;
                case 4:
                    toolStripStatusLabel.Text = $"Количество учителей: {dgvTeachers.RowCount - 1}";
                    break;
            }
        }

    }
}
