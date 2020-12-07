using System;
using System.Collections.Generic;

#nullable disable

namespace Softdent2OpenDentalConversion.Models.OpenDental
{
    public partial class Computerpref
    {
        public long ComputerPrefNum { get; set; }
        public string ComputerName { get; set; }
        public bool GraphicsUseHardware { get; set; }
        public bool GraphicsSimple { get; set; }
        public string SensorType { get; set; }
        public sbyte SensorBinned { get; set; }
        public int? SensorPort { get; set; }
        public int? SensorExposure { get; set; }
        public sbyte GraphicsDoubleBuffering { get; set; }
        public int? PreferredPixelFormatNum { get; set; }
        public string AtoZpath { get; set; }
        public bool TaskKeepListHidden { get; set; }
        public int TaskDock { get; set; }
        public int TaskX { get; set; }
        public int TaskY { get; set; }
        public string DirectXformat { get; set; }
        public sbyte ScanDocSelectSource { get; set; }
        public sbyte ScanDocShowOptions { get; set; }
        public sbyte ScanDocDuplex { get; set; }
        public sbyte ScanDocGrayscale { get; set; }
        public int ScanDocResolution { get; set; }
        public byte ScanDocQuality { get; set; }
        public long ClinicNum { get; set; }
        public long ApptViewNum { get; set; }
        public byte RecentApptView { get; set; }
        public sbyte PatSelectSearchMode { get; set; }
        public sbyte NoShowLanguage { get; set; }
        public sbyte NoShowDecimal { get; set; }
        public string ComputerOs { get; set; }
        public double HelpButtonXadjustment { get; set; }
        public sbyte GraphicsUseDirectX11 { get; set; }
    }
}
