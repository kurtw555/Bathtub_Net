using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BathtubDataModel
{
    public class Segment
    {
        public string Name { get; set; }
        public int OutflowSeg { get; set; }
        public int SegGroup { get; set; }

        //Morphometric parameters------------------------------------------------
        //Surface area in square kilometers
        public Parameter SurfaceArea { get; set; } = new Parameter("Surface Area", 0.0);      
        //Mean depth in meters
        public Parameter MeanDepth { get; set; } = new Parameter("Mean Depth", 0.0);
        //Length in kilometers
        public Parameter Length { get; set; } = new Parameter("Length", 0.0);
        //Mixed layer depth meters
        public MultiParameter MixedLayerDepth { get; set; } = new MultiParameter("Mixed Layer Depth", 0.0, 0.0);        
        //Estimated mixed depth in meters
        public MultiParameter EstMixedDepth { get; set; } = new MultiParameter("Estimated Mixed Depth", 0.0, 0.12);        
        //Hypolimnetic depth in meters
        public MultiParameter HypolimneticThicknessMean { get; set; } = new MultiParameter("Hypolimnetic Thickness Mean", 0.0, 0.0);        
        //Observed WQ
        public MultiParameter NonAlgalTurb { get; set; } = new MultiParameter("Non-Algal Turb. (1/m)", 0.0, 0.0);






        public Segment() { }
        public Segment(string name) { } 
    }
}
