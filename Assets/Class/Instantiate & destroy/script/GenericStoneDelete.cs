using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericStoneDelete : MonoBehaviour
{
    Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    //OnBecameInvisible() 게임오브젝트가 화면밖으로 이동했을때 동작하는함수
    private void OnBecameInvisible() 
    {
        if(gameObject.name == "Stone_3(Clone)")
        {
            Destroy(gameObject);
        }
        else if(gameObject.name == "Stone_5(Clone)")
        {
            rigid.velocity = Vector3.zero;
            gameObject.transform.position = new Vector3(0, 5, 0);
            ObjectPool.objpool.InsertQueue(gameObject);
        }
    }

}
