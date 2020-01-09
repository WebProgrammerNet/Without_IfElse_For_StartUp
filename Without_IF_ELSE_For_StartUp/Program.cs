using System;

namespace Without_IF_ELSE_For_StartUp
{
    class Program
    {
        static void Main(string[] args)

        {
    


            try
            {
                Console.WriteLine("Proqram Sizin 1-ci defe daxil etdiyiniz reqemin 2-ci defe daxil etdiyiniz reqemden boyuk olub - olmadigini yoxlayir!");

                var parametr = Convert.ToInt32(Console.ReadLine());
                var check = Convert.ToInt32(Console.ReadLine());

                #region 1-ci variant
                string result = parametr > check ? "Boyukdur" : parametr < check ?
                                "Kicikdir" : parametr == check ?
                                "Beraberdir" : "No result";
                Console.WriteLine(result);
                #endregion

                #region 2-ci variant              
                bool response = parametr > check ? Yes(true) : parametr < check ? No(true) : parametr == check ? Equal(true) : false;
                #endregion

                #region 3-ci variant
                var yes = parametr > check && Yes(true);
                var no = parametr < check && No(true);
                var equal = parametr == check && Equal(true);
                #endregion

            }
            catch (Exception)
            {

                Console.WriteLine("Zehmet olmasa Proqrami yeniden basladin. Yalniz tam  reqem daxil edin"); ;
            }

        }
        public static bool Yes(bool yes)
        {
            Console.WriteLine("Boyukdur");
            return yes;
        }

        public static bool No(bool no)
        {
            Console.WriteLine("Kicikdir");
            return no; 
        }
        public static bool Equal(bool equal)
        {
            Console.WriteLine("Beraberdir");
            return equal;
        }
    }
}
