namespace MuhammetAliDemir.TP.Net.Hw2.Part1.CustomAttributes.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TableIdentifierAttribute : Attribute
    {
        public string Name { get; }

        public TableIdentifierAttribute(string name)
        {
            Name = name;
        }
    }
}
