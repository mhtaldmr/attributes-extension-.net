namespace MuhammetAliDemir.TP.Net.Hw2.Part1.CustomAttributes.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnIdentifierAttribute : Attribute
    {
        public string Name { get; }
        public string Type { get; }
        public bool IsRequired { get; }

        public ColumnIdentifierAttribute(string name, string type, bool isRequired)
        {
            Name = name;
            Type = type;
            IsRequired = isRequired;
        }
    }
}
