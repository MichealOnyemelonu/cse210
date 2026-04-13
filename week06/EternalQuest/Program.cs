// EXCEEDING REQUIREMENTS:
// - Added bonus points for checklist completion
// - Used polymorphism with virtual/override methods
// - File save/load using a simple text format

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
