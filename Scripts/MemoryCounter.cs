using UnityEngine;
using TMPro;
using System.Collections;

public class MemoryCounter : MonoBehaviour
{
    public static MemoryCounter Instance;

    public GameObject memoryCanvas;
    public TextMeshProUGUI memoryText;
    public GameObject endScreen;

    int memoriesFound = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void MemoryFound()
    {
        memoriesFound++;
        memoryCanvas.SetActive(true);
        memoryText.text = "Ricordo recuperato!\n" + memoriesFound + "/3";
        StartCoroutine(HideMessage());
    }

    IEnumerator HideMessage()
    {
        yield return new WaitForSeconds(4f);
        memoryCanvas.SetActive(false);
        
        if (memoriesFound >= 3)
        {
            endScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
