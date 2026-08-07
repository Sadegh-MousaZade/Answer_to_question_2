using System.Data.OleDb;
using System.Runtime.InteropServices;

string dbPath = Path.Combine(Directory.GetCurrentDirectory(), "..", "irancell.accdb");
dbPath = Path.GetFullPath(dbPath);
string connStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath}";

if (!File.Exists(dbPath))
{
    Type? catalogType = Type.GetTypeFromProgID("ADOX.Catalog");
    if (catalogType == null)
    {
        Console.WriteLine("ADOX در دسترس نیست. Access Database Engine را نصب کنید.");
        return;
    }

    dynamic catalog = Activator.CreateInstance(catalogType)!;
    catalog.Create(connStr);
    Marshal.ReleaseComObject(catalog);
    Console.WriteLine("فایل irancell.accdb ساخته شد.");
}

using OleDbConnection conn = new OleDbConnection(connStr);
conn.Open();

try
{
    string sql = @"CREATE TABLE Customer (
        mobileNo   TEXT(11)  NOT NULL,
        firstName  TEXT(50),
        lastName   TEXT(50),
        fatherName TEXT(50),
        birthdate  DATETIME,
        meliCode   TEXT(10),
        CONSTRAINT PK_Customer PRIMARY KEY (mobileNo)
    )";

    using OleDbCommand cmd = new OleDbCommand(sql, conn);
    cmd.ExecuteNonQuery();
    Console.WriteLine("جدول Customer ساخته شد.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message.Contains("already exists") || ex.Message.Contains("موجود")
        ? "جدول Customer از قبل وجود دارد."
        : "خطا: " + ex.Message);
}
