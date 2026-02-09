namespace ZAGENG_T4
{
    internal class Program
    {
        const string Feature = "AdminPanel";
        static readonly double AppVersion = 2.5;

        #region Q4
        public class User { public string Name; }      // reference type (Heap)
        public struct UserSnapshot
        {
            public string Name;
        } // value type (stack)
        static void Modify(User u, UserSnapshot s)
        {
            u.Name = "New";
            s.Name = "New";
        }

        static void ModifyWithRef(ref User u, ref UserSnapshot s)
        {
            u.Name = "RefModified";
            s.Name = "RefModified";
        } 
        #endregion


        static void Main(string[] args)
        {
            #region Q1
            //string framwork = RuntimeInformation.FrameworkDescription;
            //string OS = RuntimeInformation.OSDescription;
            //string CPU = RuntimeInformation.OSArchitecture.ToString();

            //string msg = framwork switch
            //{
            //    string r when r.Contains(".NET Core") || r.Contains(".NET 5") || r.Contains(".NET 6")
            //    || r.Contains(".NET 7") || r.Contains(".NET 8") => "Modern .NET Runtime",
            //    _ => "Legacy Runtime"
            //};
            //Console.WriteLine(framwork);
            //Console.WriteLine(OS);
            //Console.WriteLine(CPU);
            //Console.WriteLine(msg);
            #endregion

            #region Q3
            //List<int> numbers = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine();
            //Classification(numbers); 
            #endregion

            #region Q5

            //try
            //{
            //    Console.WriteLine("Starting ...");
            //    ProcessPayment(200, 300, false);
            //}
            //catch (InsufficientBalanceException ex)
            //{
            //    Console.WriteLine("Custom Error: " + ex.Message);
            //}

            //try
            //{
            //    Console.WriteLine("Starting ...");
            //    ProcessPayment(500, 300, false);
            //}
            //catch (PaymentTimeoutException ex2)
            //{
            //    Console.WriteLine("payment custom Error: " + ex2.Message);

            //}
            //finally
            //{
            //    Console.WriteLine("Operation Finished.");
            //} 
            #endregion


            #region Q4
            User u = new User { Name = "Old" };
            UserSnapshot s = new UserSnapshot { Name = "Old" };

            Modify(u, s);
            Console.WriteLine($"Normal - Class: {u.Name}, Struct: {s.Name}");

            ModifyWithRef(ref u, ref s);
            Console.WriteLine($"Ref - Class: {u.Name}, Struct: {s.Name}"); 
            #endregion

            #region Q2
            bool isEnabled = true;
            double minVersion = 3.0;

            if (isEnabled && AppVersion >= minVersion)
            {
                Console.WriteLine(Feature + " is Enabled");
            }
            else
            {
                Console.WriteLine(Feature + " is Disabled");
            }

            string status = (AppVersion >= minVersion) ? "Updated" : "Update Required";
            Console.WriteLine("Status: " + status);
            #endregion
        }
    }



    #region Q3
    //static void Classification(List<int> num)
    //{
    //    List<int> even = new List<int>();
    //    List<int> odd = new List<int>();
    //    List<int> prime = new List<int>();

    //    foreach (var number in num)
    //    {
    //        //I didn’t use else if, and I need a loop and a list, and I’m asking two existing questions.
    //        if (IsEven(number)) even.Add(number);
    //        else odd.Add(number);
    //        if (IsPrime(number)) prime.Add(number);
    //    }
    //    Console.WriteLine($"Even: {string.Join(',', even)}");
    //    Console.WriteLine($"Odd: {string.Join(',', odd)}");
    //    Console.WriteLine($"Prime: {string.Join(',', prime)}");

    //}
    //static bool IsEven(int n) => n % 2 == 0;
    //static bool IsPrime(int n)
    //{
    //    // hna ana 3mlt n<2 3l4an el prime m4 negative or 1 or 0 fa lw n<2 yb2a false
    //    // ana 3ml el root 3l4an a5tsr el msafa bdl ma em4y kolo ym4y ns el masafa
    //    // lw el root 2 return root 2 ana h2smha 3ala nfsaha 3ady or lw root 8  = 2.82 , ana h2smha brdo 3ala 2 ==> even
    //    if (n < 2) return false;
    //    for (int i = 2; i <= Math.Sqrt(n); i++) if (n % i == 0) return false;
    //    return true;
    //} 
    #endregion

    #region Q5
    //static void ProcessPayment(int balance, int price, bool IsServerDown)
    //{
    //    if (price > balance)
    //        throw new InsufficientBalanceException("Balance is not enough");
    //    // if IsServerDown == 1 == true da yb2a el server down lw 0 false f m4 hy54 asln
    //    if (IsServerDown)
    //        throw new PaymentTimeoutException("Server is down");

    //}

    #endregion





    #region Q5
    //internal class InsufficientBalanceException : Exception
    //{
    //    public InsufficientBalanceException(string msg) : base(msg) { }
    //}

    //internal class PaymentTimeoutException : Exception
    //{
    //    public PaymentTimeoutException(string msg) : base(msg) { }
    //} 
    #endregion
}


