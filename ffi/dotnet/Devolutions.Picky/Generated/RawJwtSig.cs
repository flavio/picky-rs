// <auto-generated/> by Diplomat

#pragma warning disable 0105
using System;
using System.Runtime.InteropServices;

using Devolutions.Picky.Diplomat;
#pragma warning restore 0105

namespace Devolutions.Picky.Raw;

#nullable enable

/// <summary>
/// Signed JSON Web Token object.
/// </summary>
/// <remarks>
/// This is a JWS (JSON Web Signature) structure with JWT claims contained in a JSON payload.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public partial struct JwtSig
{
    private const string NativeLib = "DevolutionsPicky";

    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "JwtSig_builder", ExactSpelling = true)]
    public static unsafe extern JwtSigBuilder* Builder();

    /// <summary>
    /// Returns the content type.
    /// </summary>
    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "JwtSig_get_content_type", ExactSpelling = true)]
    public static unsafe extern IntPtr GetContentType(JwtSig* self, DiplomatWriteable* writeable);

    /// <summary>
    /// Returns the header as a JSON encoded payload.
    /// </summary>
    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "JwtSig_get_header", ExactSpelling = true)]
    public static unsafe extern IntPtr GetHeader(JwtSig* self, DiplomatWriteable* writeable);

    /// <summary>
    /// Returns the claims as a JSON encoded payload.
    /// </summary>
    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "JwtSig_get_claims", ExactSpelling = true)]
    public static unsafe extern IntPtr GetClaims(JwtSig* self, DiplomatWriteable* writeable);

    /// <summary>
    /// Decode JWT and check signature using provided public key.
    /// </summary>
    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "JwtSig_decode", ExactSpelling = true)]
    public static unsafe extern IntPtr Decode(byte* encodedToken, nuint encodedTokenSz, PublicKey* publicKey, JwtValidator* validator);

    /// <summary>
    /// Dangerous JWT decoding method. Signature isn't checked at all.
    /// </summary>
    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "JwtSig_decode_dangerous", ExactSpelling = true)]
    public static unsafe extern IntPtr DecodeDangerous(byte* encodedToken, nuint encodedTokenSz, JwtValidator* validator);

    /// <summary>
    /// Encode using the given private key and returns the compact representation of this token.
    /// </summary>
    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "JwtSig_encode", ExactSpelling = true)]
    public static unsafe extern IntPtr Encode(JwtSig* self, PrivateKey* key, DiplomatWriteable* writeable);

    [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "JwtSig_destroy", ExactSpelling = true)]
    public static unsafe extern void Destroy(JwtSig* self);
}
