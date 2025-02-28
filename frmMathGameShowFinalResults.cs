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
    public partial class frmMathGameShowFinalResults : Form
    {
        static short NumberOfQuestion = 0;
        static string QuestionLevel = "";
        static string OperationType = "";
        static short NumberOfCorrectAnswer = 0;
        static short NumberOfWrongAnswer = 0;
        static bool IsPass = false;

        //------------------------------------------------//
        public frmMathGameShowFinalResults()
        {
            InitializeComponent();
        }
        private void frmMathGameShowFinalResults_Load(object sender, EventArgs e)
        {
            ShowOverAllResult();
        }

        //------------------------------------------------//
        static public void GetOverAllResultInfo(short sNumberOfQuestion, string sQuestionLevel, string sOperationType, short sNumberOfCorrectAnswer, short sNumberOfWrongAnswer, bool sIsPass)
        {
            NumberOfQuestion = sNumberOfQuestion;
            QuestionLevel = sQuestionLevel;
            OperationType = sOperationType;
            NumberOfCorrectAnswer = sNumberOfCorrectAnswer;
            NumberOfWrongAnswer = sNumberOfWrongAnswer;
            IsPass = sIsPass;
        }
        private string GetFinalResult()
        {
            return (IsPass) ? "Pass" : "Fail";
        }
        private void ShowOverAllResult()
        {
            lblNumberOfQuestion.Text = NumberOfQuestion.ToString();
            lblQuestionLevel.Text = QuestionLevel;
            lblOperationType.Text = OperationType;
            lblNumberOfCorrectAnswer.Text = NumberOfCorrectAnswer.ToString();
            lblNumberOfWrongAnswer.Text = NumberOfWrongAnswer.ToString();
            lblFinalResult.Text = GetFinalResult();
        }

        //------------------------------------------------//
        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //------------------------------------------------//
    }
}