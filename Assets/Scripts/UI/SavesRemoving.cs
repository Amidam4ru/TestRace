using UnityEngine;

public class SavesRemoving : MonoBehaviour
{
    public void Remove()
    {
        PlayerPrefs.DeleteAll();
    }
}
