using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TestAssessment
{
    public partial class UsualMain : MetroForm
    {
        XmlReader xmlReader;
        string PersonName; //Имя пользователя
        string PersonSurname;
        string Group;
        string Theme; //Тема теста
        int nv;  // общее количество вопросов
        int RightAnsw; //Количество правильных ответов
        int position = 0;   // оставшееся количество вопросов

        string qw; //Вопрос
        string[] answ = new string[4]; //Варианты ответов
        string right; //Верный ответ
        bool righting; //Правота пользователя

        public UsualMain(string TestPath, string personName, string theme, string personSurname, string group)
        {
            InitializeComponent();
            PersonName = personName; //Имя пользователя
            PersonSurname = personSurname;
            Group = group;
            Theme = theme; //Тема теста
            MessageBox.Show("Для начала тестирования нажмите \"ОК\"", "Тестирование");
            xmlReader = new XmlTextReader(TestPath); //Создаем xmlReader
            xmlReader.Read();
            ReadNumbers(); //Читаем количество вопросов
            LoadQwest();
            ShowQwest();
        }
        public void ReadNumbers()
        {
            //Ищем узел <qw>
            do xmlReader.Read();
            while (xmlReader.Name != "qw");

            nv = Convert.ToInt32(xmlReader.GetAttribute("numbers")); //Читаем атрибут узла <qw> 

            xmlReader.Read(); //Входим в узел <qw>
        }

        public void LoadQwest()
        {
            position++;

            if (position > nv)
                Itog();
            else
            {
                //Ищем узел вопроса
                do xmlReader.Read();
                while (xmlReader.Name != "q" + position);

                if (xmlReader.Name == "q" + position)
                {
                    qw = xmlReader.GetAttribute("text"); //Считываем вопрос
                    right = xmlReader.GetAttribute("right"); //Считываем правильный ответ

                    xmlReader.Read(); //Входим в узел <q>

                    //Ищем узел <answers>
                    do xmlReader.Read();
                    while (xmlReader.Name != "answers");

                    xmlReader.Read(); //Входим в узел <answers>

                    answ = xmlReader.Value.Split('|'); //Cохраняем варианты ответов в массив
                }
            }
        }

        public void ShowQwest()
        {
            lblQW.Text = qw; //Выводим вопрос

            //Выводим варианты ответов
            metroRadioButton1.Text = answ[0];
            metroRadioButton2.Text = answ[1];
            metroRadioButton3.Text = answ[2];
            metroRadioButton4.Text = answ[3];

            btnNextQW.Enabled = false; //Блокируем кнопку
        }

        public void Checked()
        {
            if (righting == true)
                RightAnsw++;
        }


        public void Itog()
        {
            MessageBox.Show("Тестирование окончено!", "Тестирование");
            Agenda Ag = new Agenda(PersonName, PersonSurname, Group, Theme, nv, RightAnsw);
            this.Dispose();
            Ag.ShowDialog();
        }
        


        private void btnNextQW_Click(object sender, EventArgs e)
        {
            Checked();
            LoadQwest(); //Загружаем вопрос
            ShowQwest(); //Выводим вопрос
            righting = false; //Сбрасываем "правоту"
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            righting = false;

            if (metroRadioButton1.Checked)
            {
                if (metroRadioButton1.Text == right)
                    righting = true;
            }
            if (metroRadioButton2.Checked)
            {
                if (metroRadioButton2.Text == right)
                    righting = true;
            }
            if (metroRadioButton3.Checked)
            {
                if (metroRadioButton3.Text == right)
                    righting = true;
            }
            if (metroRadioButton4.Checked)
            {
                if (metroRadioButton4.Text == right)
                    righting = true;
            }

            btnNextQW.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Вызываем Closing 1-ой формы
        }
    }
}



      
       