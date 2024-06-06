using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeBasement : MonoBehaviour
{
    private bool touch;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            touch = true;
            Debug.Log("Player menyentuh object");
            SceneManager.LoadScene(3);
        }
    }
}
