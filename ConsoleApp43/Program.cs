


#region   InternalMutex
//Mutex mutexObject = new Mutex();  ///bir nov lock/monitor mentiqi ile iwleyir  ad parametrsiz ctor ile yaratdiqda

//for (int i = 0; i < 5; i++)
//{
//    Thread myThread = new Thread(Count);

//    myThread.Name = "Thread " + i;
//    myThread.Start();
//}


//void Count()
//{
//    int x = 1;

//    mutexObject.WaitOne();

//    for (int i = 0; i < 9; i++)
//    {
//        Console.WriteLine($"{Thread.CurrentThread.Name} : {x++}");
//        Thread.Sleep(100);
//    }

//    mutexObject.ReleaseMutex();
//}
#endregion


#region  Muttex External Thread
//string mutexName = "Nazim";
//using var m = new Mutex(false, mutexName);


//if (m.WaitOne(15000))
//{
//    Console.WriteLine("Run some amazing code");
//    Console.ReadLine();
//    m.ReleaseMutex();
//}
//else
//{
//    Console.WriteLine("Second instance is running!");
//    Environment.Exit(0);
//}
#endregion


#region semaphore
//Semaphore semaphore = new Semaphore(3, 3, "SEMAPHORE");

//for (int i = 0; i < 6; i++)
//    ThreadPool.QueueUserWorkItem(SomeMethod, semaphore);


//Console.ReadKey();





//void SomeMethod(object? state)
//{
//    var semaphore = state as Semaphore;

//    if (semaphore is null)
//        return;


//    bool isFinish = false;

//    while (!isFinish)
//    {
//        if (semaphore.WaitOne(2000))
//        {
//            try
//            {
//                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} got the key");
//                Thread.Sleep(6000);
//            }
//            finally
//            {
//                isFinish = true;
//                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} returned the key");
//                semaphore.Release();
//            }
//        }
//        else
//        {
//            Console.WriteLine($"Mister Thread number {Thread.CurrentThread.ManagedThreadId}, we have not enough keys. Please wait ...");
//        }
//    }
//}
#endregion


#region Semaphore
//class Program
//{
//    private static Semaphore semaphore = new Semaphore(3, 3);
//    private static Random random = new Random();

//    static void Main()
//    {
//        Console.WriteLine("Başlangıç...");

//        // 10 iş parçacığı oluşturalım
//        for (int i = 0; i < 10; i++)
//        {
//            Thread thread = new Thread(AccessResource);
//            thread.Name = $"Thread {i + 1}";
//            thread.Start();
//        }

//        // Programı sonlandırmadan önce bekleyelim
//        Console.ReadLine();
//    }

//    private static void AccessResource()
//    {
//        Console.WriteLine($"{Thread.CurrentThread.Name} semaforu almaya çalışıyor...");
//        semaphore.WaitOne(); // Semaphore'dan izin al

//        Console.WriteLine($"{Thread.CurrentThread.Name} semaforu aldı.");

//        // Kaynağı kullanma simülasyonu (rastgele bir süre bekleme)
//        Thread.Sleep(random.Next(1000, 5000));

//        Console.WriteLine($"{Thread.CurrentThread.Name} semaforu bırakıyor.");
//        semaphore.Release(); // Semaphore'yu serbest bırak
//    }
//}
#endregion



#region SemaphorSlim
//SemaphoreSlim _semaSlim = new SemaphoreSlim(4);


//for (int i = 0; i < 16; i++)
//{
//    var name = "Thread " + i;
//    var seconds = 2 + 2 * i;

//    new Thread(() =>
//    {
//        AccessDatebase(name, seconds);
//    }).Start();
//}


//void AccessDatebase(string name, int seconds)
//{
//    Console.WriteLine($"{name} waits for access");
//    _semaSlim.Wait();
//    Console.WriteLine($"{name} is working on database...");
//    Thread.Sleep(seconds * 1000);
//    Console.WriteLine($"{name} is completed...");
//    _semaSlim.Release();
//}
#endregion