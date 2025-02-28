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
    public partial class frmMathGameStarterMenu : Form
    {
        enum enQuestionLevel { eEasy = 1, eMedium = 2, eHard = 3, eMix = 4 };
        enum enOperationType { eAdd = 1, eSub = 2, eMult = 3, eDiv = 4, eMix = 5 };
        struct stQuestion
        {
            public int sNumber1;
            public int sNumber2;
            public enQuestionLevel sQuestionLevel;
            public enOperationType sOpType;
            public int sPlayerAnswer; 
            public int sCorrectAnswer;
            public bool sFinalResults;
        }
        struct stQuiz
        {
            public stQuestion[] sQuestion;
            public enQuestionLevel sQuestionLevel;
            public enOperationType sOpType;
            public short sNumberOfQuestion;
            public short CurrentQuestion;
            public short sNumberOfCorrectAnswer;
            public short sNumberOfWrongAnswer;
            public bool sIsPass;
            public short CountTimer;
        }

        static stQuiz Quiz = new stQuiz();
        //static stQuestion Question = new stQuestion();
        static Random random = new Random();

        //------------------------------------------------//
        private void ResetMathGameInfo()
        {
            Quiz = new stQuiz();

            lblNumberOfQuestion.Text = "0";
            lblCurrentQuestion.Text = "0";
            lblNumber1.Text = "0";
            lblNumber2.Text = "0";
            lblNumberOfCorrectAnswer.Text = "0";
            lblNumberOfWrongAnswer.Text = "0";
            lblOpType.Text = "+";
        }

        //------------------------------------------------//
        static private int RandomNumber(int From, int To)
        {
            return random.Next(From, To);
        }

        //------------------------------------------------//
        static private enQuestionLevel GetQuestionLevel(string QuestionLevel)
        {
            QuestionLevel = QuestionLevel.ToLower();

            switch (QuestionLevel)
            {
                case "easy":
                    {
                        return enQuestionLevel.eEasy;
                        //break;
                    }
                case "medium":
                    {
                        return enQuestionLevel.eMedium;
                    }
                case "hard":
                    {
                        return enQuestionLevel.eHard;
                    }
                case "mix":
                    {
                        return enQuestionLevel.eMix;
                    }
                default:
                    {
                        return enQuestionLevel.eEasy;
                    }
            }
        }

        static private enOperationType GetOperationType(string OpType)
        {
            OpType = OpType.ToLower();

            switch (OpType)
            {
                case "add":
                    {
                        return enOperationType.eAdd;
                        //break;
                    }
                case "sub":
                    {
                        return enOperationType.eSub;
                    }
                case "mult":
                    {
                        return enOperationType.eMult;
                    }
                case "div":
                    {
                        return enOperationType.eDiv;
                    }
                case "mix":
                    {
                        return enOperationType.eMix;
                    }
                default:
                    {
                        return enOperationType.eAdd;
                    }
            }
        }

        private char GetOperationTypeSymbol(enOperationType OpType)
        {
            switch (OpType)
            {
                case enOperationType.eAdd:
                    {
                        return '+';
                        //break;
                    }
                case enOperationType.eSub:
                    {
                        return '-';
                    }
                case enOperationType.eMult:
                    {
                        return 'x';
                    }
                case enOperationType.eDiv:
                    {
                        return '/';
                    }
                default:
                    {
                        return '+';
                    }
            }
        }

        static private string GetQuestionLevelName(enQuestionLevel QuestionLevel)
        {
            switch (QuestionLevel)
            {
                case enQuestionLevel.eEasy:
                    {
                        return "Easy";
                        //break;
                    }
                case enQuestionLevel.eMedium:
                    {
                        return "Medium";
                    }
                case enQuestionLevel.eHard:
                    {
                        return "Hard";
                    }
                case enQuestionLevel.eMix:
                    {
                        return "Mix";
                    }
                default:
                    {
                        return "Easy";
                    }
            }
        }

        static private string GetOperationTypeName(enOperationType OperationType)
        {
            switch (OperationType)
            {
                case enOperationType.eAdd:
                    {
                        return "Add";
                        //break;
                    }
                case enOperationType.eSub:
                    {
                        return "Sub";
                    }
                case enOperationType.eMult:
                    {
                        return "Mult";
                    }
                case enOperationType.eDiv:
                    {
                        return "Div";
                    }
                default:
                    {
                        return "Add";
                    }
            }
        }

        //------------------------------------------------//
        private void FillQuizInfo()
        {
            ResetMathGameInfo();
            Quiz.sNumberOfQuestion = frmMathGameInfoMenu.NumberOfQuestion;
            Quiz.sQuestionLevel = GetQuestionLevel(frmMathGameInfoMenu.QuestionLevel);
            Quiz.sOpType = GetOperationType(frmMathGameInfoMenu.OperationType);
        }

        //------------------------------------------------//
        private int CalculateCorrectAnswer(int Number1, int Number2, enOperationType OpType)
        {
            switch (OpType)
            {
                case enOperationType.eAdd:
                    {
                        return Number1 + Number2;
                    }
                case enOperationType.eSub:
                    {
                        return Number1 - Number2;
                    }
                case enOperationType.eMult:
                    {
                        return Number1 * Number2;
                    }
                case enOperationType.eDiv:
                    {
                        return Number1 / Number2;
                    }
                default:
                    {
                        return Number1 + Number2;
                    }
            }
        }

        private stQuestion GenerateQuestion(stQuestion Question)
        {
            Question.sQuestionLevel = Quiz.sQuestionLevel;
            Question.sOpType = Quiz.sOpType;

            if (Question.sQuestionLevel == enQuestionLevel.eMix)
            {
                Question.sQuestionLevel = (enQuestionLevel)RandomNumber(1, 3);
            }

            if (Question.sOpType == enOperationType.eMix)
            {
                Question.sOpType = (enOperationType)RandomNumber(1, 4);
            }

            switch (Question.sQuestionLevel)
            {
                case enQuestionLevel.eEasy:
                    {
                        Question.sNumber1 = RandomNumber(1, 10);
                        Question.sNumber2 = RandomNumber(1, 10);
                        Question.sCorrectAnswer = CalculateCorrectAnswer(Question.sNumber1, Question.sNumber2, Question.sOpType);
                        break;
                    }
                case enQuestionLevel.eMedium:
                    {
                        Question.sNumber1 = RandomNumber(1, 50);
                        Question.sNumber2 = RandomNumber(1, 50);
                        Question.sCorrectAnswer = CalculateCorrectAnswer(Question.sNumber1, Question.sNumber2, Question.sOpType);
                        break;
                    }
                case enQuestionLevel.eHard:
                    {
                        Question.sNumber1 = RandomNumber(1, 100);
                        Question.sNumber2 = RandomNumber(1, 100);
                        Question.sCorrectAnswer = CalculateCorrectAnswer(Question.sNumber1, Question.sNumber2, Question.sOpType);
                        break;
                    }
            }
            return Question;
        }

        private void GenerateQuiz()
        {
            stQuestion Question = new stQuestion();
            Quiz.sQuestion = new stQuestion[Quiz.sNumberOfQuestion];
            
            for (short i = 0; i < Quiz.sNumberOfQuestion; i++)
            {
                Question = GenerateQuestion(Question);

                Quiz.sQuestion[i].sNumber1 = Question.sNumber1;
                Quiz.sQuestion[i].sNumber2 = Question.sNumber2;
                Quiz.sQuestion[i].sQuestionLevel = Question.sQuestionLevel;
                Quiz.sQuestion[i].sOpType = Question.sOpType;
                Quiz.sQuestion[i].sCorrectAnswer = Question.sCorrectAnswer;
            }
        }

        //------------------------------------------------//
        public frmMathGameStarterMenu()
        {
            InitializeComponent();
        }
        private void frmMathGameStarterMenu_Load(object sender, EventArgs e)
        {
            Quiz.CurrentQuestion = 0;
            FillQuizInfo();

            lblNumberOfQuestion.Text = Quiz.sNumberOfQuestion.ToString();

            GenerateQuiz();
            ShowNextQuestionInfo();
        }

        //------------------------------------------------//
        private bool IsInt(Control control)
        {
            int Number = 0;

            return int.TryParse(control.Text, out Number);
        }

        private void TextBoxErrorProvider(object sender, CancelEventArgs e, TextBox txtControl)
        {

            if (string.IsNullOrEmpty(txtControl.Text))
            {
                e.Cancel = true;
                txtControl.Focus();

                errorProvider1.SetError(txtControl, "Must have to value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtControl, "");

                if (!IsInt(txtControl))
                {
                    e.Cancel = true;
                    txtControl.Focus();

                    errorProvider1.SetError(txtControl, "Accept Only Numbers!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtControl, "");
                }
            }

        }

        private void MakebtnCheckPlayerAnswerEnabled()
        {
            if (!string.IsNullOrEmpty(txtPlayerAnswer.Text))
            {
                btnCheckPlayerAnswer.Enabled = true;
            }
            else
            {
                btnCheckPlayerAnswer.Enabled = false;
            }
        }

        private void MakebtnCheckPlayerAnswerDisabled()
        {
            btnCheckPlayerAnswer.Enabled = false;
        }

        private void txtPlayerAnswer_TextChanged(object sender, EventArgs e)
        {
            MakebtnCheckPlayerAnswerEnabled();
        }

        private void txtPlayerAnswer_Validating(object sender, CancelEventArgs e)
        {
            TextBoxErrorProvider(sender, e, txtPlayerAnswer);
        }

        //------------------------------------------------//
        private void MakebtnNextQuestionEnabled()
        {
            btnNextQuestion.Enabled = true;
        }

        private void MakebtnNextQuestionDisabled()
        {
            btnNextQuestion.Enabled = false;
        }

        //------------------------------------------------//
        private bool IsPlayerAnswerCorrect(int PlayerAnswer, int CoreectAnswer)
        {
            return PlayerAnswer == CoreectAnswer;
        }
        private bool IsPass(short NumberOfCorrectAnswer, short NumberOfWrongAnswer)
        {
            return (NumberOfCorrectAnswer > NumberOfWrongAnswer);
        }
        private void ShowOverAllResultForm()
        {
            Form frm = new frmMathGameShowFinalResults();
            frm.ShowDialog();
        }
        private void btnCheckPlayerAnswer_Click(object sender, EventArgs e)
        {
            EndTimer();
            short CurrentQuestion = (short)(Quiz.CurrentQuestion - 1);
            Quiz.sQuestion[CurrentQuestion].sPlayerAnswer = Convert.ToInt32(txtPlayerAnswer.Text);
            Quiz.sQuestion[CurrentQuestion].sFinalResults = IsPlayerAnswerCorrect(Quiz.sQuestion[CurrentQuestion].sPlayerAnswer, Quiz.sQuestion[CurrentQuestion].sCorrectAnswer);

            if (Quiz.sQuestion[CurrentQuestion].sFinalResults) 
            {
                MessageBox.Show("Your Answer Is Correct.", "Result:");
                Quiz.sNumberOfCorrectAnswer++;
                lblNumberOfCorrectAnswer.Text = Quiz.sNumberOfCorrectAnswer.ToString();
            }
            else
            {
                MessageBox.Show("Your Answer Is Wrong! \n Correct Answer is : " + Quiz.sQuestion[CurrentQuestion].sCorrectAnswer.ToString(), "Result:");
                Quiz.sNumberOfWrongAnswer++;
                lblNumberOfWrongAnswer.Text = Quiz.sNumberOfWrongAnswer.ToString();
            }

            if (Quiz.CurrentQuestion == Quiz.sNumberOfQuestion) 
            {
                MakebtnCheckPlayerAnswerDisabled();
                Quiz.sIsPass = IsPass(Quiz.sNumberOfCorrectAnswer, Quiz.sNumberOfWrongAnswer);
                frmMathGameShowFinalResults.GetOverAllResultInfo(Quiz.sNumberOfQuestion, GetQuestionLevelName(Quiz.sQuestionLevel), GetOperationTypeName(Quiz.sOpType), Quiz.sNumberOfCorrectAnswer, Quiz.sNumberOfWrongAnswer, Quiz.sIsPass);

                this.Close();
                ShowOverAllResultForm();
                return;
            }

            MakebtnCheckPlayerAnswerDisabled();
            MakebtnNextQuestionEnabled();
            btnNextQuestion.Focus();
        }

        //------------------------------------------------//
        private void ShowNextQuestionInfo()
        {
            if (Quiz.CurrentQuestion == Quiz.sNumberOfQuestion)
            {
                EndTimer();
                MakebtnCheckPlayerAnswerDisabled();
                Quiz.sIsPass = IsPass(Quiz.sNumberOfCorrectAnswer, Quiz.sNumberOfWrongAnswer);
                frmMathGameShowFinalResults.GetOverAllResultInfo(Quiz.sNumberOfQuestion, GetQuestionLevelName(Quiz.sQuestionLevel), GetOperationTypeName(Quiz.sOpType), Quiz.sNumberOfCorrectAnswer, Quiz.sNumberOfWrongAnswer, Quiz.sIsPass);

                this.Close();
                ShowOverAllResultForm();
                return;
            }

            lblTimer.Text = "0";
            Quiz.CurrentQuestion++;
            lblCurrentQuestion.Text = (Quiz.CurrentQuestion).ToString();
            lblNumber1.Text = Quiz.sQuestion[Quiz.CurrentQuestion - 1].sNumber1.ToString();
            lblNumber2.Text = Quiz.sQuestion[Quiz.CurrentQuestion - 1].sNumber2.ToString();
            lblOpType.Text = GetOperationTypeSymbol(Quiz.sQuestion[Quiz.CurrentQuestion - 1].sOpType).ToString();

            //
            StartTimer();
        }
        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            txtPlayerAnswer.Text = "";

            ShowNextQuestionInfo();
            MakebtnNextQuestionDisabled();
            txtPlayerAnswer.Focus();
        }

        //------------------------------------------------//
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //------------------------------------------------//
        private void StartTimer()
        {
            Quiz.CountTimer = 0;
            timer1.Enabled = true;
        }

        private void EndTimer()
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Quiz.CountTimer++;
            lblTimer.Text = Quiz.CountTimer.ToString();

            if (Quiz.CountTimer == 10) 
            {
                EndTimer();
                MessageBox.Show("Time is Over!\nCorrect Answer is : " + Quiz.sQuestion[Quiz.CurrentQuestion - 1].sCorrectAnswer, "Wrong:", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Quiz.sNumberOfWrongAnswer++;
                lblNumberOfWrongAnswer.Text = Quiz.sNumberOfWrongAnswer.ToString();
                ShowNextQuestionInfo();
            }
        }

        //------------------------------------------------//
    }
}