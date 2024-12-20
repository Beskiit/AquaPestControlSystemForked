﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AquaPestControlSystem.Models.DBEntities
{
    public class Report
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReportId { get; set; }

        public DateTime DateInspection { get; set; }

        public string InspectorName { get; set; }

        public string ClientName { get; set; }

        public string Address { get; set; }

        public long ContactNum { get; set; }

        public string InspectionType { get; set; }

        public string Areas { get; set; }

        public string TreatmentType { get; set; }

        public string PestType { get; set; }

        public double SalesInput { get; set; }

        public string FileName { get; set; }
    }
}
