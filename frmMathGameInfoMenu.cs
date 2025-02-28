using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Math_Game
{
    public partial class frmMathGameInfoMenu : Form
    {
        public static short NumberOfQuestion = 0;
        public static string QuestionLevel = "";
        public static string OperationType = "";

        //--------------------------------------------//
        public frmMathGameInfoMenu()
        {
            InitializeComponent();
        }
        private void frmMathGameInfoMenu_Load(object sender, EventArgs e)
        {
            
        }

        //--------------------------------------------//

        private void ComboBoxErrorProvider(object sender, CancelEventArgs e, ComboBox cbControl)
        {
            if (string.IsNullOrEmpty(cbControl.Text))
            {
                e.Cancel = true;
                cbControl.Focus();

                errorProvider1.SetError(cbControl, "Must have to value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbControl, "");
            }
        }

        //--------------------------------------------//

        private void MakebtnStartGameEnabled()
        {
            if (!string.IsNullOrEmpty(cbNumberOfQuestion.Text) && !string.IsNullOrEmpty(cbQuestionLevel.Text) && !string.IsNullOrEmpty(cbOperationType.Text)) 
            {
                btnStartGame.Enabled = true;
            }
            //else
            //{
            //    btnStartGame.Enabled = false;
            //}
        }

        //--------------------------------------------//

        private void cbNumberOfQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakebtnStartGameEnabled();
        }

        private void cbNumberOfQuestion_Validating(object sender, CancelEventArgs e)
        {
            ComboBoxErrorProvider(sender, e, cbNumberOfQuestion);
        }

        //--------------------------------------------//

        private void cbQuestionLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakebtnStartGameEnabled();
        }

        private void cbQuestionLevel_Validating(object sender, CancelEventArgs e)
        {
            ComboBoxErrorProvider(sender, e, cbQuestionLevel);
        }

        //--------------------------------------------//

        private void cbOperationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakebtnStartGameEnabled();
        }

        private void cbOperationType_Validating(object sender, CancelEventArgs e)
        {
            ComboBoxErrorProvider(sender, e, cbOperationType);
        }

        //--------------------------------------------//
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            NumberOfQuestion = Convert.ToInt16(cbNumberOfQuestion.Text);
            QuestionLevel = cbQuestionLevel.Text;
            OperationType = cbOperationType.Text;

            Form frm = new frmMathGameStarterMenu();
            frm.ShowDialog();
        }

        //--------------------------------------------//
    }
}