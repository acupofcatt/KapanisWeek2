namespace KendimiTestEdiyorumWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //hangi metodu çağırmak istiyorsak onu yazıp çağırabiliriz
        }

        /// <summary>
        /// Çıktıyı yazan program
        /// </summary>
        private static void Soru1()
        {
            Console.WriteLine("Merhaba");
            Console.WriteLine("Nasılsın?");
            Console.WriteLine("İyiyim");
            Console.WriteLine("Sen Nasılsın?");
        }

        /// <summary>
        /// Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
        /// </summary>
        private static void Soru2()
        {
            int i = 357;
            string s = "Kediler";

            Console.WriteLine($"Tam sayı: {i}");
            Console.WriteLine($"Metin: {s}");
        }

        /// <summary>
        /// Rastgele bir sayı üretip , ekrana yazdırınız.
        /// </summary>
        private static void Soru3()
        {
            Random rand = new Random();
            int randomNumber = rand.Next();
            Console.WriteLine($"Sayı: {randomNumber}");
        }

        /// <summary>
        /// Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
        /// </summary>
        private static void Soru4()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(); //random sayı üretiyoruz
            int mode = randomNumber % 3;

            Console.WriteLine($"Sayı: {randomNumber}");
            Console.WriteLine($"3'e bölümünden kalan: {mode}");
        }

        /// <summary>
        /// Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
        /// </summary>
        private static void Soru5()
        {
            int number = 0;

            string? age;
            do
            {
                Console.WriteLine("Lütfen yaşınızı giriniz:");
                age = Console.ReadLine(); // Kullanıcıdan string olarak veri alır

                if (string.IsNullOrEmpty(age)) //kullanıcının null değer girmesi durumunda uyarı oluşturdum
                {
                    Console.WriteLine("Lütfen geçerli bir sayı değeri giriniz.");
                }
                else if (!int.TryParse(age, out number)) //int dönüşümü kontrolü
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen bir tam sayı girin."); //int olmadıysa hata ver
                }
            } while (number <= 0);

            if (number >= 18) 
            {
                Console.WriteLine("+"); //18den büyükse + yazar
            }
            else
            {
                Console.WriteLine("-"); //değilse - yazar
            }
        }

        /// <summary>
        /// Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
        /// </summary>
        private static void Soru6()
        {
            for (int i = 0; i < 10; i++) //10 kez döngüde kalması için
            {
                Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
            }
        }

        /// <summary>
        /// Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
        /// </summary>
        private static void Soru7()
        {
            void YerleriDegistir(ref string a, ref string b) //ref olarak atama yaptım ki değerler döngü dışında da atansın
            {
                string temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine("Birinci İsim:");
            string input1 = "Gülse Birsel";

            Console.WriteLine("İkinci isim:");
            string input2 = "Demet Evgar";

            YerleriDegistir(ref input1, ref input2);

            Console.WriteLine($"Birinci isim: {input1}");
            Console.WriteLine($"İkinci isim: {input2}");
        }

        /// <summary>
        /// Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
        /// </summary>
        private static void Soru8()
        {
            BenDegerDondurmem();

            void BenDegerDondurmem()
            {
                Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
            }
        }

        /// <summary>
        /// İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
        /// </summary>
        private static void Soru9()
        {
            static int toplam(int x, int y)
            {
                return x + y;
            }
        }

        /// <summary>
        /// Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
        /// </summary>
        private static void Soru10()
        {
            bool input;
            Console.WriteLine("Lütfen true ya da false giriniz:");

            while (!bool.TryParse(Console.ReadLine(), out input))
            {
                Console.Write("Lütfen true ya da false giriniz: ");
            }

            string result = TrueFalseToString(input);
            Console.WriteLine(result);

            static string TrueFalseToString(bool value)
            {
                if (value)
                {
                    return "Kullanıcı true girdi.";
                }

                return "Kullanıcı false girdi.";
            }
        }

        /// <summary>
        /// 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
        /// </summary>
        private static void Soru11()
        {
            Console.Write("Birinci kişinin yaşını girin: ");
            int age1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci kişinin yaşını girin: ");
            int age2 = int.Parse(Console.ReadLine());

            Console.Write("Üçüncü kişinin yaşını girin: ");
            int age3 = int.Parse(Console.ReadLine());

            int max = Older(age1, age2, age3);
            Console.WriteLine($"En yaşlı kişi {max} yaşındadır");

            static int Older(int age1, int age2, int age3)
            {
                int max = Math.Max(age1, Math.Max(age2, age3));
                return max;
            }
        }

        /// <summary>
        /// Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
        /// </summary>
        private static void Soru12()
        {
            Console.WriteLine("İstediğiniz sayıda sayı girebilirsiniz. Sayı girmeniz bittiğinde 0'a basabilirsiniz.");
            int max = 0;
            int number = 0;

            do
            {
                Console.WriteLine("Sayı: ");
                number = int.Parse(Console.ReadLine());

                MaxReturn(number, ref max);
            } while (number != 0);

            Console.WriteLine($"En büyük sayı değeri: {max} ");

            static int MaxReturn(int number, ref int max)
            {
                max = Math.Max(max, number);
                return max;
            }
        }

        /// <summary>
        /// Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
        /// </summary>
        private static void Soru13()
        {
            void YerleriDegistir(ref string a, ref string b)
            {
                string temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine("Lütfen birinci ismi giriniz:");
            string input1 = Console.ReadLine();

            Console.WriteLine("Lütfen ikinci ismi giriniz:");
            string input2 = Console.ReadLine();

            YerleriDegistir(ref input1, ref input2);

            Console.WriteLine($"Birinci isim: {input1}");
            Console.WriteLine($"İkinci isim: {input2}");
        }

        /// <summary>
        /// Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
        /// </summary>
        private static void Soru14()
        {
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int input = int.Parse(Console.ReadLine());

            bool tekCift = TekCift(input);

            if (tekCift) //if için koşul kontrolü yaparken içerideki değeri true mu diye kontrol edip işleme devam ediyor. bu aslında tekCift == true demek
            {
                Console.WriteLine("Seçtiğiniz sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Seçtiğiniz sayı tektir.");
            }

            static bool TekCift(int number)
            {
                return number % 2 == 0; //sayı iki ile bölünüyorsa true döndürür
            }
        }

        /// <summary>
        /// Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
        /// </summary>
        private static void Soru15()
        {
            Console.WriteLine("Ortalama hızınız saatte kaç km?: ");
            int speed = int.Parse(Console.ReadLine() ??
                                  "0"); // ?? null kontrolü yapar nullsa ardından eklenen karakteri atar

            Console.WriteLine("Yolculuk süresi kaç saat?: ");
            int time = int.Parse(Console.ReadLine() ?? "0");

            int length = Road(speed, time);

            Console.WriteLine($"Toplam yol uzunluğunuz {length} km.");

            static int Road(int speed, int time)
            {
                return speed * time;
            }
        }

        /// <summary>
        ///  Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
        /// </summary>
        private static void Soru16()
        {
            static double AreaOfCircle(int radius)
            {
                double area = Math.Pow(radius, 2) * Double.Pi;
                return area;
            }
        }

        /// <summary>
        /// "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
        /// </summary>
        private static void Soru17()
        {
            string sentence = "Zaman bir GeRi SayIm";
            string lowerSentence = sentence.ToLower();
            string upperSentence = sentence.ToUpper();
            Console.WriteLine(lowerSentence);
            Console.WriteLine(upperSentence);
        }

        /// <summary>
        /// "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
        /// </summary>
        private static void Soru18()
        {
            string text = "    Selamlar   ";
            string trimmedText = text.Trim();
            text = text.Trim(); //kalıcı olması için tekrar atama yaptım

            Console.WriteLine(text);
        }
    }
}