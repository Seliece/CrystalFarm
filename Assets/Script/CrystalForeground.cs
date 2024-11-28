using UnityEngine;

public class CrystalForeground : MonoBehaviour
{
    

    public float growth = 1;
    public float gain = 1;
    void Update()
    {
        float size = transform.localScale.y;
        if (growth >= 10) {
            size = 1;
            transform.localScale = new Vector3(1, size, 1);
            return;
        }
        if (size >= 1) {
            size = 0;
        }
        size += growth * Time.deltaTime;

        if (size >= 1) {
            size = 1;
        }
        transform.localScale = new Vector3(1, size, 1);
    }
}
