using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        if (!GameManager.Instance.isGameActive) return;

        if (other.gameObject.CompareTag("Ball"))
        {
            Destroy(other.gameObject);
            GameManager.Instance.score++;
            Debug.Log("Score: " + GameManager.Instance.score);
        }
    }

}
