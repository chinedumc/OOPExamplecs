using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Creator
{
    private int _creativityLevel = 100;

    private int _energyLevel = 100;

    public int CreativityLevel
    {
        get 
        {
            return _creativityLevel;
        }
        set 
        {
            if(value>=0 && value <= 100)
            {
                _creativityLevel = value;
            }
            else
            {
                throw new Exception("Creativity level must be between 0 and 100.");
            }
        }
    }

    public int EnergyLevel
    {
        get
        {
            return _energyLevel;
        }
        set
        {
            if (value >= 0 && value <= 100)
            {
                _energyLevel = value;
            }
            else
            {
                throw new Exception("Energy level must be between 0 and 100.");
            }
        }
    }

    public abstract void Create();
}

