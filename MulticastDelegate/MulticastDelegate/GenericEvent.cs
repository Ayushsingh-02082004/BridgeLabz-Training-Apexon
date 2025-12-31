using System;
using System.Collections.Generic;
using System.Text;

namespace MulticastDelegate
{

    // STEP 1: Custom EventArgs (data to send)
    public class PaymentEventArgs : EventArgs
    {
        public int Amount { get; set; }
        public string Status {get; set; }
    }

    // STEP 2: Publisher class (raises the event)
    public class PaymentService
    {
        public event EventHandler<PaymentEventArgs> PaymentProcessed;  //event

        public void ProcessPayment(int amount)
        {
            //Business Logic
            Console.WriteLine("Processing Payment...");

            // STEP 3: Raise event
            PaymentProcessed.Invoke(this, new PaymentEventArgs
            {
                Amount = amount,
                Status = "Success"
            });


        }
    }

    // STEP 4: Subscriber
    class progam
    {
        static void Main()
        {
            PaymentService service = new PaymentService();

            // Subscribe to the event
            service.PaymentProcessed += Service_PaymentProcessed;

            service.ProcessPayment(5000);

            Console.ReadKey();
        }

        // STEP 5: Event Handler method
        static void Service_PaymentProcessed(object sender, PaymentEventArgs e)
        {
            Console.WriteLine(
                $"Payment {e.Status} | Amount: {e.Amount}"
            );
        }
    }
}
