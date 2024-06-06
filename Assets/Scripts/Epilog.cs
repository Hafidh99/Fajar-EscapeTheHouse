using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Epilog : MonoBehaviour
{
    public float waktuLoading = 9;
    void Start()
    {
        StartCoroutine(VideoLoading());
    }
    IEnumerator VideoLoading()
    {
        yield return new WaitForSeconds(waktuLoading);

        SceneManager.LoadScene("Main Menu");
    }
}
