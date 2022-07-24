using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private int lgoal,rgoal;
    public TextMeshProUGUI textR,textL;
    void Start()
    {
        Launch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Launch()
    {
        transform.position=Vector2.zero;
        float x = Random.Range(0,2) == 0 ? -1 : 1;
        float y = Random.Range(0,2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed*x, speed*y);
        
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag=="GoalRight")
        {
            rgoal++;
            textR.text=rgoal.ToString();
            Launch();
        }
        else  if(other.gameObject.tag=="GoalLeft")
        {
            lgoal++;
            textL.text=lgoal.ToString();
            Launch();
        }
    }
}
