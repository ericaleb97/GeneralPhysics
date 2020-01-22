using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NUnit.Framework.Internal;
using PhysicalLaws;
using Assert = NUnit.Framework.Assert;

namespace ForcesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Forces()
        {
            double mass = 155;
            double acceleration = 9.18;

            var forces = new Forces(acceleration, mass);

            forces.LawofForces();

            double actual = forces.Force;
            double expected = 1422.9;
            Assert.AreEqual(expected‬, actual, 0.000000000001);
        }

        [TestMethod]
        public void PotentialEnergy()
        {
            double springConstant = 10;
            double displacement = 5;

            var potential = new PotentialEnergy(springConstant, displacement);

            potential.ElasticPotentialCalculation();

            double actual = potential.PotentialE;
            double expected = 125;
            Assert.AreEqual(expected‬, actual);
        }

        [TestMethod]
        public void TerminalVelocity()
        {
            double dragCoefficient = 0.5;
            double crossSectionalArea = 0.5;
            double mediumDensity = 1.3;
            double gravity = 9;
            double mass = 85;

            var terminal = new TerminalVelocity(dragCoefficient, crossSectionalArea, mediumDensity, gravity, mass);
            double finalVelocity = 68.61;
            terminal.TerminalCalculation();
            double intermittance = terminal.Intermittance;
            double intermittance2 = terminal.Intermittance2;
            double velocity = terminal.Velocity;
            double actual = terminal.FinalVelocity;
            Assert.AreEqual(finalVelocity, actual, 0.1);
        }

        [TestMethod]
        public void TerminalVelocity2()
        {
            double dragCoefficient = 0.5;
            double crossSectionalArea = 0.5;
            double mediumDensity = 1.3;
            double gravity = 9.18;
            double mass = 87.14;

            var terminal = new TerminalVelocity(dragCoefficient, crossSectionalArea, mediumDensity, gravity, mass);
            double finalVelocity = 70.16;
            terminal.TerminalCalculation();
            double intermittance = terminal.Intermittance;
            double intermittance2 = terminal.Intermittance2;
            double velocity = terminal.Velocity;
            double actual = terminal.FinalVelocity;
            Assert.AreEqual(finalVelocity, actual, 0.1);
        }
    }
}
