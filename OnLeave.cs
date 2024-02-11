using System;
using GTAG_NotificationLib;
using HarmonyLib;
using Photon.Pun;
using Photon.Realtime;

namespace ShibaGTTemplate.Backend
{
	// Token: 0x02000013 RID: 19
	[HarmonyPatch(typeof(GorillaNot))]
	[HarmonyPatch("OnPlayerLeftRoom", 0)]
	internal class OnLeave : HarmonyPatch
	{
		// Token: 0x06000236 RID: 566 RVA: 0x00012B9C File Offset: 0x00010D9C
		private static void MngdRefCustomMarshalerInTypeChainFlag(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, Player A_5)
		{
			A_1 = 5;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00012BB4 File Offset: 0x00010DB4
		private static void SetShadowCopyPathgetHandled(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, Player A_5)
		{
			bool flag = A_5 != PhotonNetwork.LocalPlayer;
			A_3 = flag;
			int num = ((!A_3) ? 1 : 0) * 3 + 1;
			A_0 = num;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00012C20 File Offset: 0x00010E20
		public OnLeave()
		{
			int num = 5;
			int num2 = 5;
			num2 = 5;
			while (num2 != 0)
			{
				int num3;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,ShibaGTTemplate.Backend.OnLeave), ref num, ref num2, ref num3, this, OnLeave.mversionGetStringBuilder[num]);
			}
			num2 = 5;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00012C54 File Offset: 0x00010E54
		private static void IsPropertygetAsError(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, Player A_5)
		{
			NotifiLib.SendNotification("<color=yellow>[ROOM]: YOU ARE NOW MASTER CLIENT!</color>");
			A_1 = 5;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00012C7C File Offset: 0x00010E7C
		private static void GetOptionalCustomModifiersCanon(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, Player A_5)
		{
			NotifiLib.SendNotification("<color=blue>[ROOM]:</color> Player " + A_5.NickName + " Left Lobby");
			bool isMasterClient = PhotonNetwork.IsMasterClient;
			A_4 = isMasterClient;
			int num = ((!A_4) ? 1 : 0) * 1 + 2;
			A_0 = num;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00012CF8 File Offset: 0x00010EF8
		private static void AuthorizationRuleGetHour(ref int A_0, ref int A_1, ref int A_2, ref bool A_3, ref bool A_4, Player A_5)
		{
			A_1 = 5;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00012D10 File Offset: 0x00010F10
		private static void TargetedPatchingOptOutAttributeAllButOverflow(ref int A_0, ref int A_1, ref int A_2, OnLeave A_3)
		{
			A_3..ctor();
			A_1 = 0;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00012D34 File Offset: 0x00010F34
		private static void Prefix(Player otherPlayer)
		{
			int num = 0;
			int num2 = 0;
			num2 = 0;
			while (num2 != 5)
			{
				int num3;
				bool flag;
				bool flag2;
				calli(System.Void(System.Int32&,System.Int32&,System.Int32&,System.Boolean&,System.Boolean&,Photon.Realtime.Player), ref num, ref num2, ref num3, ref flag, ref flag2, otherPlayer, OnLeave.mversionGetStringBuilder[num]);
			}
			num2 = 0;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00012D6C File Offset: 0x00010F6C
		// Note: this type is marked as 'beforefieldinit'.
		static OnLeave()
		{
			OnLeave.ILRefanytype();
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00012D80 File Offset: 0x00010F80
		private static void ILRefanytype()
		{
			OnLeave.mversionGetStringBuilder = new IntPtr[6];
			OnLeave.mversionGetStringBuilder[0] = ldftn(SetShadowCopyPathgetHandled);
			OnLeave.mversionGetStringBuilder[1] = ldftn(GetOptionalCustomModifiersCanon);
			OnLeave.mversionGetStringBuilder[2] = ldftn(IsPropertygetAsError);
			OnLeave.mversionGetStringBuilder[3] = ldftn(AuthorizationRuleGetHour);
			OnLeave.mversionGetStringBuilder[4] = ldftn(MngdRefCustomMarshalerInTypeChainFlag);
			OnLeave.mversionGetStringBuilder[5] = ldftn(TargetedPatchingOptOutAttributeAllButOverflow);
		}

		// Token: 0x04000077 RID: 119
		private static IntPtr[] mversionGetStringBuilder;
	}
}
