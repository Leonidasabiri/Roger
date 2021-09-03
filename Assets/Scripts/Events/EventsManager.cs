using System.Collections;
using UnityEngine;
public class EventsManager : MonoBehaviour
{
    [SerializeField] GameObject lights;

    float timeOfInstance = 10f;
    void BossAppearance()
    {
        int randomInd = Random.Range(0, lights.transform.childCount);
        for (int i = 0; i < lights.transform.childCount ; i++)
        {
            if (i == randomInd)
                lights.transform.GetChild(i).gameObject.SetActive(true);
            else
            {
                lights.transform.GetChild(i).gameObject.SetActive(false);
                StartCoroutine(delay(lights.transform.GetChild(i).gameObject));
            }
        }
    }
    IEnumerator delay(GameObject obj)
    {
        yield return new WaitForSeconds(1);
        obj.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<WaveManager>().ind >= 4)
            lights.SetActive(true);
        BossAppearance();
    }
}