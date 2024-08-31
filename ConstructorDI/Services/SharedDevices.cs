namespace AddTransient.Services
{
    public class SharedDevices
    {
        public string guid { get; set; }

        public SharedDevices()
        {
            this.guid = Guid.NewGuid().ToString();
        }
    }
}
