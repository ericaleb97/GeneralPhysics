using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalLaws
{
    public class TerminalVelocity
    {
        private double dragCoefficient;
        private double crossSectionalArea;
        private double mediumDensity;
        private double gravity;
        private double mass;
        private double finalVelocity;
        private double velocity;
        private double intermittance;
        private double intermittance2;

        public TerminalVelocity(double drag_coefficient, double cross_sectional_area, double medium_density, double _gravity, double _mass)
        {
            dragCoefficient = drag_coefficient;
            crossSectionalArea = cross_sectional_area;
            mediumDensity = medium_density;
            gravity = _gravity;
            mass = _mass;
        }

        public double Intermittance
        {
            get { return intermittance; }
        }

        public double Intermittance2
        {
            get { return intermittance2; }
        }

        public double DragCoefficient
        {
            get { return dragCoefficient; }
        }

        public double Velocity
        {
            get { return velocity; }
        }

        public double CrossSectionalArea
        {
            get { return crossSectionalArea; }
        }

        public double MediumDensity
        {
            get { return mediumDensity; }
        }

        public double Gravity
        {
            get { return gravity; }
        }

        public double Mass
        {
            get { return mass; }
        }

        public double FinalVelocity
        {
            get { return finalVelocity; }
        }

        public void TerminalCalculation()
        {
            intermittance = 2 * gravity * mass;
            intermittance2 = dragCoefficient * crossSectionalArea * mediumDensity;
            velocity = intermittance / intermittance2;
            finalVelocity = Math.Sqrt(velocity);
        }
    }
}
