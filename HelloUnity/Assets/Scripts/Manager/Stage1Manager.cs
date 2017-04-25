using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage1Manager : MonoBehaviour
{

    public static int score;
    public GameObject[] lifes;
    public Text scoreText;
    public Image[] lifeImage;

    // Use this for initialization
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void MinusLifeImage(PlayerPlane playerPlane){
        switch (playerPlane.hp)
        {
            case 2:
				lifeImage[2].enabled = false;
                break;
            case 1:
				lifeImage[1].enabled = false;
                break;
            case 0:
				lifeImage[0].enabled = false;
                break;
        }
    }
}
