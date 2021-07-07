using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    //オブジェクトと接触した時に呼ばれるコールバック
    void OnTriggerEnter(Collider hit){
        if(hit.CompareTag("Player")){
            //このコンポーネントを持つGameObjectを破棄する
            Destroy(gameObject);
        }
    }
    
}
