using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlane : Plane {

	// Use this for initialization
	void Start () {
		base.weapon = GetComponentInChildren<Weapon>();
	
		Debug.Log(weapon.name);
	}
	
	// Update is called once per frame
	void Update () {
        if (weapon.reload >= 0)
        {
            weapon.reload -= Time.deltaTime;
        }
	}
}
