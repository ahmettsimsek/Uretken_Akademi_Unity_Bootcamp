using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Butonlar : MonoBehaviour
{
    public void CikisButonu()
    {
        print("��k�� Yap�ld�!!");
        Application.Quit();
    }

    public void YeniOyun()
    {
        SceneManager.LoadScene(1);
    }

    public void IlkSahne()
    {
        SceneManager.LoadScene(0);
    }

    public void slidervalue(Single deger)
    {
        print(deger);
    }

    public void toggleEnabled(bool TiklandiMi)
    {
        if (TiklandiMi)
        {
            print("Kay�t edildi");
        }
        else
        {
            print("kay�t g�ncellenmesi iptal edildi");
        }
    }

    public void DropDownValue(int sayimiz)
    {
        if(sayimiz == 0)
        {
            print("Kolay seviyeyi se�tiniz");
        }
        else if(sayimiz == 1)
        {
            print("Orta seviyeyi se�tiniz");
        }
        else if (sayimiz == 2)
        {
            print("Zor seviyeyi se�tiniz");
        }
    }
}
