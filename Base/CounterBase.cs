namespace Base
{
    public class CounterBase : ComponentBase
    {
        public int currentCount { get; set; } = 0;

        public void IncrementCount()
        {
            currentCount++;
        }
    }
}