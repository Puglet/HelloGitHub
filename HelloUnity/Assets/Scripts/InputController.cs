using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public float maxHorizontal = 8;
    public float maxVertical = 4;

    private float speed;

    private Weapon weapon;
    // Use this for initialization
    void Start()
    {
        speed = this.GetComponent<PlayerPlane>().speed;
        weapon = this.GetComponent<PlayerPlane>().GetWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        // Move
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector2(h, v) * speed * Time.deltaTime);

        Vector2 position = transform.position;
        if (position.x > maxHorizontal || position.x < -maxHorizontal)
        {
            position.x = Mathf.Sign(position.x) * maxHorizontal;
        }
        if (position.y > maxVertical || position.y < -maxVertical)
        {
            position.y = Mathf.Sign(position.y) * maxVertical;
        }
        transform.position = position;

        if (Input.GetKeyDown("space") && weapon.reload < 0)
        {
            weapon.Fire();
        }
    }
}
