using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    class Program
    {
        static void Write(string name, string surname, List<Time> times, Department Doctors, int id, int id_time)
        {
            using (FileStream fileStream = new FileStream("User's information", FileMode.Append))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.WriteLine($"Name - {name}");
                    streamWriter.WriteLine($"Surname - {surname}");
                    for (int i = 0; i < Doctors.doctors.Count; i++)
                    {
                        if (Doctors.doctors[i].Id == id)
                        {
                            streamWriter.WriteLine(Doctors.doctors[i]);
                        }
                    }
                    for (int i = 0; i < times.Count; i++)
                    {
                        if (times[i]._Id == id_time)
                        {
                            streamWriter.WriteLine(times[i]);
                        }
                    }
                    streamWriter.WriteLine();
                }
            }

        }
        static void Print()
        {
            Console.WriteLine("\n1)Pediatrics\n2)Travmatalogy\n3)Pediatrics\n");


        }
        static void MakeMeeting(Department dep, int choice, int id)
        {

            if (choice == 1)
            {
                dep.doctors[id].Meeting(choice);
            }
            else if (choice == 2)
            {
                dep.doctors[id].Meeting(choice);
            }
            else if (choice == 3)
            {
                dep.doctors[id].Meeting(choice);
            }
        }
        static void PrintDoctors(Department dep)
        {
            foreach (var item in dep.doctors)
            {
                Console.WriteLine(item);
            }
        }
        static void PrintTimes(Department dep, List<Time> times, int id)
        {
            Console.Clear();
            for (int i = 0; i < times.Count; i++)
            {
                if (dep.doctors[id].ReserveOrNot[i] == false)
                {
                    Console.WriteLine(times[i]);
                }
                else
                {
                    Console.WriteLine($"{times[i]} - Reserved");
                }
            }
        }
        static void Main(string[] args)
        {

            Pediatrics department = new Pediatrics
            {
                Departmenta = "Pediatriya",
                doctors = new List<Doctor> {

                    new Doctor {
                        Name = "Pablo",
                        Age = 21,
                        Surname = "Noteskabaro",
                        Workyear = 3

                    },
                    new Doctor {
                        Name = "Senano",
                        Age = 21,
                        Surname = "Elpacino",
                        Workyear = 3

                    }



                }
            };


            Travmatalogy department1 = new Travmatalogy
            {
                Departmenta = "Travmatalogiya",
                doctors = new List<Doctor> {
                    new Doctor {
                        Name = "Zauro",
                        Age = 21,
                        Surname = "Spriteooo",
                        Workyear = 3

                    },
                    new Doctor {
                        Name = "Arifoo",
                        Age = 21,
                        Surname = "Siqaret_Istiyenoo",
                        Workyear = 3

                    },
                    new Doctor {
                        Name = "Elguno",
                        Age = 21,
                        Surname = "KodYazanoo",
                        Workyear = 3
                    }
                }
            };
            Stamatology department2 = new Stamatology
            {
                Departmenta = "Pediatriya",
                doctors = new List<Doctor> {
                    new Doctor {
                        Name = "Resuloo",
                        Age = 21,
                        Surname = "SiqaretiTergizenooooo",
                        Workyear = 3

                    },
                    new Doctor {
                        Name = "Eminoo",
                        Age = 21,
                        Surname = "Glooooo",
                        Workyear = 3

                    },
                    new Doctor {
                        Name = "Mammamiyaoooo",
                        Age = 21,
                        Surname = "Kapucinooooooo",
                        Workyear = 3

                    },
                     new Doctor {
                        Name = "Johnoooo",
                        Age = 21,
                        Surname = "Johnluooooooo",
                        Workyear = 3

                    }



                }
            };


            List<Time> times = new List<Time>
           {
         new Time{
                Starts=new DateTime(2021,02,24,09,00,00),
                Ends=new DateTime(2021,02,24,11,00,00)
         },
          new Time{
                Starts=new DateTime(2021,02,24,12,00,00),
                Ends=new DateTime(2021,02,24,14,00,00)
         },
          new Time{
                Starts=new DateTime(2021,02,15,15,00,00),
                Ends=new DateTime(2021,02,24,17,00,00)
         }

            };

            while (true)
            {
                Console.WriteLine("Hello let me know some imformation about you.\nYour name: ");
                Console.Clear();
                Console.WriteLine("Enter your name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your surname: ");
                string surname = Console.ReadLine();
                Console.WriteLine("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your email: ");
                string email = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"Welcome {name} {surname}!");
                Console.WriteLine($"Okay mr/mrs {name} {surname}");
                string choice;
                int choiceDoc;
                int choiceTime;


                Print();
                choice = Console.ReadLine();

                Console.Clear();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Choose doctor you want to meet: ");
                        PrintDoctors(department);
                        choiceDoc = Convert.ToInt32(Console.ReadLine());

                        switch (choiceDoc)
                        {
                            case 1:
                                Console.Clear();
                                PrintTimes(department, times, 0);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(department, choiceTime, 0);
                                Write(name, surname, times, department, 0, choiceTime);

                                break;
                            case 2:
                                Console.Clear();
                                PrintTimes(department, times, 1);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(department, choiceTime, 1);
                                Write(name, surname, times, department, 1, choiceTime);
                                break;

                            default:
                                Console.Clear();
                                break;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Choose doctor you want to meet: ");
                        PrintDoctors(department1);
                        choiceDoc = Convert.ToInt32(Console.ReadLine());
                        switch (choiceDoc)
                        {
                            case 3:
                                Console.Clear();
                                PrintTimes(department1, times, 0);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(department1, choiceTime, 0);
                                Write(name, surname, times, department1, 0, choiceTime);
                                break;
                            case 4:
                                Console.Clear();
                                PrintTimes(department1, times, 1);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(department1, choiceTime, 1);
                                Write(name, surname, times, department1, 1, choiceTime);
                                break;
                            case 5:
                                Console.Clear();
                                PrintTimes(department1, times, 2);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(department1, choiceTime, 2);
                                Write(name, surname, times, department1, 2, choiceTime);
                                break;
                            case 6:
                                Console.Clear();
                                PrintTimes(department1, times, 3);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(department1, choiceTime, 3);
                                break;
                            default:
                                Console.Clear();
                                break;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Choose doctor you want to meet: ");
                        PrintDoctors(department2);
                        choiceDoc = Convert.ToInt32(Console.ReadLine());
                        switch (choiceDoc)
                        {
                            case 7:
                                Console.Clear();
                                PrintTimes(department2, times, 0);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(department2, choiceTime, 0);
                                break;
                            case 8:
                                Console.Clear();
                                PrintTimes(department2, times, 1);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(department2, choiceTime, 1);
                                break;
                            case 9:
                                Console.Clear();
                                PrintTimes(department2, times, 2);
                                Console.WriteLine("Choose time: ");
                                choiceTime = Convert.ToInt32(Console.ReadLine());
                                MakeMeeting(department2, choiceTime, 2);
                                break;
                            default:
                                Console.Clear();
                                break;
                        }
                        break;

                    default:
                        break;
                }


            }
        }
    }
}
