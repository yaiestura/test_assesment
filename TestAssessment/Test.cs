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
    public partial class Test : MetroForm
    {
        string Personsname;
        string PersonSurname;
        string Group;
        public Test(string personName, string personSurname, string personGroup)
        {
            InitializeComponent();
            Personsname = personName;
            PersonSurname = personSurname;
            Group = personGroup;
        }

        private void btnUsual_Click(object sender, EventArgs e)
        {
            UsualTest Ut = new UsualTest(Personsname, PersonSurname, Group);
            Ut.Show();
        }
    }
}
