using UnityEngine;

public class CameraIdle : MonoBehaviour
{
    Vector3 pos;

    private void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = pos + new Vector3(transform.position.x,Mathf.Sin(Time.time) * 0.7f,0);       
    }
}
