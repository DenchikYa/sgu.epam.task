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

        public Point Center
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
        public int OuterRadius
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
        public int InnerRadius
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
        public Ring(Point _Center, int _outerRadius, int _innerRadius)
        {
            Center = _Center;
            OuterRadius = _outerRadius;
            InnerRadius = _innerRadius;
        }
        public string ShowRing()
        {
            return ($"Center:{center}, Outher radius: {outerRadius}, Inner radius: {innerRadius}");
        }
    }
}
