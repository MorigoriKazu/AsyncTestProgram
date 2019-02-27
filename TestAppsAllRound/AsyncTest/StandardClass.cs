using System.Threading;
/**
 * 同期処理
 */
namespace TestAppsAllRound.AsyncTest
{
    class StandardClass
    {
        //同期処理メソッド
        public int TaskStart()
        {
            return TaskDelay();
        }

        //何か重い処理とする。
        private int TaskDelay()
        {
            Thread.Sleep(5000);
            return 0;
        }
    }
}
