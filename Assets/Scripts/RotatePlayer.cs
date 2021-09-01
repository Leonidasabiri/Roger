using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 lookAt = Input.mousePosition - pos;
        float angle = Mathf.Atan2(lookAt.y , lookAt.x ) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
