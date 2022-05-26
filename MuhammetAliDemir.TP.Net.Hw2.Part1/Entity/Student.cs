using MuhammetAliDemir.TP.Net.Hw2.Part1.CustomAttributes.Attributes;

namespace MuhammetAliDemir.TP.Net.Hw2.Part1.Entity
{
    [TableIdentifier("Student")]
    public class Student
    {
        [ColumnIdentifier("Id", "int", isRequired: true)]
        public int Id { get; set; }
        [ColumnIdentifier("Name", "string", isRequired: false)]
        public string Name { get; set; }
    }
}
