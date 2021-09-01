using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Collider2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] BloodSpitsRandomizer bloodSpitsRandomizer;

    [SerializeField] float speed = 7;
    public float health = 8;

    WaveManager waveManager;

    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        waveManager = FindObjectOfType<WaveManager>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!waveManager.displayingwavemessage)
            transform.Translate(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed * Time.deltaTime, Space.World);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health--;
            Instantiate(bloodSpitsRandomizer.gameObject, transform.position, transform.rotation);
            FindObjectOfType<CameraShake>().Shake(4);
        }
    }
}