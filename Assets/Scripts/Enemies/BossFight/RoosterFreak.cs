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
        2 => "wavingclaws",
        3 => "spitting"
    };

    protected override void patrol(List<Transform> waypoints, float speed)
    {
        transform.position = Vector2.Lerp(transform.position, waypoints[i].position, speed * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, waypoints[i].rotation, speed * Time.deltaTime);
    }

    IEnumerator animationsetting(string attackname, bool attack)
    {
        anim.SetBool(attackname, attack);
        attack = false;
        yield return new WaitForSeconds(2);
        timetoattack = 2; 
    }

    // Update is called once per frame
    void Update()
    {
        if (timetoattack <= 0)
        {
            int attackindex = UnityEngine.Random.Range(1,3);
            StartCoroutine(animationsetting(attackState(attackindex), Convert.ToBoolean(timetoattack)));
            Debug.Log(attackState(attackindex));
            timetoattack = 2.0f;
        }
        else
            timetoattack -= Time.deltaTime;
        patrol(transforms, speed);
    }
}
