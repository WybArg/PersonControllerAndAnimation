using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InteractProps : MonoBehaviour
{
    public bool pressButton = false;
    public float timeOpenProps;
    private float time;


    public void Update()
    {
        if (pressButton)
        {
            time += Time.deltaTime;

            if (time > timeOpenProps)
            {
                time = 0;
                pressButton = false;
            }
        }

    }


    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.GetComponentInParent<IProps>() != null && pressButton)
        {
            collision.gameObject.GetComponentInParent<IProps>().OpenProps();
        }
    }

}
