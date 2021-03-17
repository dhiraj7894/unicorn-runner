using UnityEngine;

public class WaterBob : MonoBehaviour
{
    [SerializeField]
    float height = 0.1f;
//    float width = 0.05f;
    [SerializeField]
    float period = 1;

    private Vector3 initialPosition;
    private float offset;

    private void Awake()
    {
        height = 0.1f;
        initialPosition = transform.position;
        offset = 1 - (Random.value * 2);
    }

    private void Update()
    {
        //   transform.position = initialPosition - Vector3.up * Mathf.Sin((Time.time + offset) * period) * height;
        transform.position = initialPosition - (Vector3.right * Mathf.Sin((Time.time + offset) * period) * height) - Vector3.up * Mathf.Sin((Time.time + offset) * period) * height;

    }
}
