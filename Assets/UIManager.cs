using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Slider[] hpBars;
    private List<Stats> charStats;

    private void Awake()
    {
        //create our list so it's not null
        charStats = new List<Stats>();
    }
    public void AssignBars(GameObject[] incTeam)
    {
        //assign the UI bars to the Stats scripts so the positions match
        for (int i = 0; i < incTeam.Length; i++)
        {
            charStats.Add(incTeam[i].GetComponent<Stats>());
        }
    }

    public void UpdateBars()
    {
        for (int i = 0; i < hpBars.Length; i++)
        {
            //sliders value between 0.0f and 1.0f. 
            float percent = charStats[i].health / 100f;
            hpBars[i].value = percent;
        }
    }
}
