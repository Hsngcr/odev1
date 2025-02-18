///1.SORU 
/*Console.Write("Değerini öğrenmek istediğiniz sayıyı giriniz:");
double sayi = Convert.ToDouble(Console.ReadLine()); ////Kullanıcıdan girilen değerler string olarak algılanmaması için bu dönüşümü yaptık.

if (sayi > 0)
{
    Console.WriteLine("Girilen sayı pozitiftir.");
}
else if (sayi < 0)
{
    Console.WriteLine("Girilen sayı negatiftir.");
}
else
{
    Console.WriteLine("Girilen sayı sıfırdır.");
}*/

///2.SORU
/*Console.Write("Haftanın gününü öğrenmek için 1-7 arasında bir sayı girin: ");
int gun = Convert.ToInt32(Console.ReadLine());////Kullanıcıdan girilen değerler string olarak algılanmaması için bu dönüşümü yaptık.

switch (gun)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Yanlış değer girdiniz. Lütfen 1 ve 7 dahil olmak üzere 1 ve 7 arası değer giriniz");
        break;
}*/

////3.SORU
/*Console.Write("Birinci sayıyı giriniz: ");
double sayi1 = Convert.ToDouble(Console.ReadLine());

Console.Write("İkinci sayıyı giriniz: ");
double sayi2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Yapmak istediğiniz işlemi seçiniz (+, -, *, /): ");
char islem = Convert.ToChar(Console.ReadLine());

double sonuc;

switch (islem)
{
    case '+':
        sonuc = sayi1 + sayi2;
        Console.WriteLine($"Sonuç: {sayi1} + {sayi2} = {sonuc}");
        break;
    case '-':
        sonuc = sayi1 - sayi2;
        Console.WriteLine($"Sonuç: {sayi1} - {sayi2} = {sonuc}");
        break;
    case '*':
        sonuc = sayi1 * sayi2;
        Console.WriteLine($"Sonuç: {sayi1} * {sayi2} = {sonuc}");
        break;
    case '/':
        if (sayi2 != 0)
        {
            sonuc = sayi1 / sayi2;
            Console.WriteLine($"Sonuç: {sayi1} / {sayi2} = {sonuc}");
        }
        else
        {
            Console.WriteLine("Girdiğiniz sayı sıfıra bölünemez.");
        }
        break;
    default:
        Console.WriteLine("Hatalı işlem seçimi yaptınız Lütfen doğru işlemi seçiniz.");
        break;
}*/

//////4.SORU
/*Console.Write("Birinci sayıyı giriniz: ");
double sayi1 = Convert.ToDouble(Console.ReadLine());

Console.Write("İkinci sayıyı giriniz: ");
double sayi2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Üçüncü sayıyı giriniz: ");
double sayi3 = Convert.ToDouble(Console.ReadLine());

double enBuyuk;

if (sayi1 >= sayi2 && sayi1 >= sayi3)
{
    enBuyuk = sayi1;
}
else if (sayi2 >= sayi1 && sayi2 >= sayi3)
{
    enBuyuk = sayi2;
}
else
{
    enBuyuk = sayi3;
}

Console.WriteLine($"Girdiğiniz değerler arasından en büyüğü: {enBuyuk}");*/




////5.SORU
using System.Text.RegularExpressions;

Console.Write("Lütfen bir şifre girin: ");
string sifre = Console.ReadLine();

// Uzunluk kontrolü 
if (sifre.Length < 8)
{
    Console.WriteLine("Şifre en az 8 karakter uzunluğunda olmalıdır!");
}
// Özel karakter kontrolü 
else if (!Regex.IsMatch(sifre, @"[@#$%]"))
{
    Console.WriteLine("Şifre en az bir özel karakter içermelidir (@, #, $, %)!");
}
// Büyük harf kontrolü
else if (!Regex.IsMatch(sifre, @"[A-Z]"))
{
    Console.WriteLine("Şifre en az bir büyük harf içermelidir!");
}
else
{
    Console.WriteLine("Şifreniz yeterince güçlüdür.");
}


