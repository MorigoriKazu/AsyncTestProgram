using System;
using System.Windows.Forms;
using TestAppsAllRound.AsyncTest;

namespace TestAppsAllRound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /**
         * 非同期型処理ボタン
         */ 
        private void Button1_ClickAsync(object sender, EventArgs e)
        {
            AsyncClass asyncClass = new AsyncClass();
            asyncClass.StartAsyncTask();
        }
        /**
         * 同期処理型ボタン
         */
        private void Button3_Click(object sender, EventArgs e)
        {
            StandardClass standardClass = new StandardClass();
            standardClass.StartStandardTask();
        }

        /**
         * 非同期処理時動作確認のためのボタン
         */
        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("何もしてない、非同期のどっちかなら動けるはずだ。");
        }


    }
}
