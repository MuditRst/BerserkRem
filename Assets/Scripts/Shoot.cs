using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private float timebtwshots;
    public float starttimebtwshots;

    public Transform fire;

    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        timebtwshots = starttimebtwshots;
    }

    // Update is called once per frame
    void Update()
    {
        if(timebtwshots <= 0){
            Instantiate(bullet,transform.position,Quaternion.identity);
            timebtwshots = starttimebtwshots;
        }else{
            timebtwshots -= Time.deltaTime;
        }
        
    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag.Equals("Player")){
            Debug.Log(gameObject.name);
        }
    }
}
