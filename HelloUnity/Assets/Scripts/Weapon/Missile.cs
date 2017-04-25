using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Missile : MonoBehaviour
{

    public float speed;
    private Vector2 direction;

    public void SetDirection(Vector2 direction)
    {
        this.direction = direction;
    }

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            PlayerPlane playerPlane = collision.GetComponent<PlayerPlane>();
            if (playerPlane.hp > 0)
            {
                playerPlane.hp--;
                GameObject.Find("Stage1Manager").GetComponent<Stage1Manager>().MinusLifeImage(playerPlane);
            }
            else
            {
                SceneManager.LoadScene("Result");
            }
        }
        else if (collision.tag == "Enemy")
        {
            Stage1Manager.score += 10;
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);
    }
}
