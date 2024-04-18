class program
{ 
       static void Main(string[] args)
    {
        string input;
        Console.WriteLine("Assalomu aleykum !");
        do
        {
        Console.WriteLine("1. Check out the Fibonacci numbers");
        Console.WriteLine("2. Check for depth");
        Console.WriteLine("3. Completion of the program");
        input = Console.ReadLine();
        switch(input)
        {
            case "1":
     {
        string nums = Console.ReadLine();
        int n = Convert.ToInt32(nums);

        Fibonachi(n);

     }    break;

        case "2":
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(IsPrime(n));

        IsPrime(n);

    }break;


        }
     }while(input != "3");
    }
       static bool IsPrime(int n)
    {
       int cnt = 0;
       for (int i = 1; i <= n; i++)
       {
        if(n % i == 0)
        {
            cnt++;
        }
       }
       if (cnt == 2) return true;
       return false; 
    }
        static void Fibonachi(int n)
    {
        int [] son = new int[n];
        son[0] = 0;
        son[1] = 1;
        for (int i = 2; i<n; i++)
        {
            son[i] = son[i-1] + son[i-2];
        }
        foreach(int num in son)
        {
            Console.Write(num + " ");
        }
    }
}
