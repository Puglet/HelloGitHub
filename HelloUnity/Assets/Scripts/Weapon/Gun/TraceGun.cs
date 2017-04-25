using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraceGun : Weapon
{
    private GameObject player;

    // Use this for initialization
    void Start()
    {
		_reload = reload;
        player = GameObject.FindGameObjectWithTag("Player");        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Fire()
    {
        direction = (player.transform.position - transform.position).normalized;
        GameObject missileClone = Instantiate(missile, transform.position, Quaternion.identity);
        missileClone.GetComponent<Missile>().SetDirection(direction);
		reload = _reload;
    }
}
