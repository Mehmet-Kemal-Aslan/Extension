using Extension;
using System.Reflection;
 // Uses DateDifference extension to find difference between entered time and now.
DateTime date = new DateTime(2022, 5, 17, 11, 14, 25);
Console.WriteLine(date.DateDiffrence());

// Calls TableAttribute
DataBaseModel table = new DataBaseModel();
TableAttribute(table);
ColumnAttribute(table);

// Function to make table
static void TableAttribute(object table)
{
    Type type = table.GetType();
    var attr = type.GetCustomAttributes().ToList();
    foreach (var attribute in attr)
    {
        if (attribute is TableAttribute)
        {
            var Table = attribute as TableAttribute;
            string TableName = Table.Name;
            string[] TrChars = new[] { "Ç", "ç", "Ğ", "ğ", "ı", "İ", "Ö", "ö", "Ş", "ş", "Ü", "ü" };
            bool IsSpecialChar = TableName.Any(x => !Char.IsLetterOrDigit(x));
            bool IsTrChar = TrChars.Any(TableName.Contains);
            if( IsSpecialChar || IsTrChar)
            {
                Console.WriteLine("Enter a name does not contain Turkish or dpecial character");
            }
            else
            {
                Console.WriteLine("Table Name: " + TableName);
            }
        }
    }
}

// Function to make columns
static void ColumnAttribute(object table)
{
    var properties = typeof(DataBaseModel).GetProperties();
    foreach (var property in properties)
    {
        if (Attribute.IsDefined(property, typeof(ColumnAttribute)))
        {
            Console.WriteLine("Columns: " + property.GetCustomAttribute<ColumnAttribute>().Name + "," 
                + property.GetCustomAttribute<ColumnAttribute>().Type + "," 
                + property.GetCustomAttribute<ColumnAttribute>().Required);
        }
    }
}
