using UnityEngine;

public class BloodSpitsRandomizer : MonoBehaviour
{
    [SerializeField] Blood blood; 
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            float rot  = Random.Range(0, 180);
            float posx = Random.Range(-0.5f,0.1f);
            float posy = Random.Range(-0.8f,0.4f);
            float scalx = Random.Range(-0.5f, 2f);
            float scaly = Random.Range(-0.5f, 2f);
            GameObject obj = Instantiate(blood.gameObject, new Vector2(transform.position.x + posx, transform.position.y + posy),
                Quaternion.EulerAngles(transform.rotation.x, transform.rotation.x, rot));
            obj.transform.localScale = new Vector2(transform.localScale.x + scalx, transform.localScale.y + scaly);
        }   
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
        }
    }
}
