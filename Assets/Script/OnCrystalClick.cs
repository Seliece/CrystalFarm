using UnityEngine;
using UnityEngine.UI;

public class OnCrystalClick : MonoBehaviour
{
    public GameObject popup;
        
    public void OnClick() {
        Debug.Log("OnClick Triggered");
        Instantiate(popup, transform.parent.parent);          
    }
}
