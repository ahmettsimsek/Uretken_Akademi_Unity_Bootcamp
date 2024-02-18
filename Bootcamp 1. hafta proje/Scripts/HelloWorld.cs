using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public int sayi1, sayi2;
    public bool evliMi;
    public string isim;
    // Start is called before the first frame update
    void Start()
    {
        sayi1 = 100;
        sayi2 = 20;
        evliMi = false;
        isim = "enes";
    }

    // Update is called once per frame
    void Update()
    {
        if (sayi1 < sayi2 && isim == "enes") 
        {
            print("sayi1 ve sayi2 den kucukk ve isim enes");
        }
        else
        {
            print("önermenin ikiside yanlýþ");
        }
        if (!evliMi)
        {
            print("evli");
        }
        else
        {
            print("evli deðil");
        }
    }
}
