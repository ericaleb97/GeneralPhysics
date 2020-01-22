using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalLaws
{
   public class Forces
    {
        private double _mass;
        private double _force;
        private double _acceleration;

        public double Mass
        {
            get { return _mass; }
        }

        public double Force
        {
            get { return _force; }
        }

        public double Acceleration
        {
            get { return _acceleration; }
        }

        public Forces(double acceleration, double mass)
        {
            _acceleration = acceleration;
            _mass = mass;
        }

        public void LawofForces()
        {
            _force = _mass * _acceleration;
        }
    }
}
