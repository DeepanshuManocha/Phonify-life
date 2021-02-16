using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public void GoAr(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
