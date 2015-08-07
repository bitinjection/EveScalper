using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveScalper
{
    class StaticDataExport : IDisposable
    {
        private readonly string path;
        private readonly SQLiteConnection connection;

        public SQLiteConnection Connection
        {
            get { return this.connection; }
        }

        public StaticDataExport(string path)
        {
            this.path = path;

            string parameters = @"Data Source=" + path + ";Version=3";
            this.connection = new SQLiteConnection(parameters);
            this.connection.Open();
        }


        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    connection.Close();
                    connection.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }

}
