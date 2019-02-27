using System.Threading.Tasks;
/**
 * 非同期処理
 */
namespace TestAppsAllRound.AsyncTest
{
    class AsyncClass
    {
        private readonly AsyncForm asyncForm = new AsyncForm();
        public void StartAsyncTask()
        {
            TaskSuccess();      //非同期の場合はすぐログフォームを起動してくれる。
            asyncForm.Task();   //ログフォームを起動する
        }

        //非同期処理メソッド
        private async void TaskSuccess()
        {
            await TaskDelay();     //何か重い処理をやる。
            asyncForm.Task(0);     //重い処理が終わるとログフォームにある結果表示メソッドを起動する。
        }

        //何か重い処理とする。
        private Task TaskDelay()
        {
            return Task.Delay(5000);
        }
    }
}
