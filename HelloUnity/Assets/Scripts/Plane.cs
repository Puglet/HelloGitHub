using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public int hp;
    public float speed;
        
    [SerializeField]
    protected Weapon weapon;

    public Weapon GetWeapon(){
        return weapon;
    }

}
