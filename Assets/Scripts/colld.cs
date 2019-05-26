using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colld : MonoBehaviour
{
    // Start is called before the first frame update
    int sc = 0;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        sc = PlayerPrefs.GetInt("score");
        sc++;
        PlayerPrefs.SetInt("score", sc);
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("true");
            Destroy(gameObject);
        }
    }

    void Start()
    {
        PlayerPrefs.SetInt("score", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
