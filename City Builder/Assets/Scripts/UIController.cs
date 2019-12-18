using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{   
    
    private City city;
    [SerializeField]
    private Text dayText;
    [SerializeField] 
    private Text cityText;

    // Start is called before the first frame update
    void Start()
    {
        city = GetComponent<City>();
        dayText.text = "Day 1";
    }

    public void UpdateCityData()
    {
      cityText.text = string.Format
            ("Job: {0}/{1}\nCash: $ {2} (+${6})\nPopulation: {3}/{4}\nFood: {5}",
            city.JobsCurrent, city.JobsCeiling, city.Cash, (int)city.PopulationCurrent, (int)city.PopulationCeiling, (int)city.Food, city.JobsCurrent*2);
    }

    public void UpdateDayCount()
    {
        dayText.text = string.Format("Day {0}", city.Day);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
