// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public partial class TestMath
    {
        [TestCompiler]
        public void abs_int()
        {
            TestUtils.AreEqual(abs(0), 0);
            TestUtils.AreEqual(abs(-7), 7);
            TestUtils.AreEqual(abs(11), 11);
            TestUtils.AreEqual(abs(-2147483647), 2147483647);
            TestUtils.AreEqual(abs(-2147483648), -2147483648);
        }

        [TestCompiler]
        public void abs_int2()
        {
            TestUtils.AreEqual(abs(int2(0, -7)), int2(0, 7));
            TestUtils.AreEqual(abs(int2(11, -2147483647)), int2(11, 2147483647));
            TestUtils.AreEqual(abs(int2(-2147483648, -2147483648)), int2(-2147483648, -2147483648));
        }

        [TestCompiler]
        public void abs_int3()
        {
            TestUtils.AreEqual(abs(int3(0, -7, 11)), int3(0, 7, 11));
            TestUtils.AreEqual(abs(int3(-2147483647, -2147483648, -2147483648)), int3(2147483647, -2147483648, -2147483648));
        }

        [TestCompiler]
        public void abs_int4()
        {
            TestUtils.AreEqual(abs(int4(0, -7, 11, -2147483647)), int4(0, 7, 11, 2147483647));
            TestUtils.AreEqual(abs(int4(-2147483648, -2147483648, -2147483648, -2147483648)), int4(-2147483648, -2147483648, -2147483648, -2147483648));
        }

        [TestCompiler]
        public void abs_float()
        {
            TestUtils.AreEqual(abs(0f), 0f);
            TestUtils.AreEqual(abs(-1.1f), 1.1f);
            TestUtils.AreEqual(abs(2.2f), 2.2f);
            TestUtils.AreEqual(abs(float.NegativeInfinity), float.PositiveInfinity);
            TestUtils.AreEqual(abs(float.PositiveInfinity), float.PositiveInfinity);
        }

        [TestCompiler]
        public void abs_float2()
        {
            TestUtils.AreEqual(abs(float2(0f, -1.1f)), float2(0f, 1.1f));
            TestUtils.AreEqual(abs(float2(2.2f, float.NegativeInfinity)), float2(2.2f, float.PositiveInfinity));
            TestUtils.AreEqual(abs(float2(float.PositiveInfinity, float.PositiveInfinity)), float2(float.PositiveInfinity, float.PositiveInfinity));
        }

        [TestCompiler]
        public void abs_float3()
        {
            TestUtils.AreEqual(abs(float3(0f, -1.1f, 2.2f)), float3(0f, 1.1f, 2.2f));
            TestUtils.AreEqual(abs(float3(float.NegativeInfinity, float.PositiveInfinity, float.PositiveInfinity)), float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity));
        }

        [TestCompiler]
        public void abs_float4()
        {
            TestUtils.AreEqual(abs(float4(0f, -1.1f, 2.2f, float.NegativeInfinity)), float4(0f, 1.1f, 2.2f, float.PositiveInfinity));
            TestUtils.AreEqual(abs(float4(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity)), float4(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity));
        }

        [TestCompiler]
        public void abs_double()
        {
            TestUtils.AreEqual(abs(0.0), 0.0);
            TestUtils.AreEqual(abs(-1.1), 1.1);
            TestUtils.AreEqual(abs(2.2), 2.2);
            TestUtils.AreEqual(abs(double.NegativeInfinity), double.PositiveInfinity);
            TestUtils.AreEqual(abs(double.PositiveInfinity), double.PositiveInfinity);
        }

        [TestCompiler]
        public void abs_double2()
        {
            TestUtils.AreEqual(abs(double2(0.0, -1.1)), double2(0.0, 1.1));
            TestUtils.AreEqual(abs(double2(2.2, double.NegativeInfinity)), double2(2.2, double.PositiveInfinity));
            TestUtils.AreEqual(abs(double2(double.PositiveInfinity, double.PositiveInfinity)), double2(double.PositiveInfinity, double.PositiveInfinity));
        }

        [TestCompiler]
        public void abs_double3()
        {
            TestUtils.AreEqual(abs(double3(0.0, -1.1, 2.2)), double3(0.0, 1.1, 2.2));
            TestUtils.AreEqual(abs(double3(double.NegativeInfinity, double.PositiveInfinity, double.PositiveInfinity)), double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity));
        }

        [TestCompiler]
        public void abs_double4()
        {
            TestUtils.AreEqual(abs(double4(0.0, -1.1, 2.2, double.NegativeInfinity)), double4(0.0, 1.1, 2.2, double.PositiveInfinity));
            TestUtils.AreEqual(abs(double4(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity)), double4(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity));
        }

        [TestCompiler]
        public void isfinite_float()
        {
            TestUtils.AreEqual(isfinite(-float.NaN), false);
            TestUtils.AreEqual(isfinite(float.NegativeInfinity), false);
            TestUtils.AreEqual(isfinite(float.MinValue), true);
            TestUtils.AreEqual(isfinite(-1f), true);
            TestUtils.AreEqual(isfinite(0f), true);
            TestUtils.AreEqual(isfinite(1f), true);
            TestUtils.AreEqual(isfinite(float.MaxValue), true);
            TestUtils.AreEqual(isfinite(float.PositiveInfinity), false);
            TestUtils.AreEqual(isfinite(float.NaN), false);
        }

        [TestCompiler]
        public void isfinite_float2()
        {
            TestUtils.AreEqual(isfinite(float2(-float.NaN, float.NegativeInfinity)), bool2(false, false));
            TestUtils.AreEqual(isfinite(float2(float.MinValue, -1f)), bool2(true, true));
            TestUtils.AreEqual(isfinite(float2(0f, 1f)), bool2(true, true));
            TestUtils.AreEqual(isfinite(float2(float.MaxValue, float.PositiveInfinity)), bool2(true, false));
            TestUtils.AreEqual(isfinite(float2(float.NaN, float.NaN)), bool2(false, false));
        }

        [TestCompiler]
        public void isfinite_float3()
        {
            TestUtils.AreEqual(isfinite(float3(-float.NaN, float.NegativeInfinity, float.MinValue)), bool3(false, false, true));
            TestUtils.AreEqual(isfinite(float3(-1f, 0f, 1f)), bool3(true, true, true));
            TestUtils.AreEqual(isfinite(float3(float.MaxValue, float.PositiveInfinity, float.NaN)), bool3(true, false, false));
        }

        [TestCompiler]
        public void isfinite_float4()
        {
            TestUtils.AreEqual(isfinite(float4(-float.NaN, float.NegativeInfinity, float.MinValue, -1f)), bool4(false, false, true, true));
            TestUtils.AreEqual(isfinite(float4(0f, 1f, float.MaxValue, float.PositiveInfinity)), bool4(true, true, true, false));
            TestUtils.AreEqual(isfinite(float4(float.NaN, float.NaN, float.NaN, float.NaN)), bool4(false, false, false, false));
        }

        [TestCompiler]
        public void isfinite_double()
        {
            TestUtils.AreEqual(isfinite(-double.NaN), false);
            TestUtils.AreEqual(isfinite(double.NegativeInfinity), false);
            TestUtils.AreEqual(isfinite(double.MinValue), true);
            TestUtils.AreEqual(isfinite(-1.0), true);
            TestUtils.AreEqual(isfinite(0.0), true);
            TestUtils.AreEqual(isfinite(1.0), true);
            TestUtils.AreEqual(isfinite(double.MaxValue), true);
            TestUtils.AreEqual(isfinite(double.PositiveInfinity), false);
            TestUtils.AreEqual(isfinite(double.NaN), false);
        }

        [TestCompiler]
        public void isfinite_double2()
        {
            TestUtils.AreEqual(isfinite(double2(-double.NaN, double.NegativeInfinity)), bool2(false, false));
            TestUtils.AreEqual(isfinite(double2(double.MinValue, -1.0)), bool2(true, true));
            TestUtils.AreEqual(isfinite(double2(0.0, 1.0)), bool2(true, true));
            TestUtils.AreEqual(isfinite(double2(double.MaxValue, double.PositiveInfinity)), bool2(true, false));
            TestUtils.AreEqual(isfinite(double2(double.NaN, double.NaN)), bool2(false, false));
        }

        [TestCompiler]
        public void isfinite_double3()
        {
            TestUtils.AreEqual(isfinite(double3(-double.NaN, double.NegativeInfinity, double.MinValue)), bool3(false, false, true));
            TestUtils.AreEqual(isfinite(double3(-1.0, 0.0, 1.0)), bool3(true, true, true));
            TestUtils.AreEqual(isfinite(double3(double.MaxValue, double.PositiveInfinity, double.NaN)), bool3(true, false, false));
        }

        [TestCompiler]
        public void isfinite_double4()
        {
            TestUtils.AreEqual(isfinite(double4(-double.NaN, double.NegativeInfinity, double.MinValue, -1.0)), bool4(false, false, true, true));
            TestUtils.AreEqual(isfinite(double4(0.0, 1.0, double.MaxValue, double.PositiveInfinity)), bool4(true, true, true, false));
            TestUtils.AreEqual(isfinite(double4(double.NaN, double.NaN, double.NaN, double.NaN)), bool4(false, false, false, false));
        }

        [TestCompiler]
        public void isinf_float()
        {
            TestUtils.AreEqual(isinf(-float.NaN), false);
            TestUtils.AreEqual(isinf(float.NegativeInfinity), true);
            TestUtils.AreEqual(isinf(float.MinValue), false);
            TestUtils.AreEqual(isinf(-1f), false);
            TestUtils.AreEqual(isinf(0f), false);
            TestUtils.AreEqual(isinf(1f), false);
            TestUtils.AreEqual(isinf(float.MaxValue), false);
            TestUtils.AreEqual(isinf(float.PositiveInfinity), true);
            TestUtils.AreEqual(isinf(float.NaN), false);
        }

        [TestCompiler]
        public void isinf_float2()
        {
            TestUtils.AreEqual(isinf(float2(-float.NaN, float.NegativeInfinity)), bool2(false, true));
            TestUtils.AreEqual(isinf(float2(float.MinValue, -1f)), bool2(false, false));
            TestUtils.AreEqual(isinf(float2(0f, 1f)), bool2(false, false));
            TestUtils.AreEqual(isinf(float2(float.MaxValue, float.PositiveInfinity)), bool2(false, true));
            TestUtils.AreEqual(isinf(float2(float.NaN, float.NaN)), bool2(false, false));
        }

        [TestCompiler]
        public void isinf_float3()
        {
            TestUtils.AreEqual(isinf(float3(-float.NaN, float.NegativeInfinity, float.MinValue)), bool3(false, true, false));
            TestUtils.AreEqual(isinf(float3(-1f, 0f, 1f)), bool3(false, false, false));
            TestUtils.AreEqual(isinf(float3(float.MaxValue, float.PositiveInfinity, float.NaN)), bool3(false, true, false));
        }

        [TestCompiler]
        public void isinf_float4()
        {
            TestUtils.AreEqual(isinf(float4(-float.NaN, float.NegativeInfinity, float.MinValue, -1f)), bool4(false, true, false, false));
            TestUtils.AreEqual(isinf(float4(0f, 1f, float.MaxValue, float.PositiveInfinity)), bool4(false, false, false, true));
            TestUtils.AreEqual(isinf(float4(float.NaN, float.NaN, float.NaN, float.NaN)), bool4(false, false, false, false));
        }

        [TestCompiler]
        public void isinf_double()
        {
            TestUtils.AreEqual(isinf(-double.NaN), false);
            TestUtils.AreEqual(isinf(double.NegativeInfinity), true);
            TestUtils.AreEqual(isinf(double.MinValue), false);
            TestUtils.AreEqual(isinf(-1.0), false);
            TestUtils.AreEqual(isinf(0.0), false);
            TestUtils.AreEqual(isinf(1.0), false);
            TestUtils.AreEqual(isinf(double.MaxValue), false);
            TestUtils.AreEqual(isinf(double.PositiveInfinity), true);
            TestUtils.AreEqual(isinf(double.NaN), false);
        }

        [TestCompiler]
        public void isinf_double2()
        {
            TestUtils.AreEqual(isinf(double2(-double.NaN, double.NegativeInfinity)), bool2(false, true));
            TestUtils.AreEqual(isinf(double2(double.MinValue, -1.0)), bool2(false, false));
            TestUtils.AreEqual(isinf(double2(0.0, 1.0)), bool2(false, false));
            TestUtils.AreEqual(isinf(double2(double.MaxValue, double.PositiveInfinity)), bool2(false, true));
            TestUtils.AreEqual(isinf(double2(double.NaN, double.NaN)), bool2(false, false));
        }

        [TestCompiler]
        public void isinf_double3()
        {
            TestUtils.AreEqual(isinf(double3(-double.NaN, double.NegativeInfinity, double.MinValue)), bool3(false, true, false));
            TestUtils.AreEqual(isinf(double3(-1.0, 0.0, 1.0)), bool3(false, false, false));
            TestUtils.AreEqual(isinf(double3(double.MaxValue, double.PositiveInfinity, double.NaN)), bool3(false, true, false));
        }

        [TestCompiler]
        public void isinf_double4()
        {
            TestUtils.AreEqual(isinf(double4(-double.NaN, double.NegativeInfinity, double.MinValue, -1.0)), bool4(false, true, false, false));
            TestUtils.AreEqual(isinf(double4(0.0, 1.0, double.MaxValue, double.PositiveInfinity)), bool4(false, false, false, true));
            TestUtils.AreEqual(isinf(double4(double.NaN, double.NaN, double.NaN, double.NaN)), bool4(false, false, false, false));
        }

        [TestCompiler]
        public void isnan_float()
        {
            TestUtils.AreEqual(isnan(-float.NaN), true);
            TestUtils.AreEqual(isnan(float.NegativeInfinity), false);
            TestUtils.AreEqual(isnan(float.MinValue), false);
            TestUtils.AreEqual(isnan(-1f), false);
            TestUtils.AreEqual(isnan(0f), false);
            TestUtils.AreEqual(isnan(1f), false);
            TestUtils.AreEqual(isnan(float.MaxValue), false);
            TestUtils.AreEqual(isnan(float.PositiveInfinity), false);
            TestUtils.AreEqual(isnan(float.NaN), true);
        }

        [TestCompiler]
        public void isnan_float2()
        {
            TestUtils.AreEqual(isnan(float2(-float.NaN, float.NegativeInfinity)), bool2(true, false));
            TestUtils.AreEqual(isnan(float2(float.MinValue, -1f)), bool2(false, false));
            TestUtils.AreEqual(isnan(float2(0f, 1f)), bool2(false, false));
            TestUtils.AreEqual(isnan(float2(float.MaxValue, float.PositiveInfinity)), bool2(false, false));
            TestUtils.AreEqual(isnan(float2(float.NaN, float.NaN)), bool2(true, true));
        }

        [TestCompiler]
        public void isnan_float3()
        {
            TestUtils.AreEqual(isnan(float3(-float.NaN, float.NegativeInfinity, float.MinValue)), bool3(true, false, false));
            TestUtils.AreEqual(isnan(float3(-1f, 0f, 1f)), bool3(false, false, false));
            TestUtils.AreEqual(isnan(float3(float.MaxValue, float.PositiveInfinity, float.NaN)), bool3(false, false, true));
        }

        [TestCompiler]
        public void isnan_float4()
        {
            TestUtils.AreEqual(isnan(float4(-float.NaN, float.NegativeInfinity, float.MinValue, -1f)), bool4(true, false, false, false));
            TestUtils.AreEqual(isnan(float4(0f, 1f, float.MaxValue, float.PositiveInfinity)), bool4(false, false, false, false));
            TestUtils.AreEqual(isnan(float4(float.NaN, float.NaN, float.NaN, float.NaN)), bool4(true, true, true, true));
        }

        [TestCompiler]
        public void isnan_double()
        {
            TestUtils.AreEqual(isnan(-double.NaN), true);
            TestUtils.AreEqual(isnan(double.NegativeInfinity), false);
            TestUtils.AreEqual(isnan(double.MinValue), false);
            TestUtils.AreEqual(isnan(-1.0), false);
            TestUtils.AreEqual(isnan(0.0), false);
            TestUtils.AreEqual(isnan(1.0), false);
            TestUtils.AreEqual(isnan(double.MaxValue), false);
            TestUtils.AreEqual(isnan(double.PositiveInfinity), false);
            TestUtils.AreEqual(isnan(double.NaN), true);
        }

        [TestCompiler]
        public void isnan_double2()
        {
            TestUtils.AreEqual(isnan(double2(-double.NaN, double.NegativeInfinity)), bool2(true, false));
            TestUtils.AreEqual(isnan(double2(double.MinValue, -1.0)), bool2(false, false));
            TestUtils.AreEqual(isnan(double2(0.0, 1.0)), bool2(false, false));
            TestUtils.AreEqual(isnan(double2(double.MaxValue, double.PositiveInfinity)), bool2(false, false));
            TestUtils.AreEqual(isnan(double2(double.NaN, double.NaN)), bool2(true, true));
        }

        [TestCompiler]
        public void isnan_double3()
        {
            TestUtils.AreEqual(isnan(double3(-double.NaN, double.NegativeInfinity, double.MinValue)), bool3(true, false, false));
            TestUtils.AreEqual(isnan(double3(-1.0, 0.0, 1.0)), bool3(false, false, false));
            TestUtils.AreEqual(isnan(double3(double.MaxValue, double.PositiveInfinity, double.NaN)), bool3(false, false, true));
        }

        [TestCompiler]
        public void isnan_double4()
        {
            TestUtils.AreEqual(isnan(double4(-double.NaN, double.NegativeInfinity, double.MinValue, -1.0)), bool4(true, false, false, false));
            TestUtils.AreEqual(isnan(double4(0.0, 1.0, double.MaxValue, double.PositiveInfinity)), bool4(false, false, false, false));
            TestUtils.AreEqual(isnan(double4(double.NaN, double.NaN, double.NaN, double.NaN)), bool4(true, true, true, true));
        }

        [TestCompiler]
        public void sin_float()
        {
            TestUtils.AreEqual(sin(-1000000f), 0.3499935f, 1, false);
            TestUtils.AreEqual(sin(-1.2f), -0.9320391f, 1, false);
            TestUtils.AreEqual(sin(0f), 0f, 1, false);
            TestUtils.AreEqual(sin(1.2f), 0.9320391f, 1, false);
            TestUtils.AreEqual(sin(1000000f), -0.3499935f, 1, false);
            TestUtils.AreEqual(sin(float.NegativeInfinity), float.NaN, 1, false);
            TestUtils.AreEqual(sin(float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(sin(float.PositiveInfinity), float.NaN, 1, false);
        }

        [TestCompiler]
        public void sin_float2()
        {
            TestUtils.AreEqual(sin(float2(-1000000f, -1.2f)), float2(0.3499935f, -0.9320391f), 1, false);
            TestUtils.AreEqual(sin(float2(0f, 1.2f)), float2(0f, 0.9320391f), 1, false);
            TestUtils.AreEqual(sin(float2(1000000f, float.NegativeInfinity)), float2(-0.3499935f, float.NaN), 1, false);
            TestUtils.AreEqual(sin(float2(float.NaN, float.PositiveInfinity)), float2(float.NaN, float.NaN), 1, false);
        }

        [TestCompiler]
        public void sin_float3()
        {
            TestUtils.AreEqual(sin(float3(-1000000f, -1.2f, 0f)), float3(0.3499935f, -0.9320391f, 0f), 1, false);
            TestUtils.AreEqual(sin(float3(1.2f, 1000000f, float.NegativeInfinity)), float3(0.9320391f, -0.3499935f, float.NaN), 1, false);
            TestUtils.AreEqual(sin(float3(float.NaN, float.PositiveInfinity, float.PositiveInfinity)), float3(float.NaN, float.NaN, float.NaN), 1, false);
        }

        [TestCompiler]
        public void sin_float4()
        {
            TestUtils.AreEqual(sin(float4(-1000000f, -1.2f, 0f, 1.2f)), float4(0.3499935f, -0.9320391f, 0f, 0.9320391f), 1, false);
            TestUtils.AreEqual(sin(float4(1000000f, float.NegativeInfinity, float.NaN, float.PositiveInfinity)), float4(-0.3499935f, float.NaN, float.NaN, float.NaN), 1, false);
        }

        [TestCompiler]
        public void sin_double()
        {
            TestUtils.AreEqual(sin(-1000000.0), 0.34999350217129294, 32, false);
            TestUtils.AreEqual(sin(-1.2), -0.9320390859672264, 32, false);
            TestUtils.AreEqual(sin(0.0), 0.0, 32, false);
            TestUtils.AreEqual(sin(1.2), 0.9320390859672264, 32, false);
            TestUtils.AreEqual(sin(1000000.0), -0.34999350217129294, 32, false);
            TestUtils.AreEqual(sin(double.NegativeInfinity), double.NaN, 32, false);
            TestUtils.AreEqual(sin(double.NaN), double.NaN, 32, false);
            TestUtils.AreEqual(sin(double.PositiveInfinity), double.NaN, 32, false);
        }

        [TestCompiler]
        public void sin_double2()
        {
            TestUtils.AreEqual(sin(double2(-1000000.0, -1.2)), double2(0.34999350217129294, -0.9320390859672264), 32, false);
            TestUtils.AreEqual(sin(double2(0.0, 1.2)), double2(0.0, 0.9320390859672264), 32, false);
            TestUtils.AreEqual(sin(double2(1000000.0, double.NegativeInfinity)), double2(-0.34999350217129294, double.NaN), 32, false);
            TestUtils.AreEqual(sin(double2(double.NaN, double.PositiveInfinity)), double2(double.NaN, double.NaN), 32, false);
        }

        [TestCompiler]
        public void sin_double3()
        {
            TestUtils.AreEqual(sin(double3(-1000000.0, -1.2, 0.0)), double3(0.34999350217129294, -0.9320390859672264, 0.0), 32, false);
            TestUtils.AreEqual(sin(double3(1.2, 1000000.0, double.NegativeInfinity)), double3(0.9320390859672264, -0.34999350217129294, double.NaN), 32, false);
            TestUtils.AreEqual(sin(double3(double.NaN, double.PositiveInfinity, double.PositiveInfinity)), double3(double.NaN, double.NaN, double.NaN), 32, false);
        }

        [TestCompiler]
        public void sin_double4()
        {
            TestUtils.AreEqual(sin(double4(-1000000.0, -1.2, 0.0, 1.2)), double4(0.34999350217129294, -0.9320390859672264, 0.0, 0.9320390859672264), 32, false);
            TestUtils.AreEqual(sin(double4(1000000.0, double.NegativeInfinity, double.NaN, double.PositiveInfinity)), double4(-0.34999350217129294, double.NaN, double.NaN, double.NaN), 32, false);
        }

        [TestCompiler]
        public void cos_float()
        {
            TestUtils.AreEqual(cos(-1000000f), 0.936752141f, 8, false);
            TestUtils.AreEqual(cos(-1.2f), 0.362357765f, 8, false);
            TestUtils.AreEqual(cos(0f), 1f, 8, false);
            TestUtils.AreEqual(cos(1.2f), 0.362357765f, 8, false);
            TestUtils.AreEqual(cos(1000000f), 0.936752141f, 8, false);
            TestUtils.AreEqual(cos(float.NegativeInfinity), float.NaN, 8, false);
            TestUtils.AreEqual(cos(float.NaN), float.NaN, 8, false);
            TestUtils.AreEqual(cos(float.PositiveInfinity), float.NaN, 8, false);
        }

        [TestCompiler]
        public void cos_float2()
        {
            TestUtils.AreEqual(cos(float2(-1000000f, -1.2f)), float2(0.936752141f, 0.362357765f), 8, false);
            TestUtils.AreEqual(cos(float2(0f, 1.2f)), float2(1f, 0.362357765f), 8, false);
            TestUtils.AreEqual(cos(float2(1000000f, float.NegativeInfinity)), float2(0.936752141f, float.NaN), 8, false);
            TestUtils.AreEqual(cos(float2(float.NaN, float.PositiveInfinity)), float2(float.NaN, float.NaN), 8, false);
        }

        [TestCompiler]
        public void cos_float3()
        {
            TestUtils.AreEqual(cos(float3(-1000000f, -1.2f, 0f)), float3(0.936752141f, 0.362357765f, 1f), 8, false);
            TestUtils.AreEqual(cos(float3(1.2f, 1000000f, float.NegativeInfinity)), float3(0.362357765f, 0.936752141f, float.NaN), 8, false);
            TestUtils.AreEqual(cos(float3(float.NaN, float.PositiveInfinity, float.PositiveInfinity)), float3(float.NaN, float.NaN, float.NaN), 8, false);
        }

        [TestCompiler]
        public void cos_float4()
        {
            TestUtils.AreEqual(cos(float4(-1000000f, -1.2f, 0f, 1.2f)), float4(0.936752141f, 0.362357765f, 1f, 0.362357765f), 8, false);
            TestUtils.AreEqual(cos(float4(1000000f, float.NegativeInfinity, float.NaN, float.PositiveInfinity)), float4(0.936752141f, float.NaN, float.NaN, float.NaN), 8, false);
        }

        [TestCompiler]
        public void cos_double()
        {
            TestUtils.AreEqual(cos(-1000000.0), 0.93675212753314474, 32, false);
            TestUtils.AreEqual(cos(-1.2), 0.36235775447667357, 32, false);
            TestUtils.AreEqual(cos(0.0), 1.0, 32, false);
            TestUtils.AreEqual(cos(1.2), 0.36235775447667357, 32, false);
            TestUtils.AreEqual(cos(1000000.0), 0.93675212753314474, 32, false);
            TestUtils.AreEqual(cos(double.NegativeInfinity), double.NaN, 32, false);
            TestUtils.AreEqual(cos(double.NaN), double.NaN, 32, false);
            TestUtils.AreEqual(cos(double.PositiveInfinity), double.NaN, 32, false);
        }

        [TestCompiler]
        public void cos_double2()
        {
            TestUtils.AreEqual(cos(double2(-1000000.0, -1.2)), double2(0.93675212753314474, 0.36235775447667357), 32, false);
            TestUtils.AreEqual(cos(double2(0.0, 1.2)), double2(1.0, 0.36235775447667357), 32, false);
            TestUtils.AreEqual(cos(double2(1000000.0, double.NegativeInfinity)), double2(0.93675212753314474, double.NaN), 32, false);
            TestUtils.AreEqual(cos(double2(double.NaN, double.PositiveInfinity)), double2(double.NaN, double.NaN), 32, false);
        }

        [TestCompiler]
        public void cos_double3()
        {
            TestUtils.AreEqual(cos(double3(-1000000.0, -1.2, 0.0)), double3(0.93675212753314474, 0.36235775447667357, 1.0), 32, false);
            TestUtils.AreEqual(cos(double3(1.2, 1000000.0, double.NegativeInfinity)), double3(0.36235775447667357, 0.93675212753314474, double.NaN), 32, false);
            TestUtils.AreEqual(cos(double3(double.NaN, double.PositiveInfinity, double.PositiveInfinity)), double3(double.NaN, double.NaN, double.NaN), 32, false);
        }

        [TestCompiler]
        public void cos_double4()
        {
            TestUtils.AreEqual(cos(double4(-1000000.0, -1.2, 0.0, 1.2)), double4(0.93675212753314474, 0.36235775447667357, 1.0, 0.36235775447667357), 32, false);
            TestUtils.AreEqual(cos(double4(1000000.0, double.NegativeInfinity, double.NaN, double.PositiveInfinity)), double4(0.93675212753314474, double.NaN, double.NaN, double.NaN), 32, false);
        }

        [TestCompiler]
        public void tan_float()
        {
            TestUtils.AreEqual(tan(-1000000f), 0.373624444f, 1, false);
            TestUtils.AreEqual(tan(-1.2f), -2.57215166f, 1, false);
            TestUtils.AreEqual(tan(0f), 0f, 1, false);
            TestUtils.AreEqual(tan(1.2f), 2.57215166f, 1, false);
            TestUtils.AreEqual(tan(1000000f), -0.373624444f, 1, false);
            TestUtils.AreEqual(tan(float.NegativeInfinity), float.NaN, 1, false);
            TestUtils.AreEqual(tan(float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(tan(float.PositiveInfinity), float.NaN, 1, false);
        }

        [TestCompiler]
        public void tan_float2()
        {
            TestUtils.AreEqual(tan(float2(-1000000f, -1.2f)), float2(0.373624444f, -2.57215166f), 1, false);
            TestUtils.AreEqual(tan(float2(0f, 1.2f)), float2(0f, 2.57215166f), 1, false);
            TestUtils.AreEqual(tan(float2(1000000f, float.NegativeInfinity)), float2(-0.373624444f, float.NaN), 1, false);
            TestUtils.AreEqual(tan(float2(float.NaN, float.PositiveInfinity)), float2(float.NaN, float.NaN), 1, false);
        }

        [TestCompiler]
        public void tan_float3()
        {
            TestUtils.AreEqual(tan(float3(-1000000f, -1.2f, 0f)), float3(0.373624444f, -2.57215166f, 0f), 1, false);
            TestUtils.AreEqual(tan(float3(1.2f, 1000000f, float.NegativeInfinity)), float3(2.57215166f, -0.373624444f, float.NaN), 1, false);
            TestUtils.AreEqual(tan(float3(float.NaN, float.PositiveInfinity, float.PositiveInfinity)), float3(float.NaN, float.NaN, float.NaN), 1, false);
        }

        [TestCompiler]
        public void tan_float4()
        {
            TestUtils.AreEqual(tan(float4(-1000000f, -1.2f, 0f, 1.2f)), float4(0.373624444f, -2.57215166f, 0f, 2.57215166f), 1, false);
            TestUtils.AreEqual(tan(float4(1000000f, float.NegativeInfinity, float.NaN, float.PositiveInfinity)), float4(-0.373624444f, float.NaN, float.NaN, float.NaN), 1, false);
        }

        [TestCompiler]
        public void tan_double()
        {
            TestUtils.AreEqual(tan(-1000000.0), 0.373624453987599, 32, false);
            TestUtils.AreEqual(tan(-1.2), -2.57215162212632, 32, false);
            TestUtils.AreEqual(tan(0.0), 0.0, 32, false);
            TestUtils.AreEqual(tan(1.2), 2.57215162212632, 32, false);
            TestUtils.AreEqual(tan(1000000.0), -0.373624453987599, 32, false);
            TestUtils.AreEqual(tan(double.NegativeInfinity), double.NaN, 32, false);
            TestUtils.AreEqual(tan(double.NaN), double.NaN, 32, false);
            TestUtils.AreEqual(tan(double.PositiveInfinity), double.NaN, 32, false);
        }

        [TestCompiler]
        public void tan_double2()
        {
            TestUtils.AreEqual(tan(double2(-1000000.0, -1.2)), double2(0.373624453987599, -2.57215162212632), 32, false);
            TestUtils.AreEqual(tan(double2(0.0, 1.2)), double2(0.0, 2.57215162212632), 32, false);
            TestUtils.AreEqual(tan(double2(1000000.0, double.NegativeInfinity)), double2(-0.373624453987599, double.NaN), 32, false);
            TestUtils.AreEqual(tan(double2(double.NaN, double.PositiveInfinity)), double2(double.NaN, double.NaN), 32, false);
        }

        [TestCompiler]
        public void tan_double3()
        {
            TestUtils.AreEqual(tan(double3(-1000000.0, -1.2, 0.0)), double3(0.373624453987599, -2.57215162212632, 0.0), 32, false);
            TestUtils.AreEqual(tan(double3(1.2, 1000000.0, double.NegativeInfinity)), double3(2.57215162212632, -0.373624453987599, double.NaN), 32, false);
            TestUtils.AreEqual(tan(double3(double.NaN, double.PositiveInfinity, double.PositiveInfinity)), double3(double.NaN, double.NaN, double.NaN), 32, false);
        }

        [TestCompiler]
        public void tan_double4()
        {
            TestUtils.AreEqual(tan(double4(-1000000.0, -1.2, 0.0, 1.2)), double4(0.373624453987599, -2.57215162212632, 0.0, 2.57215162212632), 32, false);
            TestUtils.AreEqual(tan(double4(1000000.0, double.NegativeInfinity, double.NaN, double.PositiveInfinity)), double4(-0.373624453987599, double.NaN, double.NaN, double.NaN), 32, false);
        }

        [TestCompiler]
        public void atan_float()
        {
            TestUtils.AreEqual(atan(-1000000f), -1.5707953f, 1, false);
            TestUtils.AreEqual(atan(-1.2f), -0.876058042f, 1, false);
            TestUtils.AreEqual(atan(0f), 0f, 1, false);
            TestUtils.AreEqual(atan(1.2f), 0.876058042f, 1, false);
            TestUtils.AreEqual(atan(1000000f), 1.5707953f, 1, false);
            TestUtils.AreEqual(atan(float.NegativeInfinity), -1.57079637f, 1, false);
            TestUtils.AreEqual(atan(float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(atan(float.PositiveInfinity), 1.57079637f, 1, false);
        }

        [TestCompiler]
        public void atan_float2()
        {
            TestUtils.AreEqual(atan(float2(-1000000f, -1.2f)), float2(-1.5707953f, -0.876058042f), 1, false);
            TestUtils.AreEqual(atan(float2(0f, 1.2f)), float2(0f, 0.876058042f), 1, false);
            TestUtils.AreEqual(atan(float2(1000000f, float.NegativeInfinity)), float2(1.5707953f, -1.57079637f), 1, false);
            TestUtils.AreEqual(atan(float2(float.NaN, float.PositiveInfinity)), float2(float.NaN, 1.57079637f), 1, false);
        }

        [TestCompiler]
        public void atan_float3()
        {
            TestUtils.AreEqual(atan(float3(-1000000f, -1.2f, 0f)), float3(-1.5707953f, -0.876058042f, 0f), 1, false);
            TestUtils.AreEqual(atan(float3(1.2f, 1000000f, float.NegativeInfinity)), float3(0.876058042f, 1.5707953f, -1.57079637f), 1, false);
            TestUtils.AreEqual(atan(float3(float.NaN, float.PositiveInfinity, float.PositiveInfinity)), float3(float.NaN, 1.57079637f, 1.57079637f), 1, false);
        }

        [TestCompiler]
        public void atan_float4()
        {
            TestUtils.AreEqual(atan(float4(-1000000f, -1.2f, 0f, 1.2f)), float4(-1.5707953f, -0.876058042f, 0f, 0.876058042f), 1, false);
            TestUtils.AreEqual(atan(float4(1000000f, float.NegativeInfinity, float.NaN, float.PositiveInfinity)), float4(1.5707953f, -1.57079637f, float.NaN, 1.57079637f), 1, false);
        }

        [TestCompiler]
        public void atan_double()
        {
            TestUtils.AreEqual(atan(-1000000.0), -1.5707953267948971, 32, false);
            TestUtils.AreEqual(atan(-1.2), -0.87605805059819342, 32, false);
            TestUtils.AreEqual(atan(0.0), 0.0, 32, false);
            TestUtils.AreEqual(atan(1.2), 0.87605805059819342, 32, false);
            TestUtils.AreEqual(atan(1000000.0), 1.5707953267948971, 32, false);
            TestUtils.AreEqual(atan(double.NegativeInfinity), -1.570796326794897, 32, false);
            TestUtils.AreEqual(atan(double.NaN), double.NaN, 32, false);
            TestUtils.AreEqual(atan(double.PositiveInfinity), 1.570796326794897, 32, false);
        }

        [TestCompiler]
        public void atan_double2()
        {
            TestUtils.AreEqual(atan(double2(-1000000.0, -1.2)), double2(-1.5707953267948971, -0.87605805059819342), 32, false);
            TestUtils.AreEqual(atan(double2(0.0, 1.2)), double2(0.0, 0.87605805059819342), 32, false);
            TestUtils.AreEqual(atan(double2(1000000.0, double.NegativeInfinity)), double2(1.5707953267948971, -1.570796326794897), 32, false);
            TestUtils.AreEqual(atan(double2(double.NaN, double.PositiveInfinity)), double2(double.NaN, 1.570796326794897), 32, false);
        }

        [TestCompiler]
        public void atan_double3()
        {
            TestUtils.AreEqual(atan(double3(-1000000.0, -1.2, 0.0)), double3(-1.5707953267948971, -0.87605805059819342, 0.0), 32, false);
            TestUtils.AreEqual(atan(double3(1.2, 1000000.0, double.NegativeInfinity)), double3(0.87605805059819342, 1.5707953267948971, -1.570796326794897), 32, false);
            TestUtils.AreEqual(atan(double3(double.NaN, double.PositiveInfinity, double.PositiveInfinity)), double3(double.NaN, 1.570796326794897, 1.570796326794897), 32, false);
        }

        [TestCompiler]
        public void atan_double4()
        {
            TestUtils.AreEqual(atan(double4(-1000000.0, -1.2, 0.0, 1.2)), double4(-1.5707953267948971, -0.87605805059819342, 0.0, 0.87605805059819342), 32, false);
            TestUtils.AreEqual(atan(double4(1000000.0, double.NegativeInfinity, double.NaN, double.PositiveInfinity)), double4(1.5707953267948971, -1.570796326794897, double.NaN, 1.570796326794897), 32, false);
        }

        [TestCompiler]
        public void atan2_float()
        {
            TestUtils.AreEqual(atan2(3.1f, 2.4f), 0.9119903f, 1, false);
            TestUtils.AreEqual(atan2(3.1f, -2.4f), 2.22960234f, 1, false);
            TestUtils.AreEqual(atan2(-3.1f, 2.4f), -0.9119903f, 1, false);
            TestUtils.AreEqual(atan2(-3.1f, -2.4f), -2.22960234f, 1, false);
            TestUtils.AreEqual(atan2(0f, 0f), 0f, 1, false);
            TestUtils.AreEqual(atan2(1f, float.NegativeInfinity), 3.14159274f, 1, false);
            TestUtils.AreEqual(atan2(1f, float.PositiveInfinity), 0f, 1, false);
            TestUtils.AreEqual(atan2(float.NegativeInfinity, 1f), -1.57079637f, 1, false);
            TestUtils.AreEqual(atan2(float.PositiveInfinity, 1f), 1.57079637f, 1, false);
            TestUtils.AreEqual(atan2(1f, float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(atan2(float.NaN, 1f), float.NaN, 1, false);
            TestUtils.AreEqual(atan2(float.NaN, float.NaN), float.NaN, 1, false);
        }

        [TestCompiler]
        public void atan2_float2()
        {
            TestUtils.AreEqual(atan2(float2(3.1f, 3.1f), float2(2.4f, -2.4f)), float2(0.9119903f, 2.22960234f), 1, false);
            TestUtils.AreEqual(atan2(float2(-3.1f, -3.1f), float2(2.4f, -2.4f)), float2(-0.9119903f, -2.22960234f), 1, false);
            TestUtils.AreEqual(atan2(float2(0f, 1f), float2(0f, float.NegativeInfinity)), float2(0f, 3.14159274f), 1, false);
            TestUtils.AreEqual(atan2(float2(1f, float.NegativeInfinity), float2(float.PositiveInfinity, 1f)), float2(0f, -1.57079637f), 1, false);
            TestUtils.AreEqual(atan2(float2(float.PositiveInfinity, 1f), float2(1f, float.NaN)), float2(1.57079637f, float.NaN), 1, false);
            TestUtils.AreEqual(atan2(float2(float.NaN, float.NaN), float2(1f, float.NaN)), float2(float.NaN, float.NaN), 1, false);
        }

        [TestCompiler]
        public void atan2_float3()
        {
            TestUtils.AreEqual(atan2(float3(3.1f, 3.1f, -3.1f), float3(2.4f, -2.4f, 2.4f)), float3(0.9119903f, 2.22960234f, -0.9119903f), 1, false);
            TestUtils.AreEqual(atan2(float3(-3.1f, 0f, 1f), float3(-2.4f, 0f, float.NegativeInfinity)), float3(-2.22960234f, 0f, 3.14159274f), 1, false);
            TestUtils.AreEqual(atan2(float3(1f, float.NegativeInfinity, float.PositiveInfinity), float3(float.PositiveInfinity, 1f, 1f)), float3(0f, -1.57079637f, 1.57079637f), 1, false);
            TestUtils.AreEqual(atan2(float3(1f, float.NaN, float.NaN), float3(float.NaN, 1f, float.NaN)), float3(float.NaN, float.NaN, float.NaN), 1, false);
        }

        [TestCompiler]
        public void atan2_float4()
        {
            TestUtils.AreEqual(atan2(float4(3.1f, 3.1f, -3.1f, -3.1f), float4(2.4f, -2.4f, 2.4f, -2.4f)), float4(0.9119903f, 2.22960234f, -0.9119903f, -2.22960234f), 1, false);
            TestUtils.AreEqual(atan2(float4(0f, 1f, 1f, float.NegativeInfinity), float4(0f, float.NegativeInfinity, float.PositiveInfinity, 1f)), float4(0f, 3.14159274f, 0f, -1.57079637f), 1, false);
            TestUtils.AreEqual(atan2(float4(float.PositiveInfinity, 1f, float.NaN, float.NaN), float4(1f, float.NaN, 1f, float.NaN)), float4(1.57079637f, float.NaN, float.NaN, float.NaN), 1, false);
        }

        [TestCompiler]
        public void atan2_double()
        {
            TestUtils.AreEqual(atan2(3.1, 2.4), 0.91199029067742043, 32, false);
            TestUtils.AreEqual(atan2(3.1, -2.4), 2.2296023629123729, 32, false);
            TestUtils.AreEqual(atan2(-3.1, 2.4), -0.91199029067742043, 32, false);
            TestUtils.AreEqual(atan2(-3.1, -2.4), -2.2296023629123729, 32, false);
            TestUtils.AreEqual(atan2(0.0, 0.0), 0.0, 32, false);
            TestUtils.AreEqual(atan2(1.0, double.NegativeInfinity), 3.1415926535897931, 32, false);
            TestUtils.AreEqual(atan2(1.0, double.PositiveInfinity), 0.0, 32, false);
            TestUtils.AreEqual(atan2(double.NegativeInfinity, 1.0), -1.5707963267948966, 32, false);
            TestUtils.AreEqual(atan2(double.PositiveInfinity, 1.0), 1.5707963267948966, 32, false);
            TestUtils.AreEqual(atan2(1.0, double.NaN), double.NaN, 32, false);
            TestUtils.AreEqual(atan2(double.NaN, 1.0), double.NaN, 32, false);
            TestUtils.AreEqual(atan2(double.NaN, double.NaN), double.NaN, 32, false);
        }

        [TestCompiler]
        public void atan2_double2()
        {
            TestUtils.AreEqual(atan2(double2(3.1, 3.1), double2(2.4, -2.4)), double2(0.91199029067742043, 2.2296023629123729), 32, false);
            TestUtils.AreEqual(atan2(double2(-3.1, -3.1), double2(2.4, -2.4)), double2(-0.91199029067742043, -2.2296023629123729), 32, false);
            TestUtils.AreEqual(atan2(double2(0.0, 1.0), double2(0.0, double.NegativeInfinity)), double2(0.0, 3.1415926535897931), 32, false);
            TestUtils.AreEqual(atan2(double2(1.0, double.NegativeInfinity), double2(double.PositiveInfinity, 1.0)), double2(0.0, -1.5707963267948966), 32, false);
            TestUtils.AreEqual(atan2(double2(double.PositiveInfinity, 1.0), double2(1.0, double.NaN)), double2(1.5707963267948966, double.NaN), 32, false);
            TestUtils.AreEqual(atan2(double2(double.NaN, double.NaN), double2(1.0, double.NaN)), double2(double.NaN, double.NaN), 32, false);
        }

        [TestCompiler]
        public void atan2_double3()
        {
            TestUtils.AreEqual(atan2(double3(3.1, 3.1, -3.1), double3(2.4, -2.4, 2.4)), double3(0.91199029067742043, 2.2296023629123729, -0.91199029067742043), 32, false);
            TestUtils.AreEqual(atan2(double3(-3.1, 0.0, 1.0), double3(-2.4, 0.0, double.NegativeInfinity)), double3(-2.2296023629123729, 0.0, 3.1415926535897931), 32, false);
            TestUtils.AreEqual(atan2(double3(1.0, double.NegativeInfinity, double.PositiveInfinity), double3(double.PositiveInfinity, 1.0, 1.0)), double3(0.0, -1.5707963267948966, 1.5707963267948966), 32, false);
            TestUtils.AreEqual(atan2(double3(1.0, double.NaN, double.NaN), double3(double.NaN, 1.0, double.NaN)), double3(double.NaN, double.NaN, double.NaN), 32, false);
        }

        [TestCompiler]
        public void atan2_double4()
        {
            TestUtils.AreEqual(atan2(double4(3.1, 3.1, -3.1, -3.1), double4(2.4, -2.4, 2.4, -2.4)), double4(0.91199029067742043, 2.2296023629123729, -0.91199029067742043, -2.2296023629123729), 32, false);
            TestUtils.AreEqual(atan2(double4(0.0, 1.0, 1.0, double.NegativeInfinity), double4(0.0, double.NegativeInfinity, double.PositiveInfinity, 1.0)), double4(0.0, 3.1415926535897931, 0.0, -1.5707963267948966), 32, false);
            TestUtils.AreEqual(atan2(double4(double.PositiveInfinity, 1.0, double.NaN, double.NaN), double4(1.0, double.NaN, 1.0, double.NaN)), double4(1.5707963267948966, double.NaN, double.NaN, double.NaN), 32, false);
        }

        [TestCompiler]
        public void sinh_float()
        {
            TestUtils.AreEqual(sinh(-2f), -3.62686038f, 1, false);
            TestUtils.AreEqual(sinh(-1.2f), -1.5094614f, 1, false);
            TestUtils.AreEqual(sinh(0f), 0f, 1, false);
            TestUtils.AreEqual(sinh(1.2f), 1.5094614f, 1, false);
            TestUtils.AreEqual(sinh(2f), 3.62686038f, 1, false);
            TestUtils.AreEqual(sinh(float.NegativeInfinity), float.NegativeInfinity, 1, false);
            TestUtils.AreEqual(sinh(float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(sinh(float.PositiveInfinity), float.PositiveInfinity, 1, false);
        }

        [TestCompiler]
        public void sinh_float2()
        {
            TestUtils.AreEqual(sinh(float2(-2f, -1.2f)), float2(-3.62686038f, -1.5094614f), 1, false);
            TestUtils.AreEqual(sinh(float2(0f, 1.2f)), float2(0f, 1.5094614f), 1, false);
            TestUtils.AreEqual(sinh(float2(2f, float.NegativeInfinity)), float2(3.62686038f, float.NegativeInfinity), 1, false);
            TestUtils.AreEqual(sinh(float2(float.NaN, float.PositiveInfinity)), float2(float.NaN, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void sinh_float3()
        {
            TestUtils.AreEqual(sinh(float3(-2f, -1.2f, 0f)), float3(-3.62686038f, -1.5094614f, 0f), 1, false);
            TestUtils.AreEqual(sinh(float3(1.2f, 2f, float.NegativeInfinity)), float3(1.5094614f, 3.62686038f, float.NegativeInfinity), 1, false);
            TestUtils.AreEqual(sinh(float3(float.NaN, float.PositiveInfinity, float.PositiveInfinity)), float3(float.NaN, float.PositiveInfinity, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void sinh_float4()
        {
            TestUtils.AreEqual(sinh(float4(-2f, -1.2f, 0f, 1.2f)), float4(-3.62686038f, -1.5094614f, 0f, 1.5094614f), 1, false);
            TestUtils.AreEqual(sinh(float4(2f, float.NegativeInfinity, float.NaN, float.PositiveInfinity)), float4(3.62686038f, float.NegativeInfinity, float.NaN, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void sinh_double()
        {
            TestUtils.AreEqual(sinh(-2.0), -3.6268604078470181, 32, false);
            TestUtils.AreEqual(sinh(-1.2), -1.509461355412173, 32, false);
            TestUtils.AreEqual(sinh(0.0), 0.0, 32, false);
            TestUtils.AreEqual(sinh(1.2), 1.509461355412173, 32, false);
            TestUtils.AreEqual(sinh(2.0), 3.6268604078470181, 32, false);
            TestUtils.AreEqual(sinh(double.NegativeInfinity), double.NegativeInfinity, 32, false);
            TestUtils.AreEqual(sinh(double.NaN), double.NaN, 32, false);
            TestUtils.AreEqual(sinh(double.PositiveInfinity), double.PositiveInfinity, 32, false);
        }

        [TestCompiler]
        public void sinh_double2()
        {
            TestUtils.AreEqual(sinh(double2(-2.0, -1.2)), double2(-3.6268604078470181, -1.509461355412173), 32, false);
            TestUtils.AreEqual(sinh(double2(0.0, 1.2)), double2(0.0, 1.509461355412173), 32, false);
            TestUtils.AreEqual(sinh(double2(2.0, double.NegativeInfinity)), double2(3.6268604078470181, double.NegativeInfinity), 32, false);
            TestUtils.AreEqual(sinh(double2(double.NaN, double.PositiveInfinity)), double2(double.NaN, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void sinh_double3()
        {
            TestUtils.AreEqual(sinh(double3(-2.0, -1.2, 0.0)), double3(-3.6268604078470181, -1.509461355412173, 0.0), 32, false);
            TestUtils.AreEqual(sinh(double3(1.2, 2.0, double.NegativeInfinity)), double3(1.509461355412173, 3.6268604078470181, double.NegativeInfinity), 32, false);
            TestUtils.AreEqual(sinh(double3(double.NaN, double.PositiveInfinity, double.PositiveInfinity)), double3(double.NaN, double.PositiveInfinity, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void sinh_double4()
        {
            TestUtils.AreEqual(sinh(double4(-2.0, -1.2, 0.0, 1.2)), double4(-3.6268604078470181, -1.509461355412173, 0.0, 1.509461355412173), 32, false);
            TestUtils.AreEqual(sinh(double4(2.0, double.NegativeInfinity, double.NaN, double.PositiveInfinity)), double4(3.6268604078470181, double.NegativeInfinity, double.NaN, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void cosh_float()
        {
            TestUtils.AreEqual(cosh(-2f), 3.76219559f, 1, false);
            TestUtils.AreEqual(cosh(-1.2f), 1.81065559f, 1, false);
            TestUtils.AreEqual(cosh(0f), 1f, 1, false);
            TestUtils.AreEqual(cosh(1.2f), 1.81065559f, 1, false);
            TestUtils.AreEqual(cosh(2f), 3.76219559f, 1, false);
            TestUtils.AreEqual(cosh(float.NegativeInfinity), float.PositiveInfinity, 1, false);
            TestUtils.AreEqual(cosh(float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(cosh(float.PositiveInfinity), float.PositiveInfinity, 1, false);
        }

        [TestCompiler]
        public void cosh_float2()
        {
            TestUtils.AreEqual(cosh(float2(-2f, -1.2f)), float2(3.76219559f, 1.81065559f), 1, false);
            TestUtils.AreEqual(cosh(float2(0f, 1.2f)), float2(1f, 1.81065559f), 1, false);
            TestUtils.AreEqual(cosh(float2(2f, float.NegativeInfinity)), float2(3.76219559f, float.PositiveInfinity), 1, false);
            TestUtils.AreEqual(cosh(float2(float.NaN, float.PositiveInfinity)), float2(float.NaN, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void cosh_float3()
        {
            TestUtils.AreEqual(cosh(float3(-2f, -1.2f, 0f)), float3(3.76219559f, 1.81065559f, 1f), 1, false);
            TestUtils.AreEqual(cosh(float3(1.2f, 2f, float.NegativeInfinity)), float3(1.81065559f, 3.76219559f, float.PositiveInfinity), 1, false);
            TestUtils.AreEqual(cosh(float3(float.NaN, float.PositiveInfinity, float.PositiveInfinity)), float3(float.NaN, float.PositiveInfinity, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void cosh_float4()
        {
            TestUtils.AreEqual(cosh(float4(-2f, -1.2f, 0f, 1.2f)), float4(3.76219559f, 1.81065559f, 1f, 1.81065559f), 1, false);
            TestUtils.AreEqual(cosh(float4(2f, float.NegativeInfinity, float.NaN, float.PositiveInfinity)), float4(3.76219559f, float.PositiveInfinity, float.NaN, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void cosh_double()
        {
            TestUtils.AreEqual(cosh(-2.0), 3.7621956910836314, 32, false);
            TestUtils.AreEqual(cosh(-1.2), 1.81065556732437, 32, false);
            TestUtils.AreEqual(cosh(0.0), 1.0, 32, false);
            TestUtils.AreEqual(cosh(1.2), 1.81065556732437, 32, false);
            TestUtils.AreEqual(cosh(2.0), 3.7621956910836314, 32, false);
            TestUtils.AreEqual(cosh(double.NegativeInfinity), double.PositiveInfinity, 32, false);
            TestUtils.AreEqual(cosh(double.NaN), double.NaN, 32, false);
            TestUtils.AreEqual(cosh(double.PositiveInfinity), double.PositiveInfinity, 32, false);
        }

        [TestCompiler]
        public void cosh_double2()
        {
            TestUtils.AreEqual(cosh(double2(-2.0, -1.2)), double2(3.7621956910836314, 1.81065556732437), 32, false);
            TestUtils.AreEqual(cosh(double2(0.0, 1.2)), double2(1.0, 1.81065556732437), 32, false);
            TestUtils.AreEqual(cosh(double2(2.0, double.NegativeInfinity)), double2(3.7621956910836314, double.PositiveInfinity), 32, false);
            TestUtils.AreEqual(cosh(double2(double.NaN, double.PositiveInfinity)), double2(double.NaN, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void cosh_double3()
        {
            TestUtils.AreEqual(cosh(double3(-2.0, -1.2, 0.0)), double3(3.7621956910836314, 1.81065556732437, 1.0), 32, false);
            TestUtils.AreEqual(cosh(double3(1.2, 2.0, double.NegativeInfinity)), double3(1.81065556732437, 3.7621956910836314, double.PositiveInfinity), 32, false);
            TestUtils.AreEqual(cosh(double3(double.NaN, double.PositiveInfinity, double.PositiveInfinity)), double3(double.NaN, double.PositiveInfinity, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void cosh_double4()
        {
            TestUtils.AreEqual(cosh(double4(-2.0, -1.2, 0.0, 1.2)), double4(3.7621956910836314, 1.81065556732437, 1.0, 1.81065556732437), 32, false);
            TestUtils.AreEqual(cosh(double4(2.0, double.NegativeInfinity, double.NaN, double.PositiveInfinity)), double4(3.7621956910836314, double.PositiveInfinity, double.NaN, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void tanh_float()
        {
            TestUtils.AreEqual(tanh(-2f), -0.9640276f, 1, false);
            TestUtils.AreEqual(tanh(-1.2f), -0.8336546f, 1, false);
            TestUtils.AreEqual(tanh(0f), 0f, 1, false);
            TestUtils.AreEqual(tanh(1.2f), 0.8336546f, 1, false);
            TestUtils.AreEqual(tanh(2f), 0.9640276f, 1, false);
            TestUtils.AreEqual(tanh(float.NegativeInfinity), -1f, 1, false);
            TestUtils.AreEqual(tanh(float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(tanh(float.PositiveInfinity), 1f, 1, false);
        }

        [TestCompiler]
        public void tanh_float2()
        {
            TestUtils.AreEqual(tanh(float2(-2f, -1.2f)), float2(-0.9640276f, -0.8336546f), 1, false);
            TestUtils.AreEqual(tanh(float2(0f, 1.2f)), float2(0f, 0.8336546f), 1, false);
            TestUtils.AreEqual(tanh(float2(2f, float.NegativeInfinity)), float2(0.9640276f, -1f), 1, false);
            TestUtils.AreEqual(tanh(float2(float.NaN, float.PositiveInfinity)), float2(float.NaN, 1f), 1, false);
        }

        [TestCompiler]
        public void tanh_float3()
        {
            TestUtils.AreEqual(tanh(float3(-2f, -1.2f, 0f)), float3(-0.9640276f, -0.8336546f, 0f), 1, false);
            TestUtils.AreEqual(tanh(float3(1.2f, 2f, float.NegativeInfinity)), float3(0.8336546f, 0.9640276f, -1f), 1, false);
            TestUtils.AreEqual(tanh(float3(float.NaN, float.PositiveInfinity, float.PositiveInfinity)), float3(float.NaN, 1f, 1f), 1, false);
        }

        [TestCompiler]
        public void tanh_float4()
        {
            TestUtils.AreEqual(tanh(float4(-2f, -1.2f, 0f, 1.2f)), float4(-0.9640276f, -0.8336546f, 0f, 0.8336546f), 1, false);
            TestUtils.AreEqual(tanh(float4(2f, float.NegativeInfinity, float.NaN, float.PositiveInfinity)), float4(0.9640276f, -1f, float.NaN, 1f), 1, false);
        }

        [TestCompiler]
        public void tanh_double()
        {
            TestUtils.AreEqual(tanh(-2.0), -0.9640275800758169, 32, false);
            TestUtils.AreEqual(tanh(-1.2), -0.83365460701215521, 32, false);
            TestUtils.AreEqual(tanh(0.0), 0.0, 32, false);
            TestUtils.AreEqual(tanh(1.2), 0.83365460701215521, 32, false);
            TestUtils.AreEqual(tanh(2.0), 0.9640275800758169, 32, false);
            TestUtils.AreEqual(tanh(double.NegativeInfinity), -1.0, 32, false);
            TestUtils.AreEqual(tanh(double.NaN), double.NaN, 32, false);
            TestUtils.AreEqual(tanh(double.PositiveInfinity), 1.0, 32, false);
        }

        [TestCompiler]
        public void tanh_double2()
        {
            TestUtils.AreEqual(tanh(double2(-2.0, -1.2)), double2(-0.9640275800758169, -0.83365460701215521), 32, false);
            TestUtils.AreEqual(tanh(double2(0.0, 1.2)), double2(0.0, 0.83365460701215521), 32, false);
            TestUtils.AreEqual(tanh(double2(2.0, double.NegativeInfinity)), double2(0.9640275800758169, -1.0), 32, false);
            TestUtils.AreEqual(tanh(double2(double.NaN, double.PositiveInfinity)), double2(double.NaN, 1.0), 32, false);
        }

        [TestCompiler]
        public void tanh_double3()
        {
            TestUtils.AreEqual(tanh(double3(-2.0, -1.2, 0.0)), double3(-0.9640275800758169, -0.83365460701215521, 0.0), 32, false);
            TestUtils.AreEqual(tanh(double3(1.2, 2.0, double.NegativeInfinity)), double3(0.83365460701215521, 0.9640275800758169, -1.0), 32, false);
            TestUtils.AreEqual(tanh(double3(double.NaN, double.PositiveInfinity, double.PositiveInfinity)), double3(double.NaN, 1.0, 1.0), 32, false);
        }

        [TestCompiler]
        public void tanh_double4()
        {
            TestUtils.AreEqual(tanh(double4(-2.0, -1.2, 0.0, 1.2)), double4(-0.9640275800758169, -0.83365460701215521, 0.0, 0.83365460701215521), 32, false);
            TestUtils.AreEqual(tanh(double4(2.0, double.NegativeInfinity, double.NaN, double.PositiveInfinity)), double4(0.9640275800758169, -1.0, double.NaN, 1.0), 32, false);
        }

        [TestCompiler]
        public void exp_float()
        {
            TestUtils.AreEqual(exp(-10f), 4.539993E-05f, 1, false);
            TestUtils.AreEqual(exp(-1.2f), 0.301194221f, 1, false);
            TestUtils.AreEqual(exp(0f), 1f, 1, false);
            TestUtils.AreEqual(exp(1.2f), 3.320117f, 1, false);
            TestUtils.AreEqual(exp(float.NegativeInfinity), 0f, 1, false);
            TestUtils.AreEqual(exp(float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(exp(float.PositiveInfinity), float.PositiveInfinity, 1, false);
        }

        [TestCompiler]
        public void exp_float2()
        {
            TestUtils.AreEqual(exp(float2(-10f, -1.2f)), float2(4.539993E-05f, 0.301194221f), 1, false);
            TestUtils.AreEqual(exp(float2(0f, 1.2f)), float2(1f, 3.320117f), 1, false);
            TestUtils.AreEqual(exp(float2(float.NegativeInfinity, float.NaN)), float2(0f, float.NaN), 1, false);
            TestUtils.AreEqual(exp(float2(float.PositiveInfinity, float.PositiveInfinity)), float2(float.PositiveInfinity, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void exp_float3()
        {
            TestUtils.AreEqual(exp(float3(-10f, -1.2f, 0f)), float3(4.539993E-05f, 0.301194221f, 1f), 1, false);
            TestUtils.AreEqual(exp(float3(1.2f, float.NegativeInfinity, float.NaN)), float3(3.320117f, 0f, float.NaN), 1, false);
            TestUtils.AreEqual(exp(float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity)), float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void exp_float4()
        {
            TestUtils.AreEqual(exp(float4(-10f, -1.2f, 0f, 1.2f)), float4(4.539993E-05f, 0.301194221f, 1f, 3.320117f), 1, false);
            TestUtils.AreEqual(exp(float4(float.NegativeInfinity, float.NaN, float.PositiveInfinity, float.PositiveInfinity)), float4(0f, float.NaN, float.PositiveInfinity, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void exp_double()
        {
            TestUtils.AreEqual(exp(-10.0), 4.5399929762484847E-05, 32, false);
            TestUtils.AreEqual(exp(-1.2), 0.30119421191220208, 32, false);
            TestUtils.AreEqual(exp(0.0), 1.0, 32, false);
            TestUtils.AreEqual(exp(1.2), 3.3201169227365477, 32, false);
            TestUtils.AreEqual(exp(double.NegativeInfinity), 0.0, 32, false);
            TestUtils.AreEqual(exp(double.NaN), double.NaN, 32, false);
            TestUtils.AreEqual(exp(double.PositiveInfinity), double.PositiveInfinity, 32, false);
        }

        [TestCompiler]
        public void exp_double2()
        {
            TestUtils.AreEqual(exp(double2(-10.0, -1.2)), double2(4.5399929762484847E-05, 0.30119421191220208), 32, false);
            TestUtils.AreEqual(exp(double2(0.0, 1.2)), double2(1.0, 3.3201169227365477), 32, false);
            TestUtils.AreEqual(exp(double2(double.NegativeInfinity, double.NaN)), double2(0.0, double.NaN), 32, false);
            TestUtils.AreEqual(exp(double2(double.PositiveInfinity, double.PositiveInfinity)), double2(double.PositiveInfinity, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void exp_double3()
        {
            TestUtils.AreEqual(exp(double3(-10.0, -1.2, 0.0)), double3(4.5399929762484847E-05, 0.30119421191220208, 1.0), 32, false);
            TestUtils.AreEqual(exp(double3(1.2, double.NegativeInfinity, double.NaN)), double3(3.3201169227365477, 0.0, double.NaN), 32, false);
            TestUtils.AreEqual(exp(double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity)), double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void exp_double4()
        {
            TestUtils.AreEqual(exp(double4(-10.0, -1.2, 0.0, 1.2)), double4(4.5399929762484847E-05, 0.30119421191220208, 1.0, 3.3201169227365477), 32, false);
            TestUtils.AreEqual(exp(double4(double.NegativeInfinity, double.NaN, double.PositiveInfinity, double.PositiveInfinity)), double4(0.0, double.NaN, double.PositiveInfinity, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void exp2_float()
        {
            TestUtils.AreEqual(exp2(-10f), 0.0009765625f, 1, false);
            TestUtils.AreEqual(exp2(-1.2f), 0.4352753f, 1, false);
            TestUtils.AreEqual(exp2(0f), 1f, 1, false);
            TestUtils.AreEqual(exp2(1.2f), 2.29739666f, 1, false);
            TestUtils.AreEqual(exp2(float.NegativeInfinity), 0f, 1, false);
            TestUtils.AreEqual(exp2(float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(exp2(float.PositiveInfinity), float.PositiveInfinity, 1, false);
        }

        [TestCompiler]
        public void exp2_float2()
        {
            TestUtils.AreEqual(exp2(float2(-10f, -1.2f)), float2(0.0009765625f, 0.4352753f), 1, false);
            TestUtils.AreEqual(exp2(float2(0f, 1.2f)), float2(1f, 2.29739666f), 1, false);
            TestUtils.AreEqual(exp2(float2(float.NegativeInfinity, float.NaN)), float2(0f, float.NaN), 1, false);
            TestUtils.AreEqual(exp2(float2(float.PositiveInfinity, float.PositiveInfinity)), float2(float.PositiveInfinity, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void exp2_float3()
        {
            TestUtils.AreEqual(exp2(float3(-10f, -1.2f, 0f)), float3(0.0009765625f, 0.4352753f, 1f), 1, false);
            TestUtils.AreEqual(exp2(float3(1.2f, float.NegativeInfinity, float.NaN)), float3(2.29739666f, 0f, float.NaN), 1, false);
            TestUtils.AreEqual(exp2(float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity)), float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void exp2_float4()
        {
            TestUtils.AreEqual(exp2(float4(-10f, -1.2f, 0f, 1.2f)), float4(0.0009765625f, 0.4352753f, 1f, 2.29739666f), 1, false);
            TestUtils.AreEqual(exp2(float4(float.NegativeInfinity, float.NaN, float.PositiveInfinity, float.PositiveInfinity)), float4(0f, float.NaN, float.PositiveInfinity, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void exp2_double()
        {
            TestUtils.AreEqual(exp2(-10.0), 0.0009765625, 32, false);
            TestUtils.AreEqual(exp2(-1.2), 0.435275281648062, 32, false);
            TestUtils.AreEqual(exp2(0.0), 1.0, 32, false);
            TestUtils.AreEqual(exp2(1.2), 2.29739670999407, 32, false);
            TestUtils.AreEqual(exp2(double.NegativeInfinity), 0.0, 32, false);
            TestUtils.AreEqual(exp2(double.NaN), double.NaN, 32, false);
            TestUtils.AreEqual(exp2(double.PositiveInfinity), double.PositiveInfinity, 32, false);
        }

        [TestCompiler]
        public void exp2_double2()
        {
            TestUtils.AreEqual(exp2(double2(-10.0, -1.2)), double2(0.0009765625, 0.435275281648062), 32, false);
            TestUtils.AreEqual(exp2(double2(0.0, 1.2)), double2(1.0, 2.29739670999407), 32, false);
            TestUtils.AreEqual(exp2(double2(double.NegativeInfinity, double.NaN)), double2(0.0, double.NaN), 32, false);
            TestUtils.AreEqual(exp2(double2(double.PositiveInfinity, double.PositiveInfinity)), double2(double.PositiveInfinity, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void exp2_double3()
        {
            TestUtils.AreEqual(exp2(double3(-10.0, -1.2, 0.0)), double3(0.0009765625, 0.435275281648062, 1.0), 32, false);
            TestUtils.AreEqual(exp2(double3(1.2, double.NegativeInfinity, double.NaN)), double3(2.29739670999407, 0.0, double.NaN), 32, false);
            TestUtils.AreEqual(exp2(double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity)), double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void exp2_double4()
        {
            TestUtils.AreEqual(exp2(double4(-10.0, -1.2, 0.0, 1.2)), double4(0.0009765625, 0.435275281648062, 1.0, 2.29739670999407), 32, false);
            TestUtils.AreEqual(exp2(double4(double.NegativeInfinity, double.NaN, double.PositiveInfinity, double.PositiveInfinity)), double4(0.0, double.NaN, double.PositiveInfinity, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void exp10_float()
        {
            TestUtils.AreEqual(exp10(-10f), 1E-10f, 32, false);
            TestUtils.AreEqual(exp10(-1.2f), 0.06309573f, 32, false);
            TestUtils.AreEqual(exp10(0f), 1f, 32, false);
            TestUtils.AreEqual(exp10(1.2f), 15.8489323f, 32, false);
            TestUtils.AreEqual(exp10(float.NegativeInfinity), 0f, 32, false);
            TestUtils.AreEqual(exp10(float.NaN), float.NaN, 32, false);
            TestUtils.AreEqual(exp10(float.PositiveInfinity), float.PositiveInfinity, 32, false);
        }

        [TestCompiler]
        public void exp10_float2()
        {
            TestUtils.AreEqual(exp10(float2(-10f, -1.2f)), float2(1E-10f, 0.06309573f), 32, false);
            TestUtils.AreEqual(exp10(float2(0f, 1.2f)), float2(1f, 15.8489323f), 32, false);
            TestUtils.AreEqual(exp10(float2(float.NegativeInfinity, float.NaN)), float2(0f, float.NaN), 32, false);
            TestUtils.AreEqual(exp10(float2(float.PositiveInfinity, float.PositiveInfinity)), float2(float.PositiveInfinity, float.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void exp10_float3()
        {
            TestUtils.AreEqual(exp10(float3(-10f, -1.2f, 0f)), float3(1E-10f, 0.06309573f, 1f), 32, false);
            TestUtils.AreEqual(exp10(float3(1.2f, float.NegativeInfinity, float.NaN)), float3(15.8489323f, 0f, float.NaN), 32, false);
            TestUtils.AreEqual(exp10(float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity)), float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void exp10_float4()
        {
            TestUtils.AreEqual(exp10(float4(-10f, -1.2f, 0f, 1.2f)), float4(1E-10f, 0.06309573f, 1f, 15.8489323f), 32, false);
            TestUtils.AreEqual(exp10(float4(float.NegativeInfinity, float.NaN, float.PositiveInfinity, float.PositiveInfinity)), float4(0f, float.NaN, float.PositiveInfinity, float.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void exp10_double()
        {
            TestUtils.AreEqual(exp10(-10.0), 1E-10, 32, false);
            TestUtils.AreEqual(exp10(-1.2), 0.063095734448019331, 32, false);
            TestUtils.AreEqual(exp10(0.0), 1.0, 32, false);
            TestUtils.AreEqual(exp10(1.2), 15.848931924611135, 32, false);
            TestUtils.AreEqual(exp10(double.NegativeInfinity), 0.0, 32, false);
            TestUtils.AreEqual(exp10(double.NaN), double.NaN, 32, false);
            TestUtils.AreEqual(exp10(double.PositiveInfinity), double.PositiveInfinity, 32, false);
        }

        [TestCompiler]
        public void exp10_double2()
        {
            TestUtils.AreEqual(exp10(double2(-10.0, -1.2)), double2(1E-10, 0.063095734448019331), 32, false);
            TestUtils.AreEqual(exp10(double2(0.0, 1.2)), double2(1.0, 15.848931924611135), 32, false);
            TestUtils.AreEqual(exp10(double2(double.NegativeInfinity, double.NaN)), double2(0.0, double.NaN), 32, false);
            TestUtils.AreEqual(exp10(double2(double.PositiveInfinity, double.PositiveInfinity)), double2(double.PositiveInfinity, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void exp10_double3()
        {
            TestUtils.AreEqual(exp10(double3(-10.0, -1.2, 0.0)), double3(1E-10, 0.063095734448019331, 1.0), 32, false);
            TestUtils.AreEqual(exp10(double3(1.2, double.NegativeInfinity, double.NaN)), double3(15.848931924611135, 0.0, double.NaN), 32, false);
            TestUtils.AreEqual(exp10(double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity)), double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void exp10_double4()
        {
            TestUtils.AreEqual(exp10(double4(-10.0, -1.2, 0.0, 1.2)), double4(1E-10, 0.063095734448019331, 1.0, 15.848931924611135), 32, false);
            TestUtils.AreEqual(exp10(double4(double.NegativeInfinity, double.NaN, double.PositiveInfinity, double.PositiveInfinity)), double4(0.0, double.NaN, double.PositiveInfinity, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void log_float()
        {
            TestUtils.AreEqual(log(1.2E-09f), -20.5409451f, 1, false);
            TestUtils.AreEqual(log(1f), 0f, 1, false);
            TestUtils.AreEqual(log(1.2E+10f), 23.2081718f, 1, false);
            TestUtils.AreEqual(log(-1f), float.NaN, 1, false);
            TestUtils.AreEqual(log(float.NegativeInfinity), float.NaN, 1, false);
            TestUtils.AreEqual(log(float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(log(float.PositiveInfinity), float.PositiveInfinity, 1, false);
        }

        [TestCompiler]
        public void log_float2()
        {
            TestUtils.AreEqual(log(float2(1.2E-09f, 1f)), float2(-20.5409451f, 0f), 1, false);
            TestUtils.AreEqual(log(float2(1.2E+10f, -1f)), float2(23.2081718f, float.NaN), 1, false);
            TestUtils.AreEqual(log(float2(float.NegativeInfinity, float.NaN)), float2(float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(log(float2(float.PositiveInfinity, float.PositiveInfinity)), float2(float.PositiveInfinity, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void log_float3()
        {
            TestUtils.AreEqual(log(float3(1.2E-09f, 1f, 1.2E+10f)), float3(-20.5409451f, 0f, 23.2081718f), 1, false);
            TestUtils.AreEqual(log(float3(-1f, float.NegativeInfinity, float.NaN)), float3(float.NaN, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(log(float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity)), float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void log_float4()
        {
            TestUtils.AreEqual(log(float4(1.2E-09f, 1f, 1.2E+10f, -1f)), float4(-20.5409451f, 0f, 23.2081718f, float.NaN), 1, false);
            TestUtils.AreEqual(log(float4(float.NegativeInfinity, float.NaN, float.PositiveInfinity, float.PositiveInfinity)), float4(float.NaN, float.NaN, float.PositiveInfinity, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void log_double()
        {
            TestUtils.AreEqual(log(1.2E-09), -20.540944280152456, 32, false);
            TestUtils.AreEqual(log(1.0), 0.0, 32, false);
            TestUtils.AreEqual(log(12000000000.0), 23.208172486734409, 32, false);
            TestUtils.AreEqual(log(-1.0), double.NaN, 32, false);
            TestUtils.AreEqual(log(double.NegativeInfinity), double.NaN, 32, false);
            TestUtils.AreEqual(log(double.NaN), double.NaN, 32, false);
            TestUtils.AreEqual(log(double.PositiveInfinity), double.PositiveInfinity, 32, false);
        }

        [TestCompiler]
        public void log_double2()
        {
            TestUtils.AreEqual(log(double2(1.2E-09, 1.0)), double2(-20.540944280152456, 0.0), 32, false);
            TestUtils.AreEqual(log(double2(12000000000.0, -1.0)), double2(23.208172486734409, double.NaN), 32, false);
            TestUtils.AreEqual(log(double2(double.NegativeInfinity, double.NaN)), double2(double.NaN, double.NaN), 32, false);
            TestUtils.AreEqual(log(double2(double.PositiveInfinity, double.PositiveInfinity)), double2(double.PositiveInfinity, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void log_double3()
        {
            TestUtils.AreEqual(log(double3(1.2E-09, 1.0, 12000000000.0)), double3(-20.540944280152456, 0.0, 23.208172486734409), 32, false);
            TestUtils.AreEqual(log(double3(-1.0, double.NegativeInfinity, double.NaN)), double3(double.NaN, double.NaN, double.NaN), 32, false);
            TestUtils.AreEqual(log(double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity)), double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void log_double4()
        {
            TestUtils.AreEqual(log(double4(1.2E-09, 1.0, 12000000000.0, -1.0)), double4(-20.540944280152456, 0.0, 23.208172486734409, double.NaN), 32, false);
            TestUtils.AreEqual(log(double4(double.NegativeInfinity, double.NaN, double.PositiveInfinity, double.PositiveInfinity)), double4(double.NaN, double.NaN, double.PositiveInfinity, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void log2_float()
        {
            TestUtils.AreEqual(log2(1.2E-09f), -29.63432f, 1, false);
            TestUtils.AreEqual(log2(1f), 0f, 1, false);
            TestUtils.AreEqual(log2(1.2E+10f), 33.4823151f, 1, false);
            TestUtils.AreEqual(log2(-1f), float.NaN, 1, false);
            TestUtils.AreEqual(log2(float.NegativeInfinity), float.NaN, 1, false);
            TestUtils.AreEqual(log2(float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(log2(float.PositiveInfinity), float.PositiveInfinity, 1, false);
        }

        [TestCompiler]
        public void log2_float2()
        {
            TestUtils.AreEqual(log2(float2(1.2E-09f, 1f)), float2(-29.63432f, 0f), 1, false);
            TestUtils.AreEqual(log2(float2(1.2E+10f, -1f)), float2(33.4823151f, float.NaN), 1, false);
            TestUtils.AreEqual(log2(float2(float.NegativeInfinity, float.NaN)), float2(float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(log2(float2(float.PositiveInfinity, float.PositiveInfinity)), float2(float.PositiveInfinity, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void log2_float3()
        {
            TestUtils.AreEqual(log2(float3(1.2E-09f, 1f, 1.2E+10f)), float3(-29.63432f, 0f, 33.4823151f), 1, false);
            TestUtils.AreEqual(log2(float3(-1f, float.NegativeInfinity, float.NaN)), float3(float.NaN, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(log2(float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity)), float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void log2_float4()
        {
            TestUtils.AreEqual(log2(float4(1.2E-09f, 1f, 1.2E+10f, -1f)), float4(-29.63432f, 0f, 33.4823151f, float.NaN), 1, false);
            TestUtils.AreEqual(log2(float4(float.NegativeInfinity, float.NaN, float.PositiveInfinity, float.PositiveInfinity)), float4(float.NaN, float.NaN, float.PositiveInfinity, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void log2_double()
        {
            TestUtils.AreEqual(log2(1.2E-09), -29.634318448152467, 32, false);
            TestUtils.AreEqual(log2(1.0), 0.0, 32, false);
            TestUtils.AreEqual(log2(12000000000.0), 33.482315354707417, 32, false);
            TestUtils.AreEqual(log2(-1.0), double.NaN, 32, false);
            TestUtils.AreEqual(log2(double.NegativeInfinity), double.NaN, 32, false);
            TestUtils.AreEqual(log2(double.NaN), double.NaN, 32, false);
            TestUtils.AreEqual(log2(double.PositiveInfinity), double.PositiveInfinity, 32, false);
        }

        [TestCompiler]
        public void log2_double2()
        {
            TestUtils.AreEqual(log2(double2(1.2E-09, 1.0)), double2(-29.634318448152467, 0.0), 32, false);
            TestUtils.AreEqual(log2(double2(12000000000.0, -1.0)), double2(33.482315354707417, double.NaN), 32, false);
            TestUtils.AreEqual(log2(double2(double.NegativeInfinity, double.NaN)), double2(double.NaN, double.NaN), 32, false);
            TestUtils.AreEqual(log2(double2(double.PositiveInfinity, double.PositiveInfinity)), double2(double.PositiveInfinity, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void log2_double3()
        {
            TestUtils.AreEqual(log2(double3(1.2E-09, 1.0, 12000000000.0)), double3(-29.634318448152467, 0.0, 33.482315354707417), 32, false);
            TestUtils.AreEqual(log2(double3(-1.0, double.NegativeInfinity, double.NaN)), double3(double.NaN, double.NaN, double.NaN), 32, false);
            TestUtils.AreEqual(log2(double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity)), double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void log2_double4()
        {
            TestUtils.AreEqual(log2(double4(1.2E-09, 1.0, 12000000000.0, -1.0)), double4(-29.634318448152467, 0.0, 33.482315354707417, double.NaN), 32, false);
            TestUtils.AreEqual(log2(double4(double.NegativeInfinity, double.NaN, double.PositiveInfinity, double.PositiveInfinity)), double4(double.NaN, double.NaN, double.PositiveInfinity, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void log10_float()
        {
            TestUtils.AreEqual(log10(1.2E-09f), -8.920818f, 1, false);
            TestUtils.AreEqual(log10(1f), 0f, 1, false);
            TestUtils.AreEqual(log10(1.2E+10f), 10.0791817f, 1, false);
            TestUtils.AreEqual(log10(-1f), float.NaN, 1, false);
            TestUtils.AreEqual(log10(float.NegativeInfinity), float.NaN, 1, false);
            TestUtils.AreEqual(log10(float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(log10(float.PositiveInfinity), float.PositiveInfinity, 1, false);
        }

        [TestCompiler]
        public void log10_float2()
        {
            TestUtils.AreEqual(log10(float2(1.2E-09f, 1f)), float2(-8.920818f, 0f), 1, false);
            TestUtils.AreEqual(log10(float2(1.2E+10f, -1f)), float2(10.0791817f, float.NaN), 1, false);
            TestUtils.AreEqual(log10(float2(float.NegativeInfinity, float.NaN)), float2(float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(log10(float2(float.PositiveInfinity, float.PositiveInfinity)), float2(float.PositiveInfinity, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void log10_float3()
        {
            TestUtils.AreEqual(log10(float3(1.2E-09f, 1f, 1.2E+10f)), float3(-8.920818f, 0f, 10.0791817f), 1, false);
            TestUtils.AreEqual(log10(float3(-1f, float.NegativeInfinity, float.NaN)), float3(float.NaN, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(log10(float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity)), float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void log10_float4()
        {
            TestUtils.AreEqual(log10(float4(1.2E-09f, 1f, 1.2E+10f, -1f)), float4(-8.920818f, 0f, 10.0791817f, float.NaN), 1, false);
            TestUtils.AreEqual(log10(float4(float.NegativeInfinity, float.NaN, float.PositiveInfinity, float.PositiveInfinity)), float4(float.NaN, float.NaN, float.PositiveInfinity, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void log10_double()
        {
            TestUtils.AreEqual(log10(1.2E-09), -8.9208187539523749, 32, false);
            TestUtils.AreEqual(log10(1.0), 0.0, 32, false);
            TestUtils.AreEqual(log10(12000000000.0), 10.079181246047623, 32, false);
            TestUtils.AreEqual(log10(-1.0), double.NaN, 32, false);
            TestUtils.AreEqual(log10(double.NegativeInfinity), double.NaN, 32, false);
            TestUtils.AreEqual(log10(double.NaN), double.NaN, 32, false);
            TestUtils.AreEqual(log10(double.PositiveInfinity), double.PositiveInfinity, 32, false);
        }

        [TestCompiler]
        public void log10_double2()
        {
            TestUtils.AreEqual(log10(double2(1.2E-09, 1.0)), double2(-8.9208187539523749, 0.0), 32, false);
            TestUtils.AreEqual(log10(double2(12000000000.0, -1.0)), double2(10.079181246047623, double.NaN), 32, false);
            TestUtils.AreEqual(log10(double2(double.NegativeInfinity, double.NaN)), double2(double.NaN, double.NaN), 32, false);
            TestUtils.AreEqual(log10(double2(double.PositiveInfinity, double.PositiveInfinity)), double2(double.PositiveInfinity, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void log10_double3()
        {
            TestUtils.AreEqual(log10(double3(1.2E-09, 1.0, 12000000000.0)), double3(-8.9208187539523749, 0.0, 10.079181246047623), 32, false);
            TestUtils.AreEqual(log10(double3(-1.0, double.NegativeInfinity, double.NaN)), double3(double.NaN, double.NaN, double.NaN), 32, false);
            TestUtils.AreEqual(log10(double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity)), double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void log10_double4()
        {
            TestUtils.AreEqual(log10(double4(1.2E-09, 1.0, 12000000000.0, -1.0)), double4(-8.9208187539523749, 0.0, 10.079181246047623, double.NaN), 32, false);
            TestUtils.AreEqual(log10(double4(double.NegativeInfinity, double.NaN, double.PositiveInfinity, double.PositiveInfinity)), double4(double.NaN, double.NaN, double.PositiveInfinity, double.PositiveInfinity), 32, false);
        }

        [TestCompiler]
        public void radians_float()
        {
            TestUtils.AreEqual(radians(-123.45f), -2.154609f, 1, false);
            TestUtils.AreEqual(radians(0f), 0f, 0, false);
            TestUtils.AreEqual(radians(123.45f), 2.154609f, 1, false);
            TestUtils.AreEqual(radians(float.NegativeInfinity), float.NegativeInfinity, 0, false);
            TestUtils.AreEqual(radians(float.NaN), float.NaN, 0, false);
            TestUtils.AreEqual(radians(float.PositiveInfinity), float.PositiveInfinity, 0, false);
        }

        [TestCompiler]
        public void radians_float2()
        {
            TestUtils.AreEqual(radians(float2(-123.45f, 0f)), float2(-2.154609f, 0f), 1, false);
            TestUtils.AreEqual(radians(float2(123.45f, float.NegativeInfinity)), float2(2.154609f, float.NegativeInfinity), 1, false);
            TestUtils.AreEqual(radians(float2(float.NaN, float.PositiveInfinity)), float2(float.NaN, float.PositiveInfinity), 0, false);
        }

        [TestCompiler]
        public void radians_float3()
        {
            TestUtils.AreEqual(radians(float3(-123.45f, 0f, 123.45f)), float3(-2.154609f, 0f, 2.154609f), 1, false);
            TestUtils.AreEqual(radians(float3(float.NegativeInfinity, float.NaN, float.PositiveInfinity)), float3(float.NegativeInfinity, float.NaN, float.PositiveInfinity), 0, false);
        }

        [TestCompiler]
        public void radians_float4()
        {
            TestUtils.AreEqual(radians(float4(-123.45f, 0f, 123.45f, float.NegativeInfinity)), float4(-2.154609f, 0f, 2.154609f, float.NegativeInfinity), 1, false);
            TestUtils.AreEqual(radians(float4(float.NaN, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity)), float4(float.NaN, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void radians_double()
        {
            TestUtils.AreEqual(radians(-123.45), -2.154608961587, 1, false);
            TestUtils.AreEqual(radians(0.0), 0.0, 0, false);
            TestUtils.AreEqual(radians(123.45), 2.154608961587, 1, false);
            TestUtils.AreEqual(radians(double.NegativeInfinity), double.NegativeInfinity, 0, false);
            TestUtils.AreEqual(radians(double.NaN), double.NaN, 0, false);
            TestUtils.AreEqual(radians(double.PositiveInfinity), double.PositiveInfinity, 0, false);
        }

        [TestCompiler]
        public void radians_double2()
        {
            TestUtils.AreEqual(radians(double2(-123.45, 0.0)), double2(-2.154608961587, 0.0), 1, false);
            TestUtils.AreEqual(radians(double2(123.45, double.NegativeInfinity)), double2(2.154608961587, double.NegativeInfinity), 1, false);
            TestUtils.AreEqual(radians(double2(double.NaN, double.PositiveInfinity)), double2(double.NaN, double.PositiveInfinity), 0, false);
        }

        [TestCompiler]
        public void radians_double3()
        {
            TestUtils.AreEqual(radians(double3(-123.45, 0.0, 123.45)), double3(-2.154608961587, 0.0, 2.154608961587), 1, false);
            TestUtils.AreEqual(radians(double3(double.NegativeInfinity, double.NaN, double.PositiveInfinity)), double3(double.NegativeInfinity, double.NaN, double.PositiveInfinity), 0, false);
        }

        [TestCompiler]
        public void radians_double4()
        {
            TestUtils.AreEqual(radians(double4(-123.45, 0.0, 123.45, double.NegativeInfinity)), double4(-2.154608961587, 0.0, 2.154608961587, double.NegativeInfinity), 1, false);
            TestUtils.AreEqual(radians(double4(double.NaN, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity)), double4(double.NaN, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity), 0, false);
        }

        [TestCompiler]
        public void degrees_float()
        {
            TestUtils.AreEqual(degrees(-123.45f), -7073.164f, 0, false);
            TestUtils.AreEqual(degrees(0f), 0f, 0, false);
            TestUtils.AreEqual(degrees(123.45f), 7073.164f, 0, false);
            TestUtils.AreEqual(degrees(float.NegativeInfinity), float.NegativeInfinity, 0, false);
            TestUtils.AreEqual(degrees(float.NaN), float.NaN, 0, false);
            TestUtils.AreEqual(degrees(float.PositiveInfinity), float.PositiveInfinity, 0, false);
        }

        [TestCompiler]
        public void degrees_float2()
        {
            TestUtils.AreEqual(degrees(float2(-123.45f, 0f)), float2(-7073.164f, 0f), 0, false);
            TestUtils.AreEqual(degrees(float2(123.45f, float.NegativeInfinity)), float2(7073.164f, float.NegativeInfinity), 0, false);
            TestUtils.AreEqual(degrees(float2(float.NaN, float.PositiveInfinity)), float2(float.NaN, float.PositiveInfinity), 0, false);
        }

        [TestCompiler]
        public void degrees_float3()
        {
            TestUtils.AreEqual(degrees(float3(-123.45f, 0f, 123.45f)), float3(-7073.164f, 0f, 7073.164f), 0, false);
            TestUtils.AreEqual(degrees(float3(float.NegativeInfinity, float.NaN, float.PositiveInfinity)), float3(float.NegativeInfinity, float.NaN, float.PositiveInfinity), 0, false);
        }

        [TestCompiler]
        public void degrees_float4()
        {
            TestUtils.AreEqual(degrees(float4(-123.45f, 0f, 123.45f, float.NegativeInfinity)), float4(-7073.164f, 0f, 7073.164f, float.NegativeInfinity), 0, false);
            TestUtils.AreEqual(degrees(float4(float.NaN, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity)), float4(float.NaN, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity), 0, false);
        }

        [TestCompiler]
        public void degrees_double()
        {
            TestUtils.AreEqual(degrees(-123.45), -7073.1639808900127, 0, false);
            TestUtils.AreEqual(degrees(0.0), 0.0, 0, false);
            TestUtils.AreEqual(degrees(123.45), 7073.1639808900127, 0, false);
            TestUtils.AreEqual(degrees(double.NegativeInfinity), double.NegativeInfinity, 0, false);
            TestUtils.AreEqual(degrees(double.NaN), double.NaN, 0, false);
            TestUtils.AreEqual(degrees(double.PositiveInfinity), double.PositiveInfinity, 0, false);
        }

        [TestCompiler]
        public void degrees_double2()
        {
            TestUtils.AreEqual(degrees(double2(-123.45, 0.0)), double2(-7073.1639808900127, 0.0), 0, false);
            TestUtils.AreEqual(degrees(double2(123.45, double.NegativeInfinity)), double2(7073.1639808900127, double.NegativeInfinity), 0, false);
            TestUtils.AreEqual(degrees(double2(double.NaN, double.PositiveInfinity)), double2(double.NaN, double.PositiveInfinity), 0, false);
        }

        [TestCompiler]
        public void degrees_double3()
        {
            TestUtils.AreEqual(degrees(double3(-123.45, 0.0, 123.45)), double3(-7073.1639808900127, 0.0, 7073.1639808900127), 0, false);
            TestUtils.AreEqual(degrees(double3(double.NegativeInfinity, double.NaN, double.PositiveInfinity)), double3(double.NegativeInfinity, double.NaN, double.PositiveInfinity), 0, false);
        }

        [TestCompiler]
        public void degrees_double4()
        {
            TestUtils.AreEqual(degrees(double4(-123.45, 0.0, 123.45, double.NegativeInfinity)), double4(-7073.1639808900127, 0.0, 7073.1639808900127, double.NegativeInfinity), 0, false);
            TestUtils.AreEqual(degrees(double4(double.NaN, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity)), double4(double.NaN, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity), 0, false);
        }

        [TestCompiler]
        public void sign_float()
        {
            TestUtils.AreEqual(sign(-123.45f), -1f);
            TestUtils.AreEqual(sign(-1E-20f), -1f);
            TestUtils.AreEqual(sign(0f), 0f);
            TestUtils.AreEqual(sign(1E-10f), 1f);
            TestUtils.AreEqual(sign(123.45f), 1f);
            TestUtils.AreEqual(sign(float.NegativeInfinity), -1f);
            TestUtils.AreEqual(sign(float.NaN), 0f);
            TestUtils.AreEqual(sign(float.PositiveInfinity), 1f);
        }

        [TestCompiler]
        public void sign_float2()
        {
            TestUtils.AreEqual(sign(float2(-123.45f, -1E-20f)), float2(-1f, -1f));
            TestUtils.AreEqual(sign(float2(0f, 1E-10f)), float2(0f, 1f));
            TestUtils.AreEqual(sign(float2(123.45f, float.NegativeInfinity)), float2(1f, -1f));
            TestUtils.AreEqual(sign(float2(float.NaN, float.PositiveInfinity)), float2(0f, 1f));
        }

        [TestCompiler]
        public void sign_float3()
        {
            TestUtils.AreEqual(sign(float3(-123.45f, -1E-20f, 0f)), float3(-1f, -1f, 0f));
            TestUtils.AreEqual(sign(float3(1E-10f, 123.45f, float.NegativeInfinity)), float3(1f, 1f, -1f));
            TestUtils.AreEqual(sign(float3(float.NaN, float.PositiveInfinity, float.PositiveInfinity)), float3(0f, 1f, 1f));
        }

        [TestCompiler]
        public void sign_float4()
        {
            TestUtils.AreEqual(sign(float4(-123.45f, -1E-20f, 0f, 1E-10f)), float4(-1f, -1f, 0f, 1f));
            TestUtils.AreEqual(sign(float4(123.45f, float.NegativeInfinity, float.NaN, float.PositiveInfinity)), float4(1f, -1f, 0f, 1f));
        }

        [TestCompiler]
        public void sign_double()
        {
            TestUtils.AreEqual(sign(-123.45), -1.0);
            TestUtils.AreEqual(sign(-1E-20), -1.0);
            TestUtils.AreEqual(sign(0.0), 0.0);
            TestUtils.AreEqual(sign(1E-10), 1.0);
            TestUtils.AreEqual(sign(123.45), 1.0);
            TestUtils.AreEqual(sign(double.NegativeInfinity), -1.0);
            TestUtils.AreEqual(sign(double.NaN), 0.0);
            TestUtils.AreEqual(sign(double.PositiveInfinity), 1.0);
        }

        [TestCompiler]
        public void sign_double2()
        {
            TestUtils.AreEqual(sign(double2(-123.45, -1E-20)), double2(-1.0, -1.0));
            TestUtils.AreEqual(sign(double2(0.0, 1E-10)), double2(0.0, 1.0));
            TestUtils.AreEqual(sign(double2(123.45, double.NegativeInfinity)), double2(1.0, -1.0));
            TestUtils.AreEqual(sign(double2(double.NaN, double.PositiveInfinity)), double2(0.0, 1.0));
        }

        [TestCompiler]
        public void sign_double3()
        {
            TestUtils.AreEqual(sign(double3(-123.45, -1E-20, 0.0)), double3(-1.0, -1.0, 0.0));
            TestUtils.AreEqual(sign(double3(1E-10, 123.45, double.NegativeInfinity)), double3(1.0, 1.0, -1.0));
            TestUtils.AreEqual(sign(double3(double.NaN, double.PositiveInfinity, double.PositiveInfinity)), double3(0.0, 1.0, 1.0));
        }

        [TestCompiler]
        public void sign_double4()
        {
            TestUtils.AreEqual(sign(double4(-123.45, -1E-20, 0.0, 1E-10)), double4(-1.0, -1.0, 0.0, 1.0));
            TestUtils.AreEqual(sign(double4(123.45, double.NegativeInfinity, double.NaN, double.PositiveInfinity)), double4(1.0, -1.0, 0.0, 1.0));
        }

        [TestCompiler]
        public void sqrt_float()
        {
            TestUtils.AreEqual(sqrt(-1f), float.NaN, 1, false);
            TestUtils.AreEqual(sqrt(0f), 0f, 1, false);
            TestUtils.AreEqual(sqrt(1E-10f), 1E-05f, 1, false);
            TestUtils.AreEqual(sqrt(123.45f), 11.1108055f, 1, false);
            TestUtils.AreEqual(sqrt(float.NegativeInfinity), float.NaN, 1, false);
            TestUtils.AreEqual(sqrt(float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(sqrt(float.PositiveInfinity), float.PositiveInfinity, 1, false);
        }

        [TestCompiler]
        public void sqrt_float2()
        {
            TestUtils.AreEqual(sqrt(float2(-1f, 0f)), float2(float.NaN, 0f), 1, false);
            TestUtils.AreEqual(sqrt(float2(1E-10f, 123.45f)), float2(1E-05f, 11.1108055f), 1, false);
            TestUtils.AreEqual(sqrt(float2(float.NegativeInfinity, float.NaN)), float2(float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(sqrt(float2(float.PositiveInfinity, float.PositiveInfinity)), float2(float.PositiveInfinity, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void sqrt_float3()
        {
            TestUtils.AreEqual(sqrt(float3(-1f, 0f, 1E-10f)), float3(float.NaN, 0f, 1E-05f), 1, false);
            TestUtils.AreEqual(sqrt(float3(123.45f, float.NegativeInfinity, float.NaN)), float3(11.1108055f, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(sqrt(float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity)), float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void sqrt_float4()
        {
            TestUtils.AreEqual(sqrt(float4(-1f, 0f, 1E-10f, 123.45f)), float4(float.NaN, 0f, 1E-05f, 11.1108055f), 1, false);
            TestUtils.AreEqual(sqrt(float4(float.NegativeInfinity, float.NaN, float.PositiveInfinity, float.PositiveInfinity)), float4(float.NaN, float.NaN, float.PositiveInfinity, float.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void sqrt_double()
        {
            TestUtils.AreEqual(sqrt(-1.0), double.NaN, 1, false);
            TestUtils.AreEqual(sqrt(0.0), 0.0, 1, false);
            TestUtils.AreEqual(sqrt(1E-10), 1E-05, 1, false);
            TestUtils.AreEqual(sqrt(123.45), 11.11080555135405, 1, false);
            TestUtils.AreEqual(sqrt(double.NegativeInfinity), double.NaN, 1, false);
            TestUtils.AreEqual(sqrt(double.NaN), double.NaN, 1, false);
            TestUtils.AreEqual(sqrt(double.PositiveInfinity), double.PositiveInfinity, 1, false);
        }

        [TestCompiler]
        public void sqrt_double2()
        {
            TestUtils.AreEqual(sqrt(double2(-1.0, 0.0)), double2(double.NaN, 0.0), 1, false);
            TestUtils.AreEqual(sqrt(double2(1E-10, 123.45)), double2(1E-05, 11.11080555135405), 1, false);
            TestUtils.AreEqual(sqrt(double2(double.NegativeInfinity, double.NaN)), double2(double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(sqrt(double2(double.PositiveInfinity, double.PositiveInfinity)), double2(double.PositiveInfinity, double.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void sqrt_double3()
        {
            TestUtils.AreEqual(sqrt(double3(-1.0, 0.0, 1E-10)), double3(double.NaN, 0.0, 1E-05), 1, false);
            TestUtils.AreEqual(sqrt(double3(123.45, double.NegativeInfinity, double.NaN)), double3(11.11080555135405, double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(sqrt(double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity)), double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void sqrt_double4()
        {
            TestUtils.AreEqual(sqrt(double4(-1.0, 0.0, 1E-10, 123.45)), double4(double.NaN, 0.0, 1E-05, 11.11080555135405), 1, false);
            TestUtils.AreEqual(sqrt(double4(double.NegativeInfinity, double.NaN, double.PositiveInfinity, double.PositiveInfinity)), double4(double.NaN, double.NaN, double.PositiveInfinity, double.PositiveInfinity), 1, false);
        }

        [TestCompiler]
        public void rsqrt_float()
        {
            TestUtils.AreEqual(rsqrt(-1f), float.NaN, 1, false);
            TestUtils.AreEqual(rsqrt(0f), float.PositiveInfinity, 1, false);
            TestUtils.AreEqual(rsqrt(1E+10f), 1E-05f, 1, false);
            TestUtils.AreEqual(rsqrt(123.45f), 0.09000248f, 1, false);
            TestUtils.AreEqual(rsqrt(float.NegativeInfinity), float.NaN, 1, false);
            TestUtils.AreEqual(rsqrt(float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(rsqrt(float.PositiveInfinity), 0f, 1, false);
        }

        [TestCompiler]
        public void rsqrt_float2()
        {
            TestUtils.AreEqual(rsqrt(float2(-1f, 0f)), float2(float.NaN, float.PositiveInfinity), 1, false);
            TestUtils.AreEqual(rsqrt(float2(1E+10f, 123.45f)), float2(1E-05f, 0.09000248f), 1, false);
            TestUtils.AreEqual(rsqrt(float2(float.NegativeInfinity, float.NaN)), float2(float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(rsqrt(float2(float.PositiveInfinity, float.PositiveInfinity)), float2(0f, 0f), 1, false);
        }

        [TestCompiler]
        public void rsqrt_float3()
        {
            TestUtils.AreEqual(rsqrt(float3(-1f, 0f, 1E+10f)), float3(float.NaN, float.PositiveInfinity, 1E-05f), 1, false);
            TestUtils.AreEqual(rsqrt(float3(123.45f, float.NegativeInfinity, float.NaN)), float3(0.09000248f, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(rsqrt(float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity)), float3(0f, 0f, 0f), 1, false);
        }

        [TestCompiler]
        public void rsqrt_float4()
        {
            TestUtils.AreEqual(rsqrt(float4(-1f, 0f, 1E+10f, 123.45f)), float4(float.NaN, float.PositiveInfinity, 1E-05f, 0.09000248f), 1, false);
            TestUtils.AreEqual(rsqrt(float4(float.NegativeInfinity, float.NaN, float.PositiveInfinity, float.PositiveInfinity)), float4(float.NaN, float.NaN, 0f, 0f), 1, false);
        }

        [TestCompiler]
        public void rsqrt_double()
        {
            TestUtils.AreEqual(rsqrt(-1.0), double.NaN, 1, false);
            TestUtils.AreEqual(rsqrt(0.0), double.PositiveInfinity, 1, false);
            TestUtils.AreEqual(rsqrt(10000000000.0), 1E-05, 1, false);
            TestUtils.AreEqual(rsqrt(123.45), 0.090002475102098425, 1, false);
            TestUtils.AreEqual(rsqrt(double.NegativeInfinity), double.NaN, 1, false);
            TestUtils.AreEqual(rsqrt(double.NaN), double.NaN, 1, false);
            TestUtils.AreEqual(rsqrt(double.PositiveInfinity), 0.0, 1, false);
        }

        [TestCompiler]
        public void rsqrt_double2()
        {
            TestUtils.AreEqual(rsqrt(double2(-1.0, 0.0)), double2(double.NaN, double.PositiveInfinity), 1, false);
            TestUtils.AreEqual(rsqrt(double2(10000000000.0, 123.45)), double2(1E-05, 0.090002475102098425), 1, false);
            TestUtils.AreEqual(rsqrt(double2(double.NegativeInfinity, double.NaN)), double2(double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(rsqrt(double2(double.PositiveInfinity, double.PositiveInfinity)), double2(0.0, 0.0), 1, false);
        }

        [TestCompiler]
        public void rsqrt_double3()
        {
            TestUtils.AreEqual(rsqrt(double3(-1.0, 0.0, 10000000000.0)), double3(double.NaN, double.PositiveInfinity, 1E-05), 1, false);
            TestUtils.AreEqual(rsqrt(double3(123.45, double.NegativeInfinity, double.NaN)), double3(0.090002475102098425, double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(rsqrt(double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity)), double3(0.0, 0.0, 0.0), 1, false);
        }

        [TestCompiler]
        public void rsqrt_double4()
        {
            TestUtils.AreEqual(rsqrt(double4(-1.0, 0.0, 10000000000.0, 123.45)), double4(double.NaN, double.PositiveInfinity, 1E-05, 0.090002475102098425), 1, false);
            TestUtils.AreEqual(rsqrt(double4(double.NegativeInfinity, double.NaN, double.PositiveInfinity, double.PositiveInfinity)), double4(double.NaN, double.NaN, 0.0, 0.0), 1, false);
        }

        [TestCompiler]
        public void rcp_float()
        {
            TestUtils.AreEqual(rcp(-123.45f), -0.008100445f, 1, false);
            TestUtils.AreEqual(rcp(0f), float.PositiveInfinity, 0, false);
            TestUtils.AreEqual(rcp(123.45f), 0.008100445f, 1, false);
            TestUtils.AreEqual(rcp(float.NaN), float.NaN, 0, false);
            TestUtils.AreEqual(rcp(float.PositiveInfinity), 0f, 0, false);
        }

        [TestCompiler]
        public void rcp_float2()
        {
            TestUtils.AreEqual(rcp(float2(-123.45f, 0f)), float2(-0.008100445f, float.PositiveInfinity), 1, false);
            TestUtils.AreEqual(rcp(float2(123.45f, float.NaN)), float2(0.008100445f, float.NaN), 1, false);
            TestUtils.AreEqual(rcp(float2(float.PositiveInfinity, float.PositiveInfinity)), float2(0f, 0f), 0, false);
        }

        [TestCompiler]
        public void rcp_float3()
        {
            TestUtils.AreEqual(rcp(float3(-123.45f, 0f, 123.45f)), float3(-0.008100445f, float.PositiveInfinity, 0.008100445f), 1, false);
            TestUtils.AreEqual(rcp(float3(float.NaN, float.PositiveInfinity, float.PositiveInfinity)), float3(float.NaN, 0f, 0f), 0, false);
        }

        [TestCompiler]
        public void rcp_float4()
        {
            TestUtils.AreEqual(rcp(float4(-123.45f, 0f, 123.45f, float.NaN)), float4(-0.008100445f, float.PositiveInfinity, 0.008100445f, float.NaN), 1, false);
            TestUtils.AreEqual(rcp(float4(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity)), float4(0f, 0f, 0f, 0f), 0, false);
        }

        [TestCompiler]
        public void rcp_double()
        {
            TestUtils.AreEqual(rcp(-123.45), -0.0081004455245038479, 1, false);
            TestUtils.AreEqual(rcp(0.0), double.PositiveInfinity, 0, false);
            TestUtils.AreEqual(rcp(123.45), 0.0081004455245038479, 1, false);
            TestUtils.AreEqual(rcp(double.NaN), double.NaN, 0, false);
            TestUtils.AreEqual(rcp(double.PositiveInfinity), 0.0, 0, false);
        }

        [TestCompiler]
        public void rcp_double2()
        {
            TestUtils.AreEqual(rcp(double2(-123.45, 0.0)), double2(-0.0081004455245038479, double.PositiveInfinity), 1, false);
            TestUtils.AreEqual(rcp(double2(123.45, double.NaN)), double2(0.0081004455245038479, double.NaN), 1, false);
            TestUtils.AreEqual(rcp(double2(double.PositiveInfinity, double.PositiveInfinity)), double2(0.0, 0.0), 0, false);
        }

        [TestCompiler]
        public void rcp_double3()
        {
            TestUtils.AreEqual(rcp(double3(-123.45, 0.0, 123.45)), double3(-0.0081004455245038479, double.PositiveInfinity, 0.0081004455245038479), 1, false);
            TestUtils.AreEqual(rcp(double3(double.NaN, double.PositiveInfinity, double.PositiveInfinity)), double3(double.NaN, 0.0, 0.0), 0, false);
        }

        [TestCompiler]
        public void rcp_double4()
        {
            TestUtils.AreEqual(rcp(double4(-123.45, 0.0, 123.45, double.NaN)), double4(-0.0081004455245038479, double.PositiveInfinity, 0.0081004455245038479, double.NaN), 1, false);
            TestUtils.AreEqual(rcp(double4(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity)), double4(0.0, 0.0, 0.0, 0.0), 0, false);
        }

        [TestCompiler]
        public void floor_float()
        {
            TestUtils.AreEqual(floor(float.NegativeInfinity), float.NegativeInfinity);
            TestUtils.AreEqual(floor(-100.51f), -101f);
            TestUtils.AreEqual(floor(-100.5f), -101f);
            TestUtils.AreEqual(floor(-100.49f), -101f);
            TestUtils.AreEqual(floor(0f), 0f);
            TestUtils.AreEqual(floor(100.49f), 100f);
            TestUtils.AreEqual(floor(100.5f), 100f);
            TestUtils.AreEqual(floor(100.51f), 100f);
            TestUtils.AreEqual(floor(float.PositiveInfinity), float.PositiveInfinity);
            TestUtils.AreEqual(floor(float.NaN), float.NaN);
        }

        [TestCompiler]
        public void floor_float2()
        {
            TestUtils.AreEqual(floor(float2(float.NegativeInfinity, -100.51f)), float2(float.NegativeInfinity, -101f));
            TestUtils.AreEqual(floor(float2(-100.5f, -100.49f)), float2(-101f, -101f));
            TestUtils.AreEqual(floor(float2(0f, 100.49f)), float2(0f, 100f));
            TestUtils.AreEqual(floor(float2(100.5f, 100.51f)), float2(100f, 100f));
            TestUtils.AreEqual(floor(float2(float.PositiveInfinity, float.NaN)), float2(float.PositiveInfinity, float.NaN));
        }

        [TestCompiler]
        public void floor_float3()
        {
            TestUtils.AreEqual(floor(float3(float.NegativeInfinity, -100.51f, -100.5f)), float3(float.NegativeInfinity, -101f, -101f));
            TestUtils.AreEqual(floor(float3(-100.49f, 0f, 100.49f)), float3(-101f, 0f, 100f));
            TestUtils.AreEqual(floor(float3(100.5f, 100.51f, float.PositiveInfinity)), float3(100f, 100f, float.PositiveInfinity));
            TestUtils.AreEqual(floor(float3(float.NaN, float.NaN, float.NaN)), float3(float.NaN, float.NaN, float.NaN));
        }

        [TestCompiler]
        public void floor_float4()
        {
            TestUtils.AreEqual(floor(float4(float.NegativeInfinity, -100.51f, -100.5f, -100.49f)), float4(float.NegativeInfinity, -101f, -101f, -101f));
            TestUtils.AreEqual(floor(float4(0f, 100.49f, 100.5f, 100.51f)), float4(0f, 100f, 100f, 100f));
            TestUtils.AreEqual(floor(float4(float.PositiveInfinity, float.NaN, float.NaN, float.NaN)), float4(float.PositiveInfinity, float.NaN, float.NaN, float.NaN));
        }

        [TestCompiler]
        public void floor_double()
        {
            TestUtils.AreEqual(floor(double.NegativeInfinity), double.NegativeInfinity);
            TestUtils.AreEqual(floor(-100.51), -101.0);
            TestUtils.AreEqual(floor(-100.5), -101.0);
            TestUtils.AreEqual(floor(-100.49), -101.0);
            TestUtils.AreEqual(floor(0.0), 0.0);
            TestUtils.AreEqual(floor(100.49), 100.0);
            TestUtils.AreEqual(floor(100.5), 100.0);
            TestUtils.AreEqual(floor(100.51), 100.0);
            TestUtils.AreEqual(floor(double.PositiveInfinity), double.PositiveInfinity);
            TestUtils.AreEqual(floor(double.NaN), double.NaN);
        }

        [TestCompiler]
        public void floor_double2()
        {
            TestUtils.AreEqual(floor(double2(double.NegativeInfinity, -100.51)), double2(double.NegativeInfinity, -101.0));
            TestUtils.AreEqual(floor(double2(-100.5, -100.49)), double2(-101.0, -101.0));
            TestUtils.AreEqual(floor(double2(0.0, 100.49)), double2(0.0, 100.0));
            TestUtils.AreEqual(floor(double2(100.5, 100.51)), double2(100.0, 100.0));
            TestUtils.AreEqual(floor(double2(double.PositiveInfinity, double.NaN)), double2(double.PositiveInfinity, double.NaN));
        }

        [TestCompiler]
        public void floor_double3()
        {
            TestUtils.AreEqual(floor(double3(double.NegativeInfinity, -100.51, -100.5)), double3(double.NegativeInfinity, -101.0, -101.0));
            TestUtils.AreEqual(floor(double3(-100.49, 0.0, 100.49)), double3(-101.0, 0.0, 100.0));
            TestUtils.AreEqual(floor(double3(100.5, 100.51, double.PositiveInfinity)), double3(100.0, 100.0, double.PositiveInfinity));
            TestUtils.AreEqual(floor(double3(double.NaN, double.NaN, double.NaN)), double3(double.NaN, double.NaN, double.NaN));
        }

        [TestCompiler]
        public void floor_double4()
        {
            TestUtils.AreEqual(floor(double4(double.NegativeInfinity, -100.51, -100.5, -100.49)), double4(double.NegativeInfinity, -101.0, -101.0, -101.0));
            TestUtils.AreEqual(floor(double4(0.0, 100.49, 100.5, 100.51)), double4(0.0, 100.0, 100.0, 100.0));
            TestUtils.AreEqual(floor(double4(double.PositiveInfinity, double.NaN, double.NaN, double.NaN)), double4(double.PositiveInfinity, double.NaN, double.NaN, double.NaN));
        }

        [TestCompiler]
        public void ceil_float()
        {
            TestUtils.AreEqual(ceil(float.NegativeInfinity), float.NegativeInfinity);
            TestUtils.AreEqual(ceil(-100.51f), -100f);
            TestUtils.AreEqual(ceil(-100.5f), -100f);
            TestUtils.AreEqual(ceil(-100.49f), -100f);
            TestUtils.AreEqual(ceil(0f), 0f);
            TestUtils.AreEqual(ceil(100.49f), 101f);
            TestUtils.AreEqual(ceil(100.5f), 101f);
            TestUtils.AreEqual(ceil(100.51f), 101f);
            TestUtils.AreEqual(ceil(float.PositiveInfinity), float.PositiveInfinity);
            TestUtils.AreEqual(ceil(float.NaN), float.NaN);
        }

        [TestCompiler]
        public void ceil_float2()
        {
            TestUtils.AreEqual(ceil(float2(float.NegativeInfinity, -100.51f)), float2(float.NegativeInfinity, -100f));
            TestUtils.AreEqual(ceil(float2(-100.5f, -100.49f)), float2(-100f, -100f));
            TestUtils.AreEqual(ceil(float2(0f, 100.49f)), float2(0f, 101f));
            TestUtils.AreEqual(ceil(float2(100.5f, 100.51f)), float2(101f, 101f));
            TestUtils.AreEqual(ceil(float2(float.PositiveInfinity, float.NaN)), float2(float.PositiveInfinity, float.NaN));
        }

        [TestCompiler]
        public void ceil_float3()
        {
            TestUtils.AreEqual(ceil(float3(float.NegativeInfinity, -100.51f, -100.5f)), float3(float.NegativeInfinity, -100f, -100f));
            TestUtils.AreEqual(ceil(float3(-100.49f, 0f, 100.49f)), float3(-100f, 0f, 101f));
            TestUtils.AreEqual(ceil(float3(100.5f, 100.51f, float.PositiveInfinity)), float3(101f, 101f, float.PositiveInfinity));
            TestUtils.AreEqual(ceil(float3(float.NaN, float.NaN, float.NaN)), float3(float.NaN, float.NaN, float.NaN));
        }

        [TestCompiler]
        public void ceil_float4()
        {
            TestUtils.AreEqual(ceil(float4(float.NegativeInfinity, -100.51f, -100.5f, -100.49f)), float4(float.NegativeInfinity, -100f, -100f, -100f));
            TestUtils.AreEqual(ceil(float4(0f, 100.49f, 100.5f, 100.51f)), float4(0f, 101f, 101f, 101f));
            TestUtils.AreEqual(ceil(float4(float.PositiveInfinity, float.NaN, float.NaN, float.NaN)), float4(float.PositiveInfinity, float.NaN, float.NaN, float.NaN));
        }

        [TestCompiler]
        public void ceil_double()
        {
            TestUtils.AreEqual(ceil(double.NegativeInfinity), double.NegativeInfinity);
            TestUtils.AreEqual(ceil(-100.51), -100.0);
            TestUtils.AreEqual(ceil(-100.5), -100.0);
            TestUtils.AreEqual(ceil(-100.49), -100.0);
            TestUtils.AreEqual(ceil(0.0), 0.0);
            TestUtils.AreEqual(ceil(100.49), 101.0);
            TestUtils.AreEqual(ceil(100.5), 101.0);
            TestUtils.AreEqual(ceil(100.51), 101.0);
            TestUtils.AreEqual(ceil(double.PositiveInfinity), double.PositiveInfinity);
            TestUtils.AreEqual(ceil(double.NaN), double.NaN);
        }

        [TestCompiler]
        public void ceil_double2()
        {
            TestUtils.AreEqual(ceil(double2(double.NegativeInfinity, -100.51)), double2(double.NegativeInfinity, -100.0));
            TestUtils.AreEqual(ceil(double2(-100.5, -100.49)), double2(-100.0, -100.0));
            TestUtils.AreEqual(ceil(double2(0.0, 100.49)), double2(0.0, 101.0));
            TestUtils.AreEqual(ceil(double2(100.5, 100.51)), double2(101.0, 101.0));
            TestUtils.AreEqual(ceil(double2(double.PositiveInfinity, double.NaN)), double2(double.PositiveInfinity, double.NaN));
        }

        [TestCompiler]
        public void ceil_double3()
        {
            TestUtils.AreEqual(ceil(double3(double.NegativeInfinity, -100.51, -100.5)), double3(double.NegativeInfinity, -100.0, -100.0));
            TestUtils.AreEqual(ceil(double3(-100.49, 0.0, 100.49)), double3(-100.0, 0.0, 101.0));
            TestUtils.AreEqual(ceil(double3(100.5, 100.51, double.PositiveInfinity)), double3(101.0, 101.0, double.PositiveInfinity));
            TestUtils.AreEqual(ceil(double3(double.NaN, double.NaN, double.NaN)), double3(double.NaN, double.NaN, double.NaN));
        }

        [TestCompiler]
        public void ceil_double4()
        {
            TestUtils.AreEqual(ceil(double4(double.NegativeInfinity, -100.51, -100.5, -100.49)), double4(double.NegativeInfinity, -100.0, -100.0, -100.0));
            TestUtils.AreEqual(ceil(double4(0.0, 100.49, 100.5, 100.51)), double4(0.0, 101.0, 101.0, 101.0));
            TestUtils.AreEqual(ceil(double4(double.PositiveInfinity, double.NaN, double.NaN, double.NaN)), double4(double.PositiveInfinity, double.NaN, double.NaN, double.NaN));
        }

        [TestCompiler]
        public void round_float()
        {
            TestUtils.AreEqual(round(float.NegativeInfinity), float.NegativeInfinity);
            TestUtils.AreEqual(round(-100.51f), -101f);
            TestUtils.AreEqual(round(-100.5f), -100f);
            TestUtils.AreEqual(round(-100.49f), -100f);
            TestUtils.AreEqual(round(0f), 0f);
            TestUtils.AreEqual(round(100.49f), 100f);
            TestUtils.AreEqual(round(100.5f), 100f);
            TestUtils.AreEqual(round(100.51f), 101f);
            TestUtils.AreEqual(round(101.5f), 102f);
            TestUtils.AreEqual(round(float.PositiveInfinity), float.PositiveInfinity);
            TestUtils.AreEqual(round(float.NaN), float.NaN);
        }

        [TestCompiler]
        public void round_float2()
        {
            TestUtils.AreEqual(round(float2(float.NegativeInfinity, -100.51f)), float2(float.NegativeInfinity, -101f));
            TestUtils.AreEqual(round(float2(-100.5f, -100.49f)), float2(-100f, -100f));
            TestUtils.AreEqual(round(float2(0f, 100.49f)), float2(0f, 100f));
            TestUtils.AreEqual(round(float2(100.5f, 100.51f)), float2(100f, 101f));
            TestUtils.AreEqual(round(float2(101.5f, float.PositiveInfinity)), float2(102f, float.PositiveInfinity));
            TestUtils.AreEqual(round(float2(float.NaN, float.NaN)), float2(float.NaN, float.NaN));
        }

        [TestCompiler]
        public void round_float3()
        {
            TestUtils.AreEqual(round(float3(float.NegativeInfinity, -100.51f, -100.5f)), float3(float.NegativeInfinity, -101f, -100f));
            TestUtils.AreEqual(round(float3(-100.49f, 0f, 100.49f)), float3(-100f, 0f, 100f));
            TestUtils.AreEqual(round(float3(100.5f, 100.51f, 101.5f)), float3(100f, 101f, 102f));
            TestUtils.AreEqual(round(float3(float.PositiveInfinity, float.NaN, float.NaN)), float3(float.PositiveInfinity, float.NaN, float.NaN));
        }

        [TestCompiler]
        public void round_float4()
        {
            TestUtils.AreEqual(round(float4(float.NegativeInfinity, -100.51f, -100.5f, -100.49f)), float4(float.NegativeInfinity, -101f, -100f, -100f));
            TestUtils.AreEqual(round(float4(0f, 100.49f, 100.5f, 100.51f)), float4(0f, 100f, 100f, 101f));
            TestUtils.AreEqual(round(float4(101.5f, float.PositiveInfinity, float.NaN, float.NaN)), float4(102f, float.PositiveInfinity, float.NaN, float.NaN));
        }

        [TestCompiler]
        public void round_double()
        {
            TestUtils.AreEqual(round(double.NegativeInfinity), double.NegativeInfinity);
            TestUtils.AreEqual(round(-100.51), -101.0);
            TestUtils.AreEqual(round(-100.5), -100.0);
            TestUtils.AreEqual(round(-100.49), -100.0);
            TestUtils.AreEqual(round(0.0), 0.0);
            TestUtils.AreEqual(round(100.49), 100.0);
            TestUtils.AreEqual(round(100.5), 100.0);
            TestUtils.AreEqual(round(100.51), 101.0);
            TestUtils.AreEqual(round(101.5), 102.0);
            TestUtils.AreEqual(round(double.PositiveInfinity), double.PositiveInfinity);
            TestUtils.AreEqual(round(double.NaN), double.NaN);
        }

        [TestCompiler]
        public void round_double2()
        {
            TestUtils.AreEqual(round(double2(double.NegativeInfinity, -100.51)), double2(double.NegativeInfinity, -101.0));
            TestUtils.AreEqual(round(double2(-100.5, -100.49)), double2(-100.0, -100.0));
            TestUtils.AreEqual(round(double2(0.0, 100.49)), double2(0.0, 100.0));
            TestUtils.AreEqual(round(double2(100.5, 100.51)), double2(100.0, 101.0));
            TestUtils.AreEqual(round(double2(101.5, double.PositiveInfinity)), double2(102.0, double.PositiveInfinity));
            TestUtils.AreEqual(round(double2(double.NaN, double.NaN)), double2(double.NaN, double.NaN));
        }

        [TestCompiler]
        public void round_double3()
        {
            TestUtils.AreEqual(round(double3(double.NegativeInfinity, -100.51, -100.5)), double3(double.NegativeInfinity, -101.0, -100.0));
            TestUtils.AreEqual(round(double3(-100.49, 0.0, 100.49)), double3(-100.0, 0.0, 100.0));
            TestUtils.AreEqual(round(double3(100.5, 100.51, 101.5)), double3(100.0, 101.0, 102.0));
            TestUtils.AreEqual(round(double3(double.PositiveInfinity, double.NaN, double.NaN)), double3(double.PositiveInfinity, double.NaN, double.NaN));
        }

        [TestCompiler]
        public void round_double4()
        {
            TestUtils.AreEqual(round(double4(double.NegativeInfinity, -100.51, -100.5, -100.49)), double4(double.NegativeInfinity, -101.0, -100.0, -100.0));
            TestUtils.AreEqual(round(double4(0.0, 100.49, 100.5, 100.51)), double4(0.0, 100.0, 100.0, 101.0));
            TestUtils.AreEqual(round(double4(101.5, double.PositiveInfinity, double.NaN, double.NaN)), double4(102.0, double.PositiveInfinity, double.NaN, double.NaN));
        }

        [TestCompiler]
        public void trunc_float()
        {
            TestUtils.AreEqual(trunc(float.NegativeInfinity), float.NegativeInfinity);
            TestUtils.AreEqual(trunc(-100.51f), -100f);
            TestUtils.AreEqual(trunc(-100.5f), -100f);
            TestUtils.AreEqual(trunc(-100.49f), -100f);
            TestUtils.AreEqual(trunc(0f), 0f);
            TestUtils.AreEqual(trunc(100.49f), 100f);
            TestUtils.AreEqual(trunc(100.5f), 100f);
            TestUtils.AreEqual(trunc(100.51f), 100f);
            TestUtils.AreEqual(trunc(101.5f), 101f);
            TestUtils.AreEqual(trunc(float.PositiveInfinity), float.PositiveInfinity);
            TestUtils.AreEqual(trunc(float.NaN), float.NaN);
        }

        [TestCompiler]
        public void trunc_float2()
        {
            TestUtils.AreEqual(trunc(float2(float.NegativeInfinity, -100.51f)), float2(float.NegativeInfinity, -100f));
            TestUtils.AreEqual(trunc(float2(-100.5f, -100.49f)), float2(-100f, -100f));
            TestUtils.AreEqual(trunc(float2(0f, 100.49f)), float2(0f, 100f));
            TestUtils.AreEqual(trunc(float2(100.5f, 100.51f)), float2(100f, 100f));
            TestUtils.AreEqual(trunc(float2(101.5f, float.PositiveInfinity)), float2(101f, float.PositiveInfinity));
            TestUtils.AreEqual(trunc(float2(float.NaN, float.NaN)), float2(float.NaN, float.NaN));
        }

        [TestCompiler]
        public void trunc_float3()
        {
            TestUtils.AreEqual(trunc(float3(float.NegativeInfinity, -100.51f, -100.5f)), float3(float.NegativeInfinity, -100f, -100f));
            TestUtils.AreEqual(trunc(float3(-100.49f, 0f, 100.49f)), float3(-100f, 0f, 100f));
            TestUtils.AreEqual(trunc(float3(100.5f, 100.51f, 101.5f)), float3(100f, 100f, 101f));
            TestUtils.AreEqual(trunc(float3(float.PositiveInfinity, float.NaN, float.NaN)), float3(float.PositiveInfinity, float.NaN, float.NaN));
        }

        [TestCompiler]
        public void trunc_float4()
        {
            TestUtils.AreEqual(trunc(float4(float.NegativeInfinity, -100.51f, -100.5f, -100.49f)), float4(float.NegativeInfinity, -100f, -100f, -100f));
            TestUtils.AreEqual(trunc(float4(0f, 100.49f, 100.5f, 100.51f)), float4(0f, 100f, 100f, 100f));
            TestUtils.AreEqual(trunc(float4(101.5f, float.PositiveInfinity, float.NaN, float.NaN)), float4(101f, float.PositiveInfinity, float.NaN, float.NaN));
        }

        [TestCompiler]
        public void trunc_double()
        {
            TestUtils.AreEqual(trunc(double.NegativeInfinity), double.NegativeInfinity);
            TestUtils.AreEqual(trunc(-100.51), -100.0);
            TestUtils.AreEqual(trunc(-100.5), -100.0);
            TestUtils.AreEqual(trunc(-100.49), -100.0);
            TestUtils.AreEqual(trunc(0.0), 0.0);
            TestUtils.AreEqual(trunc(100.49), 100.0);
            TestUtils.AreEqual(trunc(100.5), 100.0);
            TestUtils.AreEqual(trunc(100.51), 100.0);
            TestUtils.AreEqual(trunc(101.5), 101.0);
            TestUtils.AreEqual(trunc(double.PositiveInfinity), double.PositiveInfinity);
            TestUtils.AreEqual(trunc(double.NaN), double.NaN);
        }

        [TestCompiler]
        public void trunc_double2()
        {
            TestUtils.AreEqual(trunc(double2(double.NegativeInfinity, -100.51)), double2(double.NegativeInfinity, -100.0));
            TestUtils.AreEqual(trunc(double2(-100.5, -100.49)), double2(-100.0, -100.0));
            TestUtils.AreEqual(trunc(double2(0.0, 100.49)), double2(0.0, 100.0));
            TestUtils.AreEqual(trunc(double2(100.5, 100.51)), double2(100.0, 100.0));
            TestUtils.AreEqual(trunc(double2(101.5, double.PositiveInfinity)), double2(101.0, double.PositiveInfinity));
            TestUtils.AreEqual(trunc(double2(double.NaN, double.NaN)), double2(double.NaN, double.NaN));
        }

        [TestCompiler]
        public void trunc_double3()
        {
            TestUtils.AreEqual(trunc(double3(double.NegativeInfinity, -100.51, -100.5)), double3(double.NegativeInfinity, -100.0, -100.0));
            TestUtils.AreEqual(trunc(double3(-100.49, 0.0, 100.49)), double3(-100.0, 0.0, 100.0));
            TestUtils.AreEqual(trunc(double3(100.5, 100.51, 101.5)), double3(100.0, 100.0, 101.0));
            TestUtils.AreEqual(trunc(double3(double.PositiveInfinity, double.NaN, double.NaN)), double3(double.PositiveInfinity, double.NaN, double.NaN));
        }

        [TestCompiler]
        public void trunc_double4()
        {
            TestUtils.AreEqual(trunc(double4(double.NegativeInfinity, -100.51, -100.5, -100.49)), double4(double.NegativeInfinity, -100.0, -100.0, -100.0));
            TestUtils.AreEqual(trunc(double4(0.0, 100.49, 100.5, 100.51)), double4(0.0, 100.0, 100.0, 100.0));
            TestUtils.AreEqual(trunc(double4(101.5, double.PositiveInfinity, double.NaN, double.NaN)), double4(101.0, double.PositiveInfinity, double.NaN, double.NaN));
        }

        [TestCompiler]
        public void frac_float()
        {
            TestUtils.AreEqual(frac(float.NegativeInfinity), float.NaN, 64, false);
            TestUtils.AreEqual(frac(-1E+20f), 0f, 64, false);
            TestUtils.AreEqual(frac(-100.3f), 0.7f, 64, false);
            TestUtils.AreEqual(frac(0f), 0f, 64, false);
            TestUtils.AreEqual(frac(100.8f), 0.8f, 64, false);
            TestUtils.AreEqual(frac(float.PositiveInfinity), float.NaN, 64, false);
            TestUtils.AreEqual(frac(float.NaN), float.NaN, 64, false);
        }

        [TestCompiler]
        public void frac_float2()
        {
            TestUtils.AreEqual(frac(float2(float.NegativeInfinity, -1E+20f)), float2(float.NaN, 0f), 64, false);
            TestUtils.AreEqual(frac(float2(-100.3f, 0f)), float2(0.7f, 0f), 64, false);
            TestUtils.AreEqual(frac(float2(100.8f, float.PositiveInfinity)), float2(0.8f, float.NaN), 64, false);
            TestUtils.AreEqual(frac(float2(float.NaN, float.NaN)), float2(float.NaN, float.NaN), 64, false);
        }

        [TestCompiler]
        public void frac_float3()
        {
            TestUtils.AreEqual(frac(float3(float.NegativeInfinity, -1E+20f, -100.3f)), float3(float.NaN, 0f, 0.7f), 64, false);
            TestUtils.AreEqual(frac(float3(0f, 100.8f, float.PositiveInfinity)), float3(0f, 0.8f, float.NaN), 64, false);
            TestUtils.AreEqual(frac(float3(float.NaN, float.NaN, float.NaN)), float3(float.NaN, float.NaN, float.NaN), 64, false);
        }

        [TestCompiler]
        public void frac_float4()
        {
            TestUtils.AreEqual(frac(float4(float.NegativeInfinity, -1E+20f, -100.3f, 0f)), float4(float.NaN, 0f, 0.7f, 0f), 64, false);
            TestUtils.AreEqual(frac(float4(100.8f, float.PositiveInfinity, float.NaN, float.NaN)), float4(0.8f, float.NaN, float.NaN, float.NaN), 64, false);
        }

        [TestCompiler]
        public void frac_double()
        {
            TestUtils.AreEqual(frac(double.NegativeInfinity), double.NaN, 64, false);
            TestUtils.AreEqual(frac(-1E+20), 0.0, 64, false);
            TestUtils.AreEqual(frac(-100.3), 0.7, 64, false);
            TestUtils.AreEqual(frac(0.0), 0.0, 64, false);
            TestUtils.AreEqual(frac(100.8), 0.8, 64, false);
            TestUtils.AreEqual(frac(double.PositiveInfinity), double.NaN, 64, false);
            TestUtils.AreEqual(frac(double.NaN), double.NaN, 64, false);
        }

        [TestCompiler]
        public void frac_double2()
        {
            TestUtils.AreEqual(frac(double2(double.NegativeInfinity, -1E+20)), double2(double.NaN, 0.0), 64, false);
            TestUtils.AreEqual(frac(double2(-100.3, 0.0)), double2(0.7, 0.0), 64, false);
            TestUtils.AreEqual(frac(double2(100.8, double.PositiveInfinity)), double2(0.8, double.NaN), 64, false);
            TestUtils.AreEqual(frac(double2(double.NaN, double.NaN)), double2(double.NaN, double.NaN), 64, false);
        }

        [TestCompiler]
        public void frac_double3()
        {
            TestUtils.AreEqual(frac(double3(double.NegativeInfinity, -1E+20, -100.3)), double3(double.NaN, 0.0, 0.7), 64, false);
            TestUtils.AreEqual(frac(double3(0.0, 100.8, double.PositiveInfinity)), double3(0.0, 0.8, double.NaN), 64, false);
            TestUtils.AreEqual(frac(double3(double.NaN, double.NaN, double.NaN)), double3(double.NaN, double.NaN, double.NaN), 64, false);
        }

        [TestCompiler]
        public void frac_double4()
        {
            TestUtils.AreEqual(frac(double4(double.NegativeInfinity, -1E+20, -100.3, 0.0)), double4(double.NaN, 0.0, 0.7, 0.0), 64, false);
            TestUtils.AreEqual(frac(double4(100.8, double.PositiveInfinity, double.NaN, double.NaN)), double4(0.8, double.NaN, double.NaN, double.NaN), 64, false);
        }

        [TestCompiler]
        public void lerp_float()
        {
            TestUtils.AreEqual(lerp(-123.45f, 439.43f, -1.5f), -967.77f, 1, false);
            TestUtils.AreEqual(lerp(-123.45f, 439.43f, 0.5f), 157.99f, 1, false);
            TestUtils.AreEqual(lerp(-123.45f, 439.43f, 5.5f), 2972.39f, 1, false);
            TestUtils.AreEqual(lerp(-123.45f, 439.43f, float.NaN), float.NaN, 1, false);
        }

        [TestCompiler]
        public void lerp_float2()
        {
            TestUtils.AreEqual(lerp(float2(-123.45f, -123.45f), float2(439.43f, 439.43f), float2(-1.5f, 0.5f)), float2(-967.77f, 157.99f), 1, false);
            TestUtils.AreEqual(lerp(float2(-123.45f, -123.45f), float2(439.43f, 439.43f), float2(5.5f, float.NaN)), float2(2972.39f, float.NaN), 1, false);
        }

        [TestCompiler]
        public void lerp_float3()
        {
            TestUtils.AreEqual(lerp(float3(-123.45f, -123.45f, -123.45f), float3(439.43f, 439.43f, 439.43f), float3(-1.5f, 0.5f, 5.5f)), float3(-967.77f, 157.99f, 2972.39f), 1, false);
            TestUtils.AreEqual(lerp(float3(-123.45f, -123.45f, -123.45f), float3(439.43f, 439.43f, 439.43f), float3(float.NaN, float.NaN, float.NaN)), float3(float.NaN, float.NaN, float.NaN), 1, false);
        }

        [TestCompiler]
        public void lerp_float4()
        {
            TestUtils.AreEqual(lerp(float4(-123.45f, -123.45f, -123.45f, -123.45f), float4(439.43f, 439.43f, 439.43f, 439.43f), float4(-1.5f, 0.5f, 5.5f, float.NaN)), float4(-967.77f, 157.99f, 2972.39f, float.NaN), 1, false);
        }

        [TestCompiler]
        public void lerp_double()
        {
            TestUtils.AreEqual(lerp(-123.45, 439.43, -1.5), -967.77, 1, false);
            TestUtils.AreEqual(lerp(-123.45, 439.43, 0.5), 157.99, 1, false);
            TestUtils.AreEqual(lerp(-123.45, 439.43, 5.5), 2972.39, 1, false);
            TestUtils.AreEqual(lerp(-123.45, 439.43, double.NaN), double.NaN, 1, false);
        }

        [TestCompiler]
        public void lerp_double2()
        {
            TestUtils.AreEqual(lerp(double2(-123.45, -123.45), double2(439.43, 439.43), double2(-1.5, 0.5)), double2(-967.77, 157.99), 1, false);
            TestUtils.AreEqual(lerp(double2(-123.45, -123.45), double2(439.43, 439.43), double2(5.5, double.NaN)), double2(2972.39, double.NaN), 1, false);
        }

        [TestCompiler]
        public void lerp_double3()
        {
            TestUtils.AreEqual(lerp(double3(-123.45, -123.45, -123.45), double3(439.43, 439.43, 439.43), double3(-1.5, 0.5, 5.5)), double3(-967.77, 157.99, 2972.39), 1, false);
            TestUtils.AreEqual(lerp(double3(-123.45, -123.45, -123.45), double3(439.43, 439.43, 439.43), double3(double.NaN, double.NaN, double.NaN)), double3(double.NaN, double.NaN, double.NaN), 1, false);
        }

        [TestCompiler]
        public void lerp_double4()
        {
            TestUtils.AreEqual(lerp(double4(-123.45, -123.45, -123.45, -123.45), double4(439.43, 439.43, 439.43, 439.43), double4(-1.5, 0.5, 5.5, double.NaN)), double4(-967.77, 157.99, 2972.39, double.NaN), 1, false);
        }

        [TestCompiler]
        public void unlerp_float()
        {
            TestUtils.AreEqual(unlerp(-123.45f, 439.43f, -254.3f), -0.232465178f, 4, false);
            TestUtils.AreEqual(unlerp(-123.45f, 439.43f, 0f), 0.219318509f, 4, false);
            TestUtils.AreEqual(unlerp(-123.45f, 439.43f, 632.1f), 1.34229326f, 4, false);
            TestUtils.AreEqual(unlerp(123.4f, 123.4f, -430f), float.NegativeInfinity, 4, false);
            TestUtils.AreEqual(unlerp(123.4f, 123.4f, 430f), float.PositiveInfinity, 4, false);
            TestUtils.AreEqual(unlerp(439.43f, -123.45f, -254.3f), 1.23246515f, 4, false);
            TestUtils.AreEqual(unlerp(439.43f, -123.45f, 0f), 0.7806815f, 4, false);
            TestUtils.AreEqual(unlerp(439.43f, -123.45f, 632.1f), -0.3422932f, 4, false);
        }

        [TestCompiler]
        public void unlerp_float2()
        {
            TestUtils.AreEqual(unlerp(float2(-123.45f, -123.45f), float2(439.43f, 439.43f), float2(-254.3f, 0f)), float2(-0.232465178f, 0.219318509f), 4, false);
            TestUtils.AreEqual(unlerp(float2(-123.45f, 123.4f), float2(439.43f, 123.4f), float2(632.1f, -430f)), float2(1.34229326f, float.NegativeInfinity), 4, false);
            TestUtils.AreEqual(unlerp(float2(123.4f, 439.43f), float2(123.4f, -123.45f), float2(430f, -254.3f)), float2(float.PositiveInfinity, 1.23246515f), 4, false);
            TestUtils.AreEqual(unlerp(float2(439.43f, 439.43f), float2(-123.45f, -123.45f), float2(0f, 632.1f)), float2(0.7806815f, -0.3422932f), 4, false);
        }

        [TestCompiler]
        public void unlerp_float3()
        {
            TestUtils.AreEqual(unlerp(float3(-123.45f, -123.45f, -123.45f), float3(439.43f, 439.43f, 439.43f), float3(-254.3f, 0f, 632.1f)), float3(-0.232465178f, 0.219318509f, 1.34229326f), 4, false);
            TestUtils.AreEqual(unlerp(float3(123.4f, 123.4f, 439.43f), float3(123.4f, 123.4f, -123.45f), float3(-430f, 430f, -254.3f)), float3(float.NegativeInfinity, float.PositiveInfinity, 1.23246515f), 4, false);
            TestUtils.AreEqual(unlerp(float3(439.43f, 439.43f, 439.43f), float3(-123.45f, -123.45f, -123.45f), float3(0f, 632.1f, 632.1f)), float3(0.7806815f, -0.3422932f, -0.3422932f), 4, false);
        }

        [TestCompiler]
        public void unlerp_float4()
        {
            TestUtils.AreEqual(unlerp(float4(-123.45f, -123.45f, -123.45f, 123.4f), float4(439.43f, 439.43f, 439.43f, 123.4f), float4(-254.3f, 0f, 632.1f, -430f)), float4(-0.232465178f, 0.219318509f, 1.34229326f, float.NegativeInfinity), 4, false);
            TestUtils.AreEqual(unlerp(float4(123.4f, 439.43f, 439.43f, 439.43f), float4(123.4f, -123.45f, -123.45f, -123.45f), float4(430f, -254.3f, 0f, 632.1f)), float4(float.PositiveInfinity, 1.23246515f, 0.7806815f, -0.3422932f), 4, false);
        }

        [TestCompiler]
        public void unlerp_double()
        {
            TestUtils.AreEqual(unlerp(-123.45, 439.43, -254.3), -0.23246517907902217, 4, false);
            TestUtils.AreEqual(unlerp(-123.45, 439.43, 0.0), 0.21931850483229107, 4, false);
            TestUtils.AreEqual(unlerp(-123.45, 439.43, 632.1), 1.3422932063672541, 4, false);
            TestUtils.AreEqual(unlerp(123.4, 123.4, -430.0), double.NegativeInfinity, 4, false);
            TestUtils.AreEqual(unlerp(123.4, 123.4, 430.0), double.PositiveInfinity, 4, false);
            TestUtils.AreEqual(unlerp(439.43, -123.45, -254.3), 1.2324651790790222, 4, false);
            TestUtils.AreEqual(unlerp(439.43, -123.45, 0.0), 0.78068149516770891, 4, false);
            TestUtils.AreEqual(unlerp(439.43, -123.45, 632.1), -0.34229320636725413, 4, false);
        }

        [TestCompiler]
        public void unlerp_double2()
        {
            TestUtils.AreEqual(unlerp(double2(-123.45, -123.45), double2(439.43, 439.43), double2(-254.3, 0.0)), double2(-0.23246517907902217, 0.21931850483229107), 4, false);
            TestUtils.AreEqual(unlerp(double2(-123.45, 123.4), double2(439.43, 123.4), double2(632.1, -430.0)), double2(1.3422932063672541, double.NegativeInfinity), 4, false);
            TestUtils.AreEqual(unlerp(double2(123.4, 439.43), double2(123.4, -123.45), double2(430.0, -254.3)), double2(double.PositiveInfinity, 1.2324651790790222), 4, false);
            TestUtils.AreEqual(unlerp(double2(439.43, 439.43), double2(-123.45, -123.45), double2(0.0, 632.1)), double2(0.78068149516770891, -0.34229320636725413), 4, false);
        }

        [TestCompiler]
        public void unlerp_double3()
        {
            TestUtils.AreEqual(unlerp(double3(-123.45, -123.45, -123.45), double3(439.43, 439.43, 439.43), double3(-254.3, 0.0, 632.1)), double3(-0.23246517907902217, 0.21931850483229107, 1.3422932063672541), 4, false);
            TestUtils.AreEqual(unlerp(double3(123.4, 123.4, 439.43), double3(123.4, 123.4, -123.45), double3(-430.0, 430.0, -254.3)), double3(double.NegativeInfinity, double.PositiveInfinity, 1.2324651790790222), 4, false);
            TestUtils.AreEqual(unlerp(double3(439.43, 439.43, 439.43), double3(-123.45, -123.45, -123.45), double3(0.0, 632.1, 632.1)), double3(0.78068149516770891, -0.34229320636725413, -0.34229320636725413), 4, false);
        }

        [TestCompiler]
        public void unlerp_double4()
        {
            TestUtils.AreEqual(unlerp(double4(-123.45, -123.45, -123.45, 123.4), double4(439.43, 439.43, 439.43, 123.4), double4(-254.3, 0.0, 632.1, -430.0)), double4(-0.23246517907902217, 0.21931850483229107, 1.3422932063672541, double.NegativeInfinity), 4, false);
            TestUtils.AreEqual(unlerp(double4(123.4, 439.43, 439.43, 439.43), double4(123.4, -123.45, -123.45, -123.45), double4(430.0, -254.3, 0.0, 632.1)), double4(double.PositiveInfinity, 1.2324651790790222, 0.78068149516770891, -0.34229320636725413), 4, false);
        }

        [TestCompiler]
        public void remap_float()
        {
            TestUtils.AreEqual(remap(-123.45f, 439.43f, 541.3f, 631.5f, -200f), 529.0331f, 4, false);
            TestUtils.AreEqual(remap(-123.45f, 439.43f, 541.3f, 631.5f, -100f), 545.0578f, 4, false);
            TestUtils.AreEqual(remap(-123.45f, 439.43f, 541.3f, 631.5f, 500f), 641.2062f, 4, false);
            TestUtils.AreEqual(remap(439.43f, -123.45f, 541.3f, 631.5f, -200f), 643.7669f, 4, false);
            TestUtils.AreEqual(remap(439.43f, -123.45f, 541.3f, 631.5f, -100f), 627.7422f, 4, false);
            TestUtils.AreEqual(remap(439.43f, -123.45f, 541.3f, 631.5f, 500f), 531.5938f, 4, false);
            TestUtils.AreEqual(remap(-123.45f, 439.43f, 631.5f, 541.3f, -200f), 643.7669f, 4, false);
            TestUtils.AreEqual(remap(-123.45f, 439.43f, 631.5f, 541.3f, -100f), 627.7422f, 4, false);
            TestUtils.AreEqual(remap(-123.45f, 439.43f, 631.5f, 541.3f, 500f), 531.5938f, 4, false);
            TestUtils.AreEqual(remap(-123.45f, -123.45f, 541.3f, 631.5f, -200f), float.NegativeInfinity, 4, false);
            TestUtils.AreEqual(remap(-123.45f, -123.45f, 541.3f, 631.5f, -100f), float.PositiveInfinity, 4, false);
        }

        [TestCompiler]
        public void remap_float2()
        {
            TestUtils.AreEqual(remap(float2(-123.45f, -123.45f), float2(439.43f, 439.43f), float2(541.3f, 541.3f), float2(631.5f, 631.5f), float2(-200f, -100f)), float2(529.0331f, 545.0578f), 4, false);
            TestUtils.AreEqual(remap(float2(-123.45f, 439.43f), float2(439.43f, -123.45f), float2(541.3f, 541.3f), float2(631.5f, 631.5f), float2(500f, -200f)), float2(641.2062f, 643.7669f), 4, false);
            TestUtils.AreEqual(remap(float2(439.43f, 439.43f), float2(-123.45f, -123.45f), float2(541.3f, 541.3f), float2(631.5f, 631.5f), float2(-100f, 500f)), float2(627.7422f, 531.5938f), 4, false);
            TestUtils.AreEqual(remap(float2(-123.45f, -123.45f), float2(439.43f, 439.43f), float2(631.5f, 631.5f), float2(541.3f, 541.3f), float2(-200f, -100f)), float2(643.7669f, 627.7422f), 4, false);
            TestUtils.AreEqual(remap(float2(-123.45f, -123.45f), float2(439.43f, -123.45f), float2(631.5f, 541.3f), float2(541.3f, 631.5f), float2(500f, -200f)), float2(531.5938f, float.NegativeInfinity), 4, false);
            TestUtils.AreEqual(remap(float2(-123.45f, -123.45f), float2(-123.45f, -123.45f), float2(541.3f, 541.3f), float2(631.5f, 631.5f), float2(-100f, -100f)), float2(float.PositiveInfinity, float.PositiveInfinity), 4, false);
        }

        [TestCompiler]
        public void remap_float3()
        {
            TestUtils.AreEqual(remap(float3(-123.45f, -123.45f, -123.45f), float3(439.43f, 439.43f, 439.43f), float3(541.3f, 541.3f, 541.3f), float3(631.5f, 631.5f, 631.5f), float3(-200f, -100f, 500f)), float3(529.0331f, 545.0578f, 641.2062f), 4, false);
            TestUtils.AreEqual(remap(float3(439.43f, 439.43f, 439.43f), float3(-123.45f, -123.45f, -123.45f), float3(541.3f, 541.3f, 541.3f), float3(631.5f, 631.5f, 631.5f), float3(-200f, -100f, 500f)), float3(643.7669f, 627.7422f, 531.5938f), 4, false);
            TestUtils.AreEqual(remap(float3(-123.45f, -123.45f, -123.45f), float3(439.43f, 439.43f, 439.43f), float3(631.5f, 631.5f, 631.5f), float3(541.3f, 541.3f, 541.3f), float3(-200f, -100f, 500f)), float3(643.7669f, 627.7422f, 531.5938f), 4, false);
            TestUtils.AreEqual(remap(float3(-123.45f, -123.45f, -123.45f), float3(-123.45f, -123.45f, -123.45f), float3(541.3f, 541.3f, 541.3f), float3(631.5f, 631.5f, 631.5f), float3(-200f, -100f, -100f)), float3(float.NegativeInfinity, float.PositiveInfinity, float.PositiveInfinity), 4, false);
        }

        [TestCompiler]
        public void remap_float4()
        {
            TestUtils.AreEqual(remap(float4(-123.45f, -123.45f, -123.45f, 439.43f), float4(439.43f, 439.43f, 439.43f, -123.45f), float4(541.3f, 541.3f, 541.3f, 541.3f), float4(631.5f, 631.5f, 631.5f, 631.5f), float4(-200f, -100f, 500f, -200f)), float4(529.0331f, 545.0578f, 641.2062f, 643.7669f), 4, false);
            TestUtils.AreEqual(remap(float4(439.43f, 439.43f, -123.45f, -123.45f), float4(-123.45f, -123.45f, 439.43f, 439.43f), float4(541.3f, 541.3f, 631.5f, 631.5f), float4(631.5f, 631.5f, 541.3f, 541.3f), float4(-100f, 500f, -200f, -100f)), float4(627.7422f, 531.5938f, 643.7669f, 627.7422f), 4, false);
            TestUtils.AreEqual(remap(float4(-123.45f, -123.45f, -123.45f, -123.45f), float4(439.43f, -123.45f, -123.45f, -123.45f), float4(631.5f, 541.3f, 541.3f, 541.3f), float4(541.3f, 631.5f, 631.5f, 631.5f), float4(500f, -200f, -100f, -100f)), float4(531.5938f, float.NegativeInfinity, float.PositiveInfinity, float.PositiveInfinity), 4, false);
        }

        [TestCompiler]
        public void remap_double()
        {
            TestUtils.AreEqual(remap(-123.45, 439.43, 541.3, 631.5, -200.0), 529.03306921546334, 4, false);
            TestUtils.AreEqual(remap(-123.45, 439.43, 541.3, 631.5, -100.0), 545.057799175668, 4, false);
            TestUtils.AreEqual(remap(-123.45, 439.43, 541.3, 631.5, 500.0), 641.206178936896, 4, false);
            TestUtils.AreEqual(remap(439.43, -123.45, 541.3, 631.5, -200.0), 643.76693078453673, 4, false);
            TestUtils.AreEqual(remap(439.43, -123.45, 541.3, 631.5, -100.0), 627.742200824332, 4, false);
            TestUtils.AreEqual(remap(439.43, -123.45, 541.3, 631.5, 500.0), 531.59382106310409, 4, false);
            TestUtils.AreEqual(remap(-123.45, 439.43, 631.5, 541.3, -200.0), 643.76693078453673, 4, false);
            TestUtils.AreEqual(remap(-123.45, 439.43, 631.5, 541.3, -100.0), 627.742200824332, 4, false);
            TestUtils.AreEqual(remap(-123.45, 439.43, 631.5, 541.3, 500.0), 531.59382106310409, 4, false);
            TestUtils.AreEqual(remap(-123.45, -123.45, 541.3, 631.5, -200.0), double.NegativeInfinity, 4, false);
            TestUtils.AreEqual(remap(-123.45, -123.45, 541.3, 631.5, -100.0), double.PositiveInfinity, 4, false);
        }

        [TestCompiler]
        public void remap_double2()
        {
            TestUtils.AreEqual(remap(double2(-123.45, -123.45), double2(439.43, 439.43), double2(541.3, 541.3), double2(631.5, 631.5), double2(-200.0, -100.0)), double2(529.03306921546334, 545.057799175668), 4, false);
            TestUtils.AreEqual(remap(double2(-123.45, 439.43), double2(439.43, -123.45), double2(541.3, 541.3), double2(631.5, 631.5), double2(500.0, -200.0)), double2(641.206178936896, 643.76693078453673), 4, false);
            TestUtils.AreEqual(remap(double2(439.43, 439.43), double2(-123.45, -123.45), double2(541.3, 541.3), double2(631.5, 631.5), double2(-100.0, 500.0)), double2(627.742200824332, 531.59382106310409), 4, false);
            TestUtils.AreEqual(remap(double2(-123.45, -123.45), double2(439.43, 439.43), double2(631.5, 631.5), double2(541.3, 541.3), double2(-200.0, -100.0)), double2(643.76693078453673, 627.742200824332), 4, false);
            TestUtils.AreEqual(remap(double2(-123.45, -123.45), double2(439.43, -123.45), double2(631.5, 541.3), double2(541.3, 631.5), double2(500.0, -200.0)), double2(531.59382106310409, double.NegativeInfinity), 4, false);
            TestUtils.AreEqual(remap(double2(-123.45, -123.45), double2(-123.45, -123.45), double2(541.3, 541.3), double2(631.5, 631.5), double2(-100.0, -100.0)), double2(double.PositiveInfinity, double.PositiveInfinity), 4, false);
        }

        [TestCompiler]
        public void remap_double3()
        {
            TestUtils.AreEqual(remap(double3(-123.45, -123.45, -123.45), double3(439.43, 439.43, 439.43), double3(541.3, 541.3, 541.3), double3(631.5, 631.5, 631.5), double3(-200.0, -100.0, 500.0)), double3(529.03306921546334, 545.057799175668, 641.206178936896), 4, false);
            TestUtils.AreEqual(remap(double3(439.43, 439.43, 439.43), double3(-123.45, -123.45, -123.45), double3(541.3, 541.3, 541.3), double3(631.5, 631.5, 631.5), double3(-200.0, -100.0, 500.0)), double3(643.76693078453673, 627.742200824332, 531.59382106310409), 4, false);
            TestUtils.AreEqual(remap(double3(-123.45, -123.45, -123.45), double3(439.43, 439.43, 439.43), double3(631.5, 631.5, 631.5), double3(541.3, 541.3, 541.3), double3(-200.0, -100.0, 500.0)), double3(643.76693078453673, 627.742200824332, 531.59382106310409), 4, false);
            TestUtils.AreEqual(remap(double3(-123.45, -123.45, -123.45), double3(-123.45, -123.45, -123.45), double3(541.3, 541.3, 541.3), double3(631.5, 631.5, 631.5), double3(-200.0, -100.0, -100.0)), double3(double.NegativeInfinity, double.PositiveInfinity, double.PositiveInfinity), 4, false);
        }

        [TestCompiler]
        public void remap_double4()
        {
            TestUtils.AreEqual(remap(double4(-123.45, -123.45, -123.45, 439.43), double4(439.43, 439.43, 439.43, -123.45), double4(541.3, 541.3, 541.3, 541.3), double4(631.5, 631.5, 631.5, 631.5), double4(-200.0, -100.0, 500.0, -200.0)), double4(529.03306921546334, 545.057799175668, 641.206178936896, 643.76693078453673), 4, false);
            TestUtils.AreEqual(remap(double4(439.43, 439.43, -123.45, -123.45), double4(-123.45, -123.45, 439.43, 439.43), double4(541.3, 541.3, 631.5, 631.5), double4(631.5, 631.5, 541.3, 541.3), double4(-100.0, 500.0, -200.0, -100.0)), double4(627.742200824332, 531.59382106310409, 643.76693078453673, 627.742200824332), 4, false);
            TestUtils.AreEqual(remap(double4(-123.45, -123.45, -123.45, -123.45), double4(439.43, -123.45, -123.45, -123.45), double4(631.5, 541.3, 541.3, 541.3), double4(541.3, 631.5, 631.5, 631.5), double4(500.0, -200.0, -100.0, -100.0)), double4(531.59382106310409, double.NegativeInfinity, double.PositiveInfinity, double.PositiveInfinity), 4, false);
        }

        [TestCompiler]
        public void clamp_float()
        {
            TestUtils.AreEqual(clamp(float.NegativeInfinity, -123.45f, 439.43f), -123.45f);
            TestUtils.AreEqual(clamp(-254.3f, -123.45f, 439.43f), -123.45f);
            TestUtils.AreEqual(clamp(246.3f, -123.45f, 439.43f), 246.3f);
            TestUtils.AreEqual(clamp(632.1f, -123.45f, 439.43f), 439.43f);
            TestUtils.AreEqual(clamp(-254.3f, 439.43f, -123.45f), 439.43f);
            TestUtils.AreEqual(clamp(246.3f, 439.43f, -123.45f), 439.43f);
            TestUtils.AreEqual(clamp(632.1f, 439.43f, -123.45f), 439.43f);
            TestUtils.AreEqual(clamp(float.PositiveInfinity, -123.45f, 439.43f), 439.43f);
            TestUtils.AreEqual(clamp(float.NaN, -123.45f, 439.43f), 439.43f);
        }

        [TestCompiler]
        public void clamp_float2()
        {
            TestUtils.AreEqual(clamp(float2(float.NegativeInfinity, -254.3f), float2(-123.45f, -123.45f), float2(439.43f, 439.43f)), float2(-123.45f, -123.45f));
            TestUtils.AreEqual(clamp(float2(246.3f, 632.1f), float2(-123.45f, -123.45f), float2(439.43f, 439.43f)), float2(246.3f, 439.43f));
            TestUtils.AreEqual(clamp(float2(-254.3f, 246.3f), float2(439.43f, 439.43f), float2(-123.45f, -123.45f)), float2(439.43f, 439.43f));
            TestUtils.AreEqual(clamp(float2(632.1f, float.PositiveInfinity), float2(439.43f, -123.45f), float2(-123.45f, 439.43f)), float2(439.43f, 439.43f));
            TestUtils.AreEqual(clamp(float2(float.NaN, float.NaN), float2(-123.45f, -123.45f), float2(439.43f, 439.43f)), float2(439.43f, 439.43f));
        }

        [TestCompiler]
        public void clamp_float3()
        {
            TestUtils.AreEqual(clamp(float3(float.NegativeInfinity, -254.3f, 246.3f), float3(-123.45f, -123.45f, -123.45f), float3(439.43f, 439.43f, 439.43f)), float3(-123.45f, -123.45f, 246.3f));
            TestUtils.AreEqual(clamp(float3(632.1f, -254.3f, 246.3f), float3(-123.45f, 439.43f, 439.43f), float3(439.43f, -123.45f, -123.45f)), float3(439.43f, 439.43f, 439.43f));
            TestUtils.AreEqual(clamp(float3(632.1f, float.PositiveInfinity, float.NaN), float3(439.43f, -123.45f, -123.45f), float3(-123.45f, 439.43f, 439.43f)), float3(439.43f, 439.43f, 439.43f));
        }

        [TestCompiler]
        public void clamp_float4()
        {
            TestUtils.AreEqual(clamp(float4(float.NegativeInfinity, -254.3f, 246.3f, 632.1f), float4(-123.45f, -123.45f, -123.45f, -123.45f), float4(439.43f, 439.43f, 439.43f, 439.43f)), float4(-123.45f, -123.45f, 246.3f, 439.43f));
            TestUtils.AreEqual(clamp(float4(-254.3f, 246.3f, 632.1f, float.PositiveInfinity), float4(439.43f, 439.43f, 439.43f, -123.45f), float4(-123.45f, -123.45f, -123.45f, 439.43f)), float4(439.43f, 439.43f, 439.43f, 439.43f));
            TestUtils.AreEqual(clamp(float4(float.NaN, float.NaN, float.NaN, float.NaN), float4(-123.45f, -123.45f, -123.45f, -123.45f), float4(439.43f, 439.43f, 439.43f, 439.43f)), float4(439.43f, 439.43f, 439.43f, 439.43f));
        }

        [TestCompiler]
        public void clamp_double()
        {
            TestUtils.AreEqual(clamp(double.NegativeInfinity, -123.45, 439.43), -123.45);
            TestUtils.AreEqual(clamp(-254.3, -123.45, 439.43), -123.45);
            TestUtils.AreEqual(clamp(246.3, -123.45, 439.43), 246.3);
            TestUtils.AreEqual(clamp(632.1, -123.45, 439.43), 439.43);
            TestUtils.AreEqual(clamp(-254.3, 439.43, -123.45), 439.43);
            TestUtils.AreEqual(clamp(246.3, 439.43, -123.45), 439.43);
            TestUtils.AreEqual(clamp(632.1, 439.43, -123.45), 439.43);
            TestUtils.AreEqual(clamp(double.PositiveInfinity, -123.45, 439.43), 439.43);
            TestUtils.AreEqual(clamp(double.NaN, -123.45, 439.43), 439.43);
        }

        [TestCompiler]
        public void clamp_double2()
        {
            TestUtils.AreEqual(clamp(double2(double.NegativeInfinity, -254.3), double2(-123.45, -123.45), double2(439.43, 439.43)), double2(-123.45, -123.45));
            TestUtils.AreEqual(clamp(double2(246.3, 632.1), double2(-123.45, -123.45), double2(439.43, 439.43)), double2(246.3, 439.43));
            TestUtils.AreEqual(clamp(double2(-254.3, 246.3), double2(439.43, 439.43), double2(-123.45, -123.45)), double2(439.43, 439.43));
            TestUtils.AreEqual(clamp(double2(632.1, double.PositiveInfinity), double2(439.43, -123.45), double2(-123.45, 439.43)), double2(439.43, 439.43));
            TestUtils.AreEqual(clamp(double2(double.NaN, double.NaN), double2(-123.45, -123.45), double2(439.43, 439.43)), double2(439.43, 439.43));
        }

        [TestCompiler]
        public void clamp_double3()
        {
            TestUtils.AreEqual(clamp(double3(double.NegativeInfinity, -254.3, 246.3), double3(-123.45, -123.45, -123.45), double3(439.43, 439.43, 439.43)), double3(-123.45, -123.45, 246.3));
            TestUtils.AreEqual(clamp(double3(632.1, -254.3, 246.3), double3(-123.45, 439.43, 439.43), double3(439.43, -123.45, -123.45)), double3(439.43, 439.43, 439.43));
            TestUtils.AreEqual(clamp(double3(632.1, double.PositiveInfinity, double.NaN), double3(439.43, -123.45, -123.45), double3(-123.45, 439.43, 439.43)), double3(439.43, 439.43, 439.43));
        }

        [TestCompiler]
        public void clamp_double4()
        {
            TestUtils.AreEqual(clamp(double4(double.NegativeInfinity, -254.3, 246.3, 632.1), double4(-123.45, -123.45, -123.45, -123.45), double4(439.43, 439.43, 439.43, 439.43)), double4(-123.45, -123.45, 246.3, 439.43));
            TestUtils.AreEqual(clamp(double4(-254.3, 246.3, 632.1, double.PositiveInfinity), double4(439.43, 439.43, 439.43, -123.45), double4(-123.45, -123.45, -123.45, 439.43)), double4(439.43, 439.43, 439.43, 439.43));
            TestUtils.AreEqual(clamp(double4(double.NaN, double.NaN, double.NaN, double.NaN), double4(-123.45, -123.45, -123.45, -123.45), double4(439.43, 439.43, 439.43, 439.43)), double4(439.43, 439.43, 439.43, 439.43));
        }

        [TestCompiler]
        public void saturate_float()
        {
            TestUtils.AreEqual(saturate(float.NegativeInfinity), 0f);
            TestUtils.AreEqual(saturate(-123.45f), 0f);
            TestUtils.AreEqual(saturate(0f), 0f);
            TestUtils.AreEqual(saturate(0.5f), 0.5f);
            TestUtils.AreEqual(saturate(1f), 1f);
            TestUtils.AreEqual(saturate(123.45f), 1f);
            TestUtils.AreEqual(saturate(float.PositiveInfinity), 1f);
            TestUtils.AreEqual(saturate(float.NaN), 1f);
        }

        [TestCompiler]
        public void saturate_float2()
        {
            TestUtils.AreEqual(saturate(float2(float.NegativeInfinity, -123.45f)), float2(0f, 0f));
            TestUtils.AreEqual(saturate(float2(0f, 0.5f)), float2(0f, 0.5f));
            TestUtils.AreEqual(saturate(float2(1f, 123.45f)), float2(1f, 1f));
            TestUtils.AreEqual(saturate(float2(float.PositiveInfinity, float.NaN)), float2(1f, 1f));
        }

        [TestCompiler]
        public void saturate_float3()
        {
            TestUtils.AreEqual(saturate(float3(float.NegativeInfinity, -123.45f, 0f)), float3(0f, 0f, 0f));
            TestUtils.AreEqual(saturate(float3(0.5f, 1f, 123.45f)), float3(0.5f, 1f, 1f));
            TestUtils.AreEqual(saturate(float3(float.PositiveInfinity, float.NaN, float.NaN)), float3(1f, 1f, 1f));
        }

        [TestCompiler]
        public void saturate_float4()
        {
            TestUtils.AreEqual(saturate(float4(float.NegativeInfinity, -123.45f, 0f, 0.5f)), float4(0f, 0f, 0f, 0.5f));
            TestUtils.AreEqual(saturate(float4(1f, 123.45f, float.PositiveInfinity, float.NaN)), float4(1f, 1f, 1f, 1f));
        }

        [TestCompiler]
        public void saturate_double()
        {
            TestUtils.AreEqual(saturate(double.NegativeInfinity), 0.0);
            TestUtils.AreEqual(saturate(-123.45), 0.0);
            TestUtils.AreEqual(saturate(0.0), 0.0);
            TestUtils.AreEqual(saturate(0.5), 0.5);
            TestUtils.AreEqual(saturate(1.0), 1.0);
            TestUtils.AreEqual(saturate(123.45), 1.0);
            TestUtils.AreEqual(saturate(double.PositiveInfinity), 1.0);
            TestUtils.AreEqual(saturate(double.NaN), 1.0);
        }

        [TestCompiler]
        public void saturate_double2()
        {
            TestUtils.AreEqual(saturate(double2(double.NegativeInfinity, -123.45)), double2(0.0, 0.0));
            TestUtils.AreEqual(saturate(double2(0.0, 0.5)), double2(0.0, 0.5));
            TestUtils.AreEqual(saturate(double2(1.0, 123.45)), double2(1.0, 1.0));
            TestUtils.AreEqual(saturate(double2(double.PositiveInfinity, double.NaN)), double2(1.0, 1.0));
        }

        [TestCompiler]
        public void saturate_double3()
        {
            TestUtils.AreEqual(saturate(double3(double.NegativeInfinity, -123.45, 0.0)), double3(0.0, 0.0, 0.0));
            TestUtils.AreEqual(saturate(double3(0.5, 1.0, 123.45)), double3(0.5, 1.0, 1.0));
            TestUtils.AreEqual(saturate(double3(double.PositiveInfinity, double.NaN, double.NaN)), double3(1.0, 1.0, 1.0));
        }

        [TestCompiler]
        public void saturate_double4()
        {
            TestUtils.AreEqual(saturate(double4(double.NegativeInfinity, -123.45, 0.0, 0.5)), double4(0.0, 0.0, 0.0, 0.5));
            TestUtils.AreEqual(saturate(double4(1.0, 123.45, double.PositiveInfinity, double.NaN)), double4(1.0, 1.0, 1.0, 1.0));
        }

        [TestCompiler]
        public void step_float()
        {
            TestUtils.AreEqual(step(-123.45f, float.NegativeInfinity), 0f);
            TestUtils.AreEqual(step(-123.45f, -200f), 0f);
            TestUtils.AreEqual(step(-123.45f, 200f), 1f);
            TestUtils.AreEqual(step(-123.45f, float.PositiveInfinity), 1f);
            TestUtils.AreEqual(step(-123.45f, float.NaN), 0f);
            TestUtils.AreEqual(step(123.45f, float.NegativeInfinity), 0f);
            TestUtils.AreEqual(step(123.45f, -200f), 0f);
            TestUtils.AreEqual(step(123.45f, 200f), 1f);
            TestUtils.AreEqual(step(123.45f, float.PositiveInfinity), 1f);
            TestUtils.AreEqual(step(123.45f, float.NaN), 0f);
            TestUtils.AreEqual(step(float.NegativeInfinity, float.NegativeInfinity), 1f);
            TestUtils.AreEqual(step(float.NegativeInfinity, -200f), 1f);
            TestUtils.AreEqual(step(float.NegativeInfinity, 200f), 1f);
            TestUtils.AreEqual(step(float.NegativeInfinity, float.PositiveInfinity), 1f);
            TestUtils.AreEqual(step(float.NegativeInfinity, float.NaN), 0f);
            TestUtils.AreEqual(step(float.PositiveInfinity, float.NegativeInfinity), 0f);
            TestUtils.AreEqual(step(float.PositiveInfinity, -200f), 0f);
            TestUtils.AreEqual(step(float.PositiveInfinity, 200f), 0f);
            TestUtils.AreEqual(step(float.PositiveInfinity, float.PositiveInfinity), 1f);
            TestUtils.AreEqual(step(float.PositiveInfinity, float.NaN), 0f);
            TestUtils.AreEqual(step(float.NaN, float.NegativeInfinity), 0f);
            TestUtils.AreEqual(step(float.NaN, -200f), 0f);
            TestUtils.AreEqual(step(float.NaN, 200f), 0f);
            TestUtils.AreEqual(step(float.NaN, float.PositiveInfinity), 0f);
            TestUtils.AreEqual(step(float.NaN, float.NaN), 0f);
        }

        [TestCompiler]
        public void step_float2()
        {
            TestUtils.AreEqual(step(float2(-123.45f, -123.45f), float2(float.NegativeInfinity, -200f)), float2(0f, 0f));
            TestUtils.AreEqual(step(float2(-123.45f, -123.45f), float2(200f, float.PositiveInfinity)), float2(1f, 1f));
            TestUtils.AreEqual(step(float2(-123.45f, 123.45f), float2(float.NaN, float.NegativeInfinity)), float2(0f, 0f));
            TestUtils.AreEqual(step(float2(123.45f, 123.45f), float2(-200f, 200f)), float2(0f, 1f));
            TestUtils.AreEqual(step(float2(123.45f, 123.45f), float2(float.PositiveInfinity, float.NaN)), float2(1f, 0f));
            TestUtils.AreEqual(step(float2(float.NegativeInfinity, float.NegativeInfinity), float2(float.NegativeInfinity, -200f)), float2(1f, 1f));
            TestUtils.AreEqual(step(float2(float.NegativeInfinity, float.NegativeInfinity), float2(200f, float.PositiveInfinity)), float2(1f, 1f));
            TestUtils.AreEqual(step(float2(float.NegativeInfinity, float.PositiveInfinity), float2(float.NaN, float.NegativeInfinity)), float2(0f, 0f));
            TestUtils.AreEqual(step(float2(float.PositiveInfinity, float.PositiveInfinity), float2(-200f, 200f)), float2(0f, 0f));
            TestUtils.AreEqual(step(float2(float.PositiveInfinity, float.PositiveInfinity), float2(float.PositiveInfinity, float.NaN)), float2(1f, 0f));
            TestUtils.AreEqual(step(float2(float.NaN, float.NaN), float2(float.NegativeInfinity, -200f)), float2(0f, 0f));
            TestUtils.AreEqual(step(float2(float.NaN, float.NaN), float2(200f, float.PositiveInfinity)), float2(0f, 0f));
            TestUtils.AreEqual(step(float2(float.NaN, float.NaN), float2(float.NaN, float.NaN)), float2(0f, 0f));
        }

        [TestCompiler]
        public void step_float3()
        {
            TestUtils.AreEqual(step(float3(-123.45f, -123.45f, -123.45f), float3(float.NegativeInfinity, -200f, 200f)), float3(0f, 0f, 1f));
            TestUtils.AreEqual(step(float3(-123.45f, -123.45f, 123.45f), float3(float.PositiveInfinity, float.NaN, float.NegativeInfinity)), float3(1f, 0f, 0f));
            TestUtils.AreEqual(step(float3(123.45f, 123.45f, 123.45f), float3(-200f, 200f, float.PositiveInfinity)), float3(0f, 1f, 1f));
            TestUtils.AreEqual(step(float3(123.45f, float.NegativeInfinity, float.NegativeInfinity), float3(float.NaN, float.NegativeInfinity, -200f)), float3(0f, 1f, 1f));
            TestUtils.AreEqual(step(float3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity), float3(200f, float.PositiveInfinity, float.NaN)), float3(1f, 1f, 0f));
            TestUtils.AreEqual(step(float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity), float3(float.NegativeInfinity, -200f, 200f)), float3(0f, 0f, 0f));
            TestUtils.AreEqual(step(float3(float.PositiveInfinity, float.PositiveInfinity, float.NaN), float3(float.PositiveInfinity, float.NaN, float.NegativeInfinity)), float3(1f, 0f, 0f));
            TestUtils.AreEqual(step(float3(float.NaN, float.NaN, float.NaN), float3(-200f, 200f, float.PositiveInfinity)), float3(0f, 0f, 0f));
            TestUtils.AreEqual(step(float3(float.NaN, float.NaN, float.NaN), float3(float.NaN, float.NaN, float.NaN)), float3(0f, 0f, 0f));
        }

        [TestCompiler]
        public void step_float4()
        {
            TestUtils.AreEqual(step(float4(-123.45f, -123.45f, -123.45f, -123.45f), float4(float.NegativeInfinity, -200f, 200f, float.PositiveInfinity)), float4(0f, 0f, 1f, 1f));
            TestUtils.AreEqual(step(float4(-123.45f, 123.45f, 123.45f, 123.45f), float4(float.NaN, float.NegativeInfinity, -200f, 200f)), float4(0f, 0f, 0f, 1f));
            TestUtils.AreEqual(step(float4(123.45f, 123.45f, float.NegativeInfinity, float.NegativeInfinity), float4(float.PositiveInfinity, float.NaN, float.NegativeInfinity, -200f)), float4(1f, 0f, 1f, 1f));
            TestUtils.AreEqual(step(float4(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.PositiveInfinity), float4(200f, float.PositiveInfinity, float.NaN, float.NegativeInfinity)), float4(1f, 1f, 0f, 0f));
            TestUtils.AreEqual(step(float4(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity), float4(-200f, 200f, float.PositiveInfinity, float.NaN)), float4(0f, 0f, 1f, 0f));
            TestUtils.AreEqual(step(float4(float.NaN, float.NaN, float.NaN, float.NaN), float4(float.NegativeInfinity, -200f, 200f, float.PositiveInfinity)), float4(0f, 0f, 0f, 0f));
            TestUtils.AreEqual(step(float4(float.NaN, float.NaN, float.NaN, float.NaN), float4(float.NaN, float.NaN, float.NaN, float.NaN)), float4(0f, 0f, 0f, 0f));
        }

        [TestCompiler]
        public void step_double()
        {
            TestUtils.AreEqual(step(-123.45, double.NegativeInfinity), 0.0);
            TestUtils.AreEqual(step(-123.45, -200.0), 0.0);
            TestUtils.AreEqual(step(-123.45, 200.0), 1.0);
            TestUtils.AreEqual(step(-123.45, double.PositiveInfinity), 1.0);
            TestUtils.AreEqual(step(-123.45, double.NaN), 0.0);
            TestUtils.AreEqual(step(123.45, double.NegativeInfinity), 0.0);
            TestUtils.AreEqual(step(123.45, -200.0), 0.0);
            TestUtils.AreEqual(step(123.45, 200.0), 1.0);
            TestUtils.AreEqual(step(123.45, double.PositiveInfinity), 1.0);
            TestUtils.AreEqual(step(123.45, double.NaN), 0.0);
            TestUtils.AreEqual(step(double.NegativeInfinity, double.NegativeInfinity), 1.0);
            TestUtils.AreEqual(step(double.NegativeInfinity, -200.0), 1.0);
            TestUtils.AreEqual(step(double.NegativeInfinity, 200.0), 1.0);
            TestUtils.AreEqual(step(double.NegativeInfinity, double.PositiveInfinity), 1.0);
            TestUtils.AreEqual(step(double.NegativeInfinity, double.NaN), 0.0);
            TestUtils.AreEqual(step(double.PositiveInfinity, double.NegativeInfinity), 0.0);
            TestUtils.AreEqual(step(double.PositiveInfinity, -200.0), 0.0);
            TestUtils.AreEqual(step(double.PositiveInfinity, 200.0), 0.0);
            TestUtils.AreEqual(step(double.PositiveInfinity, double.PositiveInfinity), 1.0);
            TestUtils.AreEqual(step(double.PositiveInfinity, double.NaN), 0.0);
            TestUtils.AreEqual(step(double.NaN, double.NegativeInfinity), 0.0);
            TestUtils.AreEqual(step(double.NaN, -200.0), 0.0);
            TestUtils.AreEqual(step(double.NaN, 200.0), 0.0);
            TestUtils.AreEqual(step(double.NaN, double.PositiveInfinity), 0.0);
            TestUtils.AreEqual(step(double.NaN, double.NaN), 0.0);
        }

        [TestCompiler]
        public void step_double2()
        {
            TestUtils.AreEqual(step(double2(-123.45, -123.45), double2(double.NegativeInfinity, -200.0)), double2(0.0, 0.0));
            TestUtils.AreEqual(step(double2(-123.45, -123.45), double2(200.0, double.PositiveInfinity)), double2(1.0, 1.0));
            TestUtils.AreEqual(step(double2(-123.45, 123.45), double2(double.NaN, double.NegativeInfinity)), double2(0.0, 0.0));
            TestUtils.AreEqual(step(double2(123.45, 123.45), double2(-200.0, 200.0)), double2(0.0, 1.0));
            TestUtils.AreEqual(step(double2(123.45, 123.45), double2(double.PositiveInfinity, double.NaN)), double2(1.0, 0.0));
            TestUtils.AreEqual(step(double2(double.NegativeInfinity, double.NegativeInfinity), double2(double.NegativeInfinity, -200.0)), double2(1.0, 1.0));
            TestUtils.AreEqual(step(double2(double.NegativeInfinity, double.NegativeInfinity), double2(200.0, double.PositiveInfinity)), double2(1.0, 1.0));
            TestUtils.AreEqual(step(double2(double.NegativeInfinity, double.PositiveInfinity), double2(double.NaN, double.NegativeInfinity)), double2(0.0, 0.0));
            TestUtils.AreEqual(step(double2(double.PositiveInfinity, double.PositiveInfinity), double2(-200.0, 200.0)), double2(0.0, 0.0));
            TestUtils.AreEqual(step(double2(double.PositiveInfinity, double.PositiveInfinity), double2(double.PositiveInfinity, double.NaN)), double2(1.0, 0.0));
            TestUtils.AreEqual(step(double2(double.NaN, double.NaN), double2(double.NegativeInfinity, -200.0)), double2(0.0, 0.0));
            TestUtils.AreEqual(step(double2(double.NaN, double.NaN), double2(200.0, double.PositiveInfinity)), double2(0.0, 0.0));
            TestUtils.AreEqual(step(double2(double.NaN, double.NaN), double2(double.NaN, double.NaN)), double2(0.0, 0.0));
        }

        [TestCompiler]
        public void step_double3()
        {
            TestUtils.AreEqual(step(double3(-123.45, -123.45, -123.45), double3(double.NegativeInfinity, -200.0, 200.0)), double3(0.0, 0.0, 1.0));
            TestUtils.AreEqual(step(double3(-123.45, -123.45, 123.45), double3(double.PositiveInfinity, double.NaN, double.NegativeInfinity)), double3(1.0, 0.0, 0.0));
            TestUtils.AreEqual(step(double3(123.45, 123.45, 123.45), double3(-200.0, 200.0, double.PositiveInfinity)), double3(0.0, 1.0, 1.0));
            TestUtils.AreEqual(step(double3(123.45, double.NegativeInfinity, double.NegativeInfinity), double3(double.NaN, double.NegativeInfinity, -200.0)), double3(0.0, 1.0, 1.0));
            TestUtils.AreEqual(step(double3(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity), double3(200.0, double.PositiveInfinity, double.NaN)), double3(1.0, 1.0, 0.0));
            TestUtils.AreEqual(step(double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity), double3(double.NegativeInfinity, -200.0, 200.0)), double3(0.0, 0.0, 0.0));
            TestUtils.AreEqual(step(double3(double.PositiveInfinity, double.PositiveInfinity, double.NaN), double3(double.PositiveInfinity, double.NaN, double.NegativeInfinity)), double3(1.0, 0.0, 0.0));
            TestUtils.AreEqual(step(double3(double.NaN, double.NaN, double.NaN), double3(-200.0, 200.0, double.PositiveInfinity)), double3(0.0, 0.0, 0.0));
            TestUtils.AreEqual(step(double3(double.NaN, double.NaN, double.NaN), double3(double.NaN, double.NaN, double.NaN)), double3(0.0, 0.0, 0.0));
        }

        [TestCompiler]
        public void step_double4()
        {
            TestUtils.AreEqual(step(double4(-123.45, -123.45, -123.45, -123.45), double4(double.NegativeInfinity, -200.0, 200.0, double.PositiveInfinity)), double4(0.0, 0.0, 1.0, 1.0));
            TestUtils.AreEqual(step(double4(-123.45, 123.45, 123.45, 123.45), double4(double.NaN, double.NegativeInfinity, -200.0, 200.0)), double4(0.0, 0.0, 0.0, 1.0));
            TestUtils.AreEqual(step(double4(123.45, 123.45, double.NegativeInfinity, double.NegativeInfinity), double4(double.PositiveInfinity, double.NaN, double.NegativeInfinity, -200.0)), double4(1.0, 0.0, 1.0, 1.0));
            TestUtils.AreEqual(step(double4(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, double.PositiveInfinity), double4(200.0, double.PositiveInfinity, double.NaN, double.NegativeInfinity)), double4(1.0, 1.0, 0.0, 0.0));
            TestUtils.AreEqual(step(double4(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity), double4(-200.0, 200.0, double.PositiveInfinity, double.NaN)), double4(0.0, 0.0, 1.0, 0.0));
            TestUtils.AreEqual(step(double4(double.NaN, double.NaN, double.NaN, double.NaN), double4(double.NegativeInfinity, -200.0, 200.0, double.PositiveInfinity)), double4(0.0, 0.0, 0.0, 0.0));
            TestUtils.AreEqual(step(double4(double.NaN, double.NaN, double.NaN, double.NaN), double4(double.NaN, double.NaN, double.NaN, double.NaN)), double4(0.0, 0.0, 0.0, 0.0));
        }

        [TestCompiler]
        public void min_int()
        {
            TestUtils.AreEqual(min(-2147483648, -2147483648), -2147483648);
            TestUtils.AreEqual(min(-2147483648, -1), -2147483648);
            TestUtils.AreEqual(min(-1, -2147483648), -2147483648);
            TestUtils.AreEqual(min(-1234, -3456), -3456);
            TestUtils.AreEqual(min(-3456, -1234), -3456);
            TestUtils.AreEqual(min(-1234, 3456), -1234);
            TestUtils.AreEqual(min(3456, -1234), -1234);
            TestUtils.AreEqual(min(1234, 3456), 1234);
            TestUtils.AreEqual(min(3456, 1234), 1234);
            TestUtils.AreEqual(min(1, 2147483647), 1);
            TestUtils.AreEqual(min(2147483647, 1), 1);
            TestUtils.AreEqual(min(2147483647, -2147483648), -2147483648);
            TestUtils.AreEqual(min(2147483647, 2147483647), 2147483647);
        }

        [TestCompiler]
        public void min_int2()
        {
            TestUtils.AreEqual(min(int2(-2147483648, -2147483648), int2(-2147483648, -1)), int2(-2147483648, -2147483648));
            TestUtils.AreEqual(min(int2(-1, -1234), int2(-2147483648, -3456)), int2(-2147483648, -3456));
            TestUtils.AreEqual(min(int2(-3456, -1234), int2(-1234, 3456)), int2(-3456, -1234));
            TestUtils.AreEqual(min(int2(3456, 1234), int2(-1234, 3456)), int2(-1234, 1234));
            TestUtils.AreEqual(min(int2(3456, 1), int2(1234, 2147483647)), int2(1234, 1));
            TestUtils.AreEqual(min(int2(2147483647, 2147483647), int2(1, -2147483648)), int2(1, -2147483648));
            TestUtils.AreEqual(min(int2(2147483647, 2147483647), int2(2147483647, 2147483647)), int2(2147483647, 2147483647));
        }

        [TestCompiler]
        public void min_int3()
        {
            TestUtils.AreEqual(min(int3(-2147483648, -2147483648, -1), int3(-2147483648, -1, -2147483648)), int3(-2147483648, -2147483648, -2147483648));
            TestUtils.AreEqual(min(int3(-1234, -3456, -1234), int3(-3456, -1234, 3456)), int3(-3456, -3456, -1234));
            TestUtils.AreEqual(min(int3(3456, 1234, 3456), int3(-1234, 3456, 1234)), int3(-1234, 1234, 1234));
            TestUtils.AreEqual(min(int3(1, 2147483647, 2147483647), int3(2147483647, 1, -2147483648)), int3(1, 1, -2147483648));
            TestUtils.AreEqual(min(int3(2147483647, 2147483647, 2147483647), int3(2147483647, 2147483647, 2147483647)), int3(2147483647, 2147483647, 2147483647));
        }

        [TestCompiler]
        public void min_int4()
        {
            TestUtils.AreEqual(min(int4(-2147483648, -2147483648, -1, -1234), int4(-2147483648, -1, -2147483648, -3456)), int4(-2147483648, -2147483648, -2147483648, -3456));
            TestUtils.AreEqual(min(int4(-3456, -1234, 3456, 1234), int4(-1234, 3456, -1234, 3456)), int4(-3456, -1234, -1234, 1234));
            TestUtils.AreEqual(min(int4(3456, 1, 2147483647, 2147483647), int4(1234, 2147483647, 1, -2147483648)), int4(1234, 1, 1, -2147483648));
            TestUtils.AreEqual(min(int4(2147483647, 2147483647, 2147483647, 2147483647), int4(2147483647, 2147483647, 2147483647, 2147483647)), int4(2147483647, 2147483647, 2147483647, 2147483647));
        }

        [TestCompiler]
        public void min_uint()
        {
            TestUtils.AreEqual(min(1234u, 3456u), 1234u);
            TestUtils.AreEqual(min(3456u, 1234u), 1234u);
            TestUtils.AreEqual(min(4294967040u, 7u), 7u);
            TestUtils.AreEqual(min(7u, 4294967040u), 7u);
            TestUtils.AreEqual(min(1u, 4294967295u), 1u);
            TestUtils.AreEqual(min(4294967295u, 1u), 1u);
            TestUtils.AreEqual(min(4294967295u, 4294967295u), 4294967295u);
        }

        [TestCompiler]
        public void min_uint2()
        {
            TestUtils.AreEqual(min(uint2(1234u, 3456u), uint2(3456u, 1234u)), uint2(1234u, 1234u));
            TestUtils.AreEqual(min(uint2(4294967040u, 7u), uint2(7u, 4294967040u)), uint2(7u, 7u));
            TestUtils.AreEqual(min(uint2(1u, 4294967295u), uint2(4294967295u, 1u)), uint2(1u, 1u));
            TestUtils.AreEqual(min(uint2(4294967295u, 4294967295u), uint2(4294967295u, 4294967295u)), uint2(4294967295u, 4294967295u));
        }

        [TestCompiler]
        public void min_uint3()
        {
            TestUtils.AreEqual(min(uint3(1234u, 3456u, 4294967040u), uint3(3456u, 1234u, 7u)), uint3(1234u, 1234u, 7u));
            TestUtils.AreEqual(min(uint3(7u, 1u, 4294967295u), uint3(4294967040u, 4294967295u, 1u)), uint3(7u, 1u, 1u));
            TestUtils.AreEqual(min(uint3(4294967295u, 4294967295u, 4294967295u), uint3(4294967295u, 4294967295u, 4294967295u)), uint3(4294967295u, 4294967295u, 4294967295u));
        }

        [TestCompiler]
        public void min_uint4()
        {
            TestUtils.AreEqual(min(uint4(1234u, 3456u, 4294967040u, 7u), uint4(3456u, 1234u, 7u, 4294967040u)), uint4(1234u, 1234u, 7u, 7u));
            TestUtils.AreEqual(min(uint4(1u, 4294967295u, 4294967295u, 4294967295u), uint4(4294967295u, 1u, 4294967295u, 4294967295u)), uint4(1u, 1u, 4294967295u, 4294967295u));
        }

        [TestCompiler]
        public void min_long()
        {
            TestUtils.AreEqual(min(-9223372036854775808L, -9223372036854775808L), -9223372036854775808L);
            TestUtils.AreEqual(min(-9223372036854775808L, -1L), -9223372036854775808L);
            TestUtils.AreEqual(min(-1L, -9223372036854775808L), -9223372036854775808L);
            TestUtils.AreEqual(min(-1234L, -3456L), -3456L);
            TestUtils.AreEqual(min(-3456L, -1234L), -3456L);
            TestUtils.AreEqual(min(-1234L, 3456L), -1234L);
            TestUtils.AreEqual(min(3456L, -1234L), -1234L);
            TestUtils.AreEqual(min(1234L, 3456L), 1234L);
            TestUtils.AreEqual(min(3456L, 1234L), 1234L);
            TestUtils.AreEqual(min(1L, 9223372036854775807L), 1L);
            TestUtils.AreEqual(min(9223372036854775807L, 1L), 1L);
            TestUtils.AreEqual(min(9223372036854775807L, -9223372036854775808L), -9223372036854775808L);
            TestUtils.AreEqual(min(9223372036854775807L, 9223372036854775807L), 9223372036854775807L);
        }

        [TestCompiler]
        public void min_ulong()
        {
            TestUtils.AreEqual(min(1234UL, 3456UL), 1234UL);
            TestUtils.AreEqual(min(3456UL, 1234UL), 1234UL);
            TestUtils.AreEqual(min(18446744073709551360UL, 7UL), 7UL);
            TestUtils.AreEqual(min(7UL, 18446744073709551360UL), 7UL);
            TestUtils.AreEqual(min(1UL, 18446744073709551615UL), 1UL);
            TestUtils.AreEqual(min(18446744073709551615UL, 1UL), 1UL);
            TestUtils.AreEqual(min(18446744073709551615UL, 18446744073709551615UL), 18446744073709551615UL);
        }

        [TestCompiler]
        public void min_float()
        {
            TestUtils.AreEqual(min(float.NegativeInfinity, float.NegativeInfinity), float.NegativeInfinity);
            TestUtils.AreEqual(min(float.NegativeInfinity, -1f), float.NegativeInfinity);
            TestUtils.AreEqual(min(-1f, float.NegativeInfinity), float.NegativeInfinity);
            TestUtils.AreEqual(min(-1234.56f, -3456.7f), -3456.7f);
            TestUtils.AreEqual(min(-3456.7f, -1234.56f), -3456.7f);
            TestUtils.AreEqual(min(-1234.56f, 3456.7f), -1234.56f);
            TestUtils.AreEqual(min(3456.7f, -1234.56f), -1234.56f);
            TestUtils.AreEqual(min(1234.56f, 3456.7f), 1234.56f);
            TestUtils.AreEqual(min(3456.7f, 1234.56f), 1234.56f);
            TestUtils.AreEqual(min(1f, float.PositiveInfinity), 1f);
            TestUtils.AreEqual(min(float.PositiveInfinity, 1f), 1f);
            TestUtils.AreEqual(min(float.PositiveInfinity, float.NegativeInfinity), float.NegativeInfinity);
            TestUtils.AreEqual(min(float.PositiveInfinity, float.PositiveInfinity), float.PositiveInfinity);
            TestUtils.AreEqual(min(float.NaN, 2.3f), 2.3f);
            TestUtils.AreEqual(min(2.3f, float.NaN), 2.3f);
            TestUtils.AreEqual(min(float.NaN, float.NaN), float.NaN);
        }

        [TestCompiler]
        public void min_float2()
        {
            TestUtils.AreEqual(min(float2(float.NegativeInfinity, float.NegativeInfinity), float2(float.NegativeInfinity, -1f)), float2(float.NegativeInfinity, float.NegativeInfinity));
            TestUtils.AreEqual(min(float2(-1f, -1234.56f), float2(float.NegativeInfinity, -3456.7f)), float2(float.NegativeInfinity, -3456.7f));
            TestUtils.AreEqual(min(float2(-3456.7f, -1234.56f), float2(-1234.56f, 3456.7f)), float2(-3456.7f, -1234.56f));
            TestUtils.AreEqual(min(float2(3456.7f, 1234.56f), float2(-1234.56f, 3456.7f)), float2(-1234.56f, 1234.56f));
            TestUtils.AreEqual(min(float2(3456.7f, 1f), float2(1234.56f, float.PositiveInfinity)), float2(1234.56f, 1f));
            TestUtils.AreEqual(min(float2(float.PositiveInfinity, float.PositiveInfinity), float2(1f, float.NegativeInfinity)), float2(1f, float.NegativeInfinity));
            TestUtils.AreEqual(min(float2(float.PositiveInfinity, float.NaN), float2(float.PositiveInfinity, 2.3f)), float2(float.PositiveInfinity, 2.3f));
            TestUtils.AreEqual(min(float2(2.3f, float.NaN), float2(float.NaN, float.NaN)), float2(2.3f, float.NaN));
        }

        [TestCompiler]
        public void min_float3()
        {
            TestUtils.AreEqual(min(float3(float.NegativeInfinity, float.NegativeInfinity, -1f), float3(float.NegativeInfinity, -1f, float.NegativeInfinity)), float3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity));
            TestUtils.AreEqual(min(float3(-1234.56f, -3456.7f, -1234.56f), float3(-3456.7f, -1234.56f, 3456.7f)), float3(-3456.7f, -3456.7f, -1234.56f));
            TestUtils.AreEqual(min(float3(3456.7f, 1234.56f, 3456.7f), float3(-1234.56f, 3456.7f, 1234.56f)), float3(-1234.56f, 1234.56f, 1234.56f));
            TestUtils.AreEqual(min(float3(1f, float.PositiveInfinity, float.PositiveInfinity), float3(float.PositiveInfinity, 1f, float.NegativeInfinity)), float3(1f, 1f, float.NegativeInfinity));
            TestUtils.AreEqual(min(float3(float.PositiveInfinity, float.NaN, 2.3f), float3(float.PositiveInfinity, 2.3f, float.NaN)), float3(float.PositiveInfinity, 2.3f, 2.3f));
            TestUtils.AreEqual(min(float3(float.NaN, float.NaN, float.NaN), float3(float.NaN, float.NaN, float.NaN)), float3(float.NaN, float.NaN, float.NaN));
        }

        [TestCompiler]
        public void min_float4()
        {
            TestUtils.AreEqual(min(float4(float.NegativeInfinity, float.NegativeInfinity, -1f, -1234.56f), float4(float.NegativeInfinity, -1f, float.NegativeInfinity, -3456.7f)), float4(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, -3456.7f));
            TestUtils.AreEqual(min(float4(-3456.7f, -1234.56f, 3456.7f, 1234.56f), float4(-1234.56f, 3456.7f, -1234.56f, 3456.7f)), float4(-3456.7f, -1234.56f, -1234.56f, 1234.56f));
            TestUtils.AreEqual(min(float4(3456.7f, 1f, float.PositiveInfinity, float.PositiveInfinity), float4(1234.56f, float.PositiveInfinity, 1f, float.NegativeInfinity)), float4(1234.56f, 1f, 1f, float.NegativeInfinity));
            TestUtils.AreEqual(min(float4(float.PositiveInfinity, float.NaN, 2.3f, float.NaN), float4(float.PositiveInfinity, 2.3f, float.NaN, float.NaN)), float4(float.PositiveInfinity, 2.3f, 2.3f, float.NaN));
        }

        [TestCompiler]
        public void min_double()
        {
            TestUtils.AreEqual(min(double.NegativeInfinity, double.NegativeInfinity), double.NegativeInfinity);
            TestUtils.AreEqual(min(double.NegativeInfinity, -1.0), double.NegativeInfinity);
            TestUtils.AreEqual(min(-1.0, double.NegativeInfinity), double.NegativeInfinity);
            TestUtils.AreEqual(min(-1234.56, -3456.7), -3456.7);
            TestUtils.AreEqual(min(-3456.7, -1234.56), -3456.7);
            TestUtils.AreEqual(min(-1234.56, 3456.7), -1234.56);
            TestUtils.AreEqual(min(3456.7, -1234.56), -1234.56);
            TestUtils.AreEqual(min(1234.56, 3456.7), 1234.56);
            TestUtils.AreEqual(min(3456.7, 1234.56), 1234.56);
            TestUtils.AreEqual(min(1.0, double.PositiveInfinity), 1.0);
            TestUtils.AreEqual(min(double.PositiveInfinity, 1.0), 1.0);
            TestUtils.AreEqual(min(double.PositiveInfinity, double.NegativeInfinity), double.NegativeInfinity);
            TestUtils.AreEqual(min(double.PositiveInfinity, double.PositiveInfinity), double.PositiveInfinity);
            TestUtils.AreEqual(min(double.NaN, 2.3), 2.3);
            TestUtils.AreEqual(min(2.3, double.NaN), 2.3);
            TestUtils.AreEqual(min(double.NaN, double.NaN), double.NaN);
        }

        [TestCompiler]
        public void min_double2()
        {
            TestUtils.AreEqual(min(double2(double.NegativeInfinity, double.NegativeInfinity), double2(double.NegativeInfinity, -1.0)), double2(double.NegativeInfinity, double.NegativeInfinity));
            TestUtils.AreEqual(min(double2(-1.0, -1234.56), double2(double.NegativeInfinity, -3456.7)), double2(double.NegativeInfinity, -3456.7));
            TestUtils.AreEqual(min(double2(-3456.7, -1234.56), double2(-1234.56, 3456.7)), double2(-3456.7, -1234.56));
            TestUtils.AreEqual(min(double2(3456.7, 1234.56), double2(-1234.56, 3456.7)), double2(-1234.56, 1234.56));
            TestUtils.AreEqual(min(double2(3456.7, 1.0), double2(1234.56, double.PositiveInfinity)), double2(1234.56, 1.0));
            TestUtils.AreEqual(min(double2(double.PositiveInfinity, double.PositiveInfinity), double2(1.0, double.NegativeInfinity)), double2(1.0, double.NegativeInfinity));
            TestUtils.AreEqual(min(double2(double.PositiveInfinity, double.NaN), double2(double.PositiveInfinity, 2.3)), double2(double.PositiveInfinity, 2.3));
            TestUtils.AreEqual(min(double2(2.3, double.NaN), double2(double.NaN, double.NaN)), double2(2.3, double.NaN));
        }

        [TestCompiler]
        public void min_double3()
        {
            TestUtils.AreEqual(min(double3(double.NegativeInfinity, double.NegativeInfinity, -1.0), double3(double.NegativeInfinity, -1.0, double.NegativeInfinity)), double3(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity));
            TestUtils.AreEqual(min(double3(-1234.56, -3456.7, -1234.56), double3(-3456.7, -1234.56, 3456.7)), double3(-3456.7, -3456.7, -1234.56));
            TestUtils.AreEqual(min(double3(3456.7, 1234.56, 3456.7), double3(-1234.56, 3456.7, 1234.56)), double3(-1234.56, 1234.56, 1234.56));
            TestUtils.AreEqual(min(double3(1.0, double.PositiveInfinity, double.PositiveInfinity), double3(double.PositiveInfinity, 1.0, double.NegativeInfinity)), double3(1.0, 1.0, double.NegativeInfinity));
            TestUtils.AreEqual(min(double3(double.PositiveInfinity, double.NaN, 2.3), double3(double.PositiveInfinity, 2.3, double.NaN)), double3(double.PositiveInfinity, 2.3, 2.3));
            TestUtils.AreEqual(min(double3(double.NaN, double.NaN, double.NaN), double3(double.NaN, double.NaN, double.NaN)), double3(double.NaN, double.NaN, double.NaN));
        }

        [TestCompiler]
        public void min_double4()
        {
            TestUtils.AreEqual(min(double4(double.NegativeInfinity, double.NegativeInfinity, -1.0, -1234.56), double4(double.NegativeInfinity, -1.0, double.NegativeInfinity, -3456.7)), double4(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, -3456.7));
            TestUtils.AreEqual(min(double4(-3456.7, -1234.56, 3456.7, 1234.56), double4(-1234.56, 3456.7, -1234.56, 3456.7)), double4(-3456.7, -1234.56, -1234.56, 1234.56));
            TestUtils.AreEqual(min(double4(3456.7, 1.0, double.PositiveInfinity, double.PositiveInfinity), double4(1234.56, double.PositiveInfinity, 1.0, double.NegativeInfinity)), double4(1234.56, 1.0, 1.0, double.NegativeInfinity));
            TestUtils.AreEqual(min(double4(double.PositiveInfinity, double.NaN, 2.3, double.NaN), double4(double.PositiveInfinity, 2.3, double.NaN, double.NaN)), double4(double.PositiveInfinity, 2.3, 2.3, double.NaN));
        }

        [TestCompiler]
        public void max_int()
        {
            TestUtils.AreEqual(max(-2147483648, -2147483648), -2147483648);
            TestUtils.AreEqual(max(-2147483648, -1), -1);
            TestUtils.AreEqual(max(-1, -2147483648), -1);
            TestUtils.AreEqual(max(-1234, -3456), -1234);
            TestUtils.AreEqual(max(-3456, -1234), -1234);
            TestUtils.AreEqual(max(-1234, 3456), 3456);
            TestUtils.AreEqual(max(3456, -1234), 3456);
            TestUtils.AreEqual(max(1234, 3456), 3456);
            TestUtils.AreEqual(max(3456, 1234), 3456);
            TestUtils.AreEqual(max(1, 2147483647), 2147483647);
            TestUtils.AreEqual(max(2147483647, 1), 2147483647);
            TestUtils.AreEqual(max(2147483647, -2147483648), 2147483647);
            TestUtils.AreEqual(max(2147483647, 2147483647), 2147483647);
        }

        [TestCompiler]
        public void max_int2()
        {
            TestUtils.AreEqual(max(int2(-2147483648, -2147483648), int2(-2147483648, -1)), int2(-2147483648, -1));
            TestUtils.AreEqual(max(int2(-1, -1234), int2(-2147483648, -3456)), int2(-1, -1234));
            TestUtils.AreEqual(max(int2(-3456, -1234), int2(-1234, 3456)), int2(-1234, 3456));
            TestUtils.AreEqual(max(int2(3456, 1234), int2(-1234, 3456)), int2(3456, 3456));
            TestUtils.AreEqual(max(int2(3456, 1), int2(1234, 2147483647)), int2(3456, 2147483647));
            TestUtils.AreEqual(max(int2(2147483647, 2147483647), int2(1, -2147483648)), int2(2147483647, 2147483647));
            TestUtils.AreEqual(max(int2(2147483647, 2147483647), int2(2147483647, 2147483647)), int2(2147483647, 2147483647));
        }

        [TestCompiler]
        public void max_int3()
        {
            TestUtils.AreEqual(max(int3(-2147483648, -2147483648, -1), int3(-2147483648, -1, -2147483648)), int3(-2147483648, -1, -1));
            TestUtils.AreEqual(max(int3(-1234, -3456, -1234), int3(-3456, -1234, 3456)), int3(-1234, -1234, 3456));
            TestUtils.AreEqual(max(int3(3456, 1234, 3456), int3(-1234, 3456, 1234)), int3(3456, 3456, 3456));
            TestUtils.AreEqual(max(int3(1, 2147483647, 2147483647), int3(2147483647, 1, -2147483648)), int3(2147483647, 2147483647, 2147483647));
            TestUtils.AreEqual(max(int3(2147483647, 2147483647, 2147483647), int3(2147483647, 2147483647, 2147483647)), int3(2147483647, 2147483647, 2147483647));
        }

        [TestCompiler]
        public void max_int4()
        {
            TestUtils.AreEqual(max(int4(-2147483648, -2147483648, -1, -1234), int4(-2147483648, -1, -2147483648, -3456)), int4(-2147483648, -1, -1, -1234));
            TestUtils.AreEqual(max(int4(-3456, -1234, 3456, 1234), int4(-1234, 3456, -1234, 3456)), int4(-1234, 3456, 3456, 3456));
            TestUtils.AreEqual(max(int4(3456, 1, 2147483647, 2147483647), int4(1234, 2147483647, 1, -2147483648)), int4(3456, 2147483647, 2147483647, 2147483647));
            TestUtils.AreEqual(max(int4(2147483647, 2147483647, 2147483647, 2147483647), int4(2147483647, 2147483647, 2147483647, 2147483647)), int4(2147483647, 2147483647, 2147483647, 2147483647));
        }

        [TestCompiler]
        public void max_uint()
        {
            TestUtils.AreEqual(max(1234u, 3456u), 3456u);
            TestUtils.AreEqual(max(3456u, 1234u), 3456u);
            TestUtils.AreEqual(max(4294967040u, 7u), 4294967040u);
            TestUtils.AreEqual(max(7u, 4294967040u), 4294967040u);
            TestUtils.AreEqual(max(1u, 4294967295u), 4294967295u);
            TestUtils.AreEqual(max(4294967295u, 1u), 4294967295u);
            TestUtils.AreEqual(max(4294967295u, 4294967295u), 4294967295u);
        }

        [TestCompiler]
        public void max_uint2()
        {
            TestUtils.AreEqual(max(uint2(1234u, 3456u), uint2(3456u, 1234u)), uint2(3456u, 3456u));
            TestUtils.AreEqual(max(uint2(4294967040u, 7u), uint2(7u, 4294967040u)), uint2(4294967040u, 4294967040u));
            TestUtils.AreEqual(max(uint2(1u, 4294967295u), uint2(4294967295u, 1u)), uint2(4294967295u, 4294967295u));
            TestUtils.AreEqual(max(uint2(4294967295u, 4294967295u), uint2(4294967295u, 4294967295u)), uint2(4294967295u, 4294967295u));
        }

        [TestCompiler]
        public void max_uint3()
        {
            TestUtils.AreEqual(max(uint3(1234u, 3456u, 4294967040u), uint3(3456u, 1234u, 7u)), uint3(3456u, 3456u, 4294967040u));
            TestUtils.AreEqual(max(uint3(7u, 1u, 4294967295u), uint3(4294967040u, 4294967295u, 1u)), uint3(4294967040u, 4294967295u, 4294967295u));
            TestUtils.AreEqual(max(uint3(4294967295u, 4294967295u, 4294967295u), uint3(4294967295u, 4294967295u, 4294967295u)), uint3(4294967295u, 4294967295u, 4294967295u));
        }

        [TestCompiler]
        public void max_uint4()
        {
            TestUtils.AreEqual(max(uint4(1234u, 3456u, 4294967040u, 7u), uint4(3456u, 1234u, 7u, 4294967040u)), uint4(3456u, 3456u, 4294967040u, 4294967040u));
            TestUtils.AreEqual(max(uint4(1u, 4294967295u, 4294967295u, 4294967295u), uint4(4294967295u, 1u, 4294967295u, 4294967295u)), uint4(4294967295u, 4294967295u, 4294967295u, 4294967295u));
        }

        [TestCompiler]
        public void max_long()
        {
            TestUtils.AreEqual(max(-9223372036854775808L, -9223372036854775808L), -9223372036854775808L);
            TestUtils.AreEqual(max(-9223372036854775808L, -1L), -1L);
            TestUtils.AreEqual(max(-1L, -9223372036854775808L), -1L);
            TestUtils.AreEqual(max(-1234L, -3456L), -1234L);
            TestUtils.AreEqual(max(-3456L, -1234L), -1234L);
            TestUtils.AreEqual(max(-1234L, 3456L), 3456L);
            TestUtils.AreEqual(max(3456L, -1234L), 3456L);
            TestUtils.AreEqual(max(1234L, 3456L), 3456L);
            TestUtils.AreEqual(max(3456L, 1234L), 3456L);
            TestUtils.AreEqual(max(1L, 9223372036854775807L), 9223372036854775807L);
            TestUtils.AreEqual(max(9223372036854775807L, 1L), 9223372036854775807L);
            TestUtils.AreEqual(max(9223372036854775807L, -9223372036854775808L), 9223372036854775807L);
            TestUtils.AreEqual(max(9223372036854775807L, 9223372036854775807L), 9223372036854775807L);
        }

        [TestCompiler]
        public void max_ulong()
        {
            TestUtils.AreEqual(max(1234UL, 3456UL), 3456UL);
            TestUtils.AreEqual(max(3456UL, 1234UL), 3456UL);
            TestUtils.AreEqual(max(18446744073709551360UL, 7UL), 18446744073709551360UL);
            TestUtils.AreEqual(max(7UL, 18446744073709551360UL), 18446744073709551360UL);
            TestUtils.AreEqual(max(1UL, 18446744073709551615UL), 18446744073709551615UL);
            TestUtils.AreEqual(max(18446744073709551615UL, 1UL), 18446744073709551615UL);
            TestUtils.AreEqual(max(18446744073709551615UL, 18446744073709551615UL), 18446744073709551615UL);
        }

        [TestCompiler]
        public void max_float()
        {
            TestUtils.AreEqual(max(float.NegativeInfinity, float.NegativeInfinity), float.NegativeInfinity);
            TestUtils.AreEqual(max(float.NegativeInfinity, -1f), -1f);
            TestUtils.AreEqual(max(-1f, float.NegativeInfinity), -1f);
            TestUtils.AreEqual(max(-1234.56f, -3456.7f), -1234.56f);
            TestUtils.AreEqual(max(-3456.7f, -1234.56f), -1234.56f);
            TestUtils.AreEqual(max(-1234.56f, 3456.7f), 3456.7f);
            TestUtils.AreEqual(max(3456.7f, -1234.56f), 3456.7f);
            TestUtils.AreEqual(max(1234.56f, 3456.7f), 3456.7f);
            TestUtils.AreEqual(max(3456.7f, 1234.56f), 3456.7f);
            TestUtils.AreEqual(max(1f, float.PositiveInfinity), float.PositiveInfinity);
            TestUtils.AreEqual(max(float.PositiveInfinity, 1f), float.PositiveInfinity);
            TestUtils.AreEqual(max(float.PositiveInfinity, float.NegativeInfinity), float.PositiveInfinity);
            TestUtils.AreEqual(max(float.PositiveInfinity, float.PositiveInfinity), float.PositiveInfinity);
            TestUtils.AreEqual(max(float.NaN, 2.3f), 2.3f);
            TestUtils.AreEqual(max(2.3f, float.NaN), 2.3f);
            TestUtils.AreEqual(max(float.NaN, float.NaN), float.NaN);
        }

        [TestCompiler]
        public void max_float2()
        {
            TestUtils.AreEqual(max(float2(float.NegativeInfinity, float.NegativeInfinity), float2(float.NegativeInfinity, -1f)), float2(float.NegativeInfinity, -1f));
            TestUtils.AreEqual(max(float2(-1f, -1234.56f), float2(float.NegativeInfinity, -3456.7f)), float2(-1f, -1234.56f));
            TestUtils.AreEqual(max(float2(-3456.7f, -1234.56f), float2(-1234.56f, 3456.7f)), float2(-1234.56f, 3456.7f));
            TestUtils.AreEqual(max(float2(3456.7f, 1234.56f), float2(-1234.56f, 3456.7f)), float2(3456.7f, 3456.7f));
            TestUtils.AreEqual(max(float2(3456.7f, 1f), float2(1234.56f, float.PositiveInfinity)), float2(3456.7f, float.PositiveInfinity));
            TestUtils.AreEqual(max(float2(float.PositiveInfinity, float.PositiveInfinity), float2(1f, float.NegativeInfinity)), float2(float.PositiveInfinity, float.PositiveInfinity));
            TestUtils.AreEqual(max(float2(float.PositiveInfinity, float.NaN), float2(float.PositiveInfinity, 2.3f)), float2(float.PositiveInfinity, 2.3f));
            TestUtils.AreEqual(max(float2(2.3f, float.NaN), float2(float.NaN, float.NaN)), float2(2.3f, float.NaN));
        }

        [TestCompiler]
        public void max_float3()
        {
            TestUtils.AreEqual(max(float3(float.NegativeInfinity, float.NegativeInfinity, -1f), float3(float.NegativeInfinity, -1f, float.NegativeInfinity)), float3(float.NegativeInfinity, -1f, -1f));
            TestUtils.AreEqual(max(float3(-1234.56f, -3456.7f, -1234.56f), float3(-3456.7f, -1234.56f, 3456.7f)), float3(-1234.56f, -1234.56f, 3456.7f));
            TestUtils.AreEqual(max(float3(3456.7f, 1234.56f, 3456.7f), float3(-1234.56f, 3456.7f, 1234.56f)), float3(3456.7f, 3456.7f, 3456.7f));
            TestUtils.AreEqual(max(float3(1f, float.PositiveInfinity, float.PositiveInfinity), float3(float.PositiveInfinity, 1f, float.NegativeInfinity)), float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity));
            TestUtils.AreEqual(max(float3(float.PositiveInfinity, float.NaN, 2.3f), float3(float.PositiveInfinity, 2.3f, float.NaN)), float3(float.PositiveInfinity, 2.3f, 2.3f));
            TestUtils.AreEqual(max(float3(float.NaN, float.NaN, float.NaN), float3(float.NaN, float.NaN, float.NaN)), float3(float.NaN, float.NaN, float.NaN));
        }

        [TestCompiler]
        public void max_float4()
        {
            TestUtils.AreEqual(max(float4(float.NegativeInfinity, float.NegativeInfinity, -1f, -1234.56f), float4(float.NegativeInfinity, -1f, float.NegativeInfinity, -3456.7f)), float4(float.NegativeInfinity, -1f, -1f, -1234.56f));
            TestUtils.AreEqual(max(float4(-3456.7f, -1234.56f, 3456.7f, 1234.56f), float4(-1234.56f, 3456.7f, -1234.56f, 3456.7f)), float4(-1234.56f, 3456.7f, 3456.7f, 3456.7f));
            TestUtils.AreEqual(max(float4(3456.7f, 1f, float.PositiveInfinity, float.PositiveInfinity), float4(1234.56f, float.PositiveInfinity, 1f, float.NegativeInfinity)), float4(3456.7f, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity));
            TestUtils.AreEqual(max(float4(float.PositiveInfinity, float.NaN, 2.3f, float.NaN), float4(float.PositiveInfinity, 2.3f, float.NaN, float.NaN)), float4(float.PositiveInfinity, 2.3f, 2.3f, float.NaN));
        }

        [TestCompiler]
        public void max_double()
        {
            TestUtils.AreEqual(max(double.NegativeInfinity, double.NegativeInfinity), double.NegativeInfinity);
            TestUtils.AreEqual(max(double.NegativeInfinity, -1.0), -1.0);
            TestUtils.AreEqual(max(-1.0, double.NegativeInfinity), -1.0);
            TestUtils.AreEqual(max(-1234.56, -3456.7), -1234.56);
            TestUtils.AreEqual(max(-3456.7, -1234.56), -1234.56);
            TestUtils.AreEqual(max(-1234.56, 3456.7), 3456.7);
            TestUtils.AreEqual(max(3456.7, -1234.56), 3456.7);
            TestUtils.AreEqual(max(1234.56, 3456.7), 3456.7);
            TestUtils.AreEqual(max(3456.7, 1234.56), 3456.7);
            TestUtils.AreEqual(max(1.0, double.PositiveInfinity), double.PositiveInfinity);
            TestUtils.AreEqual(max(double.PositiveInfinity, 1.0), double.PositiveInfinity);
            TestUtils.AreEqual(max(double.PositiveInfinity, double.NegativeInfinity), double.PositiveInfinity);
            TestUtils.AreEqual(max(double.PositiveInfinity, double.PositiveInfinity), double.PositiveInfinity);
            TestUtils.AreEqual(max(double.NaN, 2.3), 2.3);
            TestUtils.AreEqual(max(2.3, double.NaN), 2.3);
            TestUtils.AreEqual(max(double.NaN, double.NaN), double.NaN);
        }

        [TestCompiler]
        public void max_double2()
        {
            TestUtils.AreEqual(max(double2(double.NegativeInfinity, double.NegativeInfinity), double2(double.NegativeInfinity, -1.0)), double2(double.NegativeInfinity, -1.0));
            TestUtils.AreEqual(max(double2(-1.0, -1234.56), double2(double.NegativeInfinity, -3456.7)), double2(-1.0, -1234.56));
            TestUtils.AreEqual(max(double2(-3456.7, -1234.56), double2(-1234.56, 3456.7)), double2(-1234.56, 3456.7));
            TestUtils.AreEqual(max(double2(3456.7, 1234.56), double2(-1234.56, 3456.7)), double2(3456.7, 3456.7));
            TestUtils.AreEqual(max(double2(3456.7, 1.0), double2(1234.56, double.PositiveInfinity)), double2(3456.7, double.PositiveInfinity));
            TestUtils.AreEqual(max(double2(double.PositiveInfinity, double.PositiveInfinity), double2(1.0, double.NegativeInfinity)), double2(double.PositiveInfinity, double.PositiveInfinity));
            TestUtils.AreEqual(max(double2(double.PositiveInfinity, double.NaN), double2(double.PositiveInfinity, 2.3)), double2(double.PositiveInfinity, 2.3));
            TestUtils.AreEqual(max(double2(2.3, double.NaN), double2(double.NaN, double.NaN)), double2(2.3, double.NaN));
        }

        [TestCompiler]
        public void max_double3()
        {
            TestUtils.AreEqual(max(double3(double.NegativeInfinity, double.NegativeInfinity, -1.0), double3(double.NegativeInfinity, -1.0, double.NegativeInfinity)), double3(double.NegativeInfinity, -1.0, -1.0));
            TestUtils.AreEqual(max(double3(-1234.56, -3456.7, -1234.56), double3(-3456.7, -1234.56, 3456.7)), double3(-1234.56, -1234.56, 3456.7));
            TestUtils.AreEqual(max(double3(3456.7, 1234.56, 3456.7), double3(-1234.56, 3456.7, 1234.56)), double3(3456.7, 3456.7, 3456.7));
            TestUtils.AreEqual(max(double3(1.0, double.PositiveInfinity, double.PositiveInfinity), double3(double.PositiveInfinity, 1.0, double.NegativeInfinity)), double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity));
            TestUtils.AreEqual(max(double3(double.PositiveInfinity, double.NaN, 2.3), double3(double.PositiveInfinity, 2.3, double.NaN)), double3(double.PositiveInfinity, 2.3, 2.3));
            TestUtils.AreEqual(max(double3(double.NaN, double.NaN, double.NaN), double3(double.NaN, double.NaN, double.NaN)), double3(double.NaN, double.NaN, double.NaN));
        }

        [TestCompiler]
        public void max_double4()
        {
            TestUtils.AreEqual(max(double4(double.NegativeInfinity, double.NegativeInfinity, -1.0, -1234.56), double4(double.NegativeInfinity, -1.0, double.NegativeInfinity, -3456.7)), double4(double.NegativeInfinity, -1.0, -1.0, -1234.56));
            TestUtils.AreEqual(max(double4(-3456.7, -1234.56, 3456.7, 1234.56), double4(-1234.56, 3456.7, -1234.56, 3456.7)), double4(-1234.56, 3456.7, 3456.7, 3456.7));
            TestUtils.AreEqual(max(double4(3456.7, 1.0, double.PositiveInfinity, double.PositiveInfinity), double4(1234.56, double.PositiveInfinity, 1.0, double.NegativeInfinity)), double4(3456.7, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity));
            TestUtils.AreEqual(max(double4(double.PositiveInfinity, double.NaN, 2.3, double.NaN), double4(double.PositiveInfinity, 2.3, double.NaN, double.NaN)), double4(double.PositiveInfinity, 2.3, 2.3, double.NaN));
        }

        [TestCompiler]
        public void smoothstep_float()
        {
            TestUtils.AreEqual(smoothstep(-123.45f, 345.6f, float.NegativeInfinity), 0f, 8, false);
            TestUtils.AreEqual(smoothstep(-123.45f, 345.6f, -200f), 0f, 8, false);
            TestUtils.AreEqual(smoothstep(-123.45f, 345.6f, -100f), 0.00724848127f, 8, false);
            TestUtils.AreEqual(smoothstep(-123.45f, 345.6f, 400f), 1f, 8, false);
            TestUtils.AreEqual(smoothstep(-123.45f, 345.6f, float.PositiveInfinity), 1f, 8, false);
            TestUtils.AreEqual(smoothstep(-123.45f, 345.6f, float.NaN), 1f, 8, false);
            TestUtils.AreEqual(smoothstep(345.6f, -123.45f, float.NegativeInfinity), 1f, 8, false);
            TestUtils.AreEqual(smoothstep(345.6f, -123.45f, -200f), 1f, 8, false);
            TestUtils.AreEqual(smoothstep(345.6f, -123.45f, -100f), 0.992751539f, 8, false);
            TestUtils.AreEqual(smoothstep(345.6f, -123.45f, 400f), 0f, 8, false);
            TestUtils.AreEqual(smoothstep(345.6f, -123.45f, float.PositiveInfinity), 0f, 8, false);
            TestUtils.AreEqual(smoothstep(345.6f, -123.45f, float.NaN), 1f, 8, false);
        }

        [TestCompiler]
        public void smoothstep_float2()
        {
            TestUtils.AreEqual(smoothstep(float2(-123.45f, -123.45f), float2(345.6f, 345.6f), float2(float.NegativeInfinity, -200f)), float2(0f, 0f), 8, false);
            TestUtils.AreEqual(smoothstep(float2(-123.45f, -123.45f), float2(345.6f, 345.6f), float2(-100f, 400f)), float2(0.00724848127f, 1f), 8, false);
            TestUtils.AreEqual(smoothstep(float2(-123.45f, -123.45f), float2(345.6f, 345.6f), float2(float.PositiveInfinity, float.NaN)), float2(1f, 1f), 8, false);
            TestUtils.AreEqual(smoothstep(float2(345.6f, 345.6f), float2(-123.45f, -123.45f), float2(float.NegativeInfinity, -200f)), float2(1f, 1f), 8, false);
            TestUtils.AreEqual(smoothstep(float2(345.6f, 345.6f), float2(-123.45f, -123.45f), float2(-100f, 400f)), float2(0.992751539f, 0f), 8, false);
            TestUtils.AreEqual(smoothstep(float2(345.6f, 345.6f), float2(-123.45f, -123.45f), float2(float.PositiveInfinity, float.NaN)), float2(0f, 1f), 8, false);
        }

        [TestCompiler]
        public void smoothstep_float3()
        {
            TestUtils.AreEqual(smoothstep(float3(-123.45f, -123.45f, -123.45f), float3(345.6f, 345.6f, 345.6f), float3(float.NegativeInfinity, -200f, -100f)), float3(0f, 0f, 0.00724848127f), 8, false);
            TestUtils.AreEqual(smoothstep(float3(-123.45f, -123.45f, -123.45f), float3(345.6f, 345.6f, 345.6f), float3(400f, float.PositiveInfinity, float.NaN)), float3(1f, 1f, 1f), 8, false);
            TestUtils.AreEqual(smoothstep(float3(345.6f, 345.6f, 345.6f), float3(-123.45f, -123.45f, -123.45f), float3(float.NegativeInfinity, -200f, -100f)), float3(1f, 1f, 0.992751539f), 8, false);
            TestUtils.AreEqual(smoothstep(float3(345.6f, 345.6f, 345.6f), float3(-123.45f, -123.45f, -123.45f), float3(400f, float.PositiveInfinity, float.NaN)), float3(0f, 0f, 1f), 8, false);
        }

        [TestCompiler]
        public void smoothstep_float4()
        {
            TestUtils.AreEqual(smoothstep(float4(-123.45f, -123.45f, -123.45f, -123.45f), float4(345.6f, 345.6f, 345.6f, 345.6f), float4(float.NegativeInfinity, -200f, -100f, 400f)), float4(0f, 0f, 0.00724848127f, 1f), 8, false);
            TestUtils.AreEqual(smoothstep(float4(-123.45f, -123.45f, 345.6f, 345.6f), float4(345.6f, 345.6f, -123.45f, -123.45f), float4(float.PositiveInfinity, float.NaN, float.NegativeInfinity, -200f)), float4(1f, 1f, 1f, 1f), 8, false);
            TestUtils.AreEqual(smoothstep(float4(345.6f, 345.6f, 345.6f, 345.6f), float4(-123.45f, -123.45f, -123.45f, -123.45f), float4(-100f, 400f, float.PositiveInfinity, float.NaN)), float4(0.992751539f, 0f, 0f, 1f), 8, false);
        }

        [TestCompiler]
        public void smoothstep_double()
        {
            TestUtils.AreEqual(smoothstep(-123.45, 345.6, double.NegativeInfinity), 0.0, 8, false);
            TestUtils.AreEqual(smoothstep(-123.45, 345.6, -200.0), 0.0, 8, false);
            TestUtils.AreEqual(smoothstep(-123.45, 345.6, -100.0), 0.0072484810488798995, 8, false);
            TestUtils.AreEqual(smoothstep(-123.45, 345.6, 400.0), 1.0, 8, false);
            TestUtils.AreEqual(smoothstep(-123.45, 345.6, double.PositiveInfinity), 1.0, 8, false);
            TestUtils.AreEqual(smoothstep(-123.45, 345.6, double.NaN), 1.0, 8, false);
            TestUtils.AreEqual(smoothstep(345.6, -123.45, double.NegativeInfinity), 1.0, 8, false);
            TestUtils.AreEqual(smoothstep(345.6, -123.45, -200.0), 1.0, 8, false);
            TestUtils.AreEqual(smoothstep(345.6, -123.45, -100.0), 0.99275151895112013, 8, false);
            TestUtils.AreEqual(smoothstep(345.6, -123.45, 400.0), 0.0, 8, false);
            TestUtils.AreEqual(smoothstep(345.6, -123.45, double.PositiveInfinity), 0.0, 8, false);
            TestUtils.AreEqual(smoothstep(345.6, -123.45, double.NaN), 1.0, 8, false);
        }

        [TestCompiler]
        public void smoothstep_double2()
        {
            TestUtils.AreEqual(smoothstep(double2(-123.45, -123.45), double2(345.6, 345.6), double2(double.NegativeInfinity, -200.0)), double2(0.0, 0.0), 8, false);
            TestUtils.AreEqual(smoothstep(double2(-123.45, -123.45), double2(345.6, 345.6), double2(-100.0, 400.0)), double2(0.0072484810488798995, 1.0), 8, false);
            TestUtils.AreEqual(smoothstep(double2(-123.45, -123.45), double2(345.6, 345.6), double2(double.PositiveInfinity, double.NaN)), double2(1.0, 1.0), 8, false);
            TestUtils.AreEqual(smoothstep(double2(345.6, 345.6), double2(-123.45, -123.45), double2(double.NegativeInfinity, -200.0)), double2(1.0, 1.0), 8, false);
            TestUtils.AreEqual(smoothstep(double2(345.6, 345.6), double2(-123.45, -123.45), double2(-100.0, 400.0)), double2(0.99275151895112013, 0.0), 8, false);
            TestUtils.AreEqual(smoothstep(double2(345.6, 345.6), double2(-123.45, -123.45), double2(double.PositiveInfinity, double.NaN)), double2(0.0, 1.0), 8, false);
        }

        [TestCompiler]
        public void smoothstep_double3()
        {
            TestUtils.AreEqual(smoothstep(double3(-123.45, -123.45, -123.45), double3(345.6, 345.6, 345.6), double3(double.NegativeInfinity, -200.0, -100.0)), double3(0.0, 0.0, 0.0072484810488798995), 8, false);
            TestUtils.AreEqual(smoothstep(double3(-123.45, -123.45, -123.45), double3(345.6, 345.6, 345.6), double3(400.0, double.PositiveInfinity, double.NaN)), double3(1.0, 1.0, 1.0), 8, false);
            TestUtils.AreEqual(smoothstep(double3(345.6, 345.6, 345.6), double3(-123.45, -123.45, -123.45), double3(double.NegativeInfinity, -200.0, -100.0)), double3(1.0, 1.0, 0.99275151895112013), 8, false);
            TestUtils.AreEqual(smoothstep(double3(345.6, 345.6, 345.6), double3(-123.45, -123.45, -123.45), double3(400.0, double.PositiveInfinity, double.NaN)), double3(0.0, 0.0, 1.0), 8, false);
        }

        [TestCompiler]
        public void smoothstep_double4()
        {
            TestUtils.AreEqual(smoothstep(double4(-123.45, -123.45, -123.45, -123.45), double4(345.6, 345.6, 345.6, 345.6), double4(double.NegativeInfinity, -200.0, -100.0, 400.0)), double4(0.0, 0.0, 0.0072484810488798995, 1.0), 8, false);
            TestUtils.AreEqual(smoothstep(double4(-123.45, -123.45, 345.6, 345.6), double4(345.6, 345.6, -123.45, -123.45), double4(double.PositiveInfinity, double.NaN, double.NegativeInfinity, -200.0)), double4(1.0, 1.0, 1.0, 1.0), 8, false);
            TestUtils.AreEqual(smoothstep(double4(345.6, 345.6, 345.6, 345.6), double4(-123.45, -123.45, -123.45, -123.45), double4(-100.0, 400.0, double.PositiveInfinity, double.NaN)), double4(0.99275151895112013, 0.0, 0.0, 1.0), 8, false);
        }

        [TestCompiler]
        public void mad_int()
        {
            TestUtils.AreEqual(mad(1234, 5678, 91011), 7097663);
            TestUtils.AreEqual(mad(1234, 5678, -91011), 6915641);
            TestUtils.AreEqual(mad(1234, -5678, 91011), -6915641);
            TestUtils.AreEqual(mad(1234, -5678, -91011), -7097663);
            TestUtils.AreEqual(mad(-1234, 5678, 91011), -6915641);
            TestUtils.AreEqual(mad(-1234, 5678, -91011), -7097663);
            TestUtils.AreEqual(mad(-1234, -5678, 91011), 7097663);
            TestUtils.AreEqual(mad(-1234, -5678, -91011), 6915641);
            TestUtils.AreEqual(mad(98765, 56789, 91011), 1313889300);
            TestUtils.AreEqual(mad(98765, 56789, -91011), 1313707278);
            TestUtils.AreEqual(mad(98765, -56789, 91011), -1313707278);
            TestUtils.AreEqual(mad(98765, -56789, -91011), -1313889300);
            TestUtils.AreEqual(mad(-98765, 56789, 91011), -1313707278);
            TestUtils.AreEqual(mad(-98765, 56789, -91011), -1313889300);
            TestUtils.AreEqual(mad(-98765, -56789, 91011), 1313889300);
            TestUtils.AreEqual(mad(-98765, -56789, -91011), 1313707278);
        }

        [TestCompiler]
        public void mad_int2()
        {
            TestUtils.AreEqual(mad(int2(1234, 1234), int2(5678, 5678), int2(91011, -91011)), int2(7097663, 6915641));
            TestUtils.AreEqual(mad(int2(1234, 1234), int2(-5678, -5678), int2(91011, -91011)), int2(-6915641, -7097663));
            TestUtils.AreEqual(mad(int2(-1234, -1234), int2(5678, 5678), int2(91011, -91011)), int2(-6915641, -7097663));
            TestUtils.AreEqual(mad(int2(-1234, -1234), int2(-5678, -5678), int2(91011, -91011)), int2(7097663, 6915641));
            TestUtils.AreEqual(mad(int2(98765, 98765), int2(56789, 56789), int2(91011, -91011)), int2(1313889300, 1313707278));
            TestUtils.AreEqual(mad(int2(98765, 98765), int2(-56789, -56789), int2(91011, -91011)), int2(-1313707278, -1313889300));
            TestUtils.AreEqual(mad(int2(-98765, -98765), int2(56789, 56789), int2(91011, -91011)), int2(-1313707278, -1313889300));
            TestUtils.AreEqual(mad(int2(-98765, -98765), int2(-56789, -56789), int2(91011, -91011)), int2(1313889300, 1313707278));
        }

        [TestCompiler]
        public void mad_int3()
        {
            TestUtils.AreEqual(mad(int3(1234, 1234, 1234), int3(5678, 5678, -5678), int3(91011, -91011, 91011)), int3(7097663, 6915641, -6915641));
            TestUtils.AreEqual(mad(int3(1234, -1234, -1234), int3(-5678, 5678, 5678), int3(-91011, 91011, -91011)), int3(-7097663, -6915641, -7097663));
            TestUtils.AreEqual(mad(int3(-1234, -1234, 98765), int3(-5678, -5678, 56789), int3(91011, -91011, 91011)), int3(7097663, 6915641, 1313889300));
            TestUtils.AreEqual(mad(int3(98765, 98765, 98765), int3(56789, -56789, -56789), int3(-91011, 91011, -91011)), int3(1313707278, -1313707278, -1313889300));
            TestUtils.AreEqual(mad(int3(-98765, -98765, -98765), int3(56789, 56789, -56789), int3(91011, -91011, 91011)), int3(-1313707278, -1313889300, 1313889300));
            TestUtils.AreEqual(mad(int3(-98765, -98765, -98765), int3(-56789, -56789, -56789), int3(-91011, -91011, -91011)), int3(1313707278, 1313707278, 1313707278));
        }

        [TestCompiler]
        public void mad_int4()
        {
            TestUtils.AreEqual(mad(int4(1234, 1234, 1234, 1234), int4(5678, 5678, -5678, -5678), int4(91011, -91011, 91011, -91011)), int4(7097663, 6915641, -6915641, -7097663));
            TestUtils.AreEqual(mad(int4(-1234, -1234, -1234, -1234), int4(5678, 5678, -5678, -5678), int4(91011, -91011, 91011, -91011)), int4(-6915641, -7097663, 7097663, 6915641));
            TestUtils.AreEqual(mad(int4(98765, 98765, 98765, 98765), int4(56789, 56789, -56789, -56789), int4(91011, -91011, 91011, -91011)), int4(1313889300, 1313707278, -1313707278, -1313889300));
            TestUtils.AreEqual(mad(int4(-98765, -98765, -98765, -98765), int4(56789, 56789, -56789, -56789), int4(91011, -91011, 91011, -91011)), int4(-1313707278, -1313889300, 1313889300, 1313707278));
        }

        [TestCompiler]
        public void mad_uint()
        {
            TestUtils.AreEqual(mad(1234u, 5678u, 91011u), 7097663u);
            TestUtils.AreEqual(mad(98765u, 56789u, 91011u), 1313889300u);
        }

        [TestCompiler]
        public void mad_uint2()
        {
            TestUtils.AreEqual(mad(uint2(1234u, 98765u), uint2(5678u, 56789u), uint2(91011u, 91011u)), uint2(7097663u, 1313889300u));
        }

        [TestCompiler]
        public void mad_uint3()
        {
            TestUtils.AreEqual(mad(uint3(1234u, 98765u, 98765u), uint3(5678u, 56789u, 56789u), uint3(91011u, 91011u, 91011u)), uint3(7097663u, 1313889300u, 1313889300u));
        }

        [TestCompiler]
        public void mad_uint4()
        {
            TestUtils.AreEqual(mad(uint4(1234u, 98765u, 98765u, 98765u), uint4(5678u, 56789u, 56789u, 56789u), uint4(91011u, 91011u, 91011u, 91011u)), uint4(7097663u, 1313889300u, 1313889300u, 1313889300u));
        }

        [TestCompiler]
        public void mad_long()
        {
            TestUtils.AreEqual(mad(1234L, 5678L, 91011L), 7097663L);
            TestUtils.AreEqual(mad(1234L, 5678L, -91011L), 6915641L);
            TestUtils.AreEqual(mad(1234L, -5678L, 91011L), -6915641L);
            TestUtils.AreEqual(mad(1234L, -5678L, -91011L), -7097663L);
            TestUtils.AreEqual(mad(-1234L, 5678L, 91011L), -6915641L);
            TestUtils.AreEqual(mad(-1234L, 5678L, -91011L), -7097663L);
            TestUtils.AreEqual(mad(-1234L, -5678L, 91011L), 7097663L);
            TestUtils.AreEqual(mad(-1234L, -5678L, -91011L), 6915641L);
            TestUtils.AreEqual(mad(9876543210L, 5678901234L, 9101112134L), 747681210895778426L);
            TestUtils.AreEqual(mad(9876543210L, 5678901234L, -9101112134L), 747681192693554158L);
            TestUtils.AreEqual(mad(9876543210L, -5678901234L, 9101112134L), -747681192693554158L);
            TestUtils.AreEqual(mad(9876543210L, -5678901234L, -9101112134L), -747681210895778426L);
            TestUtils.AreEqual(mad(-9876543210L, 5678901234L, 9101112134L), -747681192693554158L);
            TestUtils.AreEqual(mad(-9876543210L, 5678901234L, -9101112134L), -747681210895778426L);
            TestUtils.AreEqual(mad(-9876543210L, -5678901234L, 9101112134L), 747681210895778426L);
            TestUtils.AreEqual(mad(-9876543210L, -5678901234L, -9101112134L), 747681192693554158L);
        }

        [TestCompiler]
        public void mad_ulong()
        {
            TestUtils.AreEqual(mad(1234UL, 5678UL, 91011UL), 7097663L);
            TestUtils.AreEqual(mad(9876543210UL, 5678901234UL, 9101112134UL), 747681210895778426L);
        }

        [TestCompiler]
        public void mad_float()
        {
            TestUtils.AreEqual(mad(-123.45f, 345.6f, 4.321f), -42660f, 1, false);
            TestUtils.AreEqual(mad(float.NaN, 345.6f, 4.321f), float.NaN, 1, false);
            TestUtils.AreEqual(mad(-123.45f, float.NaN, 4.321f), float.NaN, 1, false);
            TestUtils.AreEqual(mad(-123.45f, 345.6f, float.NaN), float.NaN, 1, false);
        }

        [TestCompiler]
        public void mad_float2()
        {
            TestUtils.AreEqual(mad(float2(-123.45f, float.NaN), float2(345.6f, 345.6f), float2(4.321f, 4.321f)), float2(-42660f, float.NaN), 1, false);
            TestUtils.AreEqual(mad(float2(-123.45f, -123.45f), float2(float.NaN, 345.6f), float2(4.321f, float.NaN)), float2(float.NaN, float.NaN), 1, false);
        }

        [TestCompiler]
        public void mad_float3()
        {
            TestUtils.AreEqual(mad(float3(-123.45f, float.NaN, -123.45f), float3(345.6f, 345.6f, float.NaN), float3(4.321f, 4.321f, 4.321f)), float3(-42660f, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(mad(float3(-123.45f, -123.45f, -123.45f), float3(345.6f, 345.6f, 345.6f), float3(float.NaN, float.NaN, float.NaN)), float3(float.NaN, float.NaN, float.NaN), 1, false);
        }

        [TestCompiler]
        public void mad_float4()
        {
            TestUtils.AreEqual(mad(float4(-123.45f, float.NaN, -123.45f, -123.45f), float4(345.6f, 345.6f, float.NaN, 345.6f), float4(4.321f, 4.321f, 4.321f, float.NaN)), float4(-42660f, float.NaN, float.NaN, float.NaN), 1, false);
        }

        [TestCompiler]
        public void mad_double()
        {
            TestUtils.AreEqual(mad(-123.45, 345.6, 4.321), -42659.999, 1, false);
            TestUtils.AreEqual(mad(double.NaN, 345.6, 4.321), double.NaN, 1, false);
            TestUtils.AreEqual(mad(-123.45, double.NaN, 4.321), double.NaN, 1, false);
            TestUtils.AreEqual(mad(-123.45, 345.6, double.NaN), double.NaN, 1, false);
        }

        [TestCompiler]
        public void mad_double2()
        {
            TestUtils.AreEqual(mad(double2(-123.45, double.NaN), double2(345.6, 345.6), double2(4.321, 4.321)), double2(-42659.999, double.NaN), 1, false);
            TestUtils.AreEqual(mad(double2(-123.45, -123.45), double2(double.NaN, 345.6), double2(4.321, double.NaN)), double2(double.NaN, double.NaN), 1, false);
        }

        [TestCompiler]
        public void mad_double3()
        {
            TestUtils.AreEqual(mad(double3(-123.45, double.NaN, -123.45), double3(345.6, 345.6, double.NaN), double3(4.321, 4.321, 4.321)), double3(-42659.999, double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(mad(double3(-123.45, -123.45, -123.45), double3(345.6, 345.6, 345.6), double3(double.NaN, double.NaN, double.NaN)), double3(double.NaN, double.NaN, double.NaN), 1, false);
        }

        [TestCompiler]
        public void mad_double4()
        {
            TestUtils.AreEqual(mad(double4(-123.45, double.NaN, -123.45, -123.45), double4(345.6, 345.6, double.NaN, 345.6), double4(4.321, 4.321, 4.321, double.NaN)), double4(-42659.999, double.NaN, double.NaN, double.NaN), 1, false);
        }

        [TestCompiler]
        public void fmod_float()
        {
            TestUtils.AreEqual(fmod(float.NegativeInfinity, float.NegativeInfinity), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(-323.4f, float.NegativeInfinity), -323.4f, 1, false);
            TestUtils.AreEqual(fmod(-0.0f, float.NegativeInfinity), -0.0f, 1, false);
            TestUtils.AreEqual(fmod(0f, float.NegativeInfinity), 0f, 1, false);
            TestUtils.AreEqual(fmod(323.4f, float.NegativeInfinity), 323.4f, 1, false);
            TestUtils.AreEqual(fmod(float.PositiveInfinity, float.NegativeInfinity), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(float.NaN, float.NegativeInfinity), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(float.NegativeInfinity, -123.6f), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(-323.4f, -123.6f), -76.2f, 1, false);
            TestUtils.AreEqual(fmod(-0.0f, -123.6f), -0.0f, 1, false);
            TestUtils.AreEqual(fmod(0f, -123.6f), 0f, 1, false);
            TestUtils.AreEqual(fmod(323.4f, -123.6f), 76.2f, 1, false);
            TestUtils.AreEqual(fmod(float.PositiveInfinity, -123.6f), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(float.NaN, -123.6f), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(float.NegativeInfinity, -0.0f), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(-323.4f, -0.0f), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(-0.0f, -0.0f), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(0f, -0.0f), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(323.4f, -0.0f), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(float.PositiveInfinity, -0.0f), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(float.NaN, -0.0f), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(float.NegativeInfinity, 0f), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(-323.4f, 0f), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(-0.0f, 0f), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(0f, 0f), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(323.4f, 0f), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(float.PositiveInfinity, 0f), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(float.NaN, 0f), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(float.NegativeInfinity, 123.6f), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(-323.4f, 123.6f), -76.2f, 1, false);
            TestUtils.AreEqual(fmod(-0.0f, 123.6f), -0.0f, 1, false);
            TestUtils.AreEqual(fmod(0f, 123.6f), 0f, 1, false);
            TestUtils.AreEqual(fmod(323.4f, 123.6f), 76.2f, 1, false);
            TestUtils.AreEqual(fmod(float.PositiveInfinity, 123.6f), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(float.NaN, 123.6f), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(float.NegativeInfinity, float.PositiveInfinity), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(-323.4f, float.PositiveInfinity), -323.4f, 1, false);
            TestUtils.AreEqual(fmod(-0.0f, float.PositiveInfinity), -0.0f, 1, false);
            TestUtils.AreEqual(fmod(0f, float.PositiveInfinity), 0f, 1, false);
            TestUtils.AreEqual(fmod(323.4f, float.PositiveInfinity), 323.4f, 1, false);
            TestUtils.AreEqual(fmod(float.PositiveInfinity, float.PositiveInfinity), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(float.NaN, float.PositiveInfinity), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(float.NegativeInfinity, float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(-323.4f, float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(-0.0f, float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(0f, float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(323.4f, float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(float.PositiveInfinity, float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(fmod(float.NaN, float.NaN), float.NaN, 1, false);
        }

        [TestCompiler]
        public void fmod_float2()
        {
            TestUtils.AreEqual(fmod(float2(float.NegativeInfinity, -323.4f), float2(float.NegativeInfinity, float.NegativeInfinity)), float2(float.NaN, -323.4f), 1, false);
            TestUtils.AreEqual(fmod(float2(-0.0f, 0f), float2(float.NegativeInfinity, float.NegativeInfinity)), float2(-0.0f, 0f), 1, false);
            TestUtils.AreEqual(fmod(float2(323.4f, float.PositiveInfinity), float2(float.NegativeInfinity, float.NegativeInfinity)), float2(323.4f, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float2(float.NaN, float.NegativeInfinity), float2(float.NegativeInfinity, -123.6f)), float2(float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float2(-323.4f, -0.0f), float2(-123.6f, -123.6f)), float2(-76.2f, -0.0f), 1, false);
            TestUtils.AreEqual(fmod(float2(0f, 323.4f), float2(-123.6f, -123.6f)), float2(0f, 76.2f), 1, false);
            TestUtils.AreEqual(fmod(float2(float.PositiveInfinity, float.NaN), float2(-123.6f, -123.6f)), float2(float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float2(float.NegativeInfinity, -323.4f), float2(-0.0f, -0.0f)), float2(float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float2(-0.0f, 0f), float2(-0.0f, -0.0f)), float2(float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float2(323.4f, float.PositiveInfinity), float2(-0.0f, -0.0f)), float2(float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float2(float.NaN, float.NegativeInfinity), float2(-0.0f, 0f)), float2(float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float2(-323.4f, -0.0f), float2(0f, 0f)), float2(float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float2(0f, 323.4f), float2(0f, 0f)), float2(float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float2(float.PositiveInfinity, float.NaN), float2(0f, 0f)), float2(float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float2(float.NegativeInfinity, -323.4f), float2(123.6f, 123.6f)), float2(float.NaN, -76.2f), 1, false);
            TestUtils.AreEqual(fmod(float2(-0.0f, 0f), float2(123.6f, 123.6f)), float2(-0.0f, 0f), 1, false);
            TestUtils.AreEqual(fmod(float2(323.4f, float.PositiveInfinity), float2(123.6f, 123.6f)), float2(76.2f, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float2(float.NaN, float.NegativeInfinity), float2(123.6f, float.PositiveInfinity)), float2(float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float2(-323.4f, -0.0f), float2(float.PositiveInfinity, float.PositiveInfinity)), float2(-323.4f, -0.0f), 1, false);
            TestUtils.AreEqual(fmod(float2(0f, 323.4f), float2(float.PositiveInfinity, float.PositiveInfinity)), float2(0f, 323.4f), 1, false);
            TestUtils.AreEqual(fmod(float2(float.PositiveInfinity, float.NaN), float2(float.PositiveInfinity, float.PositiveInfinity)), float2(float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float2(float.NegativeInfinity, -323.4f), float2(float.NaN, float.NaN)), float2(float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float2(-0.0f, 0f), float2(float.NaN, float.NaN)), float2(float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float2(323.4f, float.PositiveInfinity), float2(float.NaN, float.NaN)), float2(float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float2(float.NaN, float.NaN), float2(float.NaN, float.NaN)), float2(float.NaN, float.NaN), 1, false);
        }

        [TestCompiler]
        public void fmod_float3()
        {
            TestUtils.AreEqual(fmod(float3(float.NegativeInfinity, -323.4f, -0.0f), float3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity)), float3(float.NaN, -323.4f, -0.0f), 1, false);
            TestUtils.AreEqual(fmod(float3(0f, 323.4f, float.PositiveInfinity), float3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity)), float3(0f, 323.4f, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float3(float.NaN, float.NegativeInfinity, -323.4f), float3(float.NegativeInfinity, -123.6f, -123.6f)), float3(float.NaN, float.NaN, -76.2f), 1, false);
            TestUtils.AreEqual(fmod(float3(-0.0f, 0f, 323.4f), float3(-123.6f, -123.6f, -123.6f)), float3(-0.0f, 0f, 76.2f), 1, false);
            TestUtils.AreEqual(fmod(float3(float.PositiveInfinity, float.NaN, float.NegativeInfinity), float3(-123.6f, -123.6f, -0.0f)), float3(float.NaN, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float3(-323.4f, -0.0f, 0f), float3(-0.0f, -0.0f, -0.0f)), float3(float.NaN, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float3(323.4f, float.PositiveInfinity, float.NaN), float3(-0.0f, -0.0f, -0.0f)), float3(float.NaN, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float3(float.NegativeInfinity, -323.4f, -0.0f), float3(0f, 0f, 0f)), float3(float.NaN, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float3(0f, 323.4f, float.PositiveInfinity), float3(0f, 0f, 0f)), float3(float.NaN, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float3(float.NaN, float.NegativeInfinity, -323.4f), float3(0f, 123.6f, 123.6f)), float3(float.NaN, float.NaN, -76.2f), 1, false);
            TestUtils.AreEqual(fmod(float3(-0.0f, 0f, 323.4f), float3(123.6f, 123.6f, 123.6f)), float3(-0.0f, 0f, 76.2f), 1, false);
            TestUtils.AreEqual(fmod(float3(float.PositiveInfinity, float.NaN, float.NegativeInfinity), float3(123.6f, 123.6f, float.PositiveInfinity)), float3(float.NaN, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float3(-323.4f, -0.0f, 0f), float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity)), float3(-323.4f, -0.0f, 0f), 1, false);
            TestUtils.AreEqual(fmod(float3(323.4f, float.PositiveInfinity, float.NaN), float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity)), float3(323.4f, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float3(float.NegativeInfinity, -323.4f, -0.0f), float3(float.NaN, float.NaN, float.NaN)), float3(float.NaN, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float3(0f, 323.4f, float.PositiveInfinity), float3(float.NaN, float.NaN, float.NaN)), float3(float.NaN, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float3(float.NaN, float.NaN, float.NaN), float3(float.NaN, float.NaN, float.NaN)), float3(float.NaN, float.NaN, float.NaN), 1, false);
        }

        [TestCompiler]
        public void fmod_float4()
        {
            TestUtils.AreEqual(fmod(float4(float.NegativeInfinity, -323.4f, -0.0f, 0f), float4(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity)), float4(float.NaN, -323.4f, -0.0f, 0f), 1, false);
            TestUtils.AreEqual(fmod(float4(323.4f, float.PositiveInfinity, float.NaN, float.NegativeInfinity), float4(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, -123.6f)), float4(323.4f, float.NaN, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float4(-323.4f, -0.0f, 0f, 323.4f), float4(-123.6f, -123.6f, -123.6f, -123.6f)), float4(-76.2f, -0.0f, 0f, 76.2f), 1, false);
            TestUtils.AreEqual(fmod(float4(float.PositiveInfinity, float.NaN, float.NegativeInfinity, -323.4f), float4(-123.6f, -123.6f, -0.0f, -0.0f)), float4(float.NaN, float.NaN, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float4(-0.0f, 0f, 323.4f, float.PositiveInfinity), float4(-0.0f, -0.0f, -0.0f, -0.0f)), float4(float.NaN, float.NaN, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float4(float.NaN, float.NegativeInfinity, -323.4f, -0.0f), float4(-0.0f, 0f, 0f, 0f)), float4(float.NaN, float.NaN, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float4(0f, 323.4f, float.PositiveInfinity, float.NaN), float4(0f, 0f, 0f, 0f)), float4(float.NaN, float.NaN, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float4(float.NegativeInfinity, -323.4f, -0.0f, 0f), float4(123.6f, 123.6f, 123.6f, 123.6f)), float4(float.NaN, -76.2f, -0.0f, 0f), 1, false);
            TestUtils.AreEqual(fmod(float4(323.4f, float.PositiveInfinity, float.NaN, float.NegativeInfinity), float4(123.6f, 123.6f, 123.6f, float.PositiveInfinity)), float4(76.2f, float.NaN, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float4(-323.4f, -0.0f, 0f, 323.4f), float4(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity)), float4(-323.4f, -0.0f, 0f, 323.4f), 1, false);
            TestUtils.AreEqual(fmod(float4(float.PositiveInfinity, float.NaN, float.NegativeInfinity, -323.4f), float4(float.PositiveInfinity, float.PositiveInfinity, float.NaN, float.NaN)), float4(float.NaN, float.NaN, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float4(-0.0f, 0f, 323.4f, float.PositiveInfinity), float4(float.NaN, float.NaN, float.NaN, float.NaN)), float4(float.NaN, float.NaN, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(fmod(float4(float.NaN, float.NaN, float.NaN, float.NaN), float4(float.NaN, float.NaN, float.NaN, float.NaN)), float4(float.NaN, float.NaN, float.NaN, float.NaN), 1, false);
        }

        [TestCompiler]
        public void fmod_double()
        {
            TestUtils.AreEqual(fmod(double.NegativeInfinity, double.NegativeInfinity), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(-323.4, double.NegativeInfinity), -323.4, 1, false);
            TestUtils.AreEqual(fmod(-0.0, double.NegativeInfinity), -0.0, 1, false);
            TestUtils.AreEqual(fmod(0.0, double.NegativeInfinity), 0.0, 1, false);
            TestUtils.AreEqual(fmod(323.4, double.NegativeInfinity), 323.4, 1, false);
            TestUtils.AreEqual(fmod(double.PositiveInfinity, double.NegativeInfinity), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(double.NaN, double.NegativeInfinity), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(double.NegativeInfinity, -123.6), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(-323.4, -123.6), -76.2, 1, false);
            TestUtils.AreEqual(fmod(-0.0, -123.6), -0.0, 1, false);
            TestUtils.AreEqual(fmod(0.0, -123.6), 0.0, 1, false);
            TestUtils.AreEqual(fmod(323.4, -123.6), 76.2, 1, false);
            TestUtils.AreEqual(fmod(double.PositiveInfinity, -123.6), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(double.NaN, -123.6), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(double.NegativeInfinity, -0.0), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(-323.4, -0.0), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(-0.0, -0.0), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(0.0, -0.0), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(323.4, -0.0), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(double.PositiveInfinity, -0.0), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(double.NaN, -0.0), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(double.NegativeInfinity, 0.0), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(-323.4, 0.0), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(-0.0, 0.0), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(0.0, 0.0), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(323.4, 0.0), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(double.PositiveInfinity, 0.0), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(double.NaN, 0.0), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(double.NegativeInfinity, 123.6), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(-323.4, 123.6), -76.2, 1, false);
            TestUtils.AreEqual(fmod(-0.0, 123.6), -0.0, 1, false);
            TestUtils.AreEqual(fmod(0.0, 123.6), 0.0, 1, false);
            TestUtils.AreEqual(fmod(323.4, 123.6), 76.2, 1, false);
            TestUtils.AreEqual(fmod(double.PositiveInfinity, 123.6), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(double.NaN, 123.6), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(double.NegativeInfinity, double.PositiveInfinity), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(-323.4, double.PositiveInfinity), -323.4, 1, false);
            TestUtils.AreEqual(fmod(-0.0, double.PositiveInfinity), -0.0, 1, false);
            TestUtils.AreEqual(fmod(0.0, double.PositiveInfinity), 0.0, 1, false);
            TestUtils.AreEqual(fmod(323.4, double.PositiveInfinity), 323.4, 1, false);
            TestUtils.AreEqual(fmod(double.PositiveInfinity, double.PositiveInfinity), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(double.NaN, double.PositiveInfinity), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(double.NegativeInfinity, double.NaN), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(-323.4, double.NaN), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(-0.0, double.NaN), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(0.0, double.NaN), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(323.4, double.NaN), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(double.PositiveInfinity, double.NaN), double.NaN, 1, false);
            TestUtils.AreEqual(fmod(double.NaN, double.NaN), double.NaN, 1, false);
        }

        [TestCompiler]
        public void fmod_double2()
        {
            TestUtils.AreEqual(fmod(double2(double.NegativeInfinity, -323.4), double2(double.NegativeInfinity, double.NegativeInfinity)), double2(double.NaN, -323.4), 1, false);
            TestUtils.AreEqual(fmod(double2(-0.0, 0.0), double2(double.NegativeInfinity, double.NegativeInfinity)), double2(-0.0, 0.0), 1, false);
            TestUtils.AreEqual(fmod(double2(323.4, double.PositiveInfinity), double2(double.NegativeInfinity, double.NegativeInfinity)), double2(323.4, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double2(double.NaN, double.NegativeInfinity), double2(double.NegativeInfinity, -123.6)), double2(double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double2(-323.4, -0.0), double2(-123.6, -123.6)), double2(-76.2, -0.0), 1, false);
            TestUtils.AreEqual(fmod(double2(0.0, 323.4), double2(-123.6, -123.6)), double2(0.0, 76.2), 1, false);
            TestUtils.AreEqual(fmod(double2(double.PositiveInfinity, double.NaN), double2(-123.6, -123.6)), double2(double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double2(double.NegativeInfinity, -323.4), double2(-0.0, -0.0)), double2(double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double2(-0.0, 0.0), double2(-0.0, -0.0)), double2(double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double2(323.4, double.PositiveInfinity), double2(-0.0, -0.0)), double2(double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double2(double.NaN, double.NegativeInfinity), double2(-0.0, 0.0)), double2(double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double2(-323.4, -0.0), double2(0.0, 0.0)), double2(double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double2(0.0, 323.4), double2(0.0, 0.0)), double2(double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double2(double.PositiveInfinity, double.NaN), double2(0.0, 0.0)), double2(double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double2(double.NegativeInfinity, -323.4), double2(123.6, 123.6)), double2(double.NaN, -76.2), 1, false);
            TestUtils.AreEqual(fmod(double2(-0.0, 0.0), double2(123.6, 123.6)), double2(-0.0, 0.0), 1, false);
            TestUtils.AreEqual(fmod(double2(323.4, double.PositiveInfinity), double2(123.6, 123.6)), double2(76.2, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double2(double.NaN, double.NegativeInfinity), double2(123.6, double.PositiveInfinity)), double2(double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double2(-323.4, -0.0), double2(double.PositiveInfinity, double.PositiveInfinity)), double2(-323.4, -0.0), 1, false);
            TestUtils.AreEqual(fmod(double2(0.0, 323.4), double2(double.PositiveInfinity, double.PositiveInfinity)), double2(0.0, 323.4), 1, false);
            TestUtils.AreEqual(fmod(double2(double.PositiveInfinity, double.NaN), double2(double.PositiveInfinity, double.PositiveInfinity)), double2(double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double2(double.NegativeInfinity, -323.4), double2(double.NaN, double.NaN)), double2(double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double2(-0.0, 0.0), double2(double.NaN, double.NaN)), double2(double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double2(323.4, double.PositiveInfinity), double2(double.NaN, double.NaN)), double2(double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double2(double.NaN, double.NaN), double2(double.NaN, double.NaN)), double2(double.NaN, double.NaN), 1, false);
        }

        [TestCompiler]
        public void fmod_double3()
        {
            TestUtils.AreEqual(fmod(double3(double.NegativeInfinity, -323.4, -0.0), double3(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity)), double3(double.NaN, -323.4, -0.0), 1, false);
            TestUtils.AreEqual(fmod(double3(0.0, 323.4, double.PositiveInfinity), double3(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity)), double3(0.0, 323.4, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double3(double.NaN, double.NegativeInfinity, -323.4), double3(double.NegativeInfinity, -123.6, -123.6)), double3(double.NaN, double.NaN, -76.2), 1, false);
            TestUtils.AreEqual(fmod(double3(-0.0, 0.0, 323.4), double3(-123.6, -123.6, -123.6)), double3(-0.0, 0.0, 76.2), 1, false);
            TestUtils.AreEqual(fmod(double3(double.PositiveInfinity, double.NaN, double.NegativeInfinity), double3(-123.6, -123.6, -0.0)), double3(double.NaN, double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double3(-323.4, -0.0, 0.0), double3(-0.0, -0.0, -0.0)), double3(double.NaN, double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double3(323.4, double.PositiveInfinity, double.NaN), double3(-0.0, -0.0, -0.0)), double3(double.NaN, double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double3(double.NegativeInfinity, -323.4, -0.0), double3(0.0, 0.0, 0.0)), double3(double.NaN, double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double3(0.0, 323.4, double.PositiveInfinity), double3(0.0, 0.0, 0.0)), double3(double.NaN, double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double3(double.NaN, double.NegativeInfinity, -323.4), double3(0.0, 123.6, 123.6)), double3(double.NaN, double.NaN, -76.2), 1, false);
            TestUtils.AreEqual(fmod(double3(-0.0, 0.0, 323.4), double3(123.6, 123.6, 123.6)), double3(-0.0, 0.0, 76.2), 1, false);
            TestUtils.AreEqual(fmod(double3(double.PositiveInfinity, double.NaN, double.NegativeInfinity), double3(123.6, 123.6, double.PositiveInfinity)), double3(double.NaN, double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double3(-323.4, -0.0, 0.0), double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity)), double3(-323.4, -0.0, 0.0), 1, false);
            TestUtils.AreEqual(fmod(double3(323.4, double.PositiveInfinity, double.NaN), double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity)), double3(323.4, double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double3(double.NegativeInfinity, -323.4, -0.0), double3(double.NaN, double.NaN, double.NaN)), double3(double.NaN, double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double3(0.0, 323.4, double.PositiveInfinity), double3(double.NaN, double.NaN, double.NaN)), double3(double.NaN, double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double3(double.NaN, double.NaN, double.NaN), double3(double.NaN, double.NaN, double.NaN)), double3(double.NaN, double.NaN, double.NaN), 1, false);
        }

        [TestCompiler]
        public void fmod_double4()
        {
            TestUtils.AreEqual(fmod(double4(double.NegativeInfinity, -323.4, -0.0, 0.0), double4(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity)), double4(double.NaN, -323.4, -0.0, 0.0), 1, false);
            TestUtils.AreEqual(fmod(double4(323.4, double.PositiveInfinity, double.NaN, double.NegativeInfinity), double4(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, -123.6)), double4(323.4, double.NaN, double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double4(-323.4, -0.0, 0.0, 323.4), double4(-123.6, -123.6, -123.6, -123.6)), double4(-76.2, -0.0, 0.0, 76.2), 1, false);
            TestUtils.AreEqual(fmod(double4(double.PositiveInfinity, double.NaN, double.NegativeInfinity, -323.4), double4(-123.6, -123.6, -0.0, -0.0)), double4(double.NaN, double.NaN, double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double4(-0.0, 0.0, 323.4, double.PositiveInfinity), double4(-0.0, -0.0, -0.0, -0.0)), double4(double.NaN, double.NaN, double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double4(double.NaN, double.NegativeInfinity, -323.4, -0.0), double4(-0.0, 0.0, 0.0, 0.0)), double4(double.NaN, double.NaN, double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double4(0.0, 323.4, double.PositiveInfinity, double.NaN), double4(0.0, 0.0, 0.0, 0.0)), double4(double.NaN, double.NaN, double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double4(double.NegativeInfinity, -323.4, -0.0, 0.0), double4(123.6, 123.6, 123.6, 123.6)), double4(double.NaN, -76.2, -0.0, 0.0), 1, false);
            TestUtils.AreEqual(fmod(double4(323.4, double.PositiveInfinity, double.NaN, double.NegativeInfinity), double4(123.6, 123.6, 123.6, double.PositiveInfinity)), double4(76.2, double.NaN, double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double4(-323.4, -0.0, 0.0, 323.4), double4(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity)), double4(-323.4, -0.0, 0.0, 323.4), 1, false);
            TestUtils.AreEqual(fmod(double4(double.PositiveInfinity, double.NaN, double.NegativeInfinity, -323.4), double4(double.PositiveInfinity, double.PositiveInfinity, double.NaN, double.NaN)), double4(double.NaN, double.NaN, double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double4(-0.0, 0.0, 323.4, double.PositiveInfinity), double4(double.NaN, double.NaN, double.NaN, double.NaN)), double4(double.NaN, double.NaN, double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(fmod(double4(double.NaN, double.NaN, double.NaN, double.NaN), double4(double.NaN, double.NaN, double.NaN, double.NaN)), double4(double.NaN, double.NaN, double.NaN, double.NaN), 1, false);
        }

        [TestCompiler]
        public void pow_float()
        {
            TestUtils.AreEqual(pow(float.NegativeInfinity, float.NegativeInfinity), 0f, 1, false);
            TestUtils.AreEqual(pow(-3.4f, float.NegativeInfinity), 0f, 1, false);
            TestUtils.AreEqual(pow(-0.0f, float.NegativeInfinity), float.PositiveInfinity, 1, false);
            TestUtils.AreEqual(pow(0f, float.NegativeInfinity), float.PositiveInfinity, 1, false);
            TestUtils.AreEqual(pow(3.4f, float.NegativeInfinity), 0f, 1, false);
            TestUtils.AreEqual(pow(float.PositiveInfinity, float.NegativeInfinity), 0f, 1, false);
            TestUtils.AreEqual(pow(float.NaN, float.NegativeInfinity), float.NaN, 1, false);
            TestUtils.AreEqual(pow(float.NegativeInfinity, -2.6f), 0f, 1, false);
            TestUtils.AreEqual(pow(-3.4f, -2.6f), float.NaN, 1, false);
            TestUtils.AreEqual(pow(-0.0f, -2.6f), float.PositiveInfinity, 1, false);
            TestUtils.AreEqual(pow(0f, -2.6f), float.PositiveInfinity, 1, false);
            TestUtils.AreEqual(pow(3.4f, -2.6f), 0.0415102f, 1, false);
            TestUtils.AreEqual(pow(float.PositiveInfinity, -2.6f), 0f, 1, false);
            TestUtils.AreEqual(pow(float.NaN, -2.6f), float.NaN, 1, false);
            TestUtils.AreEqual(pow(float.NegativeInfinity, -0.0f), 1f, 1, false);
            TestUtils.AreEqual(pow(-3.4f, -0.0f), 1f, 1, false);
            TestUtils.AreEqual(pow(-0.0f, -0.0f), 1f, 1, false);
            TestUtils.AreEqual(pow(0f, -0.0f), 1f, 1, false);
            TestUtils.AreEqual(pow(3.4f, -0.0f), 1f, 1, false);
            TestUtils.AreEqual(pow(float.PositiveInfinity, -0.0f), 1f, 1, false);
            TestUtils.AreEqual(pow(float.NegativeInfinity, 0f), 1f, 1, false);
            TestUtils.AreEqual(pow(-3.4f, 0f), 1f, 1, false);
            TestUtils.AreEqual(pow(-0.0f, 0f), 1f, 1, false);
            TestUtils.AreEqual(pow(0f, 0f), 1f, 1, false);
            TestUtils.AreEqual(pow(3.4f, 0f), 1f, 1, false);
            TestUtils.AreEqual(pow(float.PositiveInfinity, 0f), 1f, 1, false);
            TestUtils.AreEqual(pow(float.NegativeInfinity, 2.6f), float.PositiveInfinity, 1, false);
            TestUtils.AreEqual(pow(-3.4f, 2.6f), float.NaN, 1, false);
            TestUtils.AreEqual(pow(-0.0f, 2.6f), 0f, 1, false);
            TestUtils.AreEqual(pow(0f, 2.6f), 0f, 1, false);
            TestUtils.AreEqual(pow(3.4f, 2.6f), 24.0904655f, 1, false);
            TestUtils.AreEqual(pow(float.PositiveInfinity, 2.6f), float.PositiveInfinity, 1, false);
            TestUtils.AreEqual(pow(float.NaN, 2.6f), float.NaN, 1, false);
            TestUtils.AreEqual(pow(float.NegativeInfinity, float.PositiveInfinity), float.PositiveInfinity, 1, false);
            TestUtils.AreEqual(pow(-3.4f, float.PositiveInfinity), float.PositiveInfinity, 1, false);
            TestUtils.AreEqual(pow(-0.0f, float.PositiveInfinity), 0f, 1, false);
            TestUtils.AreEqual(pow(0f, float.PositiveInfinity), 0f, 1, false);
            TestUtils.AreEqual(pow(3.4f, float.PositiveInfinity), float.PositiveInfinity, 1, false);
            TestUtils.AreEqual(pow(float.PositiveInfinity, float.PositiveInfinity), float.PositiveInfinity, 1, false);
            TestUtils.AreEqual(pow(float.NaN, float.PositiveInfinity), float.NaN, 1, false);
            TestUtils.AreEqual(pow(float.NegativeInfinity, float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(pow(-3.4f, float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(pow(-0.0f, float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(pow(0f, float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(pow(3.4f, float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(pow(float.PositiveInfinity, float.NaN), float.NaN, 1, false);
            TestUtils.AreEqual(pow(float.NaN, float.NaN), float.NaN, 1, false);
        }

        [TestCompiler]
        public void pow_float2()
        {
            TestUtils.AreEqual(pow(float2(float.NegativeInfinity, -3.4f), float2(float.NegativeInfinity, float.NegativeInfinity)), float2(0f, 0f), 1, false);
            TestUtils.AreEqual(pow(float2(-0.0f, 0f), float2(float.NegativeInfinity, float.NegativeInfinity)), float2(float.PositiveInfinity, float.PositiveInfinity), 1, false);
            TestUtils.AreEqual(pow(float2(3.4f, float.PositiveInfinity), float2(float.NegativeInfinity, float.NegativeInfinity)), float2(0f, 0f), 1, false);
            TestUtils.AreEqual(pow(float2(float.NaN, float.NegativeInfinity), float2(float.NegativeInfinity, -2.6f)), float2(float.NaN, 0f), 1, false);
            TestUtils.AreEqual(pow(float2(-3.4f, -0.0f), float2(-2.6f, -2.6f)), float2(float.NaN, float.PositiveInfinity), 1, false);
            TestUtils.AreEqual(pow(float2(0f, 3.4f), float2(-2.6f, -2.6f)), float2(float.PositiveInfinity, 0.0415102f), 1, false);
            TestUtils.AreEqual(pow(float2(float.PositiveInfinity, float.NaN), float2(-2.6f, -2.6f)), float2(0f, float.NaN), 1, false);
            TestUtils.AreEqual(pow(float2(float.NegativeInfinity, -3.4f), float2(-0.0f, -0.0f)), float2(1f, 1f), 1, false);
            TestUtils.AreEqual(pow(float2(-0.0f, 0f), float2(-0.0f, -0.0f)), float2(1f, 1f), 1, false);
            TestUtils.AreEqual(pow(float2(3.4f, float.PositiveInfinity), float2(-0.0f, -0.0f)), float2(1f, 1f), 1, false);
            TestUtils.AreEqual(pow(float2(float.NegativeInfinity, -3.4f), float2(0f, 0f)), float2(1f, 1f), 1, false);
            TestUtils.AreEqual(pow(float2(-0.0f, 0f), float2(0f, 0f)), float2(1f, 1f), 1, false);
            TestUtils.AreEqual(pow(float2(3.4f, float.PositiveInfinity), float2(0f, 0f)), float2(1f, 1f), 1, false);
            TestUtils.AreEqual(pow(float2(float.NegativeInfinity, -3.4f), float2(2.6f, 2.6f)), float2(float.PositiveInfinity, float.NaN), 1, false);
            TestUtils.AreEqual(pow(float2(-0.0f, 0f), float2(2.6f, 2.6f)), float2(0f, 0f), 1, false);
            TestUtils.AreEqual(pow(float2(3.4f, float.PositiveInfinity), float2(2.6f, 2.6f)), float2(24.0904655f, float.PositiveInfinity), 1, false);
            TestUtils.AreEqual(pow(float2(float.NaN, float.NegativeInfinity), float2(2.6f, float.PositiveInfinity)), float2(float.NaN, float.PositiveInfinity), 1, false);
            TestUtils.AreEqual(pow(float2(-3.4f, -0.0f), float2(float.PositiveInfinity, float.PositiveInfinity)), float2(float.PositiveInfinity, 0f), 1, false);
            TestUtils.AreEqual(pow(float2(0f, 3.4f), float2(float.PositiveInfinity, float.PositiveInfinity)), float2(0f, float.PositiveInfinity), 1, false);
            TestUtils.AreEqual(pow(float2(float.PositiveInfinity, float.NaN), float2(float.PositiveInfinity, float.PositiveInfinity)), float2(float.PositiveInfinity, float.NaN), 1, false);
            TestUtils.AreEqual(pow(float2(float.NegativeInfinity, -3.4f), float2(float.NaN, float.NaN)), float2(float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(pow(float2(-0.0f, 0f), float2(float.NaN, float.NaN)), float2(float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(pow(float2(3.4f, float.PositiveInfinity), float2(float.NaN, float.NaN)), float2(float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(pow(float2(float.NaN, float.NaN), float2(float.NaN, float.NaN)), float2(float.NaN, float.NaN), 1, false);
        }

        [TestCompiler]
        public void pow_float3()
        {
            TestUtils.AreEqual(pow(float3(float.NegativeInfinity, -3.4f, -0.0f), float3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity)), float3(0f, 0f, float.PositiveInfinity), 1, false);
            TestUtils.AreEqual(pow(float3(0f, 3.4f, float.PositiveInfinity), float3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity)), float3(float.PositiveInfinity, 0f, 0f), 1, false);
            TestUtils.AreEqual(pow(float3(float.NaN, float.NegativeInfinity, -3.4f), float3(float.NegativeInfinity, -2.6f, -2.6f)), float3(float.NaN, 0f, float.NaN), 1, false);
            TestUtils.AreEqual(pow(float3(-0.0f, 0f, 3.4f), float3(-2.6f, -2.6f, -2.6f)), float3(float.PositiveInfinity, float.PositiveInfinity, 0.0415102f), 1, false);
            TestUtils.AreEqual(pow(float3(float.PositiveInfinity, float.NaN, float.NegativeInfinity), float3(-2.6f, -2.6f, -0.0f)), float3(0f, float.NaN, 1f), 1, false);
            TestUtils.AreEqual(pow(float3(-3.4f, -0.0f, 0f), float3(-0.0f, -0.0f, -0.0f)), float3(1f, 1f, 1f), 1, false);
            TestUtils.AreEqual(pow(float3(3.4f, float.PositiveInfinity, float.NegativeInfinity), float3(-0.0f, -0.0f, 0f)), float3(1f, 1f, 1f), 1, false);
            TestUtils.AreEqual(pow(float3(-3.4f, -0.0f, 0f), float3(0f, 0f, 0f)), float3(1f, 1f, 1f), 1, false);
            TestUtils.AreEqual(pow(float3(3.4f, float.PositiveInfinity, float.NegativeInfinity), float3(0f, 0f, 2.6f)), float3(1f, 1f, float.PositiveInfinity), 1, false);
            TestUtils.AreEqual(pow(float3(-3.4f, -0.0f, 0f), float3(2.6f, 2.6f, 2.6f)), float3(float.NaN, 0f, 0f), 1, false);
            TestUtils.AreEqual(pow(float3(3.4f, float.PositiveInfinity, float.NaN), float3(2.6f, 2.6f, 2.6f)), float3(24.0904655f, float.PositiveInfinity, float.NaN), 1, false);
            TestUtils.AreEqual(pow(float3(float.NegativeInfinity, -3.4f, -0.0f), float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity)), float3(float.PositiveInfinity, float.PositiveInfinity, 0f), 1, false);
            TestUtils.AreEqual(pow(float3(0f, 3.4f, float.PositiveInfinity), float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity)), float3(0f, float.PositiveInfinity, float.PositiveInfinity), 1, false);
            TestUtils.AreEqual(pow(float3(float.NaN, float.NegativeInfinity, -3.4f), float3(float.PositiveInfinity, float.NaN, float.NaN)), float3(float.NaN, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(pow(float3(-0.0f, 0f, 3.4f), float3(float.NaN, float.NaN, float.NaN)), float3(float.NaN, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(pow(float3(float.PositiveInfinity, float.NaN, float.NaN), float3(float.NaN, float.NaN, float.NaN)), float3(float.NaN, float.NaN, float.NaN), 1, false);
        }

        [TestCompiler]
        public void pow_float4()
        {
            TestUtils.AreEqual(pow(float4(float.NegativeInfinity, -3.4f, -0.0f, 0f), float4(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity)), float4(0f, 0f, float.PositiveInfinity, float.PositiveInfinity), 1, false);
            TestUtils.AreEqual(pow(float4(3.4f, float.PositiveInfinity, float.NaN, float.NegativeInfinity), float4(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, -2.6f)), float4(0f, 0f, float.NaN, 0f), 1, false);
            TestUtils.AreEqual(pow(float4(-3.4f, -0.0f, 0f, 3.4f), float4(-2.6f, -2.6f, -2.6f, -2.6f)), float4(float.NaN, float.PositiveInfinity, float.PositiveInfinity, 0.0415102f), 1, false);
            TestUtils.AreEqual(pow(float4(float.PositiveInfinity, float.NaN, float.NegativeInfinity, -3.4f), float4(-2.6f, -2.6f, -0.0f, -0.0f)), float4(0f, float.NaN, 1f, 1f), 1, false);
            TestUtils.AreEqual(pow(float4(-0.0f, 0f, 3.4f, float.PositiveInfinity), float4(-0.0f, -0.0f, -0.0f, -0.0f)), float4(1f, 1f, 1f, 1f), 1, false);
            TestUtils.AreEqual(pow(float4(float.NegativeInfinity, -3.4f, -0.0f, 0f), float4(0f, 0f, 0f, 0f)), float4(1f, 1f, 1f, 1f), 1, false);
            TestUtils.AreEqual(pow(float4(3.4f, float.PositiveInfinity, float.NegativeInfinity, -3.4f), float4(0f, 0f, 2.6f, 2.6f)), float4(1f, 1f, float.PositiveInfinity, float.NaN), 1, false);
            TestUtils.AreEqual(pow(float4(-0.0f, 0f, 3.4f, float.PositiveInfinity), float4(2.6f, 2.6f, 2.6f, 2.6f)), float4(0f, 0f, 24.0904655f, float.PositiveInfinity), 1, false);
            TestUtils.AreEqual(pow(float4(float.NaN, float.NegativeInfinity, -3.4f, -0.0f), float4(2.6f, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity)), float4(float.NaN, float.PositiveInfinity, float.PositiveInfinity, 0f), 1, false);
            TestUtils.AreEqual(pow(float4(0f, 3.4f, float.PositiveInfinity, float.NaN), float4(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity)), float4(0f, float.PositiveInfinity, float.PositiveInfinity, float.NaN), 1, false);
            TestUtils.AreEqual(pow(float4(float.NegativeInfinity, -3.4f, -0.0f, 0f), float4(float.NaN, float.NaN, float.NaN, float.NaN)), float4(float.NaN, float.NaN, float.NaN, float.NaN), 1, false);
            TestUtils.AreEqual(pow(float4(3.4f, float.PositiveInfinity, float.NaN, float.NaN), float4(float.NaN, float.NaN, float.NaN, float.NaN)), float4(float.NaN, float.NaN, float.NaN, float.NaN), 1, false);
        }

        [TestCompiler]
        public void pow_double()
        {
            TestUtils.AreEqual(pow(double.NegativeInfinity, double.NegativeInfinity), 0.0, 1, false);
            TestUtils.AreEqual(pow(-3.4, double.NegativeInfinity), 0.0, 1, false);
            TestUtils.AreEqual(pow(-0.0, double.NegativeInfinity), double.PositiveInfinity, 1, false);
            TestUtils.AreEqual(pow(0.0, double.NegativeInfinity), double.PositiveInfinity, 1, false);
            TestUtils.AreEqual(pow(3.4, double.NegativeInfinity), 0.0, 1, false);
            TestUtils.AreEqual(pow(double.PositiveInfinity, double.NegativeInfinity), 0.0, 1, false);
            TestUtils.AreEqual(pow(double.NaN, double.NegativeInfinity), double.NaN, 1, false);
            TestUtils.AreEqual(pow(double.NegativeInfinity, -2.6), 0.0, 1, false);
            TestUtils.AreEqual(pow(-3.4, -2.6), double.NaN, 1, false);
            TestUtils.AreEqual(pow(-0.0, -2.6), double.PositiveInfinity, 1, false);
            TestUtils.AreEqual(pow(0.0, -2.6), double.PositiveInfinity, 1, false);
            TestUtils.AreEqual(pow(3.4, -2.6), 0.041510199028461224, 1, false);
            TestUtils.AreEqual(pow(double.PositiveInfinity, -2.6), 0.0, 1, false);
            TestUtils.AreEqual(pow(double.NaN, -2.6), double.NaN, 1, false);
            TestUtils.AreEqual(pow(double.NegativeInfinity, -0.0), 1.0, 1, false);
            TestUtils.AreEqual(pow(-3.4, -0.0), 1.0, 1, false);
            TestUtils.AreEqual(pow(-0.0, -0.0), 1.0, 1, false);
            TestUtils.AreEqual(pow(0.0, -0.0), 1.0, 1, false);
            TestUtils.AreEqual(pow(3.4, -0.0), 1.0, 1, false);
            TestUtils.AreEqual(pow(double.PositiveInfinity, -0.0), 1.0, 1, false);
            TestUtils.AreEqual(pow(double.NegativeInfinity, 0.0), 1.0, 1, false);
            TestUtils.AreEqual(pow(-3.4, 0.0), 1.0, 1, false);
            TestUtils.AreEqual(pow(-0.0, 0.0), 1.0, 1, false);
            TestUtils.AreEqual(pow(0.0, 0.0), 1.0, 1, false);
            TestUtils.AreEqual(pow(3.4, 0.0), 1.0, 1, false);
            TestUtils.AreEqual(pow(double.PositiveInfinity, 0.0), 1.0, 1, false);
            TestUtils.AreEqual(pow(double.NegativeInfinity, 2.6), double.PositiveInfinity, 1, false);
            TestUtils.AreEqual(pow(-3.4, 2.6), double.NaN, 1, false);
            TestUtils.AreEqual(pow(-0.0, 2.6), 0.0, 1, false);
            TestUtils.AreEqual(pow(0.0, 2.6), 0.0, 1, false);
            TestUtils.AreEqual(pow(3.4, 2.6), 24.090465076169735, 1, false);
            TestUtils.AreEqual(pow(double.PositiveInfinity, 2.6), double.PositiveInfinity, 1, false);
            TestUtils.AreEqual(pow(double.NaN, 2.6), double.NaN, 1, false);
            TestUtils.AreEqual(pow(double.NegativeInfinity, double.PositiveInfinity), double.PositiveInfinity, 1, false);
            TestUtils.AreEqual(pow(-3.4, double.PositiveInfinity), double.PositiveInfinity, 1, false);
            TestUtils.AreEqual(pow(-0.0, double.PositiveInfinity), 0.0, 1, false);
            TestUtils.AreEqual(pow(0.0, double.PositiveInfinity), 0.0, 1, false);
            TestUtils.AreEqual(pow(3.4, double.PositiveInfinity), double.PositiveInfinity, 1, false);
            TestUtils.AreEqual(pow(double.PositiveInfinity, double.PositiveInfinity), double.PositiveInfinity, 1, false);
            TestUtils.AreEqual(pow(double.NaN, double.PositiveInfinity), double.NaN, 1, false);
            TestUtils.AreEqual(pow(double.NegativeInfinity, double.NaN), double.NaN, 1, false);
            TestUtils.AreEqual(pow(-3.4, double.NaN), double.NaN, 1, false);
            TestUtils.AreEqual(pow(-0.0, double.NaN), double.NaN, 1, false);
            TestUtils.AreEqual(pow(0.0, double.NaN), double.NaN, 1, false);
            TestUtils.AreEqual(pow(3.4, double.NaN), double.NaN, 1, false);
            TestUtils.AreEqual(pow(double.PositiveInfinity, double.NaN), double.NaN, 1, false);
            TestUtils.AreEqual(pow(double.NaN, double.NaN), double.NaN, 1, false);
        }

        [TestCompiler]
        public void pow_double2()
        {
            TestUtils.AreEqual(pow(double2(double.NegativeInfinity, -3.4), double2(double.NegativeInfinity, double.NegativeInfinity)), double2(0.0, 0.0), 1, false);
            TestUtils.AreEqual(pow(double2(-0.0, 0.0), double2(double.NegativeInfinity, double.NegativeInfinity)), double2(double.PositiveInfinity, double.PositiveInfinity), 1, false);
            TestUtils.AreEqual(pow(double2(3.4, double.PositiveInfinity), double2(double.NegativeInfinity, double.NegativeInfinity)), double2(0.0, 0.0), 1, false);
            TestUtils.AreEqual(pow(double2(double.NaN, double.NegativeInfinity), double2(double.NegativeInfinity, -2.6)), double2(double.NaN, 0.0), 1, false);
            TestUtils.AreEqual(pow(double2(-3.4, -0.0), double2(-2.6, -2.6)), double2(double.NaN, double.PositiveInfinity), 1, false);
            TestUtils.AreEqual(pow(double2(0.0, 3.4), double2(-2.6, -2.6)), double2(double.PositiveInfinity, 0.041510199028461224), 1, false);
            TestUtils.AreEqual(pow(double2(double.PositiveInfinity, double.NaN), double2(-2.6, -2.6)), double2(0.0, double.NaN), 1, false);
            TestUtils.AreEqual(pow(double2(double.NegativeInfinity, -3.4), double2(-0.0, -0.0)), double2(1.0, 1.0), 1, false);
            TestUtils.AreEqual(pow(double2(-0.0, 0.0), double2(-0.0, -0.0)), double2(1.0, 1.0), 1, false);
            TestUtils.AreEqual(pow(double2(3.4, double.PositiveInfinity), double2(-0.0, -0.0)), double2(1.0, 1.0), 1, false);
            TestUtils.AreEqual(pow(double2(double.NegativeInfinity, -3.4), double2(0.0, 0.0)), double2(1.0, 1.0), 1, false);
            TestUtils.AreEqual(pow(double2(-0.0, 0.0), double2(0.0, 0.0)), double2(1.0, 1.0), 1, false);
            TestUtils.AreEqual(pow(double2(3.4, double.PositiveInfinity), double2(0.0, 0.0)), double2(1.0, 1.0), 1, false);
            TestUtils.AreEqual(pow(double2(double.NegativeInfinity, -3.4), double2(2.6, 2.6)), double2(double.PositiveInfinity, double.NaN), 1, false);
            TestUtils.AreEqual(pow(double2(-0.0, 0.0), double2(2.6, 2.6)), double2(0.0, 0.0), 1, false);
            TestUtils.AreEqual(pow(double2(3.4, double.PositiveInfinity), double2(2.6, 2.6)), double2(24.090465076169735, double.PositiveInfinity), 1, false);
            TestUtils.AreEqual(pow(double2(double.NaN, double.NegativeInfinity), double2(2.6, double.PositiveInfinity)), double2(double.NaN, double.PositiveInfinity), 1, false);
            TestUtils.AreEqual(pow(double2(-3.4, -0.0), double2(double.PositiveInfinity, double.PositiveInfinity)), double2(double.PositiveInfinity, 0.0), 1, false);
            TestUtils.AreEqual(pow(double2(0.0, 3.4), double2(double.PositiveInfinity, double.PositiveInfinity)), double2(0.0, double.PositiveInfinity), 1, false);
            TestUtils.AreEqual(pow(double2(double.PositiveInfinity, double.NaN), double2(double.PositiveInfinity, double.PositiveInfinity)), double2(double.PositiveInfinity, double.NaN), 1, false);
            TestUtils.AreEqual(pow(double2(double.NegativeInfinity, -3.4), double2(double.NaN, double.NaN)), double2(double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(pow(double2(-0.0, 0.0), double2(double.NaN, double.NaN)), double2(double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(pow(double2(3.4, double.PositiveInfinity), double2(double.NaN, double.NaN)), double2(double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(pow(double2(double.NaN, double.NaN), double2(double.NaN, double.NaN)), double2(double.NaN, double.NaN), 1, false);
        }

        [TestCompiler]
        public void pow_double3()
        {
            TestUtils.AreEqual(pow(double3(double.NegativeInfinity, -3.4, -0.0), double3(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity)), double3(0.0, 0.0, double.PositiveInfinity), 1, false);
            TestUtils.AreEqual(pow(double3(0.0, 3.4, double.PositiveInfinity), double3(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity)), double3(double.PositiveInfinity, 0.0, 0.0), 1, false);
            TestUtils.AreEqual(pow(double3(double.NaN, double.NegativeInfinity, -3.4), double3(double.NegativeInfinity, -2.6, -2.6)), double3(double.NaN, 0.0, double.NaN), 1, false);
            TestUtils.AreEqual(pow(double3(-0.0, 0.0, 3.4), double3(-2.6, -2.6, -2.6)), double3(double.PositiveInfinity, double.PositiveInfinity, 0.041510199028461224), 1, false);
            TestUtils.AreEqual(pow(double3(double.PositiveInfinity, double.NaN, double.NegativeInfinity), double3(-2.6, -2.6, -0.0)), double3(0.0, double.NaN, 1.0), 1, false);
            TestUtils.AreEqual(pow(double3(-3.4, -0.0, 0.0), double3(-0.0, -0.0, -0.0)), double3(1.0, 1.0, 1.0), 1, false);
            TestUtils.AreEqual(pow(double3(3.4, double.PositiveInfinity, double.NegativeInfinity), double3(-0.0, -0.0, 0.0)), double3(1.0, 1.0, 1.0), 1, false);
            TestUtils.AreEqual(pow(double3(-3.4, -0.0, 0.0), double3(0.0, 0.0, 0.0)), double3(1.0, 1.0, 1.0), 1, false);
            TestUtils.AreEqual(pow(double3(3.4, double.PositiveInfinity, double.NegativeInfinity), double3(0.0, 0.0, 2.6)), double3(1.0, 1.0, double.PositiveInfinity), 1, false);
            TestUtils.AreEqual(pow(double3(-3.4, -0.0, 0.0), double3(2.6, 2.6, 2.6)), double3(double.NaN, 0.0, 0.0), 1, false);
            TestUtils.AreEqual(pow(double3(3.4, double.PositiveInfinity, double.NaN), double3(2.6, 2.6, 2.6)), double3(24.090465076169735, double.PositiveInfinity, double.NaN), 1, false);
            TestUtils.AreEqual(pow(double3(double.NegativeInfinity, -3.4, -0.0), double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity)), double3(double.PositiveInfinity, double.PositiveInfinity, 0.0), 1, false);
            TestUtils.AreEqual(pow(double3(0.0, 3.4, double.PositiveInfinity), double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity)), double3(0.0, double.PositiveInfinity, double.PositiveInfinity), 1, false);
            TestUtils.AreEqual(pow(double3(double.NaN, double.NegativeInfinity, -3.4), double3(double.PositiveInfinity, double.NaN, double.NaN)), double3(double.NaN, double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(pow(double3(-0.0, 0.0, 3.4), double3(double.NaN, double.NaN, double.NaN)), double3(double.NaN, double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(pow(double3(double.PositiveInfinity, double.NaN, double.NaN), double3(double.NaN, double.NaN, double.NaN)), double3(double.NaN, double.NaN, double.NaN), 1, false);
        }

        [TestCompiler]
        public void pow_double4()
        {
            TestUtils.AreEqual(pow(double4(double.NegativeInfinity, -3.4, -0.0, 0.0), double4(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity)), double4(0.0, 0.0, double.PositiveInfinity, double.PositiveInfinity), 1, false);
            TestUtils.AreEqual(pow(double4(3.4, double.PositiveInfinity, double.NaN, double.NegativeInfinity), double4(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, -2.6)), double4(0.0, 0.0, double.NaN, 0.0), 1, false);
            TestUtils.AreEqual(pow(double4(-3.4, -0.0, 0.0, 3.4), double4(-2.6, -2.6, -2.6, -2.6)), double4(double.NaN, double.PositiveInfinity, double.PositiveInfinity, 0.041510199028461224), 1, false);
            TestUtils.AreEqual(pow(double4(double.PositiveInfinity, double.NaN, double.NegativeInfinity, -3.4), double4(-2.6, -2.6, -0.0, -0.0)), double4(0.0, double.NaN, 1.0, 1.0), 1, false);
            TestUtils.AreEqual(pow(double4(-0.0, 0.0, 3.4, double.PositiveInfinity), double4(-0.0, -0.0, -0.0, -0.0)), double4(1.0, 1.0, 1.0, 1.0), 1, false);
            TestUtils.AreEqual(pow(double4(double.NegativeInfinity, -3.4, -0.0, 0.0), double4(0.0, 0.0, 0.0, 0.0)), double4(1.0, 1.0, 1.0, 1.0), 1, false);
            TestUtils.AreEqual(pow(double4(3.4, double.PositiveInfinity, double.NegativeInfinity, -3.4), double4(0.0, 0.0, 2.6, 2.6)), double4(1.0, 1.0, double.PositiveInfinity, double.NaN), 1, false);
            TestUtils.AreEqual(pow(double4(-0.0, 0.0, 3.4, double.PositiveInfinity), double4(2.6, 2.6, 2.6, 2.6)), double4(0.0, 0.0, 24.090465076169735, double.PositiveInfinity), 1, false);
            TestUtils.AreEqual(pow(double4(double.NaN, double.NegativeInfinity, -3.4, -0.0), double4(2.6, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity)), double4(double.NaN, double.PositiveInfinity, double.PositiveInfinity, 0.0), 1, false);
            TestUtils.AreEqual(pow(double4(0.0, 3.4, double.PositiveInfinity, double.NaN), double4(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity)), double4(0.0, double.PositiveInfinity, double.PositiveInfinity, double.NaN), 1, false);
            TestUtils.AreEqual(pow(double4(double.NegativeInfinity, -3.4, -0.0, 0.0), double4(double.NaN, double.NaN, double.NaN, double.NaN)), double4(double.NaN, double.NaN, double.NaN, double.NaN), 1, false);
            TestUtils.AreEqual(pow(double4(3.4, double.PositiveInfinity, double.NaN, double.NaN), double4(double.NaN, double.NaN, double.NaN, double.NaN)), double4(double.NaN, double.NaN, double.NaN, double.NaN), 1, false);
        }

        [TestCompiler]
        public void ceilpow2_int()
        {
            TestUtils.AreEqual(ceilpow2(0), 0);
            TestUtils.AreEqual(ceilpow2(1), 1);
            TestUtils.AreEqual(ceilpow2(2), 2);
            TestUtils.AreEqual(ceilpow2(3), 4);
            TestUtils.AreEqual(ceilpow2(1019642234), 1073741824);
            TestUtils.AreEqual(ceilpow2(1823423423), -2147483648);
            TestUtils.AreEqual(ceilpow2(-2147483647), 0);
        }

        [TestCompiler]
        public void ceilpow2_int2()
        {
            TestUtils.AreEqual(ceilpow2(int2(0, 1)), int2(0, 1));
            TestUtils.AreEqual(ceilpow2(int2(2, 3)), int2(2, 4));
            TestUtils.AreEqual(ceilpow2(int2(1019642234, 1823423423)), int2(1073741824, -2147483648));
            TestUtils.AreEqual(ceilpow2(int2(-2147483647, -2147483647)), int2(0, 0));
        }

        [TestCompiler]
        public void ceilpow2_int3()
        {
            TestUtils.AreEqual(ceilpow2(int3(0, 1, 2)), int3(0, 1, 2));
            TestUtils.AreEqual(ceilpow2(int3(3, 1019642234, 1823423423)), int3(4, 1073741824, -2147483648));
            TestUtils.AreEqual(ceilpow2(int3(-2147483647, -2147483647, -2147483647)), int3(0, 0, 0));
        }

        [TestCompiler]
        public void ceilpow2_int4()
        {
            TestUtils.AreEqual(ceilpow2(int4(0, 1, 2, 3)), int4(0, 1, 2, 4));
            TestUtils.AreEqual(ceilpow2(int4(1019642234, 1823423423, -2147483647, -2147483647)), int4(1073741824, -2147483648, 0, 0));
        }

        [TestCompiler]
        public void ceilpow2_uint()
        {
            TestUtils.AreEqual(ceilpow2(0u), 0u);
            TestUtils.AreEqual(ceilpow2(1u), 1u);
            TestUtils.AreEqual(ceilpow2(2u), 2u);
            TestUtils.AreEqual(ceilpow2(3u), 4u);
            TestUtils.AreEqual(ceilpow2(1019642234u), 1073741824u);
            TestUtils.AreEqual(ceilpow2(1823423423u), 2147483648u);
            TestUtils.AreEqual(ceilpow2(4294967295u), 0u);
        }

        [TestCompiler]
        public void ceilpow2_uint2()
        {
            TestUtils.AreEqual(ceilpow2(uint2(0u, 1u)), uint2(0u, 1u));
            TestUtils.AreEqual(ceilpow2(uint2(2u, 3u)), uint2(2u, 4u));
            TestUtils.AreEqual(ceilpow2(uint2(1019642234u, 1823423423u)), uint2(1073741824u, 2147483648u));
            TestUtils.AreEqual(ceilpow2(uint2(4294967295u, 4294967295u)), uint2(0u, 0u));
        }

        [TestCompiler]
        public void ceilpow2_uint3()
        {
            TestUtils.AreEqual(ceilpow2(uint3(0u, 1u, 2u)), uint3(0u, 1u, 2u));
            TestUtils.AreEqual(ceilpow2(uint3(3u, 1019642234u, 1823423423u)), uint3(4u, 1073741824u, 2147483648u));
            TestUtils.AreEqual(ceilpow2(uint3(4294967295u, 4294967295u, 4294967295u)), uint3(0u, 0u, 0u));
        }

        [TestCompiler]
        public void ceilpow2_uint4()
        {
            TestUtils.AreEqual(ceilpow2(uint4(0u, 1u, 2u, 3u)), uint4(0u, 1u, 2u, 4u));
            TestUtils.AreEqual(ceilpow2(uint4(1019642234u, 1823423423u, 4294967295u, 4294967295u)), uint4(1073741824u, 2147483648u, 0u, 0u));
        }

        [TestCompiler]
        public void ceilpow2_long()
        {
            TestUtils.AreEqual(ceilpow2(0L), 0L);
            TestUtils.AreEqual(ceilpow2(1L), 1L);
            TestUtils.AreEqual(ceilpow2(2L), 2L);
            TestUtils.AreEqual(ceilpow2(3L), 4L);
            TestUtils.AreEqual(ceilpow2(1019642234L), 1073741824L);
            TestUtils.AreEqual(ceilpow2(1823423423L), 2147483648L);
            TestUtils.AreEqual(ceilpow2(2147483648L), 2147483648L);
            TestUtils.AreEqual(ceilpow2(4294967295L), 4294967296L);
            TestUtils.AreEqual(ceilpow2(4294967296L), 4294967296L);
            TestUtils.AreEqual(ceilpow2(7227372236554874814L), -9223372036854775808L);
            TestUtils.AreEqual(ceilpow2(-100L), 0L);
        }

        [TestCompiler]
        public void ceilpow2_ulong()
        {
            TestUtils.AreEqual(ceilpow2(0UL), 0UL);
            TestUtils.AreEqual(ceilpow2(1UL), 1UL);
            TestUtils.AreEqual(ceilpow2(2UL), 2UL);
            TestUtils.AreEqual(ceilpow2(3UL), 4UL);
            TestUtils.AreEqual(ceilpow2(1019642234UL), 1073741824UL);
            TestUtils.AreEqual(ceilpow2(1823423423UL), 2147483648UL);
            TestUtils.AreEqual(ceilpow2(2147483648UL), 2147483648UL);
            TestUtils.AreEqual(ceilpow2(4294967295UL), 4294967296UL);
            TestUtils.AreEqual(ceilpow2(4294967296UL), 4294967296UL);
            TestUtils.AreEqual(ceilpow2(7227372236554874814UL), 9223372036854775808UL);
            TestUtils.AreEqual(ceilpow2(10223372036854775808UL), 0UL);
        }


    }
}
