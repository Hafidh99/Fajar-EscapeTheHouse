using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class ObjectMatch : MonoBehaviour
{
    [SerializeField] int matchID;

    public int Get_ID()
    {
        return matchID;
    }
}
