using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class TrashSpawner : MonoBehaviour
{
    [SerializeField]GameObject[] Trash;
    public float movetimerMax = 5;
    float movetimer;
    float maxXpos = 21;
    float minXpos = -21;
    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GetComponent<GameManager>();
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
            movetimerMax = 5 - gm.Score / 100 * 5;
            movetimerMax = Mathf.Clamp(movetimerMax, 2.2f, 100);
        }
    }
}
