namespace Ryujinx.Graphics.Gpu.Memory
{
    /// <summary>
    /// Kind of the resource at the given memory mapping.
    /// </summary>
    public enum PteKind : byte
    {
        Invalid = 0xff,
        Pitch = 0x00,
        Z16 = 0x01,
        Z162C = 0x02,
        Z16MS22C = 0x03,
        Z16MS42C = 0x04,
        Z16MS82C = 0x05,
        Z16MS162C = 0x06,
        Z162Z = 0x07,
        Z16MS22Z = 0x08,
        Z16MS42Z = 0x09,
        Z16MS82Z = 0x0a,
        Z16MS162Z = 0x0b,
        Z162CZ = 0x36,
        Z16MS22CZ = 0x37,
        Z16MS42CZ = 0x38,
        Z16MS82CZ = 0x39,
        Z16MS162CZ = 0x5f,
        Z164CZ = 0x0c,
        Z16MS24CZ = 0x0d,
        Z16MS44CZ = 0x0e,
        Z16MS84CZ = 0x0f,
        Z16MS164CZ = 0x10,
        S8Z24 = 0x11,
        S8Z241Z = 0x12,
        S8Z24MS21Z = 0x13,
        S8Z24MS41Z = 0x14,
        S8Z24MS81Z = 0x15,
        S8Z24MS161Z = 0x16,
        S8Z242CZ = 0x17,
        S8Z24MS22CZ = 0x18,
        S8Z24MS42CZ = 0x19,
        S8Z24MS82CZ = 0x1a,
        S8Z24MS162CZ = 0x1b,
        S8Z242CS = 0x1c,
        S8Z24MS22CS = 0x1d,
        S8Z24MS42CS = 0x1e,
        S8Z24MS82CS = 0x1f,
        S8Z24MS162CS = 0x20,
        S8Z244CSZV = 0x21,
        S8Z24MS24CSZV = 0x22,
        S8Z24MS44CSZV = 0x23,
        S8Z24MS84CSZV = 0x24,
        S8Z24MS164CSZV = 0x25,
        V8Z24MS4VC12 = 0x26,
        V8Z24MS4VC4 = 0x27,
        V8Z24MS8VC8 = 0x28,
        V8Z24MS8VC24 = 0x29,
        V8Z24MS4VC121ZV = 0x2e,
        V8Z24MS4VC41ZV = 0x2f,
        V8Z24MS8VC81ZV = 0x30,
        V8Z24MS8VC241ZV = 0x31,
        V8Z24MS4VC122CS = 0x32,
        V8Z24MS4VC42CS = 0x33,
        V8Z24MS8VC82CS = 0x34,
        V8Z24MS8VC242CS = 0x35,
        V8Z24MS4VC122CZV = 0x3a,
        V8Z24MS4VC42CZV = 0x3b,
        V8Z24MS8VC82CZV = 0x3c,
        V8Z24MS8VC242CZV = 0x3d,
        V8Z24MS4VC122ZV = 0x3e,
        V8Z24MS4VC42ZV = 0x3f,
        V8Z24MS8VC82ZV = 0x40,
        V8Z24MS8VC242ZV = 0x41,
        V8Z24MS4VC124CSZV = 0x42,
        V8Z24MS4VC44CSZV = 0x43,
        V8Z24MS8VC84CSZV = 0x44,
        V8Z24MS8VC244CSZV = 0x45,
        Z24S8 = 0x46,
        Z24S81Z = 0x47,
        Z24S8MS21Z = 0x48,
        Z24S8MS41Z = 0x49,
        Z24S8MS81Z = 0x4a,
        Z24S8MS161Z = 0x4b,
        Z24S82CS = 0x4c,
        Z24S8MS22CS = 0x4d,
        Z24S8MS42CS = 0x4e,
        Z24S8MS82CS = 0x4f,
        Z24S8MS162CS = 0x50,
        Z24S82CZ = 0x51,
        Z24S8MS22CZ = 0x52,
        Z24S8MS42CZ = 0x53,
        Z24S8MS82CZ = 0x54,
        Z24S8MS162CZ = 0x55,
        Z24S84CSZV = 0x56,
        Z24S8MS24CSZV = 0x57,
        Z24S8MS44CSZV = 0x58,
        Z24S8MS84CSZV = 0x59,
        Z24S8MS164CSZV = 0x5a,
        Z24V8MS4VC12 = 0x5b,
        Z24V8MS4VC4 = 0x5c,
        Z24V8MS8VC8 = 0x5d,
        Z24V8MS8VC24 = 0x5e,
        YUVB8C12Y = 0x60,
        YUVB8C22Y = 0x61,
        YUVB10C12Y = 0x62,
        YUVB10C22Y = 0x6b,
        YUVB12C12Y = 0x6c,
        YUVB12C22Y = 0x6d,
        Z24V8MS4VC121ZV = 0x63,
        Z24V8MS4VC41ZV = 0x64,
        Z24V8MS8VC81ZV = 0x65,
        Z24V8MS8VC241ZV = 0x66,
        Z24V8MS4VC122CS = 0x67,
        Z24V8MS4VC42CS = 0x68,
        Z24V8MS8VC82CS = 0x69,
        Z24V8MS8VC242CS = 0x6a,
        Z24V8MS4VC122CZV = 0x6f,
        Z24V8MS4VC42CZV = 0x70,
        Z24V8MS8VC82CZV = 0x71,
        Z24V8MS8VC242CZV = 0x72,
        Z24V8MS4VC122ZV = 0x73,
        Z24V8MS4VC42ZV = 0x74,
        Z24V8MS8VC82ZV = 0x75,
        Z24V8MS8VC242ZV = 0x76,
        Z24V8MS4VC124CSZV = 0x77,
        Z24V8MS4VC44CSZV = 0x78,
        Z24V8MS8VC84CSZV = 0x79,
        Z24V8MS8VC244CSZV = 0x7a,
        ZF32 = 0x7b,
        ZF321Z = 0x7c,
        ZF32MS21Z = 0x7d,
        ZF32MS41Z = 0x7e,
        ZF32MS81Z = 0x7f,
        ZF32MS161Z = 0x80,
        ZF322CS = 0x81,
        ZF32MS22CS = 0x82,
        ZF32MS42CS = 0x83,
        ZF32MS82CS = 0x84,
        ZF32MS162CS = 0x85,
        ZF322CZ = 0x86,
        ZF32MS22CZ = 0x87,
        ZF32MS42CZ = 0x88,
        ZF32MS82CZ = 0x89,
        ZF32MS162CZ = 0x8a,
        X8Z24X16V8S8MS4VC12 = 0x8b,
        X8Z24X16V8S8MS4VC4 = 0x8c,
        X8Z24X16V8S8MS8VC8 = 0x8d,
        X8Z24X16V8S8MS8VC24 = 0x8e,
        X8Z24X16V8S8MS4VC121CS = 0x8f,
        X8Z24X16V8S8MS4VC41CS = 0x90,
        X8Z24X16V8S8MS8VC81CS = 0x91,
        X8Z24X16V8S8MS8VC241CS = 0x92,
        X8Z24X16V8S8MS4VC121ZV = 0x97,
        X8Z24X16V8S8MS4VC41ZV = 0x98,
        X8Z24X16V8S8MS8VC81ZV = 0x99,
        X8Z24X16V8S8MS8VC241ZV = 0x9a,
        X8Z24X16V8S8MS4VC121CZV = 0x9b,
        X8Z24X16V8S8MS4VC41CZV = 0x9c,
        X8Z24X16V8S8MS8VC81CZV = 0x9d,
        X8Z24X16V8S8MS8VC241CZV = 0x9e,
        X8Z24X16V8S8MS4VC122CS = 0x9f,
        X8Z24X16V8S8MS4VC42CS = 0xa0,
        X8Z24X16V8S8MS8VC82CS = 0xa1,
        X8Z24X16V8S8MS8VC242CS = 0xa2,
        X8Z24X16V8S8MS4VC122CSZV = 0xa3,
        X8Z24X16V8S8MS4VC42CSZV = 0xa4,
        X8Z24X16V8S8MS8VC82CSZV = 0xa5,
        X8Z24X16V8S8MS8VC242CSZV = 0xa6,
        ZF32X16V8S8MS4VC12 = 0xa7,
        ZF32X16V8S8MS4VC4 = 0xa8,
        ZF32X16V8S8MS8VC8 = 0xa9,
        ZF32X16V8S8MS8VC24 = 0xaa,
        ZF32X16V8S8MS4VC121CS = 0xab,
        ZF32X16V8S8MS4VC41CS = 0xac,
        ZF32X16V8S8MS8VC81CS = 0xad,
        ZF32X16V8S8MS8VC241CS = 0xae,
        ZF32X16V8S8MS4VC121ZV = 0xb3,
        ZF32X16V8S8MS4VC41ZV = 0xb4,
        ZF32X16V8S8MS8VC81ZV = 0xb5,
        ZF32X16V8S8MS8VC241ZV = 0xb6,
        ZF32X16V8S8MS4VC121CZV = 0xb7,
        ZF32X16V8S8MS4VC41CZV = 0xb8,
        ZF32X16V8S8MS8VC81CZV = 0xb9,
        ZF32X16V8S8MS8VC241CZV = 0xba,
        ZF32X16V8S8MS4VC122CS = 0xbb,
        ZF32X16V8S8MS4VC42CS = 0xbc,
        ZF32X16V8S8MS8VC82CS = 0xbd,
        ZF32X16V8S8MS8VC242CS = 0xbe,
        ZF32X16V8S8MS4VC122CSZV = 0xbf,
        ZF32X16V8S8MS4VC42CSZV = 0xc0,
        ZF32X16V8S8MS8VC82CSZV = 0xc1,
        ZF32X16V8S8MS8VC242CSZV = 0xc2,
        ZF32X24S8 = 0xc3,
        ZF32X24S81CS = 0xc4,
        ZF32X24S8MS21CS = 0xc5,
        ZF32X24S8MS41CS = 0xc6,
        ZF32X24S8MS81CS = 0xc7,
        ZF32X24S8MS161CS = 0xc8,
        ZF32X24S82CSZV = 0xce,
        ZF32X24S8MS22CSZV = 0xcf,
        ZF32X24S8MS42CSZV = 0xd0,
        ZF32X24S8MS82CSZV = 0xd1,
        ZF32X24S8MS162CSZV = 0xd2,
        ZF32X24S82CS = 0xd3,
        ZF32X24S8MS22CS = 0xd4,
        ZF32X24S8MS42CS = 0xd5,
        ZF32X24S8MS82CS = 0xd6,
        ZF32X24S8MS162CS = 0xd7,
        S8 = 0x2a,
        S82S = 0x2b,
        Generic16Bx2 = 0xfe,
        C322C = 0xd8,
        C322CBR = 0xd9,
        C322CBA = 0xda,
        C322CRA = 0xdb,
        C322BRA = 0xdc,
        C32MS22C = 0xdd,
        C32MS22CBR = 0xde,
        C32MS24CBRA = 0xcc,
        C32MS42C = 0xdf,
        C32MS42CBR = 0xe0,
        C32MS42CBA = 0xe1,
        C32MS42CRA = 0xe2,
        C32MS42BRA = 0xe3,
        C32MS44CBRA = 0x2c,
        C32MS8MS162C = 0xe4,
        C32MS8MS162CRA = 0xe5,
        C642C = 0xe6,
        C642CBR = 0xe7,
        C642CBA = 0xe8,
        C642CRA = 0xe9,
        C642BRA = 0xea,
        C64MS22C = 0xeb,
        C64MS22CBR = 0xec,
        C64MS24CBRA = 0xcd,
        C64MS42C = 0xed,
        C64MS42CBR = 0xee,
        C64MS42CBA = 0xef,
        C64MS42CRA = 0xf0,
        C64MS42BRA = 0xf1,
        C64MS44CBRA = 0x2d,
        C64MS8MS162C = 0xf2,
        C64MS8MS162CRA = 0xf3,
        C1282C = 0xf4,
        C1282CR = 0xf5,
        C128MS22C = 0xf6,
        C128MS22CR = 0xf7,
        C128MS42C = 0xf8,
        C128MS42CR = 0xf9,
        C128MS8MS162C = 0xfa,
        C128MS8MS162CR = 0xfb,
        X8C24 = 0xfc,
        PitchNoSwizzle = 0xfd,
        SmSkedMessage = 0xca,
        SmHostMessage = 0xcb
    }

    static class PteKindExtensions
    {
        /// <summary>
        /// Checks if the kind is pitch.
        /// </summary>
        /// <param name="kind">Kind to check</param>
        /// <returns>True if pitch, false otherwise</returns>
        public static bool IsPitch(this PteKind kind)
        {
            return kind == PteKind.Pitch || kind == PteKind.PitchNoSwizzle;
        }
    }
}