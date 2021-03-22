using ProjectPhase1.Builders;
using ProjectPhase1.Repositories;
using ProjectPhase1.Strategies;
using ProjectPhase1.Templates;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProjectPhase1
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new ConcreteTeacherManagementApp();
            app.Run();
        }
    }
}
