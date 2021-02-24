using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCat : MonoBehaviour
{
    public Text fishText;
    public PlayerInventoryDisplay playerInventoryDisplay;
    private int totalfishs = 0;
    void Start()
    {
        playerInventoryDisplay = GetComponent<PlayerInventoryDisplay>();
        UpdateFishText();
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Fish"))
        {
            totalfishs++;
            UpdateFishText();
            playerInventoryDisplay.OnChangeFishTotal(totalfishs);
            Destroy(hit.gameObject);
        }
    }
    private void UpdateFishText()
    {
        string fishMessage = "Fish = " + totalfishs;
        fishText.text = fishMessage;
    }

}
