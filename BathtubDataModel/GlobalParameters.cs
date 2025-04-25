//using BathtubDataModel.ModelOptions;

//namespace BathtubDataModel.GlobalParameters
//{
//    //Global Parameter
//    public class GlobalParameter
//    {
//        public string Name { get; }
//        public string Units { get;  }
//        public double Mean { get; set; }
//        public double CV { get; set; }

//        public GlobalParameter(string name, string units, double mean, double cv)
//        {
//            Name = name;
//            Units = units;
//            Mean = mean;
//            CV = cv;
//        }
//    }

//    public class GlobalParametersVariable
//    {
//        public string Name { get; set; } = "Global Parmameters";
//        public List<string> _variableNames;

//        private Dictionary<string,GlobalParameter> _parameters = null;
//        //public GlobalParameters()
//        //{
//        //    _variableNames = new List<string>();
//        //    _variableNames.Add("Global Parmameters");
//        //    _variableNames.Add("AVERAGING PERIOD (YRS)");
//        //    _variableNames.Add("PRECIPITATION (METERS)");
//        //    _variableNames.Add("EVAPORATION (METERS)");
//        //    _variableNames.Add("INCREASE IN STORAGE (METERS)");

//            //_parameters = new Dictionary<string, GlobalParameter>();

//            //var averagingPeriod = new GlobalParameter("AVERAGING PERIOD (YRS)", "years", 0.0, 0.0);
//            //_parameters.Add(averagingPeriod.Name, averagingPeriod);

//            //var precipitation = new GlobalParameter("PRECIPITATION (METERS)", "meters", 0.0, 0.0);
//            //_parameters.Add(precipitation.Name, precipitation);

//            //var evaporation = new GlobalParameter("EVAPORATION (METERS)", "meters", 0.0, 0.0);
//            //_parameters.Add(evaporation.Name, evaporation);

//            //var increaseInStorage = new GlobalParameter("INCREASE IN STORAGE (METERS)", "meters", 0.0, 0.0);
//            //_parameters.Add(increaseInStorage.Name, increaseInStorage);

           
           
//        //}

//        //public void SetParameter(string name, double mean, double cv)
//        //{
//        //    if (_parameters.ContainsKey(name))
//        //    {
//        //        _parameters[name].Mean = mean;
//        //        _parameters[name].CV = cv;                
//        //    }
//        //}

//        //public GlobalParameter GetParameter(string name)
//        //{
//        //    GlobalParameter param = null;
//        //    if (_parameters.ContainsKey(name))
//        //    {
//        //        param = _parameters[name];
//        //    }
//        //    return param;
//        //}


//    }
//    //Averaging Period (years)
//    //public class AveragingPeriod : GlobalParameter
//    //{
//    //    public AveragingPeriod(double mean)
//    //    {
//    //        Name = "Averaging Period";
//    //        Units = "years";
//    //        Mean = mean;
//    //        CV = 0.0;
//    //    }
//    //}

//    ////Precipitation (meters)
//    //public class Precipitation : GlobalParameter
//    //{       
//    //    public Precipitation(double mean, double cv)
//    //    {
//    //        Name = "Precipitation";
//    //        Units = "meters";
//    //        Mean = mean;
//    //        CV = cv;
//    //    }
//    //}

//    ////Evaportation (meters)
//    //public class Evaportation : GlobalParameter
//    //{
//    //    public Evaportation(double mean, double cv)
//    //    {
//    //        Name = "Evaportation";
//    //        Units = "meters";
//    //        Mean = mean;
//    //        CV = cv;
//    //    }
        
//    //}

//    ////Increase In Storage (meters)
//    //public class IncreaseInStorage : GlobalParameter
//    //{        
//    //    public IncreaseInStorage(double mean, double cv)
//    //    {
//    //        Name = "Increase In Storage";
//    //        Units = "meters";
//    //        Mean = mean;
//    //        CV = cv;
//    //    }
//    //}


//}
