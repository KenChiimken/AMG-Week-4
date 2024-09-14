using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Script : MonoBehaviour
{
    [Header("Static Properties")]
    [SerializeField] private float Epsilon;
    [SerializeField] private float Infinity;
    [SerializeField] private float NegativeInfinity;
    [SerializeField] private float Pi;

    [Header("Static Methods")]
    [SerializeField] private float Abs;
    [SerializeField] private bool Approximately;
    [SerializeField] private float Ceil;
    [SerializeField] private float CeilToInt;
    [SerializeField] private float Clamp;
    [SerializeField] private float Clamp01;
    [SerializeField] private float ClosestPowerOfTwo;
    [SerializeField] private Color CorrelatedColorTemperatureToRGB;
    [SerializeField] private float Exp;
    [SerializeField] private float FloatToHalf;
    [SerializeField] private float Floor;
    [SerializeField] private float FloorToInt;
    [SerializeField] private float GammaToLinearSpace;
    [SerializeField] private float HalfToFloat;
    [SerializeField] private float InverseLerp;
    [SerializeField] private bool IsPowerOfTwo;
    [SerializeField] private float Lerp;
    [SerializeField] private float LerpAngle;
    [SerializeField] private float LerpUnclamped;
    [SerializeField] private float Log;
    [SerializeField] private float Log10;
    [SerializeField] private float Max;
    [SerializeField] private float Min;
    [SerializeField] private float MoveTowards;
    [SerializeField] private float MoveTowardsAngle;
    [SerializeField] private float NextPowerOFTwo;
    [SerializeField] private float PerlinNoise1D;
    [SerializeField] private float PingPong;
    [SerializeField] private float Pow;
    [SerializeField] private float Repeat;
    [SerializeField] private float Round;
    [SerializeField] private float RoundToInt;
    [SerializeField] private float Sign;
    [SerializeField] private float SmoothDamp;
    [SerializeField] private float SmoothStep;
    [SerializeField] private float Sqrt;

    //For SmoothDamp time and velocity ref values
    private float smoothTime = 0.6f;
    private float yVelocity = 0.2f;

    private void Update()
    {
        Epsilon = Mathf.Epsilon;
        Infinity = Mathf.Infinity;
        NegativeInfinity = Mathf.NegativeInfinity;
        Pi = Mathf.PI;
        Abs = Mathf.Abs(5);
        Approximately = Mathf.Approximately(Abs, Pi);
        Ceil = Mathf.Ceil(6);
        CeilToInt = Mathf.CeilToInt(Abs);
        Clamp = Mathf.Clamp(Clamp, Pi, Abs);
        Clamp01 = Mathf.Clamp(Clamp01, Pi, Clamp);
        ClosestPowerOfTwo = Mathf.ClosestPowerOfTwo(5);
        CorrelatedColorTemperatureToRGB = Mathf.CorrelatedColorTemperatureToRGB(9000);
        Exp = Mathf.Exp(5 - 10);
        FloatToHalf = Mathf.FloatToHalf(10);
        Floor = Mathf.Floor(2);
        FloorToInt = Mathf.FloorToInt(2);
        GammaToLinearSpace = Mathf.GammaToLinearSpace(5);
        HalfToFloat = Mathf.HalfToFloat(5);
        InverseLerp = Mathf.InverseLerp(10, 20, 15);
        IsPowerOfTwo = Mathf.IsPowerOfTwo(4);
        Lerp = Mathf.Lerp(1, 1, 2);
        LerpAngle = Mathf.LerpAngle(5, 6, 9);
        LerpUnclamped = Mathf.LerpUnclamped(5, 6, 9);
        Log = Mathf.Log(9);
        Log10 = Mathf.Log10(9);
        Max = Mathf.Max(100, Max);
        Min = Mathf.Min(50, Min);
        MoveTowards = Mathf.MoveTowards(100, 50, 20);
        MoveTowardsAngle = Mathf.MoveTowardsAngle(100, 50, 15);
        NextPowerOFTwo = Mathf.NextPowerOfTwo(10);
        PerlinNoise1D = Mathf.PerlinNoise1D(0);
        PingPong = Mathf.PingPong(8, 10);
        Pow = Mathf.Pow(10, 20);
        Repeat = Mathf.Repeat(5, 10);
        Round = Mathf.Round(100);
        RoundToInt = Mathf.RoundToInt(100);
        Sign = Mathf.Sign(15);
        SmoothDamp = Mathf.SmoothDamp(1, 5, ref yVelocity, smoothTime);
        SmoothStep = Mathf.SmoothStep(10, 15, 40);
        Sqrt = Mathf.Sqrt(100);
    }
}
