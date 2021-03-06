﻿public class Medium : Mission
{
    private const string MissionName = "Capturing dangerous criminals";
    private const double EnduranceDecrease = 50;
    private const double WearLevelDecrease = 50;

    public Medium(double scoreToComplete)
        : base(scoreToComplete)
    {

    }

    public override string Name => MissionName;

    public override double EnduranceRequired => EnduranceDecrease;

    public override double WearLevelDecrement => WearLevelDecrease;
}

