using UnityEngine;
using UnityEngine.UI;
using System;

public class CountDays : MonoBehaviour
{
    public Text daysGui;

    DateTime christmasDay, currentDay;
    DateTime firstAdvent, secondAdvent, thirdAdvent, fourthAdvent;
    
   
    // Start is called before the first frame update
    void Start()
    {
        christmasDay = new DateTime(2020, 12, 24);
        DefineAdventDates2020();

        currentDay = firstAdvent;

        daysGui.text = TotalDaysToChristmas().ToString();
    }

    private void DefineAdventDates2020()
    {
        firstAdvent = new DateTime(2020, 11, 29);
        secondAdvent = new DateTime(2020, 12, 6);
        thirdAdvent = new DateTime(2020, 12, 13);
        fourthAdvent = new DateTime(2020, 12, 20);
    }
   

  private double TotalDaysToChristmas()
    {
        return christmasDay.Subtract(currentDay).TotalDays;
    }
}

