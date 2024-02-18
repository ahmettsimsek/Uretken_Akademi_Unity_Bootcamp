using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TopKontrol : MonoBehaviour
{
    public Button btn;
    private Rigidbody rb;
    public float Hiz = 1.8f;
    public Text zaman, Can, Durum;
    float zamanSayaci = 500;
    float canSayaci = 20;
    bool oyunDevam = true;
    bool oyunTamam = false;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (oyunDevam && !oyunTamam)
        {
            zamanSayaci -= Time.deltaTime;
            zaman.text = (int)zamanSayaci + "";//int eklemessen float olarak azalýr
        }
        else if (!oyunTamam)
        {
            Durum.text = "oyun tamamlandý";
            btn.gameObject.SetActive(true);
        }
        if (zamanSayaci < 0)
        {
            oyunDevam = false;
        }
    }

    void FixedUpdate()
    {
        if (oyunDevam && !oyunTamam)
        {
            float yatay = Input.GetAxis("Horizontal");
            float dikey = Input.GetAxis("Vertical");
            Vector3 kuvvet = new Vector3(yatay, 0, dikey);
            rb.AddForce(kuvvet * Hiz);
        }
        else
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        string objIsmi = other.gameObject.name;

        if (objIsmi.Equals("Bitis"))
        {
            
            oyunTamam = true;
            Durum.text = "oyun tamamlandý tebrikler";
            btn.gameObject.SetActive (true);
        }
        else if (!objIsmi.Equals("Zemin") && !objIsmi.Equals("LabirentZemin") && !objIsmi.Equals("Baslangic"))
        {
            canSayaci -= 1;
            Can.text = canSayaci + "";
       
            if (canSayaci == 0)
            {
            oyunDevam = false;
            }
        }
    }


}
