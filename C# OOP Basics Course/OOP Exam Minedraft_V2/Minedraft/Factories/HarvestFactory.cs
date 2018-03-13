﻿using System;
using System.Collections.Generic;
using System.Text;


public class HarvestFactory
{
    public static Harvester CreateHarvest(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var oreOutput = double.Parse(arguments[2]);
        var energyRequirement = double.Parse(arguments[3]);

        switch (type)
        {
            case "Sonic":
                var sonicFactor = int.Parse(arguments[4]);
                return new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);               
                break;
            case "Hammer":
                return new HammerHarvester(id, oreOutput, energyRequirement);
                break;

            default:
                throw new ArgumentException();
                break;
        }

    }
}

