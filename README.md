# KapsullemeDemo

**_Bilindiği gibi C# nesneye dayalı bir programlama dilidir. Kapsülleme (Encapsulation) kavramı bir nesnenin bazı özellik ve işlevlerini başka sınıflardan ve nesnelerden saklamaktır. Private erişim belirteci sayesinde bu şekilde tanımlanan bir field’ i başka sınıflardan gizlemiş oluruz. Ayrıca bu field başka sınıflarda kullanılamaz.

Kapsülleme (Encapsulation) sayesinde nesneler bilinçsiz kullanımdan korunmuş olur. Fakat bazı durumlarda private field’ lara erişmemiz ve özelliklerini kullanmamız gerekebilir. Bu durumda Property kavramı devreye girer. Property bir field’ in değerini geri döndürmeye (Get) ve değerini ayarlamaya (Set) olanak sağlar.

Aşağıdaki Örnek Uygulamada Class’ ta kapsülleme kullanılarak dikdörtgenin alan hesabı yapılmıştır. Dikdörtgen kenarlarına negatif bir değer verilirse sıfırlanması sağlanmıştır.

Class ta yer alan kodlar
_**
```C#
class dortgen
    {
        private int boy;
 
        public int Boy
        {
            get { return boy; }
            set
            {
                if (value < 0)
                { boy = 0; }
                else
                { boy = value; }
            }
        }
        private int en;
       
 
        public int En
        {
            get { return en; }
            set 
            {
                if (value < 0)
                { en = 0; }
                else
                { en = value; }
              
            }
        }
 
        public int alan()
        {
            int sonuc=0;
            sonuc = en * boy;
            return sonuc;
        }
 
    }
    ```
**_Program kısmında yer alan kodlar_**

```C#
  class Program
    {
        static void Main(string[] args)
        {
            dortgen d = new dortgen();
            d.Boy =Convert.ToInt32(Console.ReadLine());
            d.En = Convert.ToInt32(Console.ReadLine());
 
            Console.WriteLine("Boy:" + d.Boy + "En:" + d.En);
            Console.WriteLine(d.alan());
            Console.ReadKey();
        }
    }
    ```
