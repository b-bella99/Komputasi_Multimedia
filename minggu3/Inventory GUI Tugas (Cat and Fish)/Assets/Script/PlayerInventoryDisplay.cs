using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour
{
    public Image[] fishPlaceholders;
    public Sprite iconFishRed;
    public Sprite iconBoneFish;
    public void OnChangeFishTotal(int fishTotal)
    {
        for (int i = 0; i < fishPlaceholders.Length; ++i)
        {
            if (i < fishTotal)
                fishPlaceholders[i].sprite = iconFishRed;
            else
                fishPlaceholders[i].sprite = iconBoneFish;
        }
    }

}
