using System;
using System.Collections.Generic;
using System.Linq;
using DefaultNamespace;
using UnityEngine;

public class Team : MonoBehaviour
{
    private List<Figure> figures;
    [SerializeField] private BoardEntity board;
    [SerializeField] private FigureColor teamColor = FigureColor.Black;
  
    private void Start()
    {
        // Get all black/white figures on board
        figures = board.GetFigures(teamColor).ToList();
        foreach (var figure in figures)
        {
            Debug.Log($"{teamColor} {figure.BaseInfo.GetFigureType().ToString()}");
        }
    }
}
