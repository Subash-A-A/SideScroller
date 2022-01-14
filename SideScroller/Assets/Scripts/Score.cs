using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    Animator animator;
    Text score;
    private void Start()
    {
        animator = player.GetComponent<Animator>();
        score = GetComponent<Text>();
    }
    void Update()
    {
        if(animator.enabled == true)
        {
            float scoreInt = float.Parse(score.text);
            scoreInt += Time.deltaTime;
            score.text = scoreInt + "";
        }
    }
}
