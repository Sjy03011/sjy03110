using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowdownToWer : MonoBehaviour
{

    private Tower thisTower;
    // Start is called before the first frame update
    void Start()
    {
        thisTower = GetComponent<Tower>();

    }

    // Update is called once per frame
    void Update()
    {
        if (thisTower.enemiesUpdate)
        {

            if(thisTower.enemiesInRange.Count >0)
            {

                foreach(EnemyController enemy in thisTower.enemiesInRange)
                {
                    enemy.SetMode(thisTower.fireRate);

                }


            }





        }
    }
}
