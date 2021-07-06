using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{

    void Update(){
        destroydoor();
    }
    void destroydoor(){
        if(GameObject.FindGameObjectsWithTag("Enemy").Length == 0){
            Destroy(GameObject.FindGameObjectWithTag("LevelEntrance"));
        }
    }
}
