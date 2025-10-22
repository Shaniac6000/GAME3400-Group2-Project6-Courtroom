using UnityEngine;
using TMPro;

public class TextAppear : MonoBehaviour
{
    public GameObject uiPanel;
    public TextMeshProUGUI text;
    public string message = "Welcome child, I am God." +
        "This is the Purgatory Court." +
        "You are dead." +
        "I know this is all a shock, but we must determine if you should go to heaven or hell.";



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiPanel.SetActive(true);
            text.text = message;
        }
    }

    private void OnTriggerExit (Collider other)
    {
        if(other.CompareTag("Player"))
        {
            uiPanel.SetActive(false);
            text.text = "";
        }
    }
}
