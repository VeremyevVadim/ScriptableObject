using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Chess/Figure")]
public class FigureBase : ScriptableObject
{
    [SerializeField] private FigureType figureType;
    [SerializeField] private FigureColor figureColor;
    [SerializeField] private MovementType movementType;
    [SerializeField] private GameObject prefab;


    public FigureType GetFigureType()
    {
        return figureType;
    }

    public FigureColor GetFigureColor()
    {
        return figureColor;
    }

    public MovementType GetFigureMovementType()
    {
        return movementType;
    }

    public GameObject GetFigurePrefab()
    {
        return prefab;
    }
}

public enum FigureType
{
    King = 0,
    Queen,
    Bishop,
    Knight,
    Rook,
    Pawn
}

public enum FigureColor
{
    Black,
    White
}

public enum MovementType
{
    King = 0,
    Queen,
    Bishop,
    Knight,
    Rook,
    Pawn
}

