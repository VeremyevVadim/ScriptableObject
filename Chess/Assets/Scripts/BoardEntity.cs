using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using DefaultNamespace;
using UnityEngine;

public class BoardEntity : MonoBehaviour
{
    [SerializeField] private Board board;
    [SerializeField] private Cell cell;

    private List<GameObject> _figures;
    private Cell[,] _cellGrid;
    private void Awake()
    {
        _cellGrid = new Cell[board.Height, board.Width];
        _figures = new List<GameObject>();
        
        // Create cells
        for (var i = 0; i < board.Height; i++)
        {
            for (var j = 0; j < board.Width; j++)
            {
                var localScale = cell.transform.localScale;
                _cellGrid[i, j] = Instantiate(cell, new Vector3(j * localScale.x, 0f, i * localScale.z), Quaternion.identity);
            }
        }

        // Spawn figures
        for (var i = 0; i < board.Arrangment.Lenght; i++)
        {
            var cellInfo = board.Arrangment[i];
            if (cellInfo.Figure != null)
            {
                var x = cellInfo.X;
                var y = cellInfo.Y;

                var a = Instantiate(cellInfo.Figure.GetFigurePrefab(), new Vector3(x, 0, y), Quaternion.identity);
                a.AddComponent<Figure>();
                a.GetComponent<Figure>().BaseInfo = cellInfo.Figure;
                _cellGrid[x, y].Setup(cellInfo.Figure, a);
                
                _figures.Add(a);
            }
        }
    }

    public IEnumerable<Figure> GetFigures(FigureColor color)
    {
        List<Figure> list = new List<Figure>();

        foreach (var figure in _figures)
        {
            var figureComponent = figure.GetComponent<Figure>();
            if (figureComponent)
            {
                if (figureComponent.BaseInfo.GetFigureColor() == color)
                    list.Add(figureComponent);
            }
        }

        return list;
    }
}
