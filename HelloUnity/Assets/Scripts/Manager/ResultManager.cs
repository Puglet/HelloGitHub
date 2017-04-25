using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour
{
    public Text scoreText;

    // Use this for initialization
    void Start()
    {
        scoreText.text = Stage1Manager.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Restart()
    {
        SceneManager.LoadScene("Stage1");
    }
}
