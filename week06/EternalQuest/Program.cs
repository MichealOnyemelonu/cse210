// EXCEEDING REQUIREMENTS:
// Added a NegativeGoal type that subtracts points as a penalty
// Introduced risk/reward mechanics for tracking bad habits
// Extended save/load functionality to support custom goal types

using System;

using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
