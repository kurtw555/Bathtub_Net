using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BathtubDataModel
{
    public class ModelData
    {
        public string Version { get; set; }
        public string CaseName { get; set; }
        public Dictionary<string, Parameters> ModelParameters { get; set; }
        private Dictionary<string, ParameterGroup> _parameterGroups = null;

        public ModelData() 
        {
            ModelParameters = new Dictionary<string, Parameters>();
            _parameterGroups = new Dictionary<string, ParameterGroup>();


        }

        private void InitializeModelParameters()
        {
            var paramNames = Globals.GlobalParameters.ParameterNames;
            var groupName = Globals.GlobalParameters.Name;
            ParameterGroup globalParams = new ParameterGroup(groupName, paramNames);

            paramNames = Globals.ModelOptions.ParameterNames;
            groupName = Globals.ModelOptions.Name;
            ParameterGroup modelOpts = new ParameterGroup(groupName, paramNames);

            paramNames = Globals.ModelCoefficients.ParameterNames;
            groupName = Globals.ModelCoefficients.Name;
            ParameterGroup modelCoeffs = new ParameterGroup(groupName, paramNames);

            paramNames = Globals.AtmosphericLoads.ParameterNames;
            groupName = Globals.AtmosphericLoads.Name;
            ParameterGroup atmosphericLoads = new ParameterGroup(groupName, paramNames);
            
        }

        public void ReadBTBFile(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException("Path cannot be null or empty.", nameof(path));
            }

            if (!System.IO.File.Exists(path))
            {
                throw new System.IO.FileNotFoundException("BTB file not found.", path);
            }

            //Read the BTB file and populate ModelParameters
            using StreamReader reader = new StreamReader(path);
            string line;
            int lineNumber = 0;
            //First two lines are meta data:
            //Vers 6.14
            //Default Case
            Version = reader.ReadLine().Trim(); // Read the first line (version info)
            CaseName = reader.ReadLine().Trim(); // Read the second line (case name)

            while ((line = reader.ReadLine()) != null)
            {
                string[] param = line.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                int dimension = int.Parse(param[0]);
                string parameterName = param[1].Trim();


            }
        }
    }

    public static class ParameterNames
    {
        public static List<string> GetGlobalParameterList()
        {
            return new List<string>
            {
                "Global Parmameters",
                "AVERAGING PERIOD (YRS)",
                "Param3"
                // Add more parameters as needed
            };
        }
        public static Dictionary<string, string> GetParameterNames()
        {       return new Dictionary<string, string>
            {
                { "Param1", "Parameter 1" },
                { "Param2", "Parameter 2" },
                { "Param3", "Parameter 3" }
                // Add more parameters as needed
            };
        }
    }
}
