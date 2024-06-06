using UnityEngine;

public class ObjectInteract : MonoBehaviour
{
    private bool touch;
    [SerializeField] GameObject puzzleCanvas;

    void Start()
    {
        
    }

void Update()
{
    if (touch && Input.GetKeyDown(KeyCode.E))
    {
        puzzleCanvas.SetActive(true);
        gameObject.GetComponent<ObjectInteract>().enabled = false;
        // Time.timeScale = 0f;
    }

    // // Check if the canvas is active
    // if (puzzleCanvas.activeSelf)
    // {
    //     Time.timeScale = 0f; // Ensure game is paused
    // }
    // else
    // {
    //     Time.timeScale = 1f; // Resume game
    // }
}

// Call this method to close the popup and resume the game
public void ClosePopup()
{
    puzzleCanvas.SetActive(false);
    gameObject.GetComponent<ObjectInteract>().enabled = true;
    Time.timeScale = 1f;
}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            touch = true;
            Debug.Log("Player menyentuh object");
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            touch = false;
            Debug.Log("Player meninggalkan object");
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
