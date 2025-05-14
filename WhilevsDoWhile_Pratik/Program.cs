
// While ile Çözümleme

Console.WriteLine("Bir limit değer giriniz: ");
int limit = Convert.ToInt32(Console.ReadLine());

int sayac = 0;

while (sayac < limit) 
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
}
// While koşul sağlandığı sürece, yani girilen limit değer 0 ve 0'dan büyük olduğu sürece döngüye giriyor. -10 girdiğimizde girmiyor örneğin ve "Ben bir Patika'lıyım" çıktısını alamıyoruz.


Console.WriteLine("------------------------");

// Do While ile 


int sayac2 = 0;
Console.WriteLine("Bir limit değer giriniz: ");
int limit2 = Convert.ToInt32(Console.ReadLine());

do
{
    Console.WriteLine("Ben Patika'lıyım!");
    sayac2++;
} while (sayac2 < limit2);

// Do While koşul sağlanmasa da bir kez döngüye giriyor. -20 girdiğinizde de örneğin, koşul sağlanmamasına rağmen 1 kez "Ben bir Patika'lıyım" çıktısını alıyoruz. 

