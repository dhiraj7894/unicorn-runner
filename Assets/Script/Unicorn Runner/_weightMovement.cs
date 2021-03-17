using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _weightMovement : MonoBehaviour
{
    [SerializeField] private bool isMouseMoving = false;
    [SerializeField] private Vector3 offsetPosition;
    private Vector3 initialPosition;
    void Start()
    {
        initialPosition = this.transform.localPosition;
    }


    void Update()
    {
        if (isMouseMoving)
            movement();
    }

    void movement()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        this.transform.localPosition = new Vector3(mousePosition.x - offsetPosition.x, mousePosition.y - offsetPosition.y, this.transform.localPosition.z);
    }
    private void OnMouseDown()
    {
        isMouseMoving = true;
    }
    private void OnMouseUp()
    {
        isMouseMoving = false;
        transform.localPosition = initialPosition;
    }
}
