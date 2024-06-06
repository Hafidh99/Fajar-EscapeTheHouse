using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(BoxCollider2D))]

public class RandomSwitch : MonoBehaviour
{
    [SerializeField] float offsetH;
    [SerializeField] float offsetV;
    [SerializeField] GameObject[] switchsL;
    [SerializeField] GameObject[] switchsR;

    void Start()
    {
        ShuffleSwitch(switchsL);
        ShuffleSwitch(switchsR);

        ArrangeSwitchs(switchsL, offsetH);
        ArrangeSwitchs(switchsR, -offsetH);
    }

    void ShuffleSwitch(GameObject[] switchs)
    {
        int numSwitch = switchs.Length;

        for (int i = switchs.Length - 1; i > 0; i--)
        {
            int randomIdx = Random.Range(0, i + 1);
            GameObject temp = switchs[i];
            switchs[i] = switchs[randomIdx];
            switchs[randomIdx] = temp;
        }
    }

    void ArrangeSwitchs(GameObject[] switchs, float offsetY)
    {
        int numSwitchs = switchs.Length;
        float switchWidth = switchs[0].GetComponent<RectTransform>().rect.width + offsetV;
        float totalWidth = switchWidth * numSwitchs;
        float firstSwitchX = transform.position.x - (totalWidth / 2) + (switchWidth / 2);

        for (int i = 0; i < numSwitchs; i++)
        {
            float offsetX = firstSwitchX + i * switchWidth;
            Vector3 cardPosition = new Vector3(offsetX, transform.position.y + offsetY, transform.position.z);
            switchs[i].transform.position = cardPosition;
        }
    }
}
