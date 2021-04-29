using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMasterScript : MonoBehaviour
{
    private float masterX = 0;
    private float masterY = 0;
    public GameObject cube;
    private Vector3 spawnPos;
    public float boundScaling = 10;
    // Start is called before the first frame update
    void Start()
    {
        masterX = -20;
        spawnPos.x = 0;
        spawnPos.y = 0;
        spawnPos.z = 0;
        spawnPos.x = masterX;
        float b = boundScaling;
        Instantiate(cube, new Vector3(-b, -b, 0), Quaternion.identity);
        Instantiate(cube, new Vector3(-b, 0, 0), Quaternion.identity);
        Instantiate(cube, new Vector3(-b, b, 0), Quaternion.identity);
        Instantiate(cube, new Vector3(0, -b, 0), Quaternion.identity);
        Instantiate(cube, new Vector3(0, 0, 0), Quaternion.identity);
        Instantiate(cube, new Vector3(0, b, 0), Quaternion.identity);
        Instantiate(cube, new Vector3(b, -b, 0), Quaternion.identity);
        Instantiate(cube, new Vector3(b, 0, 0), Quaternion.identity);
        Instantiate(cube, new Vector3(b, b, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        tick();
        spawnPos.x = masterX;
        spawnPos.y = -(masterX * masterX + 4 * masterX + 3);
        // Instantiate a cube
        if (spawnPos.x <= 20 && spawnPos.x >= -20 && spawnPos.y > -20 && spawnPos.y < 20)
        {
            Instantiate(cube, spawnPos, Quaternion.identity);
        }
    }

    void tick()
    {
        masterX += .1f;
    }
}
