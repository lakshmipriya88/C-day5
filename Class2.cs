using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    //implementing disposse pattern
    public class Customer : IDisposable
    {
        private stringreader _reader;
        //to detect deduntant calls
        private bool disposed = false;
        public Customer(string value)
        {
            this._reader = new stringreader(value);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (_reader != null)
                    {
                        this._reader.Dispose();
                    }
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
    class sample
    {
        public static void Main()
        {
            Customer c = new Customer("sample");

        }
    }
}
}
