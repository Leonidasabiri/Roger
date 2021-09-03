using UnityEngine;
using TMPro;

public class KillsCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI killsCount;
    public int count = 0;

    // Update is called once per frame
    void Update()
    {
        killsCount.text = count.ToString();
        if (count >= FindObjectOfType<WaveManager>().numberforthenextwave)
            count = 0;
    }
}
