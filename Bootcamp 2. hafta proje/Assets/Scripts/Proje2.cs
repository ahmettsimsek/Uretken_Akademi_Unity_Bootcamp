using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proje2 : MonoBehaviour
{



    void BolenleriBul(int ilkSayi, int ikinciSayi)
    {
        print("{ilkSayi} ile {ikinciSayi} aras�ndaki say�lar:");

        // �ki say� aras�ndaki t�m say�lar� yazd�r
        for (int sayi = ilkSayi; sayi <= ikinciSayi; sayi++)
        {
            print(sayi);
        }



        print("2'ye b�l�nenler:");
        // �ki say� aras�ndaki 2'ye b�l�nen say�lar� yazd�r
        for (int sayi = ilkSayi; sayi <= ikinciSayi; sayi++)
        {
            if (sayi % 2 == 0)
            {
                print(sayi);
            }
        }

        print("3'e b�l�nenler:");
        // �ki say� aras�ndaki 3'e b�l�nen say�lar� yazd�r
        for (int sayi = ilkSayi; sayi <= ikinciSayi; sayi++)
        {
            if (sayi % 3 == 0)
            {
                print(sayi);
            }
        }

        print("4'e b�l�nenler:");
        // �ki say� aras�ndaki 3'e b�l�nen say�lar� yazd�r
        for (int sayi = ilkSayi; sayi <= ikinciSayi; sayi++)
        {
            if (sayi % 4 == 0)
            {
                print(sayi);
            }
        }

        print("5'e b�l�nenler:");
        // �ki say� aras�ndaki 3'e b�l�nen say�lar� yazd�r
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
