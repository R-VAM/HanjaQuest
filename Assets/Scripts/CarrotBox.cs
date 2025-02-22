using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotBox : MonoBehaviour
{
    public RabbitGameManager rabbitGameManager;

    public int carrotCount = 10;    // 지켜야 할 당근의 수  // 0 되면 종료
    public float timer = 0f;        // 시간 재는 변수 (3초 count) 
    public float limitTime = 3f;    // 3초 지나면 당근--
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    // Monster(토끼)랑 충돌하는 동안 타이머 재생
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Monster"))
        {
            // Debug.Log("Monster Collision");
            timer += Time.deltaTime;

            if (timer > limitTime)
            {
                Destroy(collision.gameObject);  // 토끼 제거
                //rabbitGameManager.dequeue();    // 큐에서 토끼 obj 제거

                carrotCount--;
                timer = 0;
            }
        }
    }
}
