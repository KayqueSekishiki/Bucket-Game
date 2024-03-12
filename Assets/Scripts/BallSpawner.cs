using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> prefabs;
    [SerializeField] private Vector3 _originPoint = new Vector3(0, 15, -1);
    [SerializeField] private float _spawmInterval = 1;
    [SerializeField] private float _cooldown = 1;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.Instance.isGameActive) return;

        _cooldown -= Time.deltaTime;
        if (_cooldown <= 0f)
        {
            _cooldown = _spawmInterval;
            SpawmBall();
        }
    }

    private void SpawmBall()
    {
        int prefabIndex = UnityEngine.Random.Range(0, prefabs.Count);
        GameObject prefab = prefabs[prefabIndex];


        float gameWidth = GameManager.Instance.gameWidth;
        float xOffset = UnityEngine.Random.Range(-gameWidth / 2f, gameWidth / 2f);
        Vector3 position = _originPoint + new Vector3(xOffset, 0, 0);



        Quaternion rotation = prefab.transform.rotation;

        Instantiate(prefab, position, rotation);
    }
}
