using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_1.Context;

namespace Project_1
{
    public class Request : IDisposable
    {
        public bool _isDisposed = false;
        public string requestID { get; set; }
        public DateTime date { get; set; }
        public float weight { get; set; }
        public float volume { get; set; }
        public float distance { get; set; }
        public int quantity { get; set; }
        public string fullName { get; set; }
        public string phoneNumber { get; set; }
        public Status status { get; set; }
        public string mechanicID { get; set; }
        public Context.Type type { get; set; }
        public DateTime completionDate { get; set; }

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
        public Request(string requestID, DateTime date, float weight, float volume, float distance, int quantity, string fullName, string phoneNumber, Status status, Context.Type type)
        {
            this.requestID = requestID;
            this.date = date;
            this.weight = weight;
            this.volume = volume;
            this.distance = distance;
            this.quantity = quantity;
            this.fullName = fullName;
            this.phoneNumber = phoneNumber;
            this.status = status;
            this.type = type;
        }
    }
}
