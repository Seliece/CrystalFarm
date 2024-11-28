using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UpgradeSpeed : MonoBehaviour
{
    
    float speed;
    float price;
    void Start()
    {
        speed = transform.parent.parent.parent.GetChild(1).GetComponent<CrystalForeground>().growth;
        price = speed * 10;
        transform.GetChild(0).GetComponent<Text>().text = $"Upgrade Speed: {speed} -> {2*speed} \n Cost: {price}";
    }

    public void Onclick() {

        if (ScoreCounter.score >= price) {
            ScoreCounter.score -= price;
            speed *= 2;
            price = speed * 10;
            
            transform.GetChild(0).GetComponent<Text>().text = $"Upgrade Speed: {speed} -> {2*speed} \n Cost: {price}";
            transform.parent.parent.parent.GetChild(1).GetComponent<CrystalForeground>().growth *= 2;
        }
    }
}
