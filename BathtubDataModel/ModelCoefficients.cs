//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data;

//namespace BathtubDataModel.ModelCoefficients
//{
//    public class ModelCoefficient
//    {
//        public string Name { get; }
//        public double Mean { get; set; }
//        public double CV { get; set; } // Coefficient of Variation

//        public ModelCoefficient(string name, double mean, double cv)
//        {
//            Name = name;
//            Mean = mean;
//            CV = cv;
//        }
//    }

//    public  class ModelCoefficients
//    {
//        public string Name { get; set; } = "Model Options";
//        public int Count = 0;
//        private Dictionary<string, ModelCoefficient> _cofficients = null;
//        public ModelCoefficients()
//        {
//            _cofficients = new Dictionary<string, ModelCoefficient>();

//            var dispersion_rate = new ModelCoefficient("DISPERSION RATE", 0.0, 0.0);
//            _cofficients.Add(dispersion_rate.Name, dispersion_rate);

//            var p_decay_rate = new ModelCoefficient("P DECAY RATE", 0.0, 0.0);
//            _cofficients.Add(p_decay_rate.Name, p_decay_rate);

//            var n_decay_rate = new ModelCoefficient("N DECAY RATE", 0.0, 0.0);
//            _cofficients.Add(n_decay_rate.Name, n_decay_rate);

//            var chl_a_model = new ModelCoefficient("CHL-A MODEL", 0.0, 0.0);
//            _cofficients.Add(chl_a_model.Name, chl_a_model);

//            var secchi_model = new ModelCoefficient("SECCHI MODEL", 0.0, 0.0);
//            _cofficients.Add(secchi_model.Name, secchi_model);

//            var organic_n_model = new ModelCoefficient("ORGANIC N MODEL", 0.0, 0.0);
//            _cofficients.Add(organic_n_model.Name, organic_n_model);

//            var tp_op_model = new ModelCoefficient("TP-OP MODEL", 0.0, 0.0);
//            _cofficients.Add(tp_op_model.Name, tp_op_model);

//            var to_op_model = new ModelCoefficient("TO-OP MODEL", 0.0, 0.0);
//            _cofficients.Add(to_op_model.Name, to_op_model);

//            var hodv_model = new ModelCoefficient("HODV MODEL", 0.0, 0.0);
//            _cofficients.Add(hodv_model.Name, hodv_model);

//            var modv_model = new ModelCoefficient("MODV MODEL", 0.0, 0.0);
//            _cofficients.Add(modv_model.Name, modv_model);

//            var va_m2mg = new ModelCoefficient("va M2/MG", 0.0, 0.0);
//            _cofficients.Add(va_m2mg.Name, va_m2mg);

//            var min_qs = new ModelCoefficient("MINIMUM QS", 0.0, 0.0);
//            _cofficients.Add(min_qs.Name, min_qs);

//            var flushing_effect = new ModelCoefficient("FLUSHING EFFECT", 0.0, 0.0);
//            _cofficients.Add(flushing_effect.Name, flushing_effect);

//            var chlorophyll_a_cv = new ModelCoefficient("CHLOROPHYLL-A CV", 0.0, 0.0);
//            _cofficients.Add(chlorophyll_a_cv.Name, chlorophyll_a_cv);

//            var avail_factor_tp = new ModelCoefficient("Avail Factor - TP", 0.0, 0.0);
//            _cofficients.Add(avail_factor_tp.Name, avail_factor_tp);

//            var avail_factor_ortho = new ModelCoefficient("Avail Factor - Ortho", 0.0, 0.0);
//            _cofficients.Add(avail_factor_ortho.Name, avail_factor_ortho);

//            var avail_factor_tn = new ModelCoefficient("Avail Factor - TN", 0.0, 0.0);
//            _cofficients.Add(avail_factor_tn.Name, avail_factor_tn);

//            var avail_factor__inorg_n = new ModelCoefficient("Avail Factor - Inorganic N", 0.0, 0.0);
//            _cofficients.Add(avail_factor__inorg_n.Name, avail_factor__inorg_n);

//            Count = _cofficients.Count;
//        }

//        public void SetCoefficient(string name, double mean, double cv )
//        {
//            if (_cofficients.ContainsKey(name))
//            {
//                _cofficients[name].Mean = mean;
//                _cofficients[name].CV = cv;
//            }
//        }

//        public ModelCoefficient GetCoefficient(string name)
//        {
//            ModelCoefficient option = null;
//            if (_cofficients.ContainsKey(name))
//            {
//                option = _cofficients[name];
//            }
//            return option;
//        }
//    }
//}
