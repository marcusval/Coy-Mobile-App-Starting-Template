using System;
using System.Collections.Generic;
using System.Text;
using SQLite; 
namespace test2.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
