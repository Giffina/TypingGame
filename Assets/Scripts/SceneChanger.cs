using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour {

    public void NextScene()
    {
        SceneManager.LoadScene("Begin");//
    }

    public void LoadByIndex()
    {
        SceneManager.LoadScene(0);//
    }
}
