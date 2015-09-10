using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace EveScalper
{
    interface IStaticDataExport
    {
        SQLiteConnection Connection { get; }

        void Dispose();
        IReadOnlyList<int> inventoryIds();
        IReadOnlyList<Tuple<string, int>> systemList();
    }
}