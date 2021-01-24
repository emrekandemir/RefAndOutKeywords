using System;

namespace RefAndOutKeywords
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1 = 5;
            int number2 = 10;                                 // ref; Değer(Value) tipinde tanımlanmış verileri Refrance tipe çevirmek için kullanılır. Başlangıç değeri belirtilmek zorunludur.(int number1 = 5; int number2 = 10; gibi)
            var result = Add(ref number1, number2);           // 12. ve 26. satırlarda ref keyword'lerimizi yazdığımızda normalde Değer(Value) type olana number1'i Refrance typt haine getirmiş oluruz
            Console.WriteLine(result);                        // Değer(Value) type halindeyken number1 = 5 dir fakat ref keyword ile Referans type haline getiririz ve number1 = 3 olur
            Console.WriteLine(number1);                       // Ekrana result = 13,  number1 =3 verir.



            int sayi3;                                        // out: ref ile aynı mantıkta çalışır. Farkı başlangıç değeri (int sayi3 = 10; yerine int sayi3; şeklinde belirtebiliriz).
            int sayi4 = 30;                                   // out'da sadece method içersinde bir kere set edilmesi gerekir.
            var result2 = Ekle(out sayi3, sayi4);
            Console.WriteLine(result2);
            Console.WriteLine(sayi3);

        }                                                     

        static int Add(ref int number1, int number2)
        {
            number1 = 3;
            return number1 + number2;
        }


        static int Ekle(out int sayi3, int sayi4)
        {
            sayi3 = 10;
            return sayi3 + sayi4;
        }



    }
}
