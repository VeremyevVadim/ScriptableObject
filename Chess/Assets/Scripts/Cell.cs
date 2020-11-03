using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    private FigureBase _figure = null;

    public void Setup(FigureBase figure, GameObject prefabFigure)
    {
        _figure = figure;
        prefab = prefabFigure;
    }
    
}
