using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController : MonoBehaviour
{
    public delegate void OnMoveDel(Vector2 direction);
    public OnMoveDel onMoveEvent;

    public delegate void OnLookDel(Vector2 direction);
    public OnLookDel onLookEvent;
    public void CallMoveEvent(Vector2 direction)
    {
        onMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        onLookEvent?.Invoke(direction);
    }
}
