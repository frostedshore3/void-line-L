using System;
using HarmonyLib;
using UnityEngine;

namespace ShibaGTTemplate.Backend
{
	// Token: 0x02000011 RID: 17
	[HarmonyPatch(typeof(VRRig), "OnDisable")]
	internal class GhostPatch : MonoBehaviour
	{
		// Token: 0x06000227 RID: 551 RVA: 0x00012870 File Offset: 0x00010A70
		private static bool VariantBoolAssemblyFileVersionAttribute(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, VRRig A_5)
		{
			bool flag = true;
			A_4 = flag;
			A_0 = 3;
			bool result;
			return result;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000128A4 File Offset: 0x00010AA4
		public GhostPatch()
		{
			int num = 4;
			int num2 = 4;
			num2 = 4;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.Backend.GhostPatch), ref num, ref num2, ref num3, this, GhostPatch.getCursorLeftModule[num]);
			}
			num2 = 4;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000128D8 File Offset: 0x00010AD8
		public static bool Prefix(VRRig __instance)
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			bool result;
			while (num2 != 5)
			{
				int num3;
				bool flag;
				bool flag2;
				result = calli(System.Boolean(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,VRRig), ref num, ref num2, ref num3, ref flag, ref flag2, __instance, GhostPatch.getCursorLeftModule[num]);
			}
			num2 = 0;
			return result;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00012914 File Offset: 0x00010B14
		private static bool FixupDatapUnk(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, VRRig A_5)
		{
			bool result = A_4;
			A_1 = 5;
			return result;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00012934 File Offset: 0x00010B34
		private static bool HResultsLastEvent(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, VRRig A_5)
		{
			bool flag = false;
			A_4 = flag;
			A_0 = 3;
			bool result;
			return result;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00012968 File Offset: 0x00010B68
		private static bool TokenizerStreamNumberBufferBytes(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, VRRig A_5)
		{
			bool flag = A_5 == GorillaTagger.Instance.offlineVRRig;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 1 + 1;
			A_0 = num;
			bool result;
			return result;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000129D8 File Offset: 0x00010BD8
		private static void StindRIDisposableToIClosableAdapter(ref int A_0, ref int A_1, ref int A_2, GhostPatch A_3)
		{
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000129FC File Offset: 0x00010BFC
		// Note: this type is marked as 'beforefieldinit'.
		static GhostPatch()
		{
			GhostPatch.GenerateAppDomainEvidenceImportAsAgnostic();
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00012A10 File Offset: 0x00010C10
		private static void GenerateAppDomainEvidenceImportAsAgnostic()
		{
			GhostPatch.getCursorLeftModule = new IntPtr[5];
			GhostPatch.getCursorLeftModule[0] = ldftn(TokenizerStreamNumberBufferBytes);
			GhostPatch.getCursorLeftModule[1] = ldftn(HResultsLastEvent);
			GhostPatch.getCursorLeftModule[2] = ldftn(VariantBoolAssemblyFileVersionAttribute);
			GhostPatch.getCursorLeftModule[3] = ldftn(FixupDatapUnk);
			GhostPatch.getCursorLeftModule[4] = ldftn(StindRIDisposableToIClosableAdapter);
		}

		// Token: 0x04000075 RID: 117
		private static IntPtr[] getCursorLeftModule;
	}
}
