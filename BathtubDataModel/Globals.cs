using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BathtubDataModel.Globals
{


    public static class GlobalParameters
    {
        public const string Name = "Global Parmameters";
        public const string AVG_PERIOD = "AVERAGING PERIOD (YRS)";
        public const string PRECIPITATION = "PRECIPITATION (METERS)";
        public const string EVAPORATION = "EVAPORATION (METERS)";
        public const string INCREASE_IN_STORAGE = "INCREASE IN STORAGE (METERS)";
        public static List<string> ParameterNames { get; } = ClassAttributes.GetAttributes(typeof(GlobalParameters));
    }

    public static class ModelOptions
    {
        public const string Name = "Model Options";
        public const string ConservativeSubstance = "CONSERVATIVE SUBSTANCE";
        public const string PhosphorusBalance = "PHOSPHORUS BALANCE";
        public const string NitrogenBalance = "NITROGEN BALANCE";
        public const string ChlorophyllA = "CHLOROPHYLL-A";
        public const string SecchiDepth = "SECCHI DEPTH";
        public const string Dispersion = "DISPERSION";
        public const string PhosphorusCalibration = "PHOSPHORUS CALIBRATION";
        public const string NitrogenCalibration = "NITROGEN CALIBRATION";
        public const string ErrorAnalysis = "ERROR ANALYSIS";
        public const string AvailabilityFactors = "AVAILABILITY FACTORS";
        public const string MassBalanceTables = "MASS-BALANCE TABLES";
        public const string OutputDestination = "OUTPUT DESTINATION";
        public static List<string> ParameterNames { get; } = ClassAttributes.GetAttributes(typeof(ModelOptions));
    }

    public static class ModelCoefficients
    {
        public const string Name = "Model Coefficients";
        public const string DispersionRate = "DISPERSION RATE";
        public const string PDecayRate = "P DECAY RATE";
        public const string NDecayRate = "N DECAY RATE";
        public const string ChlAModel = "CHL-A MODEL";
        public const string SecchiModel = "SECCHI MODEL";
        public const string OrganicNModel = "ORGANIC N MODEL";
        public const string TpOpModel = "TP-OP MODEL";
        public const string HodvModel = "HODV MODEL";
        public const string ModvModel = "MODV MODEL";
        public const string VaM2Mg = "va M2/MG";
        public const string MinimumQs = "MINIMUM QS";
        public const string FlushingEffect = "FLUSHING EFFECT";
        public const string ChlorophyllACv = "CHLOROPHYLL-A CV";
        public const string AvailFactorTp = "Avail Factor - TP";
        public const string AvailFactorOrtho = "Avail Factor - Ortho";
        public const string AvailFactorTn = "Avail Factor - TN";
        public const string AvailFactorInorganicN = "Avail Factor - Inorganic N";
        public static List<string> ParameterNames { get; } = ClassAttributes.GetAttributes(typeof(ModelCoefficients));
    }

    public static class AtmosphericLoads
    {
        public const string Name = "Atmospheric Loads";
        public const string ConservativeSubstance = "CONSERVATIVE SUBST.";
        public const string TotalP = "TOTAL P";
        public const string TotalN = "TOTAL N";
        public const string OrthoP = "ORTHO P";
        public const string InorganicN = "INORGANIC N";
        public static List<string> ParameterNames { get; } = ClassAttributes.GetAttributes(typeof(AtmosphericLoads));
    }

    public static class ClassAttributes
    {
        // Helper method to get the attributes of a class
        public static List<string> GetAttributes(Type type)
        {
            // Get the type of the GlobalParameters class
            List<string> attributes = new List<string>();

            //Console.WriteLine("Attributes of GlobalParameters:");

            // Iterate over all public constants in the class
            foreach (FieldInfo field in type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy))
            {
                if (field.IsLiteral && !field.IsInitOnly) // Check if the field is a constant
                {
                    attributes.Add(field.GetValue(null).ToString());
                    //Console.WriteLine($"{field.Name} = {field.GetValue(null)}");
                }
            }
            return attributes;


        }
    }
}
