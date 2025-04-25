using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BathtubDataModel
{
    public class Parameter
    {
        public string Name { get; }
        public double Mean { get; set; }
        public double? CV { get; set; } // Coefficient of Variation, nullable to allow for parameters without CV

        public Parameter(string name, double mean, double? cv= null)
        {
            Name = name;
            Mean = mean;
            CV = cv;
        }

    }

    public class Parameters
    {
        private string _name { get; set; } = "";
        public int Count = 0;
        private Dictionary<string, Parameters> _parameters = null;
        private Dictionary<string, string> _parameterNames = null;

        public Parameters(string name, Dictionary<string, string> parameterNames)
        {
            _name = name;
            _parameterNames = new Dictionary<string, string>(parameterNames);
            _parameters = new Dictionary<string, Parameters>();
        }

        public void AddParameter(string name, Parameters parameter)
        {
            if (_parameterNames.ContainsKey(name))
            {
                if (_parameters.ContainsKey(name))
                    _parameters[name] = parameter; // Update existing parameter
                else
                    _parameters.Add(name, parameter); // Add new parameter

            }
            else
            {
                throw new ArgumentException($"Invalid parameter name '{name}' does not exist in the parameter names dictionary.");
            }
        }

        public Parameters GetParameter(string name)
        {
            Parameters param = null;
            if (_parameters.ContainsKey(name))
                param = _parameters[name];

            return param;
        }
    }

    public class MultiParameter : Parameter
    {
        public double CV { get; set; } // Coefficient of Variation

        public MultiParameter(string name, double mean, double cv)
                : base(name, mean) // Pass 'name' and 'mean' to the base class constructor
        {
            CV = cv; // Initialize the CV property
        }
    }

    public class ParameterGroup
    {
        public string Name { get; }
        private IReadOnlyList<string> _variableNames;
        private List<Parameter> _paramValues = new List<Parameter>();


        public ParameterGroup(string groupName, List<string> variableNames)
        {
            Name = groupName;
            _variableNames = new List<string>(variableNames);
        }

        // Add a parameter value to the group
        public void AddParameter(Parameter parameter)
        {
            _paramValues.Add(parameter);
        }

        // Get all parameter values
        public List<Parameter> GetParameterValues()
        {
            return _paramValues;
        }
    }
}
    
