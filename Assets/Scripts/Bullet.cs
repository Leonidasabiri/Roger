using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 6;

    CameraShake cameraShake;

    void Update()
    {
        cameraShake = FindObjectOfType<CameraShake>();
        transform.Translate(Vector3.up * speed * Time.deltaTime);    
    }

    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            cameraShake.Shake(3);
            Destroy(gameObject);
        }
    }
}
