using System.Threading.Tasks;
/**
 * 非同期処理
 */
namespace TestAppsAllRound.AsyncTest
{
    class AsyncClass
    {
        //非同期処理メソッド
        internal async Task<int> TaskStart()
        {
            return await TaskDelay();     //何か重い処理をやる。
        }

        //何か重い処理とする。
        private async Task<int> TaskDelay()
        {
            await Task.Delay(5000);
            return 0;
        }
    }
}
