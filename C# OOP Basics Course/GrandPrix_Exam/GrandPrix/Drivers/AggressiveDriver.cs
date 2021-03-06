﻿using System;
using System.Collections.Generic;
using System.Text;


public class AggressiveDriver : Driver
{

    public AggressiveDriver(string name, Car car) : base(name, car)
    {

    }

    public override double FuelConsumptionPerKm => 2.7;

    public override double Speed => 1.3 * ((Car.Hp + Car.Tyre.Degradation) / Car.FuelAmount);
}

