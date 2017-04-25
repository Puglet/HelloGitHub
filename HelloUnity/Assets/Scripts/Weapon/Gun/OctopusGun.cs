using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OctopusGun : Weapon
{
    public Transform[] missileSpots;

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
        GameObject missileClone0 = Instantiate(missile, missileSpots[0].position, missileSpots[0].rotation);
        GameObject missileClone1 = Instantiate(missile, missileSpots[1].position, missileSpots[1].rotation);
        GameObject missileClone2 = Instantiate(missile, missileSpots[2].position, missileSpots[2].rotation);
        GameObject missileClone3 = Instantiate(missile, missileSpots[3].position, missileSpots[3].rotation);
        GameObject missileClone4 = Instantiate(missile, missileSpots[4].position, missileSpots[4].rotation);
        GameObject missileClone5 = Instantiate(missile, missileSpots[5].position, missileSpots[5].rotation);
        GameObject missileClone6 = Instantiate(missile, missileSpots[6].position, missileSpots[6].rotation);
        GameObject missileClone7 = Instantiate(missile, missileSpots[7].position, missileSpots[7].rotation);

        missileClone0.GetComponent<Missile>().SetDirection(direction);
        missileClone1.GetComponent<Missile>().SetDirection(direction);
        missileClone2.GetComponent<Missile>().SetDirection(direction);
        missileClone3.GetComponent<Missile>().SetDirection(direction);
        missileClone4.GetComponent<Missile>().SetDirection(direction);
        missileClone5.GetComponent<Missile>().SetDirection(direction);
        missileClone6.GetComponent<Missile>().SetDirection(direction);
        missileClone7.GetComponent<Missile>().SetDirection(direction);

        reload = _reload;
    }
}
