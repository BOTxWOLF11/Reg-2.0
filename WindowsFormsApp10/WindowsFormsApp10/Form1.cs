using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 existingForm = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            // Открываем новую форму Form2
            Form2 newForm = new Form2();
            newForm.Show();
            if (existingForm != null)
            {
                // Закрываем существующую форму Form2
                existingForm.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 existingForm = Application.OpenForms.OfType<Form3>().FirstOrDefault();
            // Открываем новую форму Form2
            Form3 newForm = new Form3();
            newForm.Show();
            if (existingForm != null)
            {
                // Закрываем существующую форму Form2
                existingForm.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
