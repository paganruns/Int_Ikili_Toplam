internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Start();
        EndingApp();
    }

    public static void Start()
    {
        try
        {
            Console.WriteLine("\nSayılar ve uzunluğu çift sayıda olan bir dizi giriniz:");

            int[] intArray = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

            if(intArray.Length%2 == 1) 
            {
                Console.WriteLine("Lütfen dizi uzunluğunu çift sayıda giriniz");
                Start();
            }

            for (int i = 0; i < intArray.Length; i=i+2)
            {
                if(intArray[i] != intArray[i+1]) NonSame(intArray[i], intArray[i+1]);
                else if(intArray[i] == intArray[i+1]) Same(intArray[i], intArray[i+1]);
            }
        }
        catch (System.Exception)
        {
            ErrorMessage();
            Start();
        }    
    }

    public static void NonSame(int a, int b)
    {
        Console.Write("{0} ", a+b);
    }

    public static void Same(int a, int b)
    {
        Console.Write("{0} ", (a+b) * (a+b));
    }

    public static void ErrorMessage()
    {
        Console.WriteLine("Lütfen geçerli değer giriniz!");
    }

    public static void EndingApp()
    {
        Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz: \n" +
                          "********************************************************* \n" +
                          "(1) Programı sonlandır \n" +
                          "(2) Programı tekrar başlat \n");  

        string choice = Console.ReadLine();
        if(choice.Contains('1')) Environment.Exit(0);
        else if(choice.Contains('2')) Start();
        else {ErrorMessage(); EndingApp();}
    }

}