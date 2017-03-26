using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kilos : MonoBehaviour
{

    public InputField myField;
    public int value;
    public void Update()
       {
           getval();
       }
    public void getval()
    {
        value = int.Parse(myField.text);
        if (value < 300) myField.text = (value+1).ToString();
    }
}
