using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OncollisionDestroy : MonoBehaviour
{
    void OntriggerEnter2D(Collider2D col){
        if(col.CompareTag("Player")){
            Debug.Log(col);
            Destroy(col,0);
        }
    }
}
