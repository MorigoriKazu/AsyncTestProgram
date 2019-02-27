using System.Threading;
/**
 * 同期処理
 */
namespace TestAppsAllRound.AsyncTest
{
    class StandardClass
    {
        private readonly AsyncForm asyncForm = new AsyncForm();

        public void StartStandardTask()
        {
            TaskSuccess();      //同期型処理の場合は何か重い処理をしないとログフォームが起動しない。
            asyncForm.Task();   //ログフォームを起動する
        }

        //同期処理メソッド
        private void TaskSuccess()
        {
            TaskDelay();
            asyncForm.Task(0);  //起動したログフォームのラベルに結果を表示させる。
        }

        //何か重い処理とする。
        private void TaskDelay()
        {
            Thread.Sleep(5000);
        }
    }
}
