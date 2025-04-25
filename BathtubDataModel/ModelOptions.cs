//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BathtubDataModel.ModelOptions
//{
//    public class ModelOption
//    {
//        public string Name { get; set; }
//        public int Value { get; set; }

//        public ModelOption(string name, int value)
//        {
//            Name = name;
//            Value = value;
//        }
//    }

//    public class ModelOptions
//    {
//        public string Name { get; set; } = "Model Options";
//        public int Count = 12;
//        private Dictionary<string, ModelOption> _options = null;
//        public ModelOptions()
//        {
//            _options = new Dictionary<string, ModelOption>();

//            var conserv_subst = new ModelOption("CONSERVATIVE SUBSTANCE", 0);
//            _options.Add(conserv_subst.Name, conserv_subst);

//            var phos_balance = new ModelOption("PHOSPHORUS BALANCE", 0);
//            _options.Add(phos_balance.Name, phos_balance);

//            var nitrogen_balance = new ModelOption("NITROGEN BALANCE", 0);
//            _options.Add(nitrogen_balance.Name, nitrogen_balance);

//            var chlorophyll_a = new ModelOption("CHLOROPHYLL-A", 0);
//            _options.Add(chlorophyll_a.Name, chlorophyll_a);

//            var secchi_depth = new ModelOption("SECCHI DEPTH", 0);
//            _options.Add(secchi_depth.Name, secchi_depth);

//            var dispersion = new ModelOption("DISPERSION", 0);
//            _options.Add(dispersion.Name, dispersion);

//            var phosph_calib = new ModelOption("PHOSPHORUS CALIBRATION", 0);
//            _options.Add(phosph_calib.Name, phosph_calib);

//            var nitrogen_calib = new ModelOption("NITROGEN CALIBRATION", 0);
//            _options.Add(nitrogen_calib.Name, nitrogen_calib);

//            var error_analysis = new ModelOption("ERROR ANALYSIS", 0);
//            _options.Add(error_analysis.Name, error_analysis);

//            var avail_factors = new ModelOption("AVAILABILITY FACTORS", 0);
//            _options.Add(avail_factors.Name, avail_factors);

//            var mass_balance_tables = new ModelOption("MASS-BALANCE TABLES", 0);
//            _options.Add(mass_balance_tables.Name, mass_balance_tables);

//            var output_dest = new ModelOption("OUTPUT DESTINATION", 0);
//            _options.Add(output_dest.Name, output_dest);

//            Count = _options.Count;
//        }

//        public void SetOption(string name, int value)
//        {
//            if (_options.ContainsKey(name))
//            {
//                _options[name].Value = value;
//            }
//        }

//        public ModelOption GetOption(string name)
//        {
//            ModelOption option = null;
//            if (_options.ContainsKey(name))
//            {
//                option =  _options[name];
//            }
//            return option;
//        }
//    }
//}
