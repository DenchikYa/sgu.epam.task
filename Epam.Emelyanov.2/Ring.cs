using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Emelyanov._2
{
    class Ring
    {
        private Point center;
        private int outerRadius;
        private int innerRadius;

        public Point _Center
        {
            get
            {
                return center;
            }
            set
            {
                center = value;
            }
        }
        public int _OuterRadius
        {
            get
            {
                return outerRadius;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius cannot be negative!");
                }
                outerRadius = value;
            }
        }
        public int _InnerRadius
        {
            get
            {
                return innerRadius;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius cannot be negative!");
                }
                innerRadius = value;
            }
        }

        public Ring(Point Center, int outerRadius, int innerRadius)
        {
            if (outerRadius <= innerRadius)
            {
                throw new ArgumentException("Invalid Ring!");
            }
            _Center = Center;
            _OuterRadius = outerRadius;
            _InnerRadius = innerRadius;
        }
        public double SumCircumferenceRadius
        {
            get
            {
                return CircumferenceInnerRadius + CircumferenceOuterRadius;
            }
        }
        private double CircumferenceOuterRadius
        {
            get
            {
                return (2 * Math.PI * outerRadius);
            }
        }
        private double CircumferenceInnerRadius
        {
            get
            {
                return (2 * Math.PI * innerRadius);
            }
        }
        public double Square
        {
            get
            {
                return (Math.PI * (outerRadius * outerRadius - innerRadius * innerRadius));
            }
        }
        public string ShowRing()
        {
            return ($"Center:{center}, Outher radius: {outerRadius}, Inner radius: {innerRadius}");
        }
    }
}
