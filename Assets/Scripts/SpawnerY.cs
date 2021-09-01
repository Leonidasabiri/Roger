using UnityEngine;

public class SpawnerY : MonoBehaviour
{
    [SerializeField] float minY, maxY;
    [SerializeField] float tBS;
    [SerializeField] Enemy[] enemy;

    public int maxRange = 1;

    EnemyCounter enemyCounter;
    WaveManager waveManager;

    private void Awake()
    {
        waveManager = FindObjectOfType<WaveManager>();
        enemyCounter = FindObjectOfType<EnemyCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyCounter.count < enemyCounter.maxCount && !waveManager.displayingwavemessage)
        {
            if (tBS <= 0)
            {
                if (FindObjectOfType<KillsCounter>().count + enemyCounter.count < waveManager.numberforthenextwave)
                {
                    enemyCounter.count++;
                    Instantiate(enemy[Random.Range(0, maxRange)].gameObject, new Vector2(transform.position.x, Random.Range(minY, maxY)), transform.rotation);
                }
                tBS = Random.Range(0.4f, 1.5f);
            }
            else
                tBS -= Time.deltaTime;
        }
    }
}