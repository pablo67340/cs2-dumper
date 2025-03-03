/*
 * Created using https://github.com/a2x/cs2-dumper
 * 2023-10-20 23:01:49.150323200 UTC
 */

public static class RenderInputLayoutField_t {
    public const nint m_pSemanticName = 0x0; // uint8_t[32]
    public const nint m_nSemanticIndex = 0x20; // int32_t
    public const nint m_Format = 0x24; // uint32_t
    public const nint m_nOffset = 0x28; // int32_t
    public const nint m_nSlot = 0x2C; // int32_t
    public const nint m_nSlotType = 0x30; // RenderSlotType_t
    public const nint m_nInstanceStepRate = 0x34; // int32_t
}

public static class VsInputSignatureElement_t {
    public const nint m_pName = 0x0; // char[64]
    public const nint m_pSemantic = 0x40; // char[64]
    public const nint m_pD3DSemanticName = 0x80; // char[64]
    public const nint m_nD3DSemanticIndex = 0xC0; // int32_t
}

public static class VsInputSignature_t {
    public const nint m_elems = 0x0; // CUtlVector<VsInputSignatureElement_t>
}