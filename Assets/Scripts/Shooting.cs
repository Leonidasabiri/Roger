using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] Transform shootPoint;
    [SerializeField] Bullet bullet;
    [SerializeField] ParticleSystem shootEffect;

    float tbs = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && tbs <= 0)
        {
            Instantiate(bullet, shootPoint.position, shootPoint.rotation);
            Instantiate(shootEffect, shootPoint.position, shootPoint.rotation);
            tbs = 0.2f;
        }
        else
            tbs -= Time.deltaTime;
    }
}
