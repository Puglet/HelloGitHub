using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public float reload;
    protected float _reload;
    protected Vector2 direction;
    public GameObject missile;
    public abstract void Fire();
}
