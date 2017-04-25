using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlane : Plane
{
    // Use this for initialization
    void Start()
    {
        weapon = GetComponentInChildren<Weapon>();
        InvokeRepeating("Fire", 2, weapon.reload);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(speed, 0) * Time.deltaTime);

    }

    private void Fire()
    {
        weapon.Fire();
    }
}
