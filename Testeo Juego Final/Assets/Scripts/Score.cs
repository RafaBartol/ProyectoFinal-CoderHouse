using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int EnemiesDead = 0;
    public static int SoulsRecolected = 0;
    public static int Orbs = 0;

    public Text orbs;
    public Text souls;

    void Update()
    {
        souls.text = "Souls Collected: " + SoulsRecolected;
        orbs.text = "Orbs Collected: " + Orbs;
    }
}
