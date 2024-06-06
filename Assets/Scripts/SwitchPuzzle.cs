using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(LineRenderer))]

public class SwitchPuzzle : MonoBehaviour
{
    LineRenderer lineRender;
    [SerializeField] int matchID;
    bool isDragging;
    Vector3 endPoint;
    ObjectMatch objectMatch;

    void Start()
    {
        lineRender = GetComponent<LineRenderer>();
        lineRender.positionCount = 2;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Input.mousePosition, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                isDragging = true;
                Vector3 mousePosition = Input.mousePosition;
                mousePosition.z = 0f;
                lineRender.SetPosition(0, mousePosition);
                Debug.Log("KEna benda");
            }
            Debug.Log("kena pencet");
        }

        if (isDragging)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 0f;
            lineRender.SetPosition(1, mousePosition);
            endPoint = mousePosition;
            Debug.Log("Lagi Neken");
        }

        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
            RaycastHit2D hit = Physics2D.Raycast(endPoint, Vector2.zero);

            if (hit.collider != null && hit.collider.TryGetComponent(out objectMatch) && matchID == objectMatch.Get_ID())
            {
                Debug.Log("Correct Form!");
                this.enabled = false;
            }
            else
            {
                lineRender.positionCount = 0;
            }
            Debug.Log("kelepasan");

            lineRender.positionCount = 2;
        }
    }
}
