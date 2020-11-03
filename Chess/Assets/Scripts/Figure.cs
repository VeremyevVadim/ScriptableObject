using System;
using UnityEngine;

public class Figure : MonoBehaviour
{
    [SerializeField] private FigureBase baseInfo;

    public FigureBase BaseInfo
    {
        get => baseInfo;
        set => baseInfo = value;
    }
}