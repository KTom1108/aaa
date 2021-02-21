namespace BlazorApp2.Data
{
    public class CommonService
    {
        public void SetLoadingTime(int loadingTime) {
            System.Threading.Thread.Sleep(loadingTime);
        }
    }
}
