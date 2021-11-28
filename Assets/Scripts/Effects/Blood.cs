using UnityEngine;

public class Blood : MonoBehaviour
{
    SpriteRenderer sprite;
    Color tmp;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        tmp = sprite.color;
        tmp.a = 1;
        sprite.color = tmp;
    }

    // Update is called once per frame
    void Update()
    {
        if(tmp.a >= 0)
            tmp.a -= Time.deltaTime / 100;
        sprite.color = tmp;
    }
}
