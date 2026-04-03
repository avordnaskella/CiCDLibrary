namespace CICDLibrary
{
    public class Class1
    {
        public static void SystemDateTime()
        {
            try
            {
                DateTime dateTimeNow = DateTime.Now;
                Console.WriteLine(dateTimeNow);
            }
            catch { Console.WriteLine("Скорей всего у вас ошибка синхронизации даты и времени. Убедитесь, что дата и время на вашем компьютере совпадает с текущим"); }
        }

        public static void InformationDateTime()
        {
            DateTime dateTimeNow = DateTime.Now;
            if (dateTimeNow > DateTime.MinValue)
            {
                Console.WriteLine($"{dateTimeNow.ToString("D")}");
                Console.WriteLine($"{dateTimeNow.ToString("d")}");
                Console.WriteLine($"{dateTimeNow.ToString("F")}");
                Console.WriteLine($"{dateTimeNow:f}");
                Console.WriteLine($"{dateTimeNow:G}");
                Console.WriteLine($"{dateTimeNow:g}");
                Console.WriteLine($"{dateTimeNow:M}");
                Console.WriteLine($"{dateTimeNow:O}");
                Console.WriteLine($"{dateTimeNow:o}");
                Console.WriteLine($"{dateTimeNow:R}");
                Console.WriteLine($"{dateTimeNow:s}");
                Console.WriteLine($"{dateTimeNow:T}");
                Console.WriteLine($"{dateTimeNow:t}");
                Console.WriteLine($"{dateTimeNow:U}");
                Console.WriteLine($"{dateTimeNow:u}");
                Console.WriteLine($"{dateTimeNow:Y}");
            }
            else
            {
                Console.WriteLine("Ваше время оказалось меньше, чем 00:00:00.0000000 UTC 1 января 0001 г. в григорианском календаре. Значения даты и времени всегда хранятся в формате UTC на сервере. Вы можете просмотреть необработанное значение на сервере ");
            }
        }

        public static void WorkTimeSpan()
        {

            Console.WriteLine("Введите количество часов");
            string? hours = Console.ReadLine();

            Console.WriteLine("Введите количество минут");
            string? minuts = Console.ReadLine();

            Console.WriteLine("Введите количество секунд");
            string? seconds = Console.ReadLine();

            DateTime dateTimeNow = DateTime.Now;


            if (int.TryParse(hours, out int x) && (int.TryParse(minuts, out int y)) && (int.TryParse(minuts, out int z)))
            {

                Console.WriteLine("+ TimeSpan");
                TimeSpan timeSpan = new TimeSpan(x, y, z);
                DateTime dateTimeNow2 = dateTimeNow + timeSpan;
                Console.WriteLine(dateTimeNow2);
                Console.WriteLine("- TimeSpan");
                DateTime dateTimeNow22 = dateTimeNow - timeSpan;
                Console.WriteLine(dateTimeNow22);

            }
            else
            {
                Console.WriteLine("Вы ввели не целое число или вообще не число");
            }



        }

        public static void DateDirthday()
        {
            Console.WriteLine("Введите ваш год рождения");
            string yearBirth = Console.ReadLine();
            Console.WriteLine("Введите ваш месяц рождения");
            string monthBirth = Console.ReadLine();
            Console.WriteLine();
            string dayBirth = Console.ReadLine();







            if (int.TryParse(yearBirth, out int x) && (int.TryParse(monthBirth, out int y)) && (int.TryParse(dayBirth, out int z)) && ((x <= 1900) && (y <= 1900) && (z <= 1900)))
            {
                DateTime today = DateTime.Today;
                DateTime myDay = new DateTime(x, y, z);

                int age = today.Year - myDay.Year;



                int month = today.Month - myDay.Month;
                if (month < 0)
                {
                    age = age - 1;
                    month = 13 + month;
                }


                int day = today.Day - myDay.Day;
                if (day < 0)
                {
                    month = month - 1;
                    day = DateTime.DaysInMonth(myDay.Year, myDay.Month) + day;
                }
                Console.WriteLine($"{age} лет {month} месяцев {day} дней");


            }
            else
            {
                Console.WriteLine("Вы ввели не целое число или вообще не число или ваши данные о дате рождения некорректны");
            }
        }

    }
}
