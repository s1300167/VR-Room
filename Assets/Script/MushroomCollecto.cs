using UnityEngine;
using TMPro;

public class MushroomCollector : MonoBehaviour
{
    public int mushroomCount = 0;

    public TextMeshProUGUI mushroomText; // 🍄 UIのTextをセット

    public void AddMushroom()
    {
        mushroomCount++;
        Debug.Log("キノコを拾った！ 合計: " + mushroomCount);

        // UI更新
        if (mushroomText != null)
        {
            mushroomText.text = "Mushroom: " + mushroomCount;
        }
    }
}
