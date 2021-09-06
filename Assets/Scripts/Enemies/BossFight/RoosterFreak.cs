using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoosterFreak : Boss
{
    [SerializeField] float speed = 40;
    [SerializeField] List<Transform> transforms;

    public int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    protected override void patrol(List<Transform> waypoints, float speed)
    {
        transform.position = Vector2.Lerp(transform.position, waypoints[i].position, speed * Time.deltaTime);
        //if (Vector2.Distance(transform.position, waypoints[i].position) <= 1)
     //       i++;
        //i = i >= waypoints.Count ? 0 : i;        
    }

    // Update is called once per frame
    void Update()
    {
        patrol(transforms, speed);
    }
}



