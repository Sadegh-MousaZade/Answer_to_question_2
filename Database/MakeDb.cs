using System;
using System.Data.OleDb;
using System.IO;
using System.Runtime.InteropServices;

string dbPath = Path.Combine(Directory.GetCurrentDirectory(), "irancell.accdb");
string connStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath}";

if (!File.Exists(dbPath)) {
    Type t = Type.GetTypeFromProgID("ADOX.Catalog")!;
    dynamic cat = Activator.CreateInstance(t)!;
    cat.Create(connStr);
    Marshal.ReleaseComObject(cat);
    Console.WriteLine("DB created");
}

using var conn = new OleDbConnection(connStr);
conn.Open();
try {
    using var cmd = new OleDbCommand(@"CREATE TABLE Customer (mobileNo TEXT(11) NOT NULL, firstName TEXT(50), lastName TEXT(50), fatherName TEXT(50), birthdate DATETIME, meliCode TEXT(10), CONSTRAINT PK_Customer PRIMARY KEY (mobileNo))", conn);
    cmd.ExecuteNonQuery();
    Console.WriteLine("Table created");
} catch (Exception ex) { Console.WriteLine(ex.Message); }
