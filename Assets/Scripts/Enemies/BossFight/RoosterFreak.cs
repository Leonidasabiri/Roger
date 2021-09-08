using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(Animator))]
public class RoosterFreak : Boss
{
    [SerializeField] float speed = 40;
    [SerializeField] List<Transform> transforms;

    Animator anim;

    public int i = 0;
    float timetoattack = 2f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    string attackState(int attacktype)       
    => attacktype switch 
    { 
        1 => "smash",
        2 => "wavingclaws"
    };

    protected override void patrol(List<Transform> waypoints, float speed)
    {
        transform.position = Vector2.Lerp(transform.position, waypoints[i].position, speed * Time.deltaTime);
    }

    void animationsetting(string attackname, bool attack)
    {
        anim.SetBool(attackname, attack);
    }

    // Update is called once per frame
    void Update()
    {
        int attackindex = UnityEngine.Random.Range(1,3);

        if (timetoattack <= 0)
        {
            animationsetting(attackState(attackindex), !Convert.ToBoolean(timetoattack));
            timetoattack = 2.0f;
        }
        patrol(transforms, speed);
    }
}
