using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public static float score = 0;
    public float globalGrowth = 0;
    private float globalGain = 0;


    void Update()
    {
        globalGrowth = GameObject.Find("Crystal").transform.GetChild(1).GetComponent<CrystalForeground>().growth;
        globalGain = GameObject.Find("Crystal").transform.GetChild(1).GetComponent<CrystalForeground>().gain;
        
        score += globalGrowth * globalGain * Time.deltaTime; 


        SetScore();
    }

    void SetScore() {
        GameObject scoreCounter = GameObject.Find("ScoreText");
        scoreCounter.GetComponent<Text>().text = $"Score: \n {score.ToString("F2")}";
    }
}
