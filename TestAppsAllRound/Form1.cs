using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestAppsAllRound.AsyncTest;

namespace TestAppsAllRound
{
    public partial class Form1 : Form
    {
        private readonly AsyncForm asyncForm = new AsyncForm();

        public Form1()
        {
            InitializeComponent();
        }
        /**
         * 非同期型処理ボタン
         */ 
        private async void Button1_ClickAsync(object sender, EventArgs e)
        {
            AsyncClass asyncClass = new AsyncClass();
            asyncForm.Task();
            int result = await asyncClass.TaskStart();
            asyncForm.Task(result);
        }
        /**
         * 非同期型処理ボタン:GUI以外の処理が2つ以上になる場合
         */
        private async void Button4_ClickAsync(object sender, EventArgs e)
        {
            AsyncClass asyncClass = new AsyncClass();
            asyncForm.Task();
            int[] result = await Task.WhenAll(asyncClass.TaskStart(), asyncClass.TaskStart());
            asyncForm.Task(result[0]);
        }
        /**
         * 同期処理型ボタン
         */
        private void Button3_Click(object sender, EventArgs e)
        {
            StandardClass standardClass = new StandardClass();
            asyncForm.Task();
            int result = standardClass.TaskStart();
            asyncForm.Task(result);
        }

        /**
         * 非同期処理時動作確認のためのボタン
         * 非同期処理や何もしていない場合のみ起動する。
         */
        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("何もしてない、非同期のどっちかなら動けるはずだ。");
        }


    }
}
