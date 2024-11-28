using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class CreateBackground : MonoBehaviour
{
    public float startGrowthPerSecond = 1;
    void Start()
    {
        Instantiate(transform.GetChild(1), transform);
        transform.GetChild(1).AddComponent<CrystalForeground>();
        transform.GetChild(1).GetComponent<CrystalForeground>().growth = startGrowthPerSecond;
        transform.GetChild(2).GetComponent<SpriteRenderer>().color = GetBackgroundColor();
        transform.GetChild(2).GetComponent<SpriteRenderer>().sortingOrder = -1;

        GameObject.Find("ScoreCounter").GetComponent<ScoreCounter>().globalGrowth += startGrowthPerSecond;
    }

    Color GetBackgroundColor() {
        Color backgroundColor = transform.GetChild(1).GetComponent<SpriteRenderer>().color;
        
        float H, S, V;

        Color.RGBToHSV(backgroundColor, out H, out S, out V);

        V -= 0.3f;

        backgroundColor = Color.HSVToRGB(H, S, V);
        
        return backgroundColor;
    }
}
