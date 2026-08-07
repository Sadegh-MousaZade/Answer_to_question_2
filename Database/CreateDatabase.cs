using System;
using System.Data.OleDb;
using System.IO;

class CreateDatabase
{
    static void Main()
    {
        string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "irancell.accdb");
        string connStr = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath}";

        if (!File.Exists(dbPath))
        {
            Type catalogType = Type.GetTypeFromProgID("ADOX.Catalog");
            dynamic catalog = Activator.CreateInstance(catalogType);
            catalog.Create(connStr);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(catalog);
            Console.WriteLine("فایل irancell.accdb ساخته شد.");
        }

        using (OleDbConnection conn = new OleDbConnection(connStr))
        {
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
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine("جدول Customer با موفقیت ساخته شد.");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("already exists") || ex.Message.Contains("موجود"))
                    Console.WriteLine("جدول Customer از قبل وجود دارد.");
                else
                    Console.WriteLine("خطا: " + ex.Message);
            }
        }
    }
}
