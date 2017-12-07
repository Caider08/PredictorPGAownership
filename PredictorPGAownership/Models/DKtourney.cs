using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PredictorPGAownership.Models
{
    public class DKtourney
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime DateTime { get; set; }

        public IList<OwnedGolfer> OwnedGolfers { get; set; }

        public IList<PredictionGolfer> PredictionGolfers { get; set; }

        public DKtourney()
        {
            List<OwnedGolfer> OwnedGolfers = new List<OwnedGolfer>();

            List<PredictionGolfer> PredictionGolfers = new List<PredictionGolfer>();

        }

        public DKtourney(IEnumerable<PredictionGolfer> predictionGolfers)
        {
            List<PredictionGolfer> PredictionGolfers = new List<PredictionGolfer>();

            foreach (PredictionGolfer golfer in predictionGolfers)
            {
                PredictionGolfers.Add(golfer);
            }
        }


    }
}
