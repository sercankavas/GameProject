using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             UserStory:
            1.     Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz.
            Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz.
            (E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır. Bunu yapacak servisi simule etmeniz yeterlidir.)

2.     Oyun satışı yapılabilecek satış ortamını simule ediniz.
            ( Yapılan satışlar oyuncu ile ilişkilendirilmelidir. Oyuncunun parametre olarak metotta olmasını kastediyorum.)

3.     Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.

4.     Satışlarda kampanya entegrasyonunu simule ediniz.

5.     Ödevinizi Github’a yükleyiniz. Github linkinizi paylaşınız.
             */

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer {Id=1,BirthYear=1986,FirstName="Sercan",LastName="Kavas",IdentityNo= 3636363 });

            OrderManager orderManager = new OrderManager(new OfferManager());
            orderManager.ad


        }
    }
}
