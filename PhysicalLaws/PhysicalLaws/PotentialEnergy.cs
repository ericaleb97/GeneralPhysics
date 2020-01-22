using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalLaws
{
    public class PotentialEnergy
    {
        private double springConstant;
        private double displacement;
        private double potentialEnergy;

        public PotentialEnergy(double spring_constant, double _displacement)
        {
            springConstant = spring_constant;
            displacement = _displacement;
        }

        public double SpringConstant
        {
            get { return springConstant; }
        }

        public double Displacement
        {
            get { return displacement; }
        }

        public double PotentialE
        {
            get { return potentialEnergy; }
        }

        public void ElasticPotentialCalculation()
        {
            potentialEnergy = 0.5 * springConstant * Math.Pow(displacement, 2);
        }
    }
}
