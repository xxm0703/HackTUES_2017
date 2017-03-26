using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class humanparameters : MonoBehaviour {

    public InputField myField;
    public string value;
    public void Update()
    {
        getval();
    }
    public void getval()
    {
        //value = int.Parse(myField.text);
        //if (value < 300) myField.text++;
    }
}
