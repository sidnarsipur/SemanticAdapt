using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiViewer: MonoBehaviour
{
    public enum Environment { Bedroom, OpenOffice, CoffeeShop, StudyRoom };

    [Header("Controls")]
    public Environment environmentOne;
    public Environment environmentTwo;

    void Start()
    {
    }

    void Update()
    {
    }
}