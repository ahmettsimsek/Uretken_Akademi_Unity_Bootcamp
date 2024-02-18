using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonController : MonoBehaviour
{
    [SerializeField] private float speed;

    private FixedJoystick fixedjoystick;
    private Rigidbody rigidbody;

    private void OnEnable()
    {
        fixedjoystick = FindFirstObjectByType<FixedJoystick>();
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float xVal = fixedjoystick.Horizontal;
        float yVal = fixedjoystick.Vertical;

        Vector3 movement = new Vector3 (xVal, 0, yVal);
        rigidbody.velocity = movement*speed;

        if(xVal !=0 && yVal !=0 )
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x,  Mathf.Atan2 (xVal, yVal) * Mathf.Rad2Deg, transform.eulerAngles.z);
        }
    }

}
