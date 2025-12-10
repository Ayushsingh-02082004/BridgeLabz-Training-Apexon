using System;

public class Class1
{
    public class ResourceHolder : IDisposable
    {
        // To track whether Dispose has been called.
        private bool _disposed = false;
        // Constructor
        public ResourceHolder()
        {
            // Allocate or initialize an unmanaged resource.
            Console.WriteLine("Unmanaged resource allocated.");
        }
        // Implementing Dispose method from IDisposable interface
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); // Prevent finalizer from being called.
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Free any other managed objects here.
                    Console.WriteLine("Free other managed objects");
                }
                // Free unmanaged resources here.
                Console.WriteLine("Unmanaged resource released.");
                _disposed = true;
            }
        }
        // Finalizer is nothing but the destructor
        ~ResourceHolder()
        {
            Dispose(false);
            Console.WriteLine("Finalizer called.");
        }
    }
    //How to Use the above class
    class Program
    {
        //static void Main(string[] args)
        //{
        //    // Using the ResourceHolder with using statement
        //    using (var resourceHolder = new ResourceHolder())
        //    {
        //        // Use the resource...
        //    } // Dispose is called automatically when exiting the using block.
        //    // If not using 'using', dispose should be called manually.
        //    var anotherResourceHolder = new ResourceHolder();
        //    // Use the resource...
        //    anotherResourceHolder.Dispose();
        //    // Without calling Dispose, finalizer will be called by GC at some point.
        //    var finalResourceHolder = new ResourceHolder();
        //    // Use the resource...
        //    Console.ReadKey();
        //}
    }

}
