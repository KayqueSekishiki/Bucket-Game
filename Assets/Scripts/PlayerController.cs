using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 4f;
    void Start()
    {

    }


    void Update()
    {
        bool isPressingLeft = Input.GetKey(KeyCode.LeftArrow);
        bool isPressingRight = Input.GetKey(KeyCode.RightArrow);


        if (isPressingLeft == isPressingRight) return;
        float movement = speed * Time.deltaTime;

        if (isPressingLeft) movement *= -1f;
        transform.position += new Vector3(movement, 0, 0);
    }
}
