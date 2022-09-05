using System;

namespace SwimingPool
{

    /// <summary>
    /// A class to test the swimming pool.
    /// </summary>
    class TestSwimmingPool
    {

        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            SwimmingPool pool = new SwimmingPool(100, 20, 5, 10, 0.1);
            Console.WriteLine("Swimming pool " + pool.SwimingPoolSize() + " Swimming pool (5000) " + pool.SwimingPoolSize(5000));
            Console.WriteLine("Fill the pool  " + pool.TimeToFill() + " Swimming pool (5000) " + pool.TimeToFill(5000));
            Console.WriteLine("Empty the pool  " + pool.TimeToEmpty() + " Swimming pool (5000) " + pool.TimeToEmpty(5000));


        }

    }
}
