using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    void Update()
    {
        if (!GameManager.Instance.isGameActive) return;

        bool isPressingLeft = Input.GetKey(KeyCode.LeftArrow);
        bool isPressingRight = Input.GetKey(KeyCode.RightArrow);


        if (isPressingLeft == isPressingRight) return;
        float movement = speed * Time.deltaTime;

        if (isPressingLeft) movement *= -1f;
        transform.position += new Vector3(movement, 0, 0);

        float movementLimit = (GameManager.Instance.gameWidth - 2) / 2;
        if (transform.position.x < -movementLimit)
        {
            transform.position = new Vector3(-movementLimit, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > movementLimit)
        {
            transform.position = new Vector3(movementLimit, transform.position.y, transform.position.z);
        }
    }
}
