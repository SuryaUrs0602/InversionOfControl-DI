namespace AddTransient.Services
{
    public class HitCounters
    {
        public string guid2 { get; set; }

        public HitCounters()
        {
            this.guid2 = Guid.NewGuid().ToString();
        }
    }
}
