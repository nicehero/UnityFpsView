using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FpsViewMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var canvasObj = Resources.Load("Canvas", typeof(Canvas));
        Canvas cube = Instantiate(canvasObj) as Canvas;
        cube.name = "MainCanvas";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
