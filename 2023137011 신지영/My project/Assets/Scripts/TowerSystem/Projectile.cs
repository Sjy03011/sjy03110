using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody rd;        //내부에서 사용할 rd

    public float moveSpped;     //이동속도
    public float damagedAmount;     //데미지 량
    private bool hasDamaged;        //flag 선언

    
    void Start()
    {
        rd = GetComponent<Rigidbody>();
        rd.velocity = transform.forward * moveSpped;        //rd의 앞쪽 방향으로 총알 이동속도를 입력
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy" && !hasDamaged)
        {
            hasDamaged = true;
        }

        Destroy(gameObject);        //Trigger 충돌이 일어나면 파괴
    }
}
