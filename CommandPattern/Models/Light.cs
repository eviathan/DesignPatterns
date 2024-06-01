namespace CommandPattern.Models
{
    public class LightReciever
    {
        public string Name { get; set; }

        public bool Enabled
        {
            get
            {
                return _enabled;
            }
            set
            {
                _enabled = value;
                Console.WriteLine($"Light {Name} was {(_enabled ? "enabled" : "disabled")}");
            }
        }

        private bool _enabled;

        public LightReciever(string name)
        {
            Name = name;
        }
    }
}