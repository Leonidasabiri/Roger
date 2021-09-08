using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaDetectors : MonoBehaviour
{
    [SerializeField] Collider2D[] areacollider;

    private void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == areacollider[0])
            FindObjectOfType<RoosterFreak>().i = 0;
        else if (collision == areacollider[1])
            FindObjectOfType<RoosterFreak>().i = 1;
        else if(collision == areacollider[2])
            FindObjectOfType<RoosterFreak>().i = 2;
        else if(collision == areacollider[3])
            FindObjectOfType<RoosterFreak>().i = 3;
    }
}
