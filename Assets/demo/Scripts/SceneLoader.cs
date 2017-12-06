using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    
    public void LoadScene(int level)
    {
        Application.LoadLevel(level);
        Camera m_MainCamera = Camera.main;
        m_MainCamera.transform.rotation = Quaternion.Euler(151f, 213f,0f);
        Application.LoadLevel(level);
    }
}