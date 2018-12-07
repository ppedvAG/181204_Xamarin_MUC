using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatenSpeichernUndLaden
{
    public interface ISQLiteHelper
    {
        SQLiteConnection GetConnection();
    }
}
