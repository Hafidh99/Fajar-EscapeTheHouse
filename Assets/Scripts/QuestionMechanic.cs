using UnityEngine;

public class QuestionMechanic : MonoBehaviour
{
    [SerializeField] GameObject[] rightAnswer;
    [SerializeField] GameObject puzzleObj;

    public void checkAnswer()
    {
        int value = 0;

        for (int i = 0; i < rightAnswer.Length; i++)
        {
            if (rightAnswer[i].transform.GetChild(1).gameObject.activeSelf) value++;
            Debug.Log(value);
        }

        if (value >= 3)
        {
            Debug.Log("Puzzle berhasil diselesaikan!");

            puzzleObj.transform.GetChild(0).gameObject.SetActive(false);
            puzzleObj.GetComponent<ObjectInteract>().enabled = false;
        }
        else
        {
            Debug.Log("puzzle gagal diselesaikan");

            puzzleObj.GetComponent<ObjectInteract>().enabled = true;
        }
    }
}
