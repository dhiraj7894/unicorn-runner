using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Trajectory : MonoBehaviour
{
    private RaycastHit hit;
    private Rigidbody rb;
    public Transform shootPoint;
    private Vector3 vo;
    public float shootPointHeight = 1.7f;
    public bool _isGrounded;

    public GameObject cursor;
    
    public float jumpHeight = 2f;

    public Transform graoundCheker;
    public LayerMask layer;
    public LayerMask groundLayer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        LaunchProjectile();
        shootPoint.localPosition = new Vector3(0, shootPointHeight, 0);
    }

    void LaunchProjectile()
    {
        

        if(Physics.Raycast(shootPoint.position,shootPoint.forward, out hit, layer))
        {
            cursor.transform.position = hit.point + Vector3.up * 0.1f;
            vo = Calculatevelocity(hit.point, shootPoint.position, jumpHeight);

            //visual(vo);
            /*if (Input.GetKeyDown(KeyCode.E) && GetComponent<PlayerMove>()._isGrounded)
            {
                rb.velocity = vo;
            }*/
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(shootPoint.position, hit.point);
    }

    public void jump()
    {
        rb.velocity = vo;
    }
    Vector3 Calculatevelocity(Vector3 target, Vector3 origin, float time)
    {
        Vector3 distance = target - origin;
        Vector3 distanceXZ = distance;
        distanceXZ.y = 0f;

        float SY = distance.y;
        float SXZ = distanceXZ.magnitude;

        float VXZ = SXZ / time;
        float VY = SY / time + 0.5f * Mathf.Abs(Physics.gravity.y) * time;

        Vector3 result = distanceXZ.normalized;
        result *= VXZ;
        result.y = VY;

        return result;
    }
}
