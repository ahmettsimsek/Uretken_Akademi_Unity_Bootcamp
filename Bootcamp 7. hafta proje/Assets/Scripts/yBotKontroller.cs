using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Animator yBotAnim;
    float maxspeed;
    float axisZ;
   

    void Start()
    {
        yBotAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            maxspeed = 0.4f;
            axisZ = maxspeed * Input.GetAxis("Vertical");//vertical yukarý demek z ekseni aklýnda kalsýn
            //yBotAnim.SetFloat("hiz", 0.4f);
            if ((Input.GetKey(KeyCode.LeftShift)) && Input.GetKey(KeyCode.W))
            {
                maxspeed = 2f;
                axisZ = maxspeed * Input.GetAxis("Vertical");
                // yBotAnim.SetFloat("hiz", 2f);
            }
        }
        else
        {
            maxspeed = 0;
            axisZ = maxspeed * Input.GetAxis("Vertical");
            // yBotAnim.SetFloat("hiz", 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            yBotAnim.SetBool("solayuru", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            yBotAnim.SetBool("solayuru", false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            yBotAnim.SetBool("sagayuru", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            yBotAnim.SetBool("sagayuru", false);
        }




        Vector3 vector = new Vector3 (0, 0, axisZ);


        //yBotAnim.SetFloat("hiz", maxspeed);
        yBotAnim.SetFloat("hiz", Vector3.ClampMagnitude(vector,2f).magnitude,2f,Time.deltaTime*3f);
        //animasyonlar arasý tatlý geçis saðlar pat diye durmaz bu sayede


    }
}
