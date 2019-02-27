using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * ログフォーム
 */ 
namespace TestAppsAllRound.AsyncTest
{
    public partial class AsyncForm : Form
    {
        public AsyncForm()
        {
            InitializeComponent();
            button1.Visible = false;
        }

        public void Task(int decision = 9)
        {
            switch (decision)
            {
                case 0:     //処理後成功の表示
                    CompleteTask();
                    break;
                case 1:     //処理後失敗の表示
                    FailedTask();
                    break;
                default:    //処理中の表示
                    WaitTask();
                    Show();
                    break;
            }
        }

        private void WaitTask()
        {
            label1.Text = "処理中ですしばらくお待ちください。";
        }

        private void FailedTask()
        {
            label1.Text = "処理に失敗しました。";
            button1.Visible = true;
        }

        private void CompleteTask()
        {
            label1.Text = "処理が完了しました。";
            button1.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
