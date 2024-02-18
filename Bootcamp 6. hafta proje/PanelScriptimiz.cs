using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScriptimiz : MonoBehaviour
{
    public GameObject panel;
   
    public void oyunaGeriDon()
    {
        panel.gameObject.SetActive(true);
    }
}
