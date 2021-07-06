using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEffect : MonoBehaviour
{
    public GameObject Hiteffect;

    void OnCollisionEnter2D(Collision2D other){
        GameObject effect= Instantiate(Hiteffect,transform.position,Quaternion.identity);
        Destroy(effect,0.2f);
        Destroy(gameObject);
    }
}
