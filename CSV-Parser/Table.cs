using System;
using System.Collections.Generic;
using System.Text;

namespace CSV_Parser
{
    class Table
    {
        public int ID { get; set; }
        public string Region { get; set; }
        public string SubRegion { get; set; }
        public string StudyArea { get; set; }
        public string SurveyYear { get; set; }
        public string BatchCode { get; set; }
        public int SurveyIndex { get; set; }
        public string SurveyDate { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Management { get; set; }
        public string StructureType { get; set; }
        public string Family { get; set; }
        public string ScientificName { get; set; }
        public string CommonName { get; set; }
        public string Trophic { get; set; }
        public float FishLength { get; set; }
        public int FishCount { get; set; }

    }
}
