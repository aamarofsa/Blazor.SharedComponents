namespace Base
{
    public class CounterBase : ComponentBase
    {
        [Parameter]
        public string Title { get; set; } = string.Empty;
        public int currentCount { get; set; } = 0;

        public void IncrementCount()
        {
            currentCount++;
        }
    }
}