using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{   // int, float (4byte)
    //변수의 명명규칙
    /*//char : 하나의 문자만 저장하는 자료형 1byte
    //char에 정수를 저장할수 있음
    // string : 문자열 저장하는 자료형 
    //변수이름은 중복되면 안됨
    //변수이름이 숫자로 시작하면 안됨
    //변수이름은 공백이 들어가면 안됨
    //변수의 특수문자는 _랑$ 만 혀용됨
    float value = 3.14f;
    char value1 = 'a';
    int value2 = 5; */
    //조건문
    /*
         if(15==10)
         {
             print("10과 10이 같습니다.");
         }
         else if(12==12)
         {
             print("12와 12는 같습니다.");
         }
         */
    //8bit==1byte 

    //인스펙터 공개
    // 자료형이 게임오브젝트?
    public GameObject prefab;
    //public : 스크립트안에 있는 변수의 내용이나 게임 오브젝트를 inspect에서 확인하거나 접근가능
    //private : 스크립트 내부에 있는 변수의 내용이나 게임 오브젝트 공개하지 않도록 설정.

    public void GenericCreate()
    {
        // Instantiate : 게임오브젝트를 생성하는 함수 변수,위치,회전값

        Instantiate(prefab, new Vector3(0, 5, 0), Quaternion.identity);
    }

    public void PoolCreate()
    {
        ObjectPool.objpool.GetQueue();
    }
}
