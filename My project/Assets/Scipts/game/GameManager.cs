using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public GameManager gameManager;
    static public Camera _camera;
    
    private void Awake()
    {
        if (gameManager != null)
        {
            Destroy(gameManager.gameObject);
        }

        gameManager = this;

        _camera = Camera.main;

        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(Camera.main);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
