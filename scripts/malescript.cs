using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class malescript : MonoBehaviour {
    public void changeToScene(int change)
    {
        SceneManager.LoadScene(change);
    }

}
