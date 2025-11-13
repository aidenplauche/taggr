namespace TAGGR.Components.Models

{
    public class Card
    {
        public string Name { get; set; }

        // TODO: Add Tags
        public string Description { get; set; }

        public Card(string name, string description = "")
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}