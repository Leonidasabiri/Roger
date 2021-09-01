using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Canvas gameOverScreen;

    // Start is called before the first frame update
    void Start()
    {
        gameOverScreen.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<PlayerMovement>().health <= 0)
        {
            gameOverScreen.gameObject.SetActive(true);
            Destroy(FindObjectOfType<PlayerMovement>().gameObject);
        }
    }
}
