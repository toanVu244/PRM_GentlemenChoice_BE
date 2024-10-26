using GentlemenChoice_BAL.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GentlemenChoice_BAL.Service.Interface
{
    public interface IPaymentService
    {
        Task<PaymentResponse> CreatePayment(PaymentRequest paymentRequest);
    }
}
