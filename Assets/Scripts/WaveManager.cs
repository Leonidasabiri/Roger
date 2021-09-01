using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaveManager : MonoBehaviour
{
    [SerializeField] Image           blackscreen;
    [SerializeField] TextMeshProUGUI wavemessage;

    public int count = 0, numberforthenextwave = 21;
    [SerializeField] string[] wavemessages = {"Wave 1","Wave 2", "Wave 3", "Wave 4"};
    int ind = 0;

    [SerializeField] float t = 5;

    public bool displayingwavemessage = false;

    bool inc = true;

    private void Start()
    {
        blackscreen.gameObject.SetActive(displayingwavemessage);
        wavemessage.gameObject.SetActive(displayingwavemessage);
    }

    // Update is called once per frame
    void Update()
    {
            if (count >= numberforthenextwave)
            {
                if (inc)
                {
                    ind++;
                    inc = false;
                    if (FindObjectOfType<SpawnerY>().maxRange < 2)
                        FindObjectOfType<SpawnerY>().maxRange++;
                }
                wavemessage.text = wavemessages[ind];
                t -= Time.deltaTime;
                displayingwavemessage = true;
                blackscreen.gameObject.SetActive(displayingwavemessage);
                wavemessage.gameObject.SetActive(displayingwavemessage);
            }
            if (t <= 0)
            {
                inc = true;
                FindObjectOfType<EnemyCounter>().maxCount += 3;
                numberforthenextwave += 5;
                displayingwavemessage = false;
                blackscreen.gameObject.SetActive(displayingwavemessage);
                wavemessage.gameObject.SetActive(displayingwavemessage);
                count = 0;
                t = 5;
            }
    }
}