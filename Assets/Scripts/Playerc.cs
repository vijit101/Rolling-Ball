using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Playerc : MonoBehaviour
{
    Rigidbody rb;
    public float ffactor = 1;
    public TextMeshProUGUI score,wintxt;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        string str = PlayerPrefs.GetInt("score").ToString();
        score.text = "Score : " + str;
        Checkwin();
    }
    public void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        rb.AddForce(new Vector3(-horizontal,0,-vertical)*ffactor,ForceMode.Force);
    }
    public void Checkwin()
    {
        if(PlayerPrefs.GetInt("score")==6)
        {
            score.gameObject.SetActive(false);
            wintxt.gameObject.SetActive(true);
        }
    }
}
