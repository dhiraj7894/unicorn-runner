using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyVertex : MonoBehaviour
{
    public int verticeIndex;
    public Vector3 initialVertexPosition;
    public Vector3 currentVertexPosition;

    public Vector3 currentVelocity;

    public JellyVertex(int _verticeIndex, Vector3 _initialVertexPosition, Vector3 _currentVertexPosition, Vector3 _currentVelocity)
    {
        verticeIndex = _verticeIndex;
        initialVertexPosition = _initialVertexPosition;
        currentVertexPosition = _currentVertexPosition;

        currentVelocity = _currentVelocity;
    }

    public Vector3 GetCurrentDisplacement()
    {
        return currentVertexPosition - initialVertexPosition;
    }

    public void UpdateVelocity(float _bounceSpeed)
    {
        currentVelocity = currentVelocity - GetCurrentDisplacement() * _bounceSpeed * Time.deltaTime;
    }

    public void Settle(float _stiffness)
    {
        currentVelocity *= 1 - _stiffness * Time.deltaTime; 
    }

    public void ApplyPressureToVertex(Transform _transform, Vector3 _position, float pressure)
    {
        Vector3 distanceVertexPoint = currentVertexPosition - _transform.InverseTransformPoint(_position);
        float adaptedPressure = pressure / (1 + distanceVertexPoint.sqrMagnitude);
        float velocity = adaptedPressure * Time.deltaTime;
        currentVelocity += distanceVertexPoint.normalized * velocity;
    }
}
