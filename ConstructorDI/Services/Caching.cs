namespace AddTransient.Services
{
    public class Caching
    {
        public string guid1 { get; set; }

        public Caching()
        {
            this.guid1 = Guid.NewGuid().ToString();
        }
    }
}
