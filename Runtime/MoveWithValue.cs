using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithValue : MonoBehaviour
{
    public Transform m_toMove;

    [Header("--- Rotation Axes ---")]
    public float m_rotateLeftRight;
    public float m_rotateUpDown;

    public float m_speedRotate;


    [Header("--- Movement ---")]
    public Vector3 m_direction;
    public float m_speedMove;


    public void SetRotateLeftRigh(float rotateHorizontalValue)
    {
        m_rotateLeftRight = rotateHorizontalValue;
    }
    public void SetRotateUpDown(float rotateVerticalValue)
    {
        m_rotateUpDown = rotateVerticalValue;
    }
    public void SetMoveForward(float forwardMovementValue)
    {
        m_direction.z = forwardMovementValue;
    }
    public void SetMoveRight(float sideMovementValue)
    {
        m_direction.x = sideMovementValue;
    }
    public void SetMoveUp(float upMovementValue)
    {
        m_direction.y = upMovementValue;
    }


    public Space m_rotateSpaceType = Space.World;
    public void Update()
    {
        m_toMove.Translate(m_direction * Time.deltaTime * m_speedMove, Space.Self);
        m_toMove.Rotate(Vector3.up, m_rotateLeftRight * Time.deltaTime * m_speedRotate, m_rotateSpaceType);
        m_toMove.Rotate(Vector3.right, m_rotateUpDown * Time.deltaTime * m_speedRotate, m_rotateSpaceType);
    }


    private void Reset()
    {
        m_toMove = transform;
    
    }

  
    
}
