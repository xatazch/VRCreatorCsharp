using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float speed = 5f;
    public GameObject dartPrefab;
    public Transform dartSpawnPoint;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(Vector3.left  * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(Vector3.right *  Time.deltaTime * speed);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dartPrefab, dartSpawnPoint.position, dartSpawnPoint.rotation);
        }
    }
}
