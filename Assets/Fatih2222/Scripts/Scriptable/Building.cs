using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Building : MonoBehaviour
{
    [SerializeField] private BuildingsSO buildingsSO;

    [SerializeField] private Canvas my_canvas;

    public List<Transform> coin_holders = new List<Transform>();

    public int price = 3;
    void Start()
    {
        
    }


    void Update()
    {
       
    }


}
