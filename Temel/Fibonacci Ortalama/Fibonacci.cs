
public class FibonacciIslemler
{
    public FibonacciIslemler(int derinlik)
    {
        Ortalama(derinlik);
    }

    public void Ortalama(int derinlikPara)
    {
        int birinci, ikinci, yeni, toplam;
        
        toplam = 2; //fibonacci dizisinin ilk iki elemanı 1 ve 1'dir dolayısıyla bunları eklemiş olarak başlarız, sonra ki ekleme 1+1 = 2 yani 3.eleman olacaktır
        birinci = 1;
        ikinci = 1;
        
        for(int i = 0; i < derinlikPara; i++)
        {
            yeni = birinci + ikinci;
            toplam += yeni;
            
            birinci = ikinci;
            ikinci = yeni;
        }

        
        System.Console.WriteLine("Ortalama: " + (toplam / derinlikPara));
    }
}