using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Context
{
    public class Mechanic : IDisposable
    {
        public bool _isDisposed = false;
        public string mechanicID { get; set; }
        public string fullName { get; set; }
        public string phoneNumber { get; set; }
        public int experience { get; set; }

        protected virtual void Dispose(bool disposing)
        {
            // check if already disposed 
            if (!_isDisposed)
            {
                // set the bool value to true 
                _isDisposed = true;
            }
        }
        public void Dispose()
        {
            // Invoke the above virtual 
            // dispose(bool disposing) method 
            Dispose(disposing: true);

            // Notify the garbage collector 
            // about the cleaning event 
            GC.SuppressFinalize(this);
        }
        public Mechanic(string mechanicID, string fullName, string phoneNumber, int experience)
        {
            this.mechanicID = mechanicID;
            this.fullName = fullName;
            this.phoneNumber = phoneNumber;
            this.experience = experience;
        }
    }
}
