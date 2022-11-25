using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Kills : MonoBehaviour
{
    public static int Muertos = 0;

    public TMP_Text kills;

    void Update()
    {
        kills.text = "Kills: " + Muertos;
    }
}
