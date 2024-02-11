using System;
using GTAG_NotificationLib;
using HarmonyLib;
using Photon.Realtime;

namespace ShibaGTTemplate.Backend
{
	// Token: 0x02000012 RID: 18
	[HarmonyPatch(typeof(GorillaNot))]
	[HarmonyPatch("OnPlayerEnteredRoom", 0)]
	internal class OnJoin : HarmonyPatch
	{
		// Token: 0x06000230 RID: 560 RVA: 0x00012A84 File Offset: 0x00010C84
		private static void Prefix(Player newPlayer)
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			while (num2 != 1)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,Photon.Realtime.Player), ref num, ref num2, ref num3, newPlayer, OnJoin.IsLayoutSequentialCrossAppDomainSerializer[num]);
			}
			num2 = 0;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00012AB8 File Offset: 0x00010CB8
		public OnJoin()
		{
			int num = 1;
			int num2 = 1;
			num2 = 1;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.Backend.OnJoin), ref num, ref num2, ref num3, this, OnJoin.IsLayoutSequentialCrossAppDomainSerializer[num]);
			}
			num2 = 1;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00012AEC File Offset: 0x00010CEC
		private static void MACTripleDESsetString(ref int A_0, ref int A_1, ref int A_2, OnJoin A_3)
		{
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00012B10 File Offset: 0x00010D10
		private static void IsEventPinnableBufferCacheEventSource(ref int A_0, ref int A_1, ref int A_2, Player A_3)
		{
			NotifiLib.SendNotification("<color=blue>[ROOM]:</color> Player " + A_3.NickName + " Joined Lobby");
			A_1 = 1;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00012B48 File Offset: 0x00010D48
		// Note: this type is marked as 'beforefieldinit'.
		static OnJoin()
		{
			OnJoin.PARAMFLAGFLCIDCallerResolvedReferences();
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00012B5C File Offset: 0x00010D5C
		private static void PARAMFLAGFLCIDCallerResolvedReferences()
		{
			OnJoin.IsLayoutSequentialCrossAppDomainSerializer = new IntPtr[2];
			OnJoin.IsLayoutSequentialCrossAppDomainSerializer[0] = ldftn(IsEventPinnableBufferCacheEventSource);
			OnJoin.IsLayoutSequentialCrossAppDomainSerializer[1] = ldftn(MACTripleDESsetString);
		}

		// Token: 0x04000076 RID: 118
		private static IntPtr[] IsLayoutSequentialCrossAppDomainSerializer;
	}
}
