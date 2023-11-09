using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    [SerializeField]GameObject[] Trash;
    float movetimerMax = 4;
    float movetimer;
    float maxXpos = 21;
    float minXpos = -21;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 12, 0);
    }

    // Update is called once per frame
    void Update()
    {
        movetimer += Time.deltaTime;
        if (movetimer >= movetimerMax)
        {
            movetimer = 0;
            Instantiate(Trash[Random.Range(0, Trash.Length)], this.transform.position, this.transform.rotation);
            transform.position = new Vector3(Random.Range(minXpos, maxXpos), 12, 0);
        }
    }
}
