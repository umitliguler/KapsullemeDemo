# KapsullemeDemo

**_Bilindiği gibi C# nesneye dayalı bir programlama dilidir. Kapsülleme (Encapsulation) kavramı bir nesnenin bazı özellik ve işlevlerini başka sınıflardan ve nesnelerden saklamaktır. Private erişim belirteci sayesinde bu şekilde tanımlanan bir field’ i başka sınıflardan gizlemiş oluruz. Ayrıca bu field başka sınıflarda kullanılamaz_**

**_Kapsülleme (Encapsulation) sayesinde nesneler bilinçsiz kullanımdan korunmuş olur. Fakat bazı durumlarda private field’ lara erişmemiz ve özelliklerini kullanmamız gerekebilir. Bu durumda Property kavramı devreye girer. Property bir field’ in değerini geri döndürmeye (Get) ve değerini ayarlamaya (Set) olanak sağlar_**

**_Aşağıdaki Örnek Uygulamada Class’ ta kapsülleme kullanılarak dikdörtgenin alan hesabı yapılmıştır. Dikdörtgen kenarlarına negatif bir değer verilirse sıfırlanması sağlanmıştır_**

**_Class ta yer alan kodlar_**

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
**_Örnek-2:  Şimdi bu konuyla alakalı bir başka örnek yapalım. Bu örneğimizde aynı zamanda Hata fırlatma ve Hata yakalama işleminin nasıl yapıldığıyla ilgili bir örnekte verelim.
Örneğimizde “Makina” isimli bir sınıf oluşturacağız. Bu sınıfın “isi” isimli bir “properties” i bulunmakta. “isi” özelliğini kapsülleyeceğiz. Aynı zamanda ısı 0’dan küçük ise veya 100′ den büyükse hata fırlatarak ana programda bu hatanın yakalanmasının nasıl gerçekleştiğini göreceğiz_**

**_Öncelikle sınıfımızı aşağıdaki şekilde oluşturuyoruz_**

```C#
    class Makina
    {
        int isi;
 
        public int Isi
        {
            get { return isi; }
            set 
            {
                if (value < = 100 && value>=0)
                { 
                    isi = value; 
                }
                else if (value < 0)
                {
                    isi = 0;
                    throw new Exception("Fazla soğuk");
                }
                else
                {
                   // Console.WriteLine("Aşırı ısınma engellendi"); // Bu şeklide sınıfımızı Windows formda 
                    //çalıştırmak istediğimizde çalışmaz.Bunun yerine
                    //aşağıdaki şekilde Hata fırlatabiliriz.
 
                     isi = 100;
                    throw new Exception("Aşırı derecede ısınma var");
                   
                }
            }
        }
 
    }
 ```  
**_Ana programımıza geçelim. Burada Kodlarımızı try-catch blokları arasına yazarak Hata Yakalama işlemini de gerçekleştireceğiz_**

  ```C#
  class Program
    {
        static void Main(string[] args)
        {
            Makina m = new Makina();
            try
            {
            m.Isi =Convert.ToInt32(Console.ReadLine());
          
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine(m.Isi);
                Console.ReadKey();
            }
            
        }
    } 
  ```
**_Programımızı çalıştırdığımızda ısı değerini 152 olarak girdiğimizde 100′ e set edildiğini ve
fırlatılan hata mesajının yakalandığını göreceğiz_**
