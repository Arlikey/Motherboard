namespace Motherboard
{
    /*internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Processor processor = new Processor() { Cores = 6, HHz = 3.5f };
                Videocard videocard = new Videocard() { Size = 4 };
                RAM ram = new RAM() { Size = 16 };
                HDD hdd = new HDD() { Size = 2 };
                Motherboard motherboard = new Motherboard(processor, ram, hdd, videocard);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }

        }

        public class Motherboard
        {
            public Motherboard(Processor processor, RAM ram, HDD hdd, Videocard videocard)
            {
                this.processor = processor;
                this.ram = ram;
                this.hdd = hdd;
                this.videocard = videocard;
            }

            private Processor processor;
            public Processor Processor
            {
                get => processor;
                set => processor = value;
            }
            private RAM ram;
            public RAM RAM
            {
                get => ram;
                set => ram = value;
            }
            private HDD hdd;
            public HDD HDD
            {
                get => hdd;
                set => hdd = value;
            }
            private Videocard videocard;

            public Videocard Videocard
            {
                get => videocard;
                set => videocard = value;
            }


        }

        public class Processor
        {
            private float hhz;
            public float HHz
            {
                get => hhz;
                set => hhz = value >= 1 && value <= 4 ? value : throw new Exception("Недопустимое значение тактовой частоты процессора!");
            }
            private int cores;
            public int Cores
            {
                get => cores;
                set => cores = value >= 2 && value <= 16 ? value : throw new Exception("Недопустимое значение количества ядер!");
            }
        }

        public class RAM
        {
            private int size;
            public int Size
            {
                get => size;
                set => size = value >= 2 && value <= 128 ? value : throw new Exception("Недопустимое значение объема оперативной памяти!");
            }
        }

        public class HDD
        {
            private int size;
            public int Size
            {
                get => size;
                set => size = value >= 200 && value <= 16_000 ? value : throw new Exception("Недопустимое значение объема жесткого диска!");
            }
        }

        public class Videocard
        {
            private int size;
            public int Size
            {
                get => size;
                set => size = value >= 2 && value <= 24 ? value : throw new Exception("Недопустимое значение объема видеопамяти!");
            }
        }
    }*/

    /*public class AdditionalTask1
    {
        static void Main()
        {
            Random random = new Random();
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 10);
            }

            int x = -1, y = -1;

            int sum = -1;
            try
            {
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

                sum = array[x] + array[y];
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine(sum);
            }
        }
    }*/

    /*public class AdditionalTask4
    {
        static void Main()
        {
            short variable = 1;

            try
            {
                while (true)
                {
                    checked
                    {
                        variable++;
                    }
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }*/

    /*public class AdditionalTask5
    {
        static void Main()
        {
            short[] array = new short[5];

            string str = null;

            try
            {
                int index;

                Console.Write("Введите индекс массива: ");
                index = int.Parse(Console.ReadLine());
                
                Console.Write("Введите значение: ");
                int a = int.Parse(Console.ReadLine());
                
                array[index] = checked((short)a);

                array[index] /= (short)a;

                Console.WriteLine(str.Length);

            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }
    }*/

    /*public class AdditionalTask7
    {
        static void Main()
        {
            decimal variable = -1;
            try
            {
                EnterNumber(ref variable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
        }

        public static void EnterNumber(ref decimal variable)
        {
            try
            {
                variable = decimal.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }*/
}
