using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While01 : MonoBehaviour
{
    public int num1;
    public int num2;

    // Start is called before the first frame update
    void Start()
    {
        if (num1 == num2)
        {
            Debug.Log("Los números son iguales");
        }

        else if (num1 < num2)
        {
            while (num1 <= num2)
            {
                Debug.Log(num1);
                num1++;
            }
        }

        else
        {
            while (num1 >= num2)
            {
                Debug.Log(num1);
                num1--;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
