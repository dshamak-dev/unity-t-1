using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartScreen : Screen, IPointerClickHandler
{
    Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();

        if (canvas != null)
        {
            canvas.renderMode = RenderMode.ScreenSpaceCamera;
            canvas.worldCamera = Camera.main;
        }

        StartCoroutine(LoadData());
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        //Output to console the clicked GameObject's name and the following message. You can replace this with your own actions for when clicking the GameObject.
        //Debug.Log(name + " Game Object Clicked!");
        //Screen.loadScene("LandingScene");
    }

    IEnumerator LoadData()
    {
        yield return new WaitForSeconds(Random.Range(2, 5));

        Screen.loadScene("LandingScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
