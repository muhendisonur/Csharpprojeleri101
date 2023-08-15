public static class UcgenCizdir
{
    public static void Ciz(this Ucgen sekil)
    {
        int solBosluk = sekil.kenarUzunlugu - 2;
        int soldanSagaBosluk = 1; //aynı satır üzerinde ilk yıldız konulduğunda aynı satır üzerinde ki diğer yıldızın kaç adet BOŞLUKTAN sonra konacağını ifade eder
        bool ilkCalisma = true;
        
        if(ilkCalisma)
        {
            for(int i = 0; i < sekil.kenarUzunlugu - 1; i++) //-1 yapılarak boşluk sayısı düzenlendi
            {
                System.Console.Write(" ");
            }
            System.Console.WriteLine("*");
            ilkCalisma = false;
        }
        
        //tekrar edilecek işlem sayısını ifade eder
        for(int i = 0; i < sekil.kenarUzunlugu - 2; i++) //-2 çünkü tepedeki yıldız yukarıda ayrıca konuldu ve alt taban düz olması için ayrıca ele alındı
        {
            //boşluk ve yıldız işlemlerini ifade eder
            for(int j = 0; j < solBosluk; j++)
            {
                System.Console.Write(" ");
            }  
            System.Console.Write("*");

            for(int k = 0; k < soldanSagaBosluk; k++)
            {
                System.Console.Write(" ");
            }
            System.Console.Write("*");

            System.Console.WriteLine(); //alt satıra geçmek için

            soldanSagaBosluk += 2;
            solBosluk--;

            //tabanın yıldız işareti ile dolu olmasını sağlamak için..
            if(solBosluk == 0) 
            {
                for(int m = 0; m < soldanSagaBosluk + 2; m++) //soldanSagaBosluk değişkeni boşluk sayısını ifade ediyor biz döngüde yıldız adedi olarak kullandık ayrıca son işlemi iptal ettik manuel olarak oradan da 1 boşluk geliyor o yüzden 2 fazla
                {
                    System.Console.Write("*");
                }
            }
        }
    }
}