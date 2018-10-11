using System;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Xml;
using System.IO;
using MetroFramework;

namespace TestAssessment
{
    public partial class TestEditor : MetroForm
    {
        XmlTextWriter testWriter; //XmlTextWriter для записи xml-файла с тестом
        public TestEditor(MetroFramework.Components.MetroStyleManager msmMenu)
        {
            InitializeComponent();
            msmEditor = msmMenu;
            this.StyleManager = msmEditor;
            DirectoryInfo TestsDir = new DirectoryInfo("Tests"); //Создаем DirectoryInfo соответствующее папке Tests c тестами

            if (!TestsDir.Exists) //Если папки Tests нет
                TestsDir.Create(); //Создаем её

            comboBox1.Items.AddRange(TestsDir.GetDirectories()); //Заполняем comboBox1 поддерикториями папки Tests
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && textBoxTheme.Text != "" && textBoxName.Text != "")
            {
                try
                {
                    testWriter = new XmlTextWriter("Tests\\" + comboBox1.Text + "\\" + textBoxName.Text + ".xml", Encoding.UTF8); //Пытаемся создать файл теста
                }
                catch (DirectoryNotFoundException) //Если поддериктории (предмета тестирования) нет
                {
                    Directory.CreateDirectory("Tests\\" + comboBox1.Text); //Создаем директорию
                    testWriter = new XmlTextWriter("Tests\\" + comboBox1.Text + "\\" + textBoxName.Text + ".xml", Encoding.UTF8); //Создаем файл теста
                }

                testWriter.Formatting = Formatting.Indented; //Обеспечиваем читабельность файла

                //Начинаем документ
                testWriter.WriteStartDocument(); //Открываем документ
                testWriter.WriteStartElement("test"); //Открываем основной тэг - test

                //Записываем тему
                testWriter.WriteStartElement("Theme"); //Открываем тэг темы
                testWriter.WriteString(textBoxTheme.Text); //Записываем тему
                testWriter.WriteEndElement(); //Закрывем тэг темы

                //Записываем вопросы
                testWriter.WriteStartElement("qw"); //Открываем тэг вопросов
                testWriter.WriteStartAttribute("numbers"); //Записываем атрибут - количество вопросов
                testWriter.WriteString(numericUpDown1.Value.ToString());
                testWriter.WriteEndAttribute();

                for (int i = 1; i <= numericUpDown1.Value; i++)
                {
                    FillQuestion QF = new FillQuestion(i, testWriter, msmEditor);
                    QF.ShowDialog();
                }

                //Завершаем написание документа
                testWriter.WriteEndElement(); //Закрывем тэг вопросов
                testWriter.WriteEndElement(); //Закрывем основной тэг - test
                testWriter.WriteEndDocument(); //Закрываем документ

                testWriter.Close();

                MetroMessageBox.Show(this,"Все вопросы успешно созданы!", "Выход", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
            else
            {
                MetroMessageBox.Show(this, "Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }


