using UnityEngine;
using UnityEngine.UI;

public class upgradeGain : MonoBehaviour
{

    float gain;
    float price;
    void Start()
    {
        gain = transform.parent.parent.parent.GetChild(1).GetComponent<CrystalForeground>().gain;
        price = gain * 10;
        transform.GetChild(0).GetComponent<Text>().text = $"Upgrade Gain: {gain} -> {2*gain} \n Cost: {price}";
    }

    public void Onclick() {

        if (ScoreCounter.score >= price) {
            ScoreCounter.score -= price;
            gain *= 2;
            price = gain * 10;
            
            transform.GetChild(0).GetComponent<Text>().text = $"Upgrade Gain: {gain} -> {2*gain} \n Cost: {price}";
            transform.parent.parent.parent.GetChild(1).GetComponent<CrystalForeground>().gain *= 2;
        }
    }
}
