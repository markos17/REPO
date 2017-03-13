namespace ch10WelcomeToSloppyJoes
{
    internal class MenuItem
    {
        public string Meat { get; set; }
        public string Condiment { get; set; }
        public string Bread { get; set; }

        public MenuItem(string meat, string condiment, string bread)
        {
            this.Meat = meat;
            this.Condiment = condiment;
            this.Bread = bread;
        }

        public override string ToString()
        {
            return Meat + " with " + Condiment + " on " + Bread;
        }
    }
}