using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    //자료구조
    //Queue : 가장먼저들어온 데이터가 먼저나가는 구조
    //static : 게임이 종료될 때까지 메모리에 남아있음


    public static ObjectPool objpool;

    public GameObject prefab;

    public Queue<GameObject> queue = new Queue<GameObject>();

    //int value = 0;
    private void Start()
    {
        objpool = this;
        // 1. 초기값설정 2.조건식 3.명령문을 한번실행함 4.초기값 증감
        for(int i = 0; i < 5; i++) //0 1 2 3 4 5일때 종료
        {
            GameObject tempPrefab = Instantiate(prefab, new Vector3(0, 5, 0), Quaternion.identity);
            queue.Enqueue(tempPrefab);
            tempPrefab.SetActive(false);

        }
    }

    public void InsertQueue(GameObject tObject)
    {
        queue.Enqueue(tObject);
        tObject.SetActive(false);
    }
    public GameObject GetQueue()
    {
        GameObject tempObject = queue.Dequeue();
        tempObject.SetActive(true);

        return tempObject;
    }
}
