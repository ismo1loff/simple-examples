class program
{ 
       static void Main(string[] args)
    {
        //Fibonachi(7);
        Console.WriteLine(IsPrime(3));
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
        }
