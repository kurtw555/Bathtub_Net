//using BathtubDataModel.GlobalParameters;
//using BathtubDataModel.ModelCoefficients;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BathtubDataModel
//{
//    public class AtmosphericLoad
//    {
//        public string Name { get; }
//        public double Mean { get; set; }
//        public double CV { get; set; } // Coefficient of Variation

//        public AtmosphericLoad(string name, double mean, double cv)
//        {
//            Name = name;
//            Mean = mean;
//            CV = cv;
//        }
//    }

//    public class AtmosphericLoads
//    {
//        public string Name { get; set; } = "Model Options";
//        public int Count = 0;
//        private Dictionary<string, AtmosphericLoad> _loads = null;
//        public AtmosphericLoads()
//        {
//            _loads = new Dictionary<string, AtmosphericLoad>();

//            var convserv_subst = new AtmosphericLoad("CONSERVATIVE SUBST.", 0.0, 0.0);
//            _loads.Add(convserv_subst.Name, convserv_subst);

//            var total_p = new AtmosphericLoad("TOTAL P", 0.0, 0.0);
//            _loads.Add(total_p.Name, total_p);

//            var total_n = new AtmosphericLoad("TOTAL N", 0.0, 0.0);
//            _loads.Add(total_n.Name, total_n);

//            var ortho_p = new AtmosphericLoad("ORTHO P", 0.0, 0.0);
//            _loads.Add(ortho_p.Name, ortho_p);

//            var inorganic_n = new AtmosphericLoad("INORGANIC N", 0.0, 0.0);
//            _loads.Add(inorganic_n.Name, inorganic_n);
//        }

//        public void SetCoefficient(string name, double mean, double cv)
//        {
//            if (_loads.ContainsKey(name))
//            {
//                _loads[name].Mean = mean;
//                _loads[name].CV = cv;
//            }
//        }

//        public AtmosphericLoad GetCoefficient(string name)
//        {
//            AtmosphericLoad atm_load = null;
//            if (_loads.ContainsKey(name))
//            {
//                atm_load = _loads[name];
//            }
//            return atm_load;
//        }
//    }
//}