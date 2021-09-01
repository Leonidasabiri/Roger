using UnityEngine;

[ExecuteInEditMode]
public class CameraShake : MonoBehaviour
{

    [SerializeField] Vector3 offset;

    // Update is called once per frame
    void Update()
    {
       transform.position = Vector3.Lerp(transform.position, new Vector3(-1.277f, -0.095f, 0) + offset, 0.5f);
    }
    public void Shake(float shakepower)
    {
        float x = Random.Range(-1, 1);
        float y = Random.Range(-1, 1);
        transform.position += new Vector3(x * shakepower,y * shakepower,transform.position.z);
        //transform.position += new Vector3(2,2,transform.position.z);
    }
}
