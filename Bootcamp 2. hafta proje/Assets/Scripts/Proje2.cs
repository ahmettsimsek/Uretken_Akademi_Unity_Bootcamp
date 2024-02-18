using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proje2 : MonoBehaviour
{



    void BolenleriBul(int ilkSayi, int ikinciSayi)
    {
        print("{ilkSayi} ile {ikinciSayi} arasýndaki sayýlar:");

        // Ýki sayý arasýndaki tüm sayýlarý yazdýr
        for (int sayi = ilkSayi; sayi <= ikinciSayi; sayi++)
        {
            print(sayi);
        }



        print("2'ye bölünenler:");
        // Ýki sayý arasýndaki 2'ye bölünen sayýlarý yazdýr
        for (int sayi = ilkSayi; sayi <= ikinciSayi; sayi++)
        {
            if (sayi % 2 == 0)
            {
                print(sayi);
            }
        }

        print("3'e bölünenler:");
        // Ýki sayý arasýndaki 3'e bölünen sayýlarý yazdýr
        for (int sayi = ilkSayi; sayi <= ikinciSayi; sayi++)
        {
            if (sayi % 3 == 0)
            {
                print(sayi);
            }
        }

        print("4'e bölünenler:");
        // Ýki sayý arasýndaki 3'e bölünen sayýlarý yazdýr
        for (int sayi = ilkSayi; sayi <= ikinciSayi; sayi++)
        {
            if (sayi % 4 == 0)
            {
                print(sayi);
            }
        }

        print("5'e bölünenler:");
        // Ýki sayý arasýndaki 3'e bölünen sayýlarý yazdýr
        for (int sayi = ilkSayi; sayi <= ikinciSayi; sayi++)
        {
            if (sayi % 5 == 0)
            {
                print(sayi);
            }
        }
    }


    private void Start()
    {
        BolenleriBul(22, 40);
    }


}
