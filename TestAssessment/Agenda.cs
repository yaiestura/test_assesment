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

namespace TestAssessment
{
    public partial class Agenda : MetroForm
    {
        float Mark;//Средний балл

        public Agenda(string PersonName, string PersonSurname, string Group, string Theme, int NumbersOfQwest, int RightAnswers)
        {
            InitializeComponent();

            //Заполняем текстовые поля
            lblName.Text += PersonName;
            lblSurname.Text += PersonSurname;
            lblGroup.Text += Group;
            lblTheme.Text = Theme;
            lblNumQ.Text += NumbersOfQwest.ToString();
            lblRight.Text += RightAnswers.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
          this.Close();
           
        }
    }
}
