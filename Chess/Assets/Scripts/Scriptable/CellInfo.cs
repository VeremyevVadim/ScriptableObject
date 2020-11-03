using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Chess/CellInfo", order = 4)]
public class CellInfo : ScriptableObject
{
    [SerializeField] private int x = 0;
    [SerializeField] private int y = 0;
    [SerializeField] private FigureBase figure = null;

    public int X => x;
    public int Y => y;
    public FigureBase Figure => figure;
}
