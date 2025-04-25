using System;

namespace BathtubDataModel
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelData modelData = new ModelData();
            modelData.ReadBTBFile("Keystone.btb");
        }
    }
}
