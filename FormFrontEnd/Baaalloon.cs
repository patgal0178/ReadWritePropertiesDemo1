using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FormFrontEnd
{
    public class Baaalloon
    {
        #region fields
        private string color;
        private double diametre;

        #endregion

        #region properties
        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                if(value.ToLower()=="red"|| value.ToLower() == "blue")
                {
                    color = value;
                }
                else
                {
                    throw new DataException("color must be red or blue");
                }

            }
        }
        
        public double Height{ get; set; }

        public double Diametre
        {
            get
            {
                return diametre;
            }

            set
            {
                if(color.ToLower() == "red")
                {
                    if (value <= 12)
                    {
                        diametre = value;
                    }
                    else
                    {
                        throw new ConstraintException("red balloon must be 12 inches or less");
                    }
                }
                else if(color.ToLower() == "blue")
                {
                    if (value <= 10)
                    {
                        diametre = value;
                    }
                    else
                    {
                        throw new ConstraintException("blue balloon must be 10 inches or less");
                    }
                }

            }
        }
        #endregion

        #region methods
        #endregion
    }
}
