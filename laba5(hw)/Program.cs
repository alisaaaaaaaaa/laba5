using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace laba5_hw_
{
    class Program
    {
        static void Compare(int[] BBB, int[] SS)
        {
            int kol1 = 0;
            int kol2 = 0;
            for (int i = 0; i < BBB.Length; i++)
            {
                if (BBB[i] == 5)
                {
                    kol1++;
                }
            }
            for (int i = 0; i < BBB.Length; i++)
            {
                if (SS[i] == 5)
                {
                    kol2++;
                }
            }
            if (kol1 == kol2)
            {
                Console.WriteLine("Drinks All Round! Free Beers on Bjorg!");
            }
            else
            {
                Console.WriteLine("Ой, Бьорг - пончик! Ни для кого пива!");
            }
        }
        static int[] CreateArray(int[] array)
        {
            Random rnd = new Random();
            int el = rnd.Next(10);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = el;
            }
            return array;
        }
        public struct Granny
        {
            public string name;
            public int age;
            public List<string> diseases;
        }
        public struct Hospital
        {
            public string name;
            public List<string> diseases;
            public int capacity;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            //#1
            Console.WriteLine("Beer Task");
            int[] BBB = new int[10];
            int[] SS = new int[10];
            CreateArray(BBB);
            CreateArray(SS);
            Compare(BBB, SS);
            //#2
            Console.WriteLine("Image Task");
            Dictionary<int, string/*Image*/> img = new Dictionary<int, string/*Image*/>();

            for (int i = 1; i < 64; i++)
            {
                if (i % 32 == 0)
                {
                    img.Add(i, /*Image.FromFile*/($"{i % 33}.jpg"));
                }
                else
                {
                    img.Add(i, /*Image.FromFile*/($"{i % 32}.jpg"));
                }
            }
            img.Add(64, /*Image.FromFile*/("32.jpg"));

            foreach (var image in img)
            {
                Console.WriteLine(image.Key + " " + image.Value);
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 1; i <= 64; i++)
            {
                int swap = rand.Next(1, 64);
                var t = img[i];
                img[i] = img[swap];
                img[swap] = t;
            }
            foreach (var item in img)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.Read();
            Console.Clear();
            //#3
            Console.WriteLine("student task");
            var StudentList = new Dictionary<int, string>();
            StreamReader sr = File.OpenText("список студентов.txt");
            while (true)
            {
                string str = sr.ReadLine();
                if (str == null)
                    break;
                else
                {
                    string student = str.Split(';').Last();
                    StudentList.Add(1,student);
                }

                
            }
            sr.Close();
            Console.WriteLine("МЕНЮ");
            Console.WriteLine("Введите:");
            Console.WriteLine("Новый студент, чтобы добавить данные о новом студенте");
            Console.WriteLine("Удалить, чтобы удалить данные о студенте");
            Console.WriteLine("Выход, чтобы завершить работу программы");
            string stroka = Console.ReadLine();
            if (stroka.Equals("Новый студент"))
            {
                Console.WriteLine("Введите номер студента в списке");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите данные о студенте через запятую((фамилия, имя, год рождения, с каким экзаменом поступил, баллы)");
                string studentdata = Console.ReadLine();
                StudentList.Add(number, studentdata);
                Console.Write("Добавлен новый студент!");
            }
            else if (stroka.Equals("Удалить"))
            {
                Console.WriteLine("Введите номер студента, которого требуется удалить из списка");
                int number = Convert.ToInt32(Console.ReadLine());
                StudentList.Remove(number);
                Console.WriteLine("Студент удален!");
            }
            else if (stroka.Equals("Выход"))
            {
                Console.ReadKey();
            }
            //#4
            Console.WriteLine("Queue Task");
            //5
            Console.WriteLine("Grany Task");
            int count;
            Console.WriteLine("Введите кол-во больниц");
            while (!int.TryParse(Console.ReadLine(), out count) || count < 0)
            {
                Console.WriteLine("Неверный ввод!");
            }
            List<Hospital> hospitals = new List<Hospital>(count);

            for (int i = 0; i < count; i++)
            {
                Hospital hospital = new Hospital();
                Console.WriteLine("Введите название больницы");
                hospital.name = Console.ReadLine();
                Console.WriteLine("Введите вместимость больницы");
                while (!int.TryParse(Console.ReadLine(), out hospital.capacity) || hospital.capacity < 0)
                {
                    Console.WriteLine("Неверный ввод");
                }
                Console.WriteLine("Введите кол-во заболеваний которые лечит данная больница");
                int countOfDiseases;
                while (!int.TryParse(Console.ReadLine(), out countOfDiseases) || countOfDiseases < 0)
                {
                    Console.WriteLine("Неверный ввод");
                }
                hospital.diseases = new List<string>();
                for (int j = 0; j < countOfDiseases; j++)
                {
                    Console.WriteLine("Введите заболевание");
                    hospital.diseases.Add(Console.ReadLine());
                }
                hospitals.Add(hospital);
            }

            Console.WriteLine("Сколько бабуль?");
            while (!int.TryParse(Console.ReadLine(), out count) || count < 0)
            {
                Console.WriteLine("Неверный ввод!");
            }
            List<Granny> grannies = new List<Granny>(count);

            for (int i = 0; i < count; i++)
            {
                Granny granny = new Granny();
                Console.WriteLine("Введите имя бабушки");
                granny.name = Console.ReadLine();
                Console.WriteLine("Введите возраст бабушки");
                while (!int.TryParse(Console.ReadLine(), out granny.age) || granny.age < 0)
                {
                    Console.WriteLine("Неверный ввод");
                }
                Console.WriteLine("Сколько заболеваний у бабушки");
                int countOfDiseases;
                while (!int.TryParse(Console.ReadLine(), out countOfDiseases) || countOfDiseases < 0)
                {
                    Console.WriteLine("Неверный ввод");
                }
                granny.diseases = new List<string>();
                for (int j = 0; j < countOfDiseases; j++)
                {
                    Console.WriteLine("Введите заболевание");
                    granny.diseases.Add(Console.ReadLine());
                }
                grannies.Add(granny);
            }
            List<int> tempGrannies = new List<int>(hospitals.Count);
            for (int i = 0; i < tempGrannies.Count; i++)
            {
                tempGrannies[i] = 0;
            }

            int cryingGrannies = 0;
            for (int i = 0; i < grannies.Count; i++)
            {
                for (int j = 0; j < tempGrannies.Count; j++)
                {
                    if ((grannies[i].diseases.Count >= hospitals[j].diseases.Count / 2) && (tempGrannies[j] < hospitals[j].capacity))
                    {
                        Console.WriteLine($"Бабушка {grannies[i].name} лечится в {hospitals[j]}");
                        tempGrannies[j]++;
                    }
                    else if (grannies[i].diseases.Count == 0)
                    {
                        Console.WriteLine($"Бабушка {grannies[i].name} пришла просто спросить в больницу {hospitals[j]}");
                        tempGrannies[j]++;
                    }
                    else
                    {
                        Console.WriteLine($"Бабушка {grannies[i].name} осталась плакать");
                        cryingGrannies++;
                    }
                }
            }
            Console.WriteLine("Вы хотите вводить данные о сотрудниках в очереди вручную или считывать их из файла?(Y,N)");
            string answer = Console.ReadLine();
            if (answer == "Y")
            {

                Console.WriteLine("Введите данные о сотрудниках в порядке очереди");
                Console.WriteLine("для завершения введите exit");
                while (true)
                {
                    Console.WriteLine("Введите имя");
                    string name = Console.ReadLine();
                    if (name == "exit")
                    {
                        break;
                    }
                    Console.WriteLine("Введите должность");
                    string post = Console.ReadLine();
                    Console.WriteLine("Введите наглость");
                    int impudence = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите тупость");
                    int stupidy = Convert.ToInt32(Console.ReadLine());
                }
            }
            else
            {
                //считать с файла
            }
            Console.WriteLine("Введите информацию о столах");
            Console.WriteLine("для завершения введите exit");
            while (true)
            {
                Console.WriteLine("Введите цвет стола");
                string color = Console.ReadLine();
                if (color == "exit")
                {
                    break;
                }
                Console.WriteLine("Введите номер стола");
                int number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введите данные о знакомствах");
            Console.WriteLine("для завершения введите exit");
            while (true)
            {
                Console.WriteLine("Введите имя  должность первого сотрудника ( вася механик)");
                string name = Console.ReadLine();
                if (name == "exit")
                {
                    break;
                }
                Console.WriteLine("Введите имя  должность второго сотрудника");
                string name2 = Console.ReadLine();
            }
        }
    }
}


        

