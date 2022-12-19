using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevExFinalSE
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private Form currentChildForm;
        public MainForm()
        {
            InitializeComponent();
            LoginForm l = new LoginForm();
            l.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainFormContainer.Controls.Add(childForm);
            MainFormContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitleChildForm.Text = childForm.Text;
        }

        private void Importelement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ImportForm());
        }

        private void Exportelement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeliveryNoteForm());
        }

        private void Revenueelement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Revenue());
        }
    }
}
