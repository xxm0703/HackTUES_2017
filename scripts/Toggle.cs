using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour {
    public void hide(GameObject obj)
    {
        if (obj.active == false)
            obj.SetActive(true);
        else
            obj.SetActive(false);
    }
}
