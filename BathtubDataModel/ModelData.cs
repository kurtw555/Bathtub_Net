using BathtubDataModel.Globals;
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
            InitializeModelParameters();
            ReadBTBFile("Keystone.btb"); // Default file path, can be changed later


        }

        private void InitializeModelParameters()
        {
            var paramNames = Globals.GlobalParameters.ParameterNames;
            var groupName = Globals.GlobalParameters.Name;
            ParameterGroup globalParams = new ParameterGroup(groupName, paramNames);
            _parameterGroups.Add(groupName, globalParams);

            paramNames = Globals.ModelOptions.ParameterNames;
            groupName = Globals.ModelOptions.Name;
            ParameterGroup modelOpts = new ParameterGroup(groupName, paramNames);
            _parameterGroups.Add(groupName, modelOpts);

            paramNames = Globals.ModelCoefficients.ParameterNames;
            groupName = Globals.ModelCoefficients.Name;
            ParameterGroup modelCoeffs = new ParameterGroup(groupName, paramNames);
            _parameterGroups.Add(groupName, modelCoeffs);

            paramNames = Globals.AtmosphericLoads.ParameterNames;
            groupName = Globals.AtmosphericLoads.Name;
            ParameterGroup atmosphericLoads = new ParameterGroup(groupName, paramNames);
            _parameterGroups.Add(groupName, atmosphericLoads);

        }

        public void ReadBTBFile(string path)
        {
            if (string.IsNullOrEmpty(path))            
                throw new ArgumentException("Path cannot be null or empty.", nameof(path));            

            if (!System.IO.File.Exists(path))            
                throw new System.IO.FileNotFoundException("BTB file not found.", path);            

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
                //Trim whitespace and quotes from the parameter name
                string parameterName = param[1].Trim().Trim('\'', '\"');
                if (string.Compare(GlobalParameters.Name, parameterName, true) == 0)
                    ParseParameters(reader, parameterName, dimension);
                else if (string.Compare(ModelOptions.Name, parameterName, true) == 0)
                    ParseParameters(reader, parameterName, dimension);
                else if (string.Compare(ModelCoefficients.Name, parameterName, true) == 0)
                    ParseParameters(reader, parameterName, dimension);
                else if (string.Compare(AtmosphericLoads.Name, parameterName, true) == 0)
                    ParseParameters(reader, parameterName, dimension);
            }

                
                     


            //}
        }

        private void ParseParameters(StreamReader reader, string groupName, int count)
        {
            for (int i = 0; i < count; i++)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split(',');
                string id = parts[0].Trim().Trim('\'', '\"'); // Read the first part as ID
                string name = parts[1].Trim().Trim('\'', '\"');
                double mean = double.Parse(parts[1]);
                double? cv = null; // Initialize CV as null
                if (parts.Length > 3)
                    cv = double.Parse(parts[2]);                
                _parameterGroups[GlobalParameters.Name].AddParameter(new Parameter(name, mean, cv));

            }
        }

        private void ParseModelOptions(StreamReader reader, int count)
        {
            for (int i = 0; i < count; i++)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split(',');
                //ModelOptions.Add(new ModelOption
                //{
                //    Id = int.Parse(parts[0]),
                //    Name = parts[1].Trim('"'),
                //    Value = int.Parse(parts[2])
                //});
            }
        }



    }


}
