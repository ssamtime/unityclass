using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    const int a = 4; //const: 상수 (실행중에 값이 변경될 수 없음)
    //a라는 상수에는 값을 저장할수없지만 a를가지고 연산수행은 가능
    int b = 100;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(a + b);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
