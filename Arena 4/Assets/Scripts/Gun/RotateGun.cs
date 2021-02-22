using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGun : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Target;

    // Update is called once per frame
    void FixedUpdate()
    {
        FaceEnemy();
    }


    void FaceEnemy()

    {

        Vector3 targetPos = Target.transform.position;

        Vector2 direction = new Vector2(
             targetPos.x - transform.position.x,
             targetPos.y - transform.position.y);

        transform.right = direction;


    }
}
