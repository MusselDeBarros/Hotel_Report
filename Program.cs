using System;

namespace HotelReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10; //numbers of max rooms 

            GuestData[] info = new GuestData[i];

            Console.WriteLine("Write here the quantity of HotelGuests:");

            int n = int.Parse(Console.ReadLine());

            if (n <= i)
            {


                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Write here your name:");

                    string name = Console.ReadLine();

                    Console.WriteLine("Write here your email:");

                    string email = Console.ReadLine();

                    int room = j + 1;
        
                    info[j] = new GuestData { Name = name, Email = email, Room = room };

                   

                }

                for (int j = 0; j < n; j++)
                {



                   

                    Console.WriteLine("Rent:");
                    Console.WriteLine("Name:" + info[j].Name);
                    Console.WriteLine("Email:" + info[j].Email);
                    Console.WriteLine("Room:"+ info[j].Room.ToString());
                    Console.WriteLine();


                }



            }
            else
            {
                Console.WriteLine("There are no rooms available for this number of students.");
            }
        }
    }
}
