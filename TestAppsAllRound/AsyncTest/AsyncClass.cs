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
            TaskSuccess();
            asyncForm.Task();
        }

        //非同期処理メソッド
        private async void TaskSuccess()
        {
            await TaskDelay();
            asyncForm.Task(0);
        }

        //何か重い処理とする。
        private Task TaskDelay()
        {
            return Task.Delay(5000);
        }
    }
}
