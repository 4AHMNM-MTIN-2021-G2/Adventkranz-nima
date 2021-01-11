using UnityEngine;

public class IlluminateAdventkranz : MonoBehaviour
{
    System.DateTime christmasDay;
    System.DateTime firstAdvent;
    System.DateTime secondAdvent;
    System.DateTime thirdAdvent;
    System.DateTime fourthAdvent;
    System.DateTime currentDay;

    public GameObject flame1, flame2, flame3, flame4;

    // Start is called before the first frame update
    void Start()
    {
        christmasDay = new System.DateTime(2020, 12, 24);
        firstAdvent = new System.DateTime(2020, 11, 29);
        secondAdvent = new System.DateTime(2020, 12, 6);
        thirdAdvent = new System.DateTime(2020, 12, 13);
        fourthAdvent = new System.DateTime(2020, 12, 20);

        currentDay = System.DateTime.Today;

        currentDay = firstAdvent;

        flame1.SetActive(false);
        flame2.SetActive(false);
        flame3.SetActive(false);
        flame4.SetActive(false);

        if (currentDay.CompareTo(firstAdvent) >= 0)
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
