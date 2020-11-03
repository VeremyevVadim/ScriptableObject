using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

[CreateAssetMenu(menuName = "Chess/BaseArrangment", order = 3)]
public class BaseArrangment : ScriptableObject
{
    [SerializeField] private CellInfo[] cellGrid;

    public CellInfo this[int index] => cellGrid[index];

    public int Lenght => cellGrid.Length;
}
