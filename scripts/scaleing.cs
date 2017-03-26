using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scaleing : MonoBehaviour
{
    static private Slider a;
    int value = (int)(a.value);
    public void Extend(GameObject obj)
    {
        // Widen the object by 0.1
        obj.transform.localScale += new Vector3(value, 0, 0);
    }
}