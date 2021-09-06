using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class AmmoIcon : MonoBehaviour
{
    [SerializeField] List<Sprite> icons = new List<Sprite>();

    Image icon;

    [SerializeField] Ammo ammo;

    private void Start()
    {
        ammo = FindObjectOfType<Ammo>();
        icon = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
            icon.sprite = icons[0];
        if (Input.GetKey(KeyCode.Alpha2))
            icon.sprite = icons[1];
        if (Input.GetKey(KeyCode.Alpha3))
            icon.sprite = icons[2];
    }
}
