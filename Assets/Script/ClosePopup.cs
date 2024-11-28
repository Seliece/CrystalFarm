using UnityEngine;

public class ClosePopup : MonoBehaviour
{
    public void OnClick() {
        Destroy(transform.parent.parent.gameObject);
    }
}
