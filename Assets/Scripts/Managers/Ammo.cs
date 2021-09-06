using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public Dictionary<bool, int> indexmapping = new Dictionary<bool, int>();

    private void Start()
    {
        indexmapping[Input.GetKeyDown(KeyCode.Alpha1)] = 0;
        indexmapping[Input.GetKeyDown(KeyCode.Alpha2)] = 1;
        indexmapping[Input.GetKeyDown(KeyCode.Alpha3)] = 2;
    }
}