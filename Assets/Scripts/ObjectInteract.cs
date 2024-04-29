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
        }
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
