using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiViewer: MonoBehaviour
{
    public enum Environment { Bedroom, OpenOffice, CoffeeShop, StudyRoom };

    [Header("Controls")]
    public Environment environment_one;
    public Environment environment_two;

    void Start()
    {
    }

    void Update()
    {
    }
}