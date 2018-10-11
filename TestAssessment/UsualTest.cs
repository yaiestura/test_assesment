using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;
using System.Xml;
using MetroFramework;

namespace TestAssessment
{
    public partial class UsualTest : MetroForm
    {
        string PersonName;
        string PersonSurname;
        string Group;
        XmlReader xmlThemeRead;
        DirectoryInfo testsDirectory = new DirectoryInfo("Tests"); //Создаем объект сообтветствующий папке Tests
        public UsualTest(string personName, string personSurname, string group)
        {
            InitializeComponent();
            PersonName = personName;
            PersonSurname = personSurname;
            Group = group;
            lblPersonName.Text = PersonName;
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Dispose();
            }

            if (testsDirectory.Exists == false)
                CreateTestDir();

            ComboBox1.Items.AddRange(testsDirectory.GetDirectories()); //Добавление подпапок из директории Tests
        }

        public void CreateTestDir()
        {
            testsDirectory.Create();
            testsDirectory.CreateSubdirectory("Pascal");
            testsDirectory.CreateSubdirectory("Си");
            testsDirectory.CreateSubdirectory("Алгоритмизация");
            testsDirectory.CreateSubdirectory("C#");
            testsDirectory.CreateSubdirectory("Python");
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTheme.Text = "Тема теста: "; //Принудительная очистка темы
            DirectoryInfo testsDir = new DirectoryInfo("Tests\\" + ComboBox1.Text); //Создем объект соответствующий выбраной папке
            listBox1.Items.Clear(); //Очищаем listBox1

            foreach (FileInfo file in testsDir.GetFiles())
            {
                listBox1.Items.Add(Path.GetFileNameWithoutExtension(file.FullName));
            }

            btnNext.Enabled = false;
        }
        
        private void btnNext_Click(object sender, EventArgs e)
        {
             string xmlPath = "Tests\\" + ComboBox1.Text + "\\" + listBox1.Text + ".xml"; //Сохраняем путь к xml - файлу
             UsualMain Main = new UsualMain(xmlPath, PersonName, lblTheme.Text, PersonSurname, Group); //Передаем во 2ую форму путь к тесту и имя пользователя
             Main.Show(); //Вызываем форму тестирования
             this.Visible = false; //Скрываем первую форму
         }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                xmlThemeRead = new XmlTextReader("Tests\\" + ComboBox1.Text + "\\" + listBox1.Text + ".xml");

                // ищем узел <Theme>
                do xmlThemeRead.Read();
                while (xmlThemeRead.Name != "Theme");

                // считываем тему теста
                xmlThemeRead.Read();

                // вывести тему теста
                lblTheme.Text = "Тема теста: " + xmlThemeRead.Value;

                // выходим из узла <Theme>
                xmlThemeRead.Read();

                btnNext.Enabled = true;
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this,"Такого файла не существует или нет прав для его открытия!\n\t\tВыберите другой файл!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
    }

