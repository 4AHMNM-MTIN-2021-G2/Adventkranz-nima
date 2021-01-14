using UnityEngine;
using System;

public class IlluminateAdventkranz : MonoBehaviour
{
    DateTime christmasDay, currentDay;
    DateTime firstAdvent, secondAdvent, thirdAdvent, fourthAdvent;

    public GameObject flame1, flame2, flame3, flame4;

    // Start is called before the first frame update
    void Start()
    {
        DefineAdventDates2020();
        ResetFlames();

        // currentDay = System.DateTime.Today;
        currentDay = firstAdvent;

        IlluminateCandles();
    }
        private void DefineAdventDates2020()
        {
            firstAdvent = new DateTime(2020, 11, 29);
            secondAdvent = new DateTime(2020, 12, 6);
            thirdAdvent = new DateTime(2020, 12, 13);
            fourthAdvent = new DateTime(2020, 12, 20);
            christmasDay = new DateTime(2020, 12, 24);
        }

        private void ResetFlames()
        {
            flame1.SetActive(false);
            flame2.SetActive(false);
            flame3.SetActive(false);
            flame4.SetActive(false);
        }

        private void IlluminateCandles()
        {
            if (currentDay.CompareTo(firstAdvent) >=0)
            {
                flame1.SetActive(true);
            }

            if (currentDay.CompareTo(secondAdvent) >= 0)
            {
                flame2.SetActive(true);
            }

            if (currentDay.CompareTo(thirdAdvent) >= 0)
            {
                flame3.SetActive(true);
            }

            if (currentDay.CompareTo(fourthAdvent) >= 0)
            {
                flame4.SetActive(true);
            }
        }
    


}
