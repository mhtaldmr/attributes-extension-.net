using MuhammetAliDemir.TP.Net.Hw2.Part1.CustomAttributes.Attributes;
using MuhammetAliDemir.TP.Net.Hw2.Part1.Entity;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MuhammetAliDemir.TP.Net.Hw2.Part1.Attributes
{
    public class ScriptGenerator
    {
        public static string Generate(Student student)
        {
            var builder = new StringBuilder();
            Type type = typeof(Student);

            //TABLE ATTRIBUTES
            // Taking the table name from Class
            var attrTableName = type.GetCustomAttribute<TableIdentifierAttribute>().Name.ToString();

            //Adding a table name checker for Escaping from Turkish Characters
            var re = new Regex(@"^[a-zA-Z]*$");
            if( !re.IsMatch(attrTableName) )
                throw new CustomAttributeFormatException(attrTableName+ " is NOT Valid Table Name!");


            //COLUMN ATTRIBUTES
            //Taking the Id field Property Attributes
            var attrId = type.GetProperty(nameof(Student.Id)).GetCustomAttribute<ColumnIdentifierAttribute>();

            var propNameOfId = attrId.Name.ToString();
            var propTypeOfId = attrId.Type.ToString();
            var propIsRequiredAId = attrId.IsRequired ? "Required" : "Not Required";

            //Taking the Name field Property Attributes
            var attrName = type.GetProperty(nameof(Student.Name)).GetCustomAttribute<ColumnIdentifierAttribute>();

            var propNameOfName = attrName.Name.ToString();
            var propTypeOfName = attrName.Type.ToString();
            var propIsRequiredAName = attrName.IsRequired ? "Required" : "Not Required";

            //Printing the values into the Console
            return builder.Append($"Table Name : {attrTableName}")
                          .AppendLine()
                          .Append($"Column1 Name : {propNameOfId}, Type : {propTypeOfId}, RequiredorNot : {propIsRequiredAId}")
                          .AppendLine()
                          .Append($"Column2 Name : {propNameOfName}, Type : {propTypeOfName}, RequiredorNot : {propIsRequiredAName}")
                          .ToString();
        }
    }
}
