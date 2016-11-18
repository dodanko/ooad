using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAD_Assignment03
{
    public partial class CapturePaymentResult
    {
        public CapturePaymentResult()
        {
            this.Errors = new List<string>();
        }

        public bool Success
        {
            get { return (!this.Errors.Any()); }
        }

        public IList<string> Errors { get; set; }
        public string CaptureTransactionId { get; set; }
        public string CaptureTransactionResult { get; set; }
    }
}
