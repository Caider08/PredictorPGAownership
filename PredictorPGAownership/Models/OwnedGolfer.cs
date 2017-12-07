using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PredictorPGAownership.Models
{
    public class OwnedGolfer
    {
        public int ID { get; set; }

        public int DKtourneyID { get; set; }

        public int PredictionGolferID { get; set; }

        public string Name { get; set; }

        public DateTime DateTime { get; set; }

        public double Ownership { get; set; }

        public int Salary { get; set; }

        public OwnedGolfer()
        {
            DateTime = DateTime.Today;
        }

    }
}
