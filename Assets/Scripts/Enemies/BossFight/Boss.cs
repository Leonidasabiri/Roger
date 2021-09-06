using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    protected virtual void patrol(List<Transform> waypoints, float speed)
    {
    }

    protected virtual void attackPattern(string[] attacknames)
    {

    }
}