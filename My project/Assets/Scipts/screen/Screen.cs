using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Screen : MonoBehaviour
{
    static public void loadScene(string name)
    {
        EditorSceneManager.LoadSceneAsyncInPlayMode(string.Format("Assets/Scenes/{0}.unity", name), new LoadSceneParameters());
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
