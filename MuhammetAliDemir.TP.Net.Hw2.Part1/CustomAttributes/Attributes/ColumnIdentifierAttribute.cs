namespace MuhammetAliDemir.TP.Net.Hw2.Part1.CustomAttributes.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnIdentifierAttribute : Attribute
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsRequired { get; set; }

        public ColumnIdentifierAttribute(string name, string type, bool isRequired)
        {
            Name = name;
            Type = type;
            IsRequired = isRequired;
        }
    }
}
