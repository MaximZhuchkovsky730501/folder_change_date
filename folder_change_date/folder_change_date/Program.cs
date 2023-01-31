
namespace folder_change_date
{
    class Programm
    {
        static void Main(string[] args)
        {
            string folder = "\\\\localhost\\temp folder";
            int minutes = 1;
            while (true)
            {
                DateTime change_time = Directory.GetLastWriteTime(folder);
                DateTime now_time = DateTime.Now;
                if (change_time.AddMinutes(minutes) < now_time)
                {
                    Console.WriteLine(change_time.ToString());
                }
            }
        }
    }
}