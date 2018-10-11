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
using System.Xml;
using MetroFramework;

namespace TestAssessment
{
    public partial class FillQuestion : MetroForm
    {
        XmlTextWriter testWriter;//XmlTextWriter для записи *.xml-файла с тестом
        int count; //Целочисленное значение количества вопросов
        public FillQuestion(int k, XmlTextWriter Writer, MetroFramework.Components.MetroStyleManager msmEditor)
        {
            InitializeComponent();
            msmFillQW = msmEditor;
            this.StyleManager = msmFillQW;
            testWriter = Writer;
            count = k;
            lblEditQuestion.Text = "Редактирование вопроса №" + count;
        }

        private void QwestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (mtbQuestion.Text != "" && mtbAnswer1.Text != "" && mtbAnswer2.Text != "" && mtbAnswer3.Text != "" && mtbAnswer4.Text != "" && mtbRight.Text != "")
            {
                if (mtbRight.Text == mtbAnswer1.Text || mtbRight.Text == mtbAnswer2.Text || mtbRight.Text == mtbAnswer3.Text || mtbRight.Text == mtbAnswer4.Text)
                {
                    //Записываем вопрос
                    testWriter.WriteStartElement("q" + count); //Открываем тэг вопроса - qN (где N - номер вопроса)

                    //Записываем текст вопроса в атрибут text
                    testWriter.WriteStartAttribute("text"); //Открываем атрибут text
                    testWriter.WriteString(mtbQuestion.Text); //Записываем атрибут text
                    testWriter.WriteEndAttribute(); //Закрываем атрибут text

                    //Записываем правильный ответ в атрибут right
                    testWriter.WriteStartAttribute("right"); //Открываем атрибут right
                    testWriter.WriteString(mtbRight.Text); //Записываем атрибут right
                    testWriter.WriteEndAttribute(); //Закрываем атрибут right

                    //Записываем тэг с ответами
                    testWriter.WriteStartElement("answers"); //Открываем тэг answers
                    testWriter.WriteString(mtbAnswer1.Text + "|" + mtbAnswer2.Text + "|" + mtbAnswer3.Text + "|" + mtbAnswer4.Text); //Записываем ответы в тэг разделяя знаком '|'
                    testWriter.WriteEndElement(); //Закрываем тэг answers

                    testWriter.WriteEndElement(); //Закрываем тэг вопроса qN

                    this.Dispose(); //Закрываем форму
                }
                else
                {
                    MetroMessageBox.Show(this,"Правильный ответ не совпадает ни к одним из вариантов ответа!\n\nПодсказка: Скопируйте правильный вариант в поле правильного ответа!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }
    }
}
