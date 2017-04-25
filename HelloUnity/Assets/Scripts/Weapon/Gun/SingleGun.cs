using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleGun : Weapon
{

    // Use this for initialization
    void Start()
    {
        _reload = reload;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Fire()
    {
        direction = transform.right;
        GameObject missileClone = Instantiate(missile, transform.position, Quaternion.identity);
        missileClone.GetComponent<Missile>().SetDirection(direction);
        reload = _reload;
    }
}
