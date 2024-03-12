using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        if (!GameManager.Instance.isGameActive) return;

        if (other.gameObject.CompareTag("Ball"))
        {
            Destroy(other.gameObject);
            Debug.Log("GAME OVER!!!");
            GameManager.Instance.isGameActive = false;
            GameObject[] BallS = GameObject.FindGameObjectsWithTag("Ball");
            foreach (GameObject ball in BallS)
            {
                Destroy(ball);
            }
        }
    }
}
