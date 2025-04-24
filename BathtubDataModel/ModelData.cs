using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BathtubDataModel
{
    public class ModelData
    {
        public Dictionary<string, Parameters> ModelParameters { get; set; }
        private Dictionary<string, ParameterGroup> _parameterGroups = null;

        public ModelData() 
        {
            ModelParameters = new Dictionary<string, Parameters>();
            _parameterGroups = new Dictionary<string, ParameterGroup>();
        }

        private void InitializeModelParameters()
        {
            // Initialize ModelParameters with default values or from a configuration
            // This is just a placeholder; actual initialization logic will depend on the application requirements
            ModelParameters.Add("DefaultParameter", new Parameters("Default", new Dictionary<string, string> { { "Param1", "Value1" } }));
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
            while ((line = reader.ReadLine()) != null)
            {
                // Process each line of the file
                Console.WriteLine(line); // Replace with actual logic to populate ModelParameters
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
