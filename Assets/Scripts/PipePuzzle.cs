using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PipePuzzle : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] Pipe[] pipes;

    void Update()
    {
        bool[] condition = new bool[pipes.Length];
        
        for (int i = 0; i < pipes.Length; i++)
        {
            condition[i] = pipes[i].Check();
        }

        if (!condition.Contains(false))
        {
            canvas.gameObject.SetActive(false);
        }

    }

}