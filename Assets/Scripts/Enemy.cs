using UnityEngine;

public class Enemy : MonoBehaviour
{
    Transform target;

    [SerializeField] BloodSpitsRandomizer bloodSpitsRandomizer;

    EnemyCounter enemyCounter;
    WaveManager waveManager;

    [SerializeField] float stopingDistance = 3;
    [SerializeField] float speed = 3;
    [SerializeField] float health = 5;

    // Start is called before the first frame update
    void Start()
    {
        waveManager = FindObjectOfType<WaveManager>();
        enemyCounter = FindObjectOfType<EnemyCounter>();
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            FindObjectOfType<KillsCounter>().count++;
            enemyCounter.count--;
            Debug.Log(FindObjectOfType<KillsCounter>().count + enemyCounter.count);
            waveManager.count++;
            Destroy(gameObject);
        }
        if (Vector2.Distance(transform.position, target.position) > stopingDistance)
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        Vector3 lookAt = target.position - transform.position;
        float angle = Mathf.Atan2(lookAt.y, lookAt.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Instantiate(bloodSpitsRandomizer, transform.position, transform.rotation);
            health--;
        }
    }
}
