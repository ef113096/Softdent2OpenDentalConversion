using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Anestheticdatum
    {
        public int AnestheticDataNum { get; set; }
        public int AnestheticRecordNum { get; set; }
        public string AnesthOpen { get; set; }
        public string AnesthClose { get; set; }
        public string SurgOpen { get; set; }
        public string SurgClose { get; set; }
        public string Anesthetist { get; set; }
        public string Surgeon { get; set; }
        public string Asst { get; set; }
        public string Circulator { get; set; }
        public string Vsmname { get; set; }
        public string VsmserNum { get; set; }
        public string Asa { get; set; }
        public string AsaEmodifier { get; set; }
        public short? O2lmin { get; set; }
        public short? N2olmin { get; set; }
        public bool? RteNasCan { get; set; }
        public bool? RteNasHood { get; set; }
        public bool? RteEtt { get; set; }
        public bool? MedRouteIvcath { get; set; }
        public bool? MedRouteIvbuttFly { get; set; }
        public bool? MedRouteIm { get; set; }
        public bool? MedRoutePo { get; set; }
        public bool? MedRouteNasal { get; set; }
        public bool? MedRouteRectal { get; set; }
        public string Ivsite { get; set; }
        public short? Ivgauge { get; set; }
        public short? IvsideR { get; set; }
        public short? IvsideL { get; set; }
        public short? Ivatt { get; set; }
        public string Ivf { get; set; }
        public float? Ivfvol { get; set; }
        public bool? MonBp { get; set; }
        public bool? MonSpO2 { get; set; }
        public bool? MonEtCo2 { get; set; }
        public bool? MonTemp { get; set; }
        public bool? MonPrecordial { get; set; }
        public bool? MonEkg { get; set; }
        public string Notes { get; set; }
        public short? PatWgt { get; set; }
        public bool? WgtUnitsLbs { get; set; }
        public bool? WgtUnitsKgs { get; set; }
        public short? PatHgt { get; set; }
        public string EscortName { get; set; }
        public string EscortCellNum { get; set; }
        public string EscortRel { get; set; }
        public string Npotime { get; set; }
        public bool? HgtUnitsIn { get; set; }
        public bool? HgtUnitsCm { get; set; }
        public string Signature { get; set; }
        public byte? SigIsTopaz { get; set; }
    }
}
