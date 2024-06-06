using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Pipe : MonoBehaviour
{

    [SerializeField] public int[] key;
    [SerializeField] public int value;

    private GameObject obj;

    public bool solved;

    void Start()
    {
        obj = gameObject;
    }

    private void Update()
    {
        if (key.Contains(value)) solved = true;
        else solved = false;

        switch (value)
        {
            case 1:
                obj.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);
                //obj.transform.rotation.z = 0;
                break;
            case 2:
                obj.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 90);
                //obj.transform.rotation.z = 90;
                break;
            case 3:
                obj.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 180);
                //obj.transform.rotation.z = 180;
                break;
            case 4:
                obj.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 270);
                //obj.transform.rotation.z = 270;
                break;
        }
    }

    public void changeValue()
    {
        if (value < 4) value++;
        else value = 1;
    }

    public bool Check()
    {
        //if (key.Contains(value)) solved = true;
        //else solved = false;
        return solved;
    }
}
