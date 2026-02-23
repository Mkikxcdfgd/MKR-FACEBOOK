using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsocial.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Microsocial
{
	// Token: 0x0200004F RID: 79
	[DesignerGenerated]
	public partial class FacebookPostGruposDiscussãoFormPrincipal : Form
	{
		// Token: 0x06001417 RID: 5143 RVA: 0x0007D770 File Offset: 0x0007B970
		public FacebookPostGruposDiscussãoFormPrincipal()
		{
			base.Load += this.FormPrincipal_Load;
			this.Service = ChromeDriverService.CreateDefaultService();
			this.ChromeDriver = null;
			this.NomeDoSoftware = "Facebook Post Grupos - Discussão";
			this.Postagens = new List<string>();
			this.DelayAleatório = 0;
			this.InitializeComponent();
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x0600141A RID: 5146 RVA: 0x0000EA1F File Offset: 0x0000CC1F
		// (set) Token: 0x0600141B RID: 5147 RVA: 0x0000EA29 File Offset: 0x0000CC29
		internal virtual Label LabelStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x0000EA32 File Offset: 0x0000CC32
		// (set) Token: 0x0600141D RID: 5149 RVA: 0x00082998 File Offset: 0x00080B98
		internal virtual Button BtnIniciar
		{
			[CompilerGenerated]
			get
			{
				return this._BtnIniciar;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BtnIniciar_Click);
				Button btnIniciar = this._BtnIniciar;
				if (btnIniciar != null)
				{
					btnIniciar.Click -= value2;
				}
				this._BtnIniciar = value;
				btnIniciar = this._BtnIniciar;
				if (btnIniciar != null)
				{
					btnIniciar.Click += value2;
				}
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x0000EA3C File Offset: 0x0000CC3C
		// (set) Token: 0x0600141F RID: 5151 RVA: 0x0000EA46 File Offset: 0x0000CC46
		internal virtual Panel Panel6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x0000EA4F File Offset: 0x0000CC4F
		// (set) Token: 0x06001421 RID: 5153 RVA: 0x0000EA59 File Offset: 0x0000CC59
		internal virtual Label LabelRelatórioCount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x0000EA62 File Offset: 0x0000CC62
		// (set) Token: 0x06001423 RID: 5155 RVA: 0x0000EA6C File Offset: 0x0000CC6C
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x0000EA75 File Offset: 0x0000CC75
		// (set) Token: 0x06001425 RID: 5157 RVA: 0x0000EA7F File Offset: 0x0000CC7F
		internal virtual ListView ListViewRelatório { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x0000EA88 File Offset: 0x0000CC88
		// (set) Token: 0x06001427 RID: 5159 RVA: 0x0000EA92 File Offset: 0x0000CC92
		internal virtual ProgressBar ProgressBarPrincipal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x0000EA9B File Offset: 0x0000CC9B
		// (set) Token: 0x06001429 RID: 5161 RVA: 0x000829DC File Offset: 0x00080BDC
		internal virtual Button BtnAbrirNavegador
		{
			[CompilerGenerated]
			get
			{
				return this._BtnAbrirNavegador;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BtnAbrirNavegador_Click);
				Button btnAbrirNavegador = this._BtnAbrirNavegador;
				if (btnAbrirNavegador != null)
				{
					btnAbrirNavegador.Click -= value2;
				}
				this._BtnAbrirNavegador = value;
				btnAbrirNavegador = this._BtnAbrirNavegador;
				if (btnAbrirNavegador != null)
				{
					btnAbrirNavegador.Click += value2;
				}
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x0000EAA5 File Offset: 0x0000CCA5
		// (set) Token: 0x0600142B RID: 5163 RVA: 0x00082A20 File Offset: 0x00080C20
		internal virtual System.Windows.Forms.Timer TimerPrincipal
		{
			[CompilerGenerated]
			get
			{
				return this._TimerPrincipal;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TimerPrincipal_Tick);
				System.Windows.Forms.Timer timerPrincipal = this._TimerPrincipal;
				if (timerPrincipal != null)
				{
					timerPrincipal.Tick -= value2;
				}
				this._TimerPrincipal = value;
				timerPrincipal = this._TimerPrincipal;
				if (timerPrincipal != null)
				{
					timerPrincipal.Tick += value2;
				}
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x0000EAAF File Offset: 0x0000CCAF
		// (set) Token: 0x0600142D RID: 5165 RVA: 0x0000EAB9 File Offset: 0x0000CCB9
		internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x0000EAC2 File Offset: 0x0000CCC2
		// (set) Token: 0x0600142F RID: 5167 RVA: 0x0000EACC File Offset: 0x0000CCCC
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06001430 RID: 5168 RVA: 0x0000EAD5 File Offset: 0x0000CCD5
		// (set) Token: 0x06001431 RID: 5169 RVA: 0x00082A64 File Offset: 0x00080C64
		internal virtual TextBox TextBoxDelay
		{
			[CompilerGenerated]
			get
			{
				return this._TextBoxDelay;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextBoxDelay_TextChanged);
				TextBox textBoxDelay = this._TextBoxDelay;
				if (textBoxDelay != null)
				{
					textBoxDelay.TextChanged -= value2;
				}
				this._TextBoxDelay = value;
				textBoxDelay = this._TextBoxDelay;
				if (textBoxDelay != null)
				{
					textBoxDelay.TextChanged += value2;
				}
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06001432 RID: 5170 RVA: 0x0000EADF File Offset: 0x0000CCDF
		// (set) Token: 0x06001433 RID: 5171 RVA: 0x00082AA8 File Offset: 0x00080CA8
		internal virtual Button BtnLimparRelatório
		{
			[CompilerGenerated]
			get
			{
				return this._BtnLimparRelatório;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BtnLimparRelatório_Click);
				Button btnLimparRelatório = this._BtnLimparRelatório;
				if (btnLimparRelatório != null)
				{
					btnLimparRelatório.Click -= value2;
				}
				this._BtnLimparRelatório = value;
				btnLimparRelatório = this._BtnLimparRelatório;
				if (btnLimparRelatório != null)
				{
					btnLimparRelatório.Click += value2;
				}
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x0000EAE9 File Offset: 0x0000CCE9
		// (set) Token: 0x06001435 RID: 5173 RVA: 0x00082AEC File Offset: 0x00080CEC
		internal virtual Button BtnExportarRelatório
		{
			[CompilerGenerated]
			get
			{
				return this._BtnExportarRelatório;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BtnExportarRelatório_Click);
				Button btnExportarRelatório = this._BtnExportarRelatório;
				if (btnExportarRelatório != null)
				{
					btnExportarRelatório.Click -= value2;
				}
				this._BtnExportarRelatório = value;
				btnExportarRelatório = this._BtnExportarRelatório;
				if (btnExportarRelatório != null)
				{
					btnExportarRelatório.Click += value2;
				}
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x0000EAF3 File Offset: 0x0000CCF3
		// (set) Token: 0x06001437 RID: 5175 RVA: 0x0000EAFD File Offset: 0x0000CCFD
		internal virtual ColumnHeader ColumnHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x0000EB06 File Offset: 0x0000CD06
		// (set) Token: 0x06001439 RID: 5177 RVA: 0x0000EB10 File Offset: 0x0000CD10
		internal virtual ColumnHeader ColumnHeader2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x0000EB19 File Offset: 0x0000CD19
		// (set) Token: 0x0600143B RID: 5179 RVA: 0x0000EB23 File Offset: 0x0000CD23
		internal virtual TabControl TabControlPrincipal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x0000EB2C File Offset: 0x0000CD2C
		// (set) Token: 0x0600143D RID: 5181 RVA: 0x0000EB36 File Offset: 0x0000CD36
		internal virtual TabPage TabPagesGrupos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x0000EB3F File Offset: 0x0000CD3F
		// (set) Token: 0x0600143F RID: 5183 RVA: 0x0000EB49 File Offset: 0x0000CD49
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x0000EB52 File Offset: 0x0000CD52
		// (set) Token: 0x06001441 RID: 5185 RVA: 0x00082B30 File Offset: 0x00080D30
		internal virtual Button BtnLimparGrupos
		{
			[CompilerGenerated]
			get
			{
				return this._BtnLimparGrupos;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BtnLimparGrupos_Click);
				Button btnLimparGrupos = this._BtnLimparGrupos;
				if (btnLimparGrupos != null)
				{
					btnLimparGrupos.Click -= value2;
				}
				this._BtnLimparGrupos = value;
				btnLimparGrupos = this._BtnLimparGrupos;
				if (btnLimparGrupos != null)
				{
					btnLimparGrupos.Click += value2;
				}
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x0000EB5C File Offset: 0x0000CD5C
		// (set) Token: 0x06001443 RID: 5187 RVA: 0x00082B74 File Offset: 0x00080D74
		internal virtual Button BtnImportarGrupos
		{
			[CompilerGenerated]
			get
			{
				return this._BtnImportarGrupos;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BtnImportarGrupos_Click);
				Button btnImportarGrupos = this._BtnImportarGrupos;
				if (btnImportarGrupos != null)
				{
					btnImportarGrupos.Click -= value2;
				}
				this._BtnImportarGrupos = value;
				btnImportarGrupos = this._BtnImportarGrupos;
				if (btnImportarGrupos != null)
				{
					btnImportarGrupos.Click += value2;
				}
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x0000EB66 File Offset: 0x0000CD66
		// (set) Token: 0x06001445 RID: 5189 RVA: 0x00082BB8 File Offset: 0x00080DB8
		internal virtual Button BtnExportarGrupos
		{
			[CompilerGenerated]
			get
			{
				return this._BtnExportarGrupos;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BtnExportarGrupos_Click);
				Button btnExportarGrupos = this._BtnExportarGrupos;
				if (btnExportarGrupos != null)
				{
					btnExportarGrupos.Click -= value2;
				}
				this._BtnExportarGrupos = value;
				btnExportarGrupos = this._BtnExportarGrupos;
				if (btnExportarGrupos != null)
				{
					btnExportarGrupos.Click += value2;
				}
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x0000EB70 File Offset: 0x0000CD70
		// (set) Token: 0x06001447 RID: 5191 RVA: 0x0000EB7A File Offset: 0x0000CD7A
		internal virtual Label LabelGruposCount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x0000EB83 File Offset: 0x0000CD83
		// (set) Token: 0x06001449 RID: 5193 RVA: 0x0000EB8D File Offset: 0x0000CD8D
		internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x0000EB96 File Offset: 0x0000CD96
		// (set) Token: 0x0600144B RID: 5195 RVA: 0x0000EBA0 File Offset: 0x0000CDA0
		internal virtual RadioButton RbtnGParticipa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x0000EBA9 File Offset: 0x0000CDA9
		// (set) Token: 0x0600144D RID: 5197 RVA: 0x0000EBB3 File Offset: 0x0000CDB3
		internal virtual RadioButton RbtnGGerencia { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x0000EBBC File Offset: 0x0000CDBC
		// (set) Token: 0x0600144F RID: 5199 RVA: 0x00082BFC File Offset: 0x00080DFC
		internal virtual ListView ListViewGrupos
		{
			[CompilerGenerated]
			get
			{
				return this._ListViewGrupos;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.ListViewGrupos_KeyDown);
				ListView listViewGrupos = this._ListViewGrupos;
				if (listViewGrupos != null)
				{
					listViewGrupos.KeyDown -= value2;
				}
				this._ListViewGrupos = value;
				listViewGrupos = this._ListViewGrupos;
				if (listViewGrupos != null)
				{
					listViewGrupos.KeyDown += value2;
				}
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x0000EBC6 File Offset: 0x0000CDC6
		// (set) Token: 0x06001451 RID: 5201 RVA: 0x0000EBD0 File Offset: 0x0000CDD0
		internal virtual ColumnHeader ColumnHeader7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001452 RID: 5202 RVA: 0x0000EBD9 File Offset: 0x0000CDD9
		// (set) Token: 0x06001453 RID: 5203 RVA: 0x0000EBE3 File Offset: 0x0000CDE3
		internal virtual ColumnHeader ColumnHeader8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x0000EBEC File Offset: 0x0000CDEC
		// (set) Token: 0x06001455 RID: 5205 RVA: 0x00082C40 File Offset: 0x00080E40
		internal virtual Button BtnExtrairMeusGrupos
		{
			[CompilerGenerated]
			get
			{
				return this._BtnExtrairMeusGrupos;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BtnExtrairMeusGrupos_Click);
				Button btnExtrairMeusGrupos = this._BtnExtrairMeusGrupos;
				if (btnExtrairMeusGrupos != null)
				{
					btnExtrairMeusGrupos.Click -= value2;
				}
				this._BtnExtrairMeusGrupos = value;
				btnExtrairMeusGrupos = this._BtnExtrairMeusGrupos;
				if (btnExtrairMeusGrupos != null)
				{
					btnExtrairMeusGrupos.Click += value2;
				}
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06001456 RID: 5206 RVA: 0x0000EBF6 File Offset: 0x0000CDF6
		// (set) Token: 0x06001457 RID: 5207 RVA: 0x0000EC00 File Offset: 0x0000CE00
		internal virtual TabPage TabPagePostagens { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x0000EC09 File Offset: 0x0000CE09
		// (set) Token: 0x06001459 RID: 5209 RVA: 0x0000EC13 File Offset: 0x0000CE13
		internal virtual TabPage TabPagePostar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x0000EC1C File Offset: 0x0000CE1C
		// (set) Token: 0x0600145B RID: 5211 RVA: 0x0000EC26 File Offset: 0x0000CE26
		internal virtual TabPage TabPageConfigurações { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x0600145C RID: 5212 RVA: 0x0000EC2F File Offset: 0x0000CE2F
		// (set) Token: 0x0600145D RID: 5213 RVA: 0x0000EC39 File Offset: 0x0000CE39
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x0000EC42 File Offset: 0x0000CE42
		// (set) Token: 0x0600145F RID: 5215 RVA: 0x0000EC4C File Offset: 0x0000CE4C
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x0000EC55 File Offset: 0x0000CE55
		// (set) Token: 0x06001461 RID: 5217 RVA: 0x00082C84 File Offset: 0x00080E84
		internal virtual TextBox TextBoxDelayAleatório
		{
			[CompilerGenerated]
			get
			{
				return this._TextBoxDelayAleatório;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextBoxDelayAleatório_TextChanged);
				TextBox textBoxDelayAleatório = this._TextBoxDelayAleatório;
				if (textBoxDelayAleatório != null)
				{
					textBoxDelayAleatório.TextChanged -= value2;
				}
				this._TextBoxDelayAleatório = value;
				textBoxDelayAleatório = this._TextBoxDelayAleatório;
				if (textBoxDelayAleatório != null)
				{
					textBoxDelayAleatório.TextChanged += value2;
				}
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06001462 RID: 5218 RVA: 0x0000EC5F File Offset: 0x0000CE5F
		// (set) Token: 0x06001463 RID: 5219 RVA: 0x0000EC69 File Offset: 0x0000CE69
		internal virtual TableLayoutPanel TableLayoutPanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x0000EC72 File Offset: 0x0000CE72
		// (set) Token: 0x06001465 RID: 5221 RVA: 0x00082CC8 File Offset: 0x00080EC8
		internal virtual ListView ListViewDescrições
		{
			[CompilerGenerated]
			get
			{
				return this._ListViewDescrições;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ListViewDescrições_DoubleClick);
				KeyEventHandler value3 = new KeyEventHandler(this.ListViewDescrições_KeyDown);
				ListView listViewDescrições = this._ListViewDescrições;
				if (listViewDescrições != null)
				{
					listViewDescrições.DoubleClick -= value2;
					listViewDescrições.KeyDown -= value3;
				}
				this._ListViewDescrições = value;
				listViewDescrições = this._ListViewDescrições;
				if (listViewDescrições != null)
				{
					listViewDescrições.DoubleClick += value2;
					listViewDescrições.KeyDown += value3;
				}
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x0000EC7C File Offset: 0x0000CE7C
		// (set) Token: 0x06001467 RID: 5223 RVA: 0x0000EC86 File Offset: 0x0000CE86
		internal virtual ColumnHeader ColumnHeader4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x0000EC8F File Offset: 0x0000CE8F
		// (set) Token: 0x06001469 RID: 5225 RVA: 0x0000EC99 File Offset: 0x0000CE99
		internal virtual RichTextBox RichTextBoxPostagem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x0000ECA2 File Offset: 0x0000CEA2
		// (set) Token: 0x0600146B RID: 5227 RVA: 0x00082D28 File Offset: 0x00080F28
		internal virtual Button BtnAddDescrição
		{
			[CompilerGenerated]
			get
			{
				return this._BtnAddDescrição;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BtnAddDescrição_Click);
				Button btnAddDescrição = this._BtnAddDescrição;
				if (btnAddDescrição != null)
				{
					btnAddDescrição.Click -= value2;
				}
				this._BtnAddDescrição = value;
				btnAddDescrição = this._BtnAddDescrição;
				if (btnAddDescrição != null)
				{
					btnAddDescrição.Click += value2;
				}
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x0000ECAC File Offset: 0x0000CEAC
		// (set) Token: 0x0600146D RID: 5229 RVA: 0x0000ECB6 File Offset: 0x0000CEB6
		internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x0000ECBF File Offset: 0x0000CEBF
		// (set) Token: 0x0600146F RID: 5231 RVA: 0x00082D6C File Offset: 0x00080F6C
		internal virtual Button BtnExportarMensagens
		{
			[CompilerGenerated]
			get
			{
				return this._BtnExportarMensagens;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BtnExportarDescrições_Click);
				Button btnExportarMensagens = this._BtnExportarMensagens;
				if (btnExportarMensagens != null)
				{
					btnExportarMensagens.Click -= value2;
				}
				this._BtnExportarMensagens = value;
				btnExportarMensagens = this._BtnExportarMensagens;
				if (btnExportarMensagens != null)
				{
					btnExportarMensagens.Click += value2;
				}
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x0000ECC9 File Offset: 0x0000CEC9
		// (set) Token: 0x06001471 RID: 5233 RVA: 0x0000ECD3 File Offset: 0x0000CED3
		internal virtual Label LabelMensagensCount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06001472 RID: 5234 RVA: 0x0000ECDC File Offset: 0x0000CEDC
		// (set) Token: 0x06001473 RID: 5235 RVA: 0x00082DB0 File Offset: 0x00080FB0
		internal virtual Button BtnLimparMensagens
		{
			[CompilerGenerated]
			get
			{
				return this._BtnLimparMensagens;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BtnLimparDescrições_Click);
				Button btnLimparMensagens = this._BtnLimparMensagens;
				if (btnLimparMensagens != null)
				{
					btnLimparMensagens.Click -= value2;
				}
				this._BtnLimparMensagens = value;
				btnLimparMensagens = this._BtnLimparMensagens;
				if (btnLimparMensagens != null)
				{
					btnLimparMensagens.Click += value2;
				}
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x0000ECE6 File Offset: 0x0000CEE6
		// (set) Token: 0x06001475 RID: 5237 RVA: 0x00082DF4 File Offset: 0x00080FF4
		internal virtual Button BtnImportarMensagens
		{
			[CompilerGenerated]
			get
			{
				return this._BtnImportarMensagens;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BtnImportarDescrições_Click);
				Button btnImportarMensagens = this._BtnImportarMensagens;
				if (btnImportarMensagens != null)
				{
					btnImportarMensagens.Click -= value2;
				}
				this._BtnImportarMensagens = value;
				btnImportarMensagens = this._BtnImportarMensagens;
				if (btnImportarMensagens != null)
				{
					btnImportarMensagens.Click += value2;
				}
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06001476 RID: 5238 RVA: 0x0000ECF0 File Offset: 0x0000CEF0
		// (set) Token: 0x06001477 RID: 5239 RVA: 0x0000ECFA File Offset: 0x0000CEFA
		internal virtual ColumnHeader ColumnHeader3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06001478 RID: 5240 RVA: 0x0000ED03 File Offset: 0x0000CF03
		// (set) Token: 0x06001479 RID: 5241 RVA: 0x0000ED0D File Offset: 0x0000CF0D
		internal virtual Label LabelGruposRestantesCount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x0000ED16 File Offset: 0x0000CF16
		// (set) Token: 0x0600147B RID: 5243 RVA: 0x00082E38 File Offset: 0x00081038
		internal virtual System.Windows.Forms.Timer TimerGruposExtração
		{
			[CompilerGenerated]
			get
			{
				return this._TimerGruposExtração;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TimerGruposExtração_Tick);
				System.Windows.Forms.Timer timerGruposExtração = this._TimerGruposExtração;
				if (timerGruposExtração != null)
				{
					timerGruposExtração.Tick -= value2;
				}
				this._TimerGruposExtração = value;
				timerGruposExtração = this._TimerGruposExtração;
				if (timerGruposExtração != null)
				{
					timerGruposExtração.Tick += value2;
				}
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x0000ED20 File Offset: 0x0000CF20
		// (set) Token: 0x0600147D RID: 5245 RVA: 0x0000ED2A File Offset: 0x0000CF2A
		internal virtual Panel Panel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x0000ED33 File Offset: 0x0000CF33
		// (set) Token: 0x0600147F RID: 5247 RVA: 0x0000ED3D File Offset: 0x0000CF3D
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x0000ED46 File Offset: 0x0000CF46
		// (set) Token: 0x06001481 RID: 5249 RVA: 0x00082E7C File Offset: 0x0008107C
		internal virtual TextBox TextBoxDelayApósColarPostagem
		{
			[CompilerGenerated]
			get
			{
				return this._TextBoxDelayApósColarPostagem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextBoxDelayApósColarPostagem_TextChanged);
				TextBox textBoxDelayApósColarPostagem = this._TextBoxDelayApósColarPostagem;
				if (textBoxDelayApósColarPostagem != null)
				{
					textBoxDelayApósColarPostagem.TextChanged -= value2;
				}
				this._TextBoxDelayApósColarPostagem = value;
				textBoxDelayApósColarPostagem = this._TextBoxDelayApósColarPostagem;
				if (textBoxDelayApósColarPostagem != null)
				{
					textBoxDelayApósColarPostagem.TextChanged += value2;
				}
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x0000ED50 File Offset: 0x0000CF50
		// (set) Token: 0x06001483 RID: 5251 RVA: 0x0000ED5A File Offset: 0x0000CF5A
		internal virtual Panel Panel7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x0000ED63 File Offset: 0x0000CF63
		// (set) Token: 0x06001485 RID: 5253 RVA: 0x0000ED6D File Offset: 0x0000CF6D
		internal virtual Panel Panel8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x0000ED76 File Offset: 0x0000CF76
		// (set) Token: 0x06001487 RID: 5255 RVA: 0x00082EC0 File Offset: 0x000810C0
		internal virtual CheckBox CheckBoxEnviarAnexo
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxEnviarAnexo;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxEnviarAnexo_CheckedChanged);
				CheckBox checkBoxEnviarAnexo = this._CheckBoxEnviarAnexo;
				if (checkBoxEnviarAnexo != null)
				{
					checkBoxEnviarAnexo.CheckedChanged -= value2;
				}
				this._CheckBoxEnviarAnexo = value;
				checkBoxEnviarAnexo = this._CheckBoxEnviarAnexo;
				if (checkBoxEnviarAnexo != null)
				{
					checkBoxEnviarAnexo.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x0000ED80 File Offset: 0x0000CF80
		// (set) Token: 0x06001489 RID: 5257 RVA: 0x00082F04 File Offset: 0x00081104
		internal virtual Button BtnProcurarAnexo
		{
			[CompilerGenerated]
			get
			{
				return this._BtnProcurarAnexo;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BtnProcurarAnexo_Click);
				Button btnProcurarAnexo = this._BtnProcurarAnexo;
				if (btnProcurarAnexo != null)
				{
					btnProcurarAnexo.Click -= value2;
				}
				this._BtnProcurarAnexo = value;
				btnProcurarAnexo = this._BtnProcurarAnexo;
				if (btnProcurarAnexo != null)
				{
					btnProcurarAnexo.Click += value2;
				}
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x0000ED8A File Offset: 0x0000CF8A
		// (set) Token: 0x0600148B RID: 5259 RVA: 0x00082F48 File Offset: 0x00081148
		internal virtual TextBox TextBoxAnexoPath
		{
			[CompilerGenerated]
			get
			{
				return this._TextBoxAnexoPath;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextBoxAnexoPath_TextChanged);
				TextBox textBoxAnexoPath = this._TextBoxAnexoPath;
				if (textBoxAnexoPath != null)
				{
					textBoxAnexoPath.TextChanged -= value2;
				}
				this._TextBoxAnexoPath = value;
				textBoxAnexoPath = this._TextBoxAnexoPath;
				if (textBoxAnexoPath != null)
				{
					textBoxAnexoPath.TextChanged += value2;
				}
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x0000ED94 File Offset: 0x0000CF94
		// (set) Token: 0x0600148D RID: 5261 RVA: 0x0000ED9E File Offset: 0x0000CF9E
		internal virtual Panel Panel9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x0000EDA7 File Offset: 0x0000CFA7
		// (set) Token: 0x0600148F RID: 5263 RVA: 0x0000EDB1 File Offset: 0x0000CFB1
		internal virtual Panel Panel10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x0000EDBA File Offset: 0x0000CFBA
		// (set) Token: 0x06001491 RID: 5265 RVA: 0x00082F8C File Offset: 0x0008118C
		internal virtual CheckBox CheckBoxFiltrarExtração
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxFiltrarExtração;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxFiltrarExtração_CheckedChanged);
				CheckBox checkBoxFiltrarExtração = this._CheckBoxFiltrarExtração;
				if (checkBoxFiltrarExtração != null)
				{
					checkBoxFiltrarExtração.CheckedChanged -= value2;
				}
				this._CheckBoxFiltrarExtração = value;
				checkBoxFiltrarExtração = this._CheckBoxFiltrarExtração;
				if (checkBoxFiltrarExtração != null)
				{
					checkBoxFiltrarExtração.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x0000EDC4 File Offset: 0x0000CFC4
		// (set) Token: 0x06001493 RID: 5267 RVA: 0x0000EDCE File Offset: 0x0000CFCE
		internal virtual TextBox TextBoxFiltroExtração { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001494 RID: 5268 RVA: 0x0000EDD7 File Offset: 0x0000CFD7
		// (set) Token: 0x06001495 RID: 5269 RVA: 0x0000EDE1 File Offset: 0x0000CFE1
		internal virtual Panel Panel11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001496 RID: 5270 RVA: 0x0000EDEA File Offset: 0x0000CFEA
		// (set) Token: 0x06001497 RID: 5271 RVA: 0x0000EDF4 File Offset: 0x0000CFF4
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06001498 RID: 5272 RVA: 0x0000EDFD File Offset: 0x0000CFFD
		// (set) Token: 0x06001499 RID: 5273 RVA: 0x0000EE07 File Offset: 0x0000D007
		internal virtual TextBox TextBoxDelayImagem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x0600149A RID: 5274 RVA: 0x0000EE10 File Offset: 0x0000D010
		// (set) Token: 0x0600149B RID: 5275 RVA: 0x0000EE1A File Offset: 0x0000D01A
		internal virtual Panel Panel12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x0000EE23 File Offset: 0x0000D023
		// (set) Token: 0x0600149D RID: 5277 RVA: 0x0000EE2D File Offset: 0x0000D02D
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x0600149E RID: 5278 RVA: 0x0000EE36 File Offset: 0x0000D036
		// (set) Token: 0x0600149F RID: 5279 RVA: 0x0000EE40 File Offset: 0x0000D040
		internal virtual TextBox TextBoxParada { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x060014A0 RID: 5280 RVA: 0x0000EE49 File Offset: 0x0000D049
		// (set) Token: 0x060014A1 RID: 5281 RVA: 0x0000EE53 File Offset: 0x0000D053
		internal virtual Panel Panel13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x060014A2 RID: 5282 RVA: 0x0000EE5C File Offset: 0x0000D05C
		// (set) Token: 0x060014A3 RID: 5283 RVA: 0x0000EE66 File Offset: 0x0000D066
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x060014A4 RID: 5284 RVA: 0x0000EE6F File Offset: 0x0000D06F
		// (set) Token: 0x060014A5 RID: 5285 RVA: 0x0000EE79 File Offset: 0x0000D079
		internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x060014A6 RID: 5286 RVA: 0x0000EE82 File Offset: 0x0000D082
		// (set) Token: 0x060014A7 RID: 5287 RVA: 0x00082FD0 File Offset: 0x000811D0
		internal virtual CheckBox CheckBoxNaoDuplicar
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxNaoDuplicar;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxNaoDuplicar_CheckedChanged);
				CheckBox checkBoxNaoDuplicar = this._CheckBoxNaoDuplicar;
				if (checkBoxNaoDuplicar != null)
				{
					checkBoxNaoDuplicar.CheckedChanged -= value2;
				}
				this._CheckBoxNaoDuplicar = value;
				checkBoxNaoDuplicar = this._CheckBoxNaoDuplicar;
				if (checkBoxNaoDuplicar != null)
				{
					checkBoxNaoDuplicar.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x060014A8 RID: 5288 RVA: 0x0000EE8C File Offset: 0x0000D08C
		// (set) Token: 0x060014A9 RID: 5289 RVA: 0x0000EE96 File Offset: 0x0000D096
		internal virtual Panel Panel16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x0000EE9F File Offset: 0x0000D09F
		// (set) Token: 0x060014AB RID: 5291 RVA: 0x0000EEA9 File Offset: 0x0000D0A9
		internal virtual Panel Panel17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x060014AC RID: 5292 RVA: 0x0000EEB2 File Offset: 0x0000D0B2
		// (set) Token: 0x060014AD RID: 5293 RVA: 0x00083014 File Offset: 0x00081214
		internal virtual Button Button2
		{
			[CompilerGenerated]
			get
			{
				return this._Button2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button2_Click);
				Button button = this._Button2;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button2 = value;
				button = this._Button2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x060014AE RID: 5294 RVA: 0x0000EEBC File Offset: 0x0000D0BC
		// (set) Token: 0x060014AF RID: 5295 RVA: 0x0000EEC6 File Offset: 0x0000D0C6
		internal virtual TextBox TextBoxAnexoPath3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x0000EECF File Offset: 0x0000D0CF
		// (set) Token: 0x060014B1 RID: 5297 RVA: 0x0000EED9 File Offset: 0x0000D0D9
		internal virtual Panel Panel14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x0000EEE2 File Offset: 0x0000D0E2
		// (set) Token: 0x060014B3 RID: 5299 RVA: 0x0000EEEC File Offset: 0x0000D0EC
		internal virtual Panel Panel15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x0000EEF5 File Offset: 0x0000D0F5
		// (set) Token: 0x060014B5 RID: 5301 RVA: 0x00083058 File Offset: 0x00081258
		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return this._Button1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click_1);
				Button button = this._Button1;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button1 = value;
				button = this._Button1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x0000EEFF File Offset: 0x0000D0FF
		// (set) Token: 0x060014B7 RID: 5303 RVA: 0x0000EF09 File Offset: 0x0000D109
		internal virtual TextBox TextBoxAnexoPath2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x0000EF12 File Offset: 0x0000D112
		// (set) Token: 0x060014B9 RID: 5305 RVA: 0x0000EF1C File Offset: 0x0000D11C
		internal virtual Panel Panel19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x0000EF25 File Offset: 0x0000D125
		// (set) Token: 0x060014BB RID: 5307 RVA: 0x0008309C File Offset: 0x0008129C
		internal virtual CheckBox CheckBox2
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBox2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox2_CheckedChanged);
				CheckBox checkBox = this._CheckBox2;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				this._CheckBox2 = value;
				checkBox = this._CheckBox2;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x0000EF2F File Offset: 0x0000D12F
		// (set) Token: 0x060014BD RID: 5309 RVA: 0x000830E0 File Offset: 0x000812E0
		internal virtual Label Label9
		{
			[CompilerGenerated]
			get
			{
				return this._Label9;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label9_Click);
				Label label = this._Label9;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label9 = value;
				label = this._Label9;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x0000EF39 File Offset: 0x0000D139
		// (set) Token: 0x060014BF RID: 5311 RVA: 0x0000EF43 File Offset: 0x0000D143
		internal virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x060014C0 RID: 5312 RVA: 0x0000EF4C File Offset: 0x0000D14C
		// (set) Token: 0x060014C1 RID: 5313 RVA: 0x0000EF56 File Offset: 0x0000D156
		internal virtual Panel Panel18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x060014C2 RID: 5314 RVA: 0x0000EF5F File Offset: 0x0000D15F
		// (set) Token: 0x060014C3 RID: 5315 RVA: 0x00083124 File Offset: 0x00081324
		internal virtual CheckBox CheckBox1
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox1_CheckedChanged);
				CheckBox checkBox = this._CheckBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				this._CheckBox1 = value;
				checkBox = this._CheckBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x0000EF69 File Offset: 0x0000D169
		// (set) Token: 0x060014C5 RID: 5317 RVA: 0x0000EF73 File Offset: 0x0000D173
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x0000EF7C File Offset: 0x0000D17C
		// (set) Token: 0x060014C7 RID: 5319 RVA: 0x0000EF86 File Offset: 0x0000D186
		internal virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x060014C8 RID: 5320 RVA: 0x0000EF8F File Offset: 0x0000D18F
		// (set) Token: 0x060014C9 RID: 5321 RVA: 0x0000EF99 File Offset: 0x0000D199
		internal virtual Panel Panel20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x0000EFA2 File Offset: 0x0000D1A2
		// (set) Token: 0x060014CB RID: 5323 RVA: 0x00083168 File Offset: 0x00081368
		internal virtual CheckBox CheckBox3
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBox3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox3_CheckedChanged);
				CheckBox checkBox = this._CheckBox3;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				this._CheckBox3 = value;
				checkBox = this._CheckBox3;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x060014CC RID: 5324 RVA: 0x0000EFAC File Offset: 0x0000D1AC
		// (set) Token: 0x060014CD RID: 5325 RVA: 0x0000EFB6 File Offset: 0x0000D1B6
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x060014CE RID: 5326 RVA: 0x0000EFBF File Offset: 0x0000D1BF
		// (set) Token: 0x060014CF RID: 5327 RVA: 0x0000EFC9 File Offset: 0x0000D1C9
		internal virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x060014D0 RID: 5328 RVA: 0x0000EFD2 File Offset: 0x0000D1D2
		// (set) Token: 0x060014D1 RID: 5329 RVA: 0x0000EFDC File Offset: 0x0000D1DC
		internal virtual Panel Panel21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x0000EFE5 File Offset: 0x0000D1E5
		// (set) Token: 0x060014D3 RID: 5331 RVA: 0x000831AC File Offset: 0x000813AC
		internal virtual CheckBox CheckBoxColou
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBoxColou;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBoxColou_CheckedChanged);
				CheckBox checkBoxColou = this._CheckBoxColou;
				if (checkBoxColou != null)
				{
					checkBoxColou.CheckedChanged -= value2;
				}
				this._CheckBoxColou = value;
				checkBoxColou = this._CheckBoxColou;
				if (checkBoxColou != null)
				{
					checkBoxColou.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x060014D4 RID: 5332 RVA: 0x0000EFEF File Offset: 0x0000D1EF
		// (set) Token: 0x060014D5 RID: 5333 RVA: 0x0000EFF9 File Offset: 0x0000D1F9
		internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x060014D6 RID: 5334 RVA: 0x0000F002 File Offset: 0x0000D202
		// (set) Token: 0x060014D7 RID: 5335 RVA: 0x0000F00C File Offset: 0x0000D20C
		internal virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x0000F015 File Offset: 0x0000D215
		// (set) Token: 0x060014D9 RID: 5337 RVA: 0x000831F0 File Offset: 0x000813F0
		internal virtual Button Button5
		{
			[CompilerGenerated]
			get
			{
				return this._Button5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button5_Click);
				Button button = this._Button5;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button5 = value;
				button = this._Button5;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x0000F01F File Offset: 0x0000D21F
		// (set) Token: 0x060014DB RID: 5339 RVA: 0x00083234 File Offset: 0x00081434
		internal virtual Button Button4
		{
			[CompilerGenerated]
			get
			{
				return this._Button4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button4_Click);
				Button button = this._Button4;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button4 = value;
				button = this._Button4;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x060014DC RID: 5340 RVA: 0x0000F029 File Offset: 0x0000D229
		// (set) Token: 0x060014DD RID: 5341 RVA: 0x00083278 File Offset: 0x00081478
		internal virtual Button Button3
		{
			[CompilerGenerated]
			get
			{
				return this._Button3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button3_Click_1);
				Button button = this._Button3;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button3 = value;
				button = this._Button3;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x060014DE RID: 5342 RVA: 0x0000F033 File Offset: 0x0000D233
		// (set) Token: 0x060014DF RID: 5343 RVA: 0x0000F03D File Offset: 0x0000D23D
		internal virtual TextBox TextBoxTabs { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x060014E0 RID: 5344 RVA: 0x0000F046 File Offset: 0x0000D246
		// (set) Token: 0x060014E1 RID: 5345 RVA: 0x0000F050 File Offset: 0x0000D250
		internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060014E2 RID: 5346
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, IntPtr dwExtraInfo);

		// Token: 0x060014E3 RID: 5347 RVA: 0x0000F059 File Offset: 0x0000D259
		private void PressCtrl()
		{
			FacebookPostGruposDiscussãoFormPrincipal.keybd_event(17, 0, 0, IntPtr.Zero);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0000F06B File Offset: 0x0000D26B
		private void ReleaseCtrl()
		{
			FacebookPostGruposDiscussãoFormPrincipal.keybd_event(17, 0, 2, IntPtr.Zero);
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x000832BC File Offset: 0x000814BC
		private void FormPrincipal_Load(object sender, EventArgs e)
		{
			bool flag = MySettingsProperty.Settings.fpd1 == 1;
			if (flag)
			{
				this.CheckBoxNaoDuplicar.Checked = true;
			}
			else
			{
				this.CheckBoxNaoDuplicar.Checked = false;
			}
			bool flag2 = MySettingsProperty.Settings.fpd2 == 1;
			if (flag2)
			{
				this.CheckBox1.Checked = true;
			}
			else
			{
				this.CheckBox1.Checked = false;
			}
			bool flag3 = MySettingsProperty.Settings.fpd3 == 1;
			if (flag3)
			{
				this.CheckBox2.Checked = true;
			}
			else
			{
				this.CheckBox2.Checked = false;
			}
			bool flag4 = MySettingsProperty.Settings.fpd4 == 1;
			if (flag4)
			{
				this.CheckBox3.Checked = true;
			}
			else
			{
				this.CheckBox3.Checked = false;
			}
			bool flag5 = MySettingsProperty.Settings.fpd5 == 1;
			if (flag5)
			{
				this.CheckBoxColou.Checked = true;
			}
			else
			{
				this.CheckBoxColou.Checked = false;
			}
			List<Control> ignorar = new List<Control>
			{
				this.LabelStatus,
				this.LabelRelatórioCount
			};
			Tradução.Traduzir(this, ignorar);
			this.CS_LGS();
			bool facebookPostGruposDiscussãoFiltrarExtração = MySettingsProperty.Settings.FacebookPostGruposDiscussãoFiltrarExtração;
			if (facebookPostGruposDiscussãoFiltrarExtração)
			{
				this.CheckBoxFiltrarExtração.CheckState = CheckState.Checked;
			}
			else
			{
				this.CheckBoxFiltrarExtração.CheckState = CheckState.Unchecked;
			}
			this.CarregarGrupos();
			this.CarregarPostagens();
			bool facebookPostGruposDiscussãoEnviarAnexo = MySettingsProperty.Settings.FacebookPostGruposDiscussãoEnviarAnexo;
			if (facebookPostGruposDiscussãoEnviarAnexo)
			{
				this.CheckBoxEnviarAnexo.CheckState = CheckState.Checked;
			}
			else
			{
				this.CheckBoxEnviarAnexo.CheckState = CheckState.Unchecked;
			}
			this.TextBoxAnexoPath.Text = MySettingsProperty.Settings.FacebookPostGruposDiscussãoAnexo;
			this.TextBoxDelayApósColarPostagem.Text = Conversions.ToString(MySettingsProperty.Settings.FacebookPostGruposDiscussãoDelayApósColarPostagem);
			this.TextBoxDelay.Text = Conversions.ToString(MySettingsProperty.Settings.FacebookPostGruposDiscussãoDelay);
			this.TextBoxDelayAleatório.Text = Conversions.ToString(MySettingsProperty.Settings.FacebookPostGruposDiscussãoDelayAleatórioAdicional);
			this.CarregarRelatório();
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x000834D0 File Offset: 0x000816D0
		public void CS_LGS()
		{
			bool flag = Operators.CompareString(RSL.RL(this.NomeDoSoftware), "A0", false) == 0;
			if (flag)
			{
				this.Text = string.Format(Tradução.Str("{0} - (Licença para demonstração)"), this.NomeDoSoftware);
			}
			bool flag2 = Operators.CompareString(RSL.RL(this.NomeDoSoftware), "B1", false) == 0;
			if (flag2)
			{
				this.Text = string.Format(Tradução.Str("{0} - (Licença ativada padrão)"), this.NomeDoSoftware);
			}
			bool flag3 = Operators.CompareString(RSL.RL(this.NomeDoSoftware), "C2", false) == 0;
			if (flag3)
			{
				this.Text = string.Format(Tradução.Str("{0} - (Licença ativada) - {1}"), this.NomeDoSoftware, RSL.RLGS(this.NomeDoSoftware));
			}
			bool flag4 = Operators.CompareString(RSL.RL(this.NomeDoSoftware), "D3", false) == 0;
			if (flag4)
			{
				this.Text = string.Format(Tradução.Str("{0} - (Licença ativada) - Master"), this.NomeDoSoftware);
			}
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x000835D8 File Offset: 0x000817D8
		public void AbrirChrome()
		{
			int num2;
			int num4;
			object obj;
			try
			{
				IL_02:
				int num = 1;
				ChromeOptions chromeOptions = new ChromeOptions();
				IL_0A:
				num = 2;
				chromeOptions.AddArguments(new string[]
				{
					"user-data-dir=" + MyProject.Application.Info.DirectoryPath + "\\chromeFPD"
				});
				IL_3A:
				num = 3;
				chromeOptions.AddExcludedArgument("enable-automation");
				IL_48:
				num = 4;
				chromeOptions.AddAdditionalCapability("useAutomationExtension", false);
				IL_5C:
				num = 5;
				chromeOptions.AddArguments(new string[]
				{
					"--disable-extensions"
				});
				IL_73:
				num = 6;
				chromeOptions.AddArguments(new string[]
				{
					"--disable-notifications"
				});
				IL_8A:
				num = 7;
				this.Service.HideCommandPromptWindow = true;
				IL_99:
				ProjectData.ClearProjectError();
				num2 = -2;
				IL_A2:
				num = 9;
				this.ChromeDriver = new ChromeDriver(this.Service, chromeOptions);
				IL_B7:
				num = 10;
				this.Chrome = new EventFiringWebDriver(this.ChromeDriver);
				IL_CB:
				num = 11;
				this.Chrome.Navigate().GoToUrl("https://www.facebook.com/");
				IL_E4:
				goto IL_16E;
				IL_E9:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_127:
				goto IL_163;
				IL_129:
				num4 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num2 > -2) ? num2 : 1);
				IL_141:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_129;
			}
			IL_163:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_16E:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00083778 File Offset: 0x00081978
		private void BtnAbrirNavegador_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(((Button)sender).Text, Tradução.Str("Abrir navegador"), false) == 0;
			if (flag)
			{
				((Button)sender).Text = Tradução.Str("Carregando...");
				((Button)sender).Enabled = false;
				this.AbrirChrome();
				this.BtnIniciar.Enabled = true;
				this.BtnExtrairMeusGrupos.Enabled = true;
				((Button)sender).Text = Tradução.Str("Fechar navegador");
				((Button)sender).Enabled = true;
			}
			else
			{
				((Button)sender).Text = Tradução.Str("Carregando...");
				((Button)sender).Enabled = false;
				this.BtnIniciar.Enabled = false;
				this.BtnExtrairMeusGrupos.Enabled = false;
				this.Parar();
				this.Chrome.Quit();
				try
				{
					this.ChromeDriver.Close();
				}
				catch (Exception ex)
				{
					foreach (Process process in Process.GetProcessesByName("chromedriver"))
					{
						try
						{
							process.Kill();
							process.WaitForExit();
						}
						catch (Exception ex2)
						{
							MessageBox.Show("Erro ao finalizar o processo: " + ex.Message);
						}
					}
				}
				((Button)sender).Text = Tradução.Str("Abrir navegador");
				((Button)sender).Enabled = true;
			}
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x0000F07D File Offset: 0x0000D27D
		public void Status(string StatusStr)
		{
			this.LabelStatus.Text = string.Format("Status: {0}", StatusStr);
			this.Refresh();
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00083924 File Offset: 0x00081B24
		public void ObterGruposCount()
		{
			this.LabelGruposCount.Text = string.Format(Tradução.Str("Grupos: {0}"), this.ListViewGrupos.Items.Count);
			this.LabelGruposRestantesCount.Text = string.Format(Tradução.Str("Grupos restantes: {0}"), this.ListViewGrupos.Items.Count);
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x00083994 File Offset: 0x00081B94
		public void GravarGrupos()
		{
			MySettingsProperty.Settings.FacebookPostGruposDiscussãoGrupos = new StringCollection();
			MySettingsProperty.Settings.FacebookPostGruposDiscussãoGrupos.AddRange(this.ListViewGrupos.Items.Cast<ListViewItem>().Select((FacebookPostGruposDiscussãoFormPrincipal._Closure$__.$I419-0 == null) ? (FacebookPostGruposDiscussãoFormPrincipal._Closure$__.$I419-0 = ((ListViewItem lvi) => string.Join("\t", lvi.SubItems.Cast<ListViewItem.ListViewSubItem>().Select((FacebookPostGruposDiscussãoFormPrincipal._Closure$__.$I419-1 == null) ? (FacebookPostGruposDiscussãoFormPrincipal._Closure$__.$I419-1 = ((ListViewItem.ListViewSubItem si) => si.Text)) : FacebookPostGruposDiscussãoFormPrincipal._Closure$__.$I419-1)))) : FacebookPostGruposDiscussãoFormPrincipal._Closure$__.$I419-0).ToArray<string>());
			MySettingsProperty.Settings.Save();
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00083A0C File Offset: 0x00081C0C
		public void CarregarGrupos()
		{
			bool flag = MySettingsProperty.Settings.FacebookPostGruposDiscussãoGrupos == null;
			if (flag)
			{
				MySettingsProperty.Settings.FacebookPostGruposDiscussãoGrupos = new StringCollection();
			}
			this.ListViewGrupos.Items.AddRange(MySettingsProperty.Settings.FacebookPostGruposDiscussãoGrupos.Cast<string>().Select((FacebookPostGruposDiscussãoFormPrincipal._Closure$__.$I420-0 == null) ? (FacebookPostGruposDiscussãoFormPrincipal._Closure$__.$I420-0 = ((string lvi) => new ListViewItem(lvi.Split(new char[]
			{
				'\t'
			})))) : FacebookPostGruposDiscussãoFormPrincipal._Closure$__.$I420-0).ToArray<ListViewItem>());
			this.ObterGruposCount();
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x0000F09E File Offset: 0x0000D29E
		public void LimparGrupos()
		{
			this.ListViewGrupos.Items.Clear();
			this.ObterGruposCount();
			MySettingsProperty.Settings.FacebookPostGruposDiscussãoGrupos.Clear();
			MySettingsProperty.Settings.Save();
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x0000F0D4 File Offset: 0x0000D2D4
		private void BtnExportarGrupos_Click(object sender, EventArgs e)
		{
			ListViewTools.ExportarListView(this.ListViewGrupos, string.Format(Tradução.Str("{0} Grupos de Facebook"), this.ListViewGrupos.Items.Count));
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x0000F107 File Offset: 0x0000D307
		private void BtnImportarGrupos_Click(object sender, EventArgs e)
		{
			ListViewTools.ImportarListView(this.ListViewGrupos, "|");
			this.ObterGruposCount();
			this.GravarGrupos();
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x0000F129 File Offset: 0x0000D329
		private void BtnLimparGrupos_Click(object sender, EventArgs e)
		{
			this.LimparGrupos();
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x00083A94 File Offset: 0x00081C94
		private void CheckBoxFiltrarExtração_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.CheckBoxFiltrarExtração.CheckState == CheckState.Checked;
			if (flag)
			{
				MySettingsProperty.Settings.FacebookPostGruposDiscussãoFiltrarExtração = true;
			}
			else
			{
				MySettingsProperty.Settings.FacebookPostGruposDiscussãoFiltrarExtração = false;
			}
			MySettingsProperty.Settings.Save();
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x00083ADC File Offset: 0x00081CDC
		public void IniciarExtraçãoGrupos()
		{
			this.BtnExtrairMeusGrupos.Text = Tradução.Str("Parar");
			this.Refresh();
			bool @checked = this.RbtnGParticipa.Checked;
			if (@checked)
			{
				this.Chrome.Navigate().GoToUrl("https://www.facebook.com/groups/joins/");
			}
			bool checked2 = this.RbtnGGerencia.Checked;
			if (checked2)
			{
				this.Chrome.Navigate().GoToUrl("https://m.facebook.com/groups_browse/your_groups/manage/");
			}
			this.TimerGruposExtração.Start();
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0000F133 File Offset: 0x0000D333
		public void PararExtraçãoGrupos()
		{
			this.TimerGruposExtração.Stop();
			this.GravarGrupos();
			this.BtnExtrairMeusGrupos.Text = Tradução.Str("Extrair");
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x00083B64 File Offset: 0x00081D64
		private void BtnExtrairMeusGrupos_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.BtnExtrairMeusGrupos.Text, Tradução.Str("Extrair"), false) == 0;
			if (flag)
			{
				this.IniciarExtraçãoGrupos();
			}
			else
			{
				this.PararExtraçãoGrupos();
			}
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x00083BA8 File Offset: 0x00081DA8
		private void TimerGruposExtração_Tick(object sender, EventArgs e)
		{
			string xpathToFind = string.Empty;
			xpathToFind = "//div[@class='x78zum5 xdt5ytf x1iyjqo2 x1n2onr6']//a[contains(@href,'/groups/')]";
			ReadOnlyCollection<IWebElement> readOnlyCollection = this.Chrome.FindElements(By.XPath(xpathToFind));
			try
			{
				foreach (IWebElement webElement in readOnlyCollection)
				{
					bool flag = Operators.CompareString(webElement.GetAttribute("href"), "Extraído", false) != 0;
					if (flag)
					{
						try
						{
							string text = webElement.FindElement(By.XPath(".//span[@class='x1lliihq x6ikm8r x10wlt62 x1n2onr6 x1j85h84']/span[@class='x193iq5w xeuugli x13faqbe x1vvkbs x1xmvt09 x6prxxf xvq8zen x1s688f xzsf02u']")).Text;
							string text2 = webElement.GetAttribute("href");
							Regex regex = new Regex("(?<=/groups/)(.*?)(?=/)", RegexOptions.IgnoreCase);
							text2 = regex.Match(text2).Value;
							ListViewItem listViewItem = this.ListViewGrupos.Items.Add(text);
							listViewItem.SubItems.Add(text2);
							this.Chrome.ExecuteScript("arguments[0].setAttribute('href', 'Extraído');", new object[]
							{
								webElement
							});
							this.Chrome.ExecuteScript("arguments[0].focus();", new object[]
							{
								webElement
							});
						}
						catch (Exception ex)
						{
						}
					}
				}
			}
			finally
			{
				IEnumerator<IWebElement> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			this.ObterGruposCount();
			try
			{
				string xpathToFind2 = string.Empty;
				bool @checked = this.RbtnGParticipa.Checked;
				if (@checked)
				{
					xpathToFind2 = "//div[@class='f4g9fmn2'][2]//div[@class='jxbw8zu1 b71ma7mt']";
				}
				bool checked2 = this.RbtnGGerencia.Checked;
				if (checked2)
				{
					xpathToFind2 = "//div[@class='f4g9fmn2'][1]//div[@class='jxbw8zu1 b71ma7mt']";
				}
				IWebElement webElement2 = this.Chrome.FindElement(By.XPath(xpathToFind2));
				this.Chrome.ExecuteScript("arguments[0].focus();", new object[]
				{
					webElement2
				});
				webElement2.Click();
			}
			catch (Exception ex2)
			{
			}
			try
			{
				IWebElement webElement3 = this.Chrome.FindElement(By.XPath("//div[@class='_k _77by _1a1e']"));
				this.Chrome.ExecuteScript("arguments[0].scrollTop += 500", new object[]
				{
					webElement3
				});
			}
			catch (Exception ex3)
			{
			}
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x00083DE0 File Offset: 0x00081FE0
		private void ListViewGrupos_KeyDown(object sender, KeyEventArgs e)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_02:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0B:
				int num2 = 2;
				this.ListViewGrupos.SelectedItems[0].Remove();
				IL_24:
				num2 = 3;
				this.GravarGrupos();
				IL_2D:
				num2 = 4;
				this.ObterGruposCount();
				IL_36:
				goto IL_A1;
				IL_38:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_5A:
				goto IL_96;
				IL_5C:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_74:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_5C;
			}
			IL_96:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_A1:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x0000F15F File Offset: 0x0000D35F
		public void ObterPostagensCount()
		{
			this.LabelMensagensCount.Text = string.Format("Postagens: {0}", this.Postagens.Count);
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x00083EA8 File Offset: 0x000820A8
		public void GravarPostagens()
		{
			bool flag = MySettingsProperty.Settings.FacebookPostGruposDiscussãoPostagens == null;
			if (flag)
			{
				MySettingsProperty.Settings.FacebookPostGruposDiscussãoPostagens = new StringCollection();
			}
			MySettingsProperty.Settings.FacebookPostGruposDiscussãoPostagens.Clear();
			try
			{
				foreach (string value in this.Postagens)
				{
					MySettingsProperty.Settings.FacebookPostGruposDiscussãoPostagens.Add(value);
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			MySettingsProperty.Settings.Save();
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x00083F48 File Offset: 0x00082148
		public void CarregarPostagensToListView()
		{
			this.ListViewDescrições.Items.Clear();
			try
			{
				foreach (string text in this.Postagens)
				{
					this.ListViewDescrições.Items.Add(text);
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00083FBC File Offset: 0x000821BC
		public void CarregarPostagensToListOfString()
		{
			this.Postagens.Clear();
			try
			{
				foreach (object obj in this.ListViewDescrições.Items)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					string text = listViewItem.Text;
					this.Postagens.Add(text);
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.GravarPostagens();
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00084044 File Offset: 0x00082244
		public void CarregarPostagens()
		{
			bool flag = MySettingsProperty.Settings.FacebookPostGruposDiscussãoPostagens != null;
			if (flag)
			{
				foreach (string item in MySettingsProperty.Settings.FacebookPostGruposDiscussãoPostagens)
				{
					this.Postagens.Add(item);
				}
			}
			this.CarregarPostagensToListView();
			this.ObterPostagensCount();
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x0000F188 File Offset: 0x0000D388
		public void ImportarPostagens()
		{
			ListOfStringTools.ImportarListOfString(this.Postagens);
			this.CarregarPostagensToListView();
			this.GravarPostagens();
			this.ObterPostagensCount();
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x0000F1AC File Offset: 0x0000D3AC
		public void ExportarMensagens()
		{
			ListOfStringTools.ExportarListOfString(this.Postagens, string.Format("Postagens {0}", this.Postagens.Count));
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x000840A4 File Offset: 0x000822A4
		public void LimparPostagens()
		{
			this.ListViewDescrições.Items.Clear();
			this.Postagens.Clear();
			this.ObterPostagensCount();
			MySettingsProperty.Settings.FacebookPostGruposDiscussãoPostagens.Clear();
			MySettingsProperty.Settings.Save();
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x000840F4 File Offset: 0x000822F4
		private void CheckBoxEnviarAnexo_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = ((CheckBox)sender).CheckState == CheckState.Checked;
			if (flag)
			{
				MySettingsProperty.Settings.FacebookPostGruposDiscussãoEnviarAnexo = true;
			}
			else
			{
				MySettingsProperty.Settings.FacebookPostGruposDiscussãoEnviarAnexo = false;
			}
			MySettingsProperty.Settings.Save();
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x0000F1D5 File Offset: 0x0000D3D5
		private void TextBoxAnexoPath_TextChanged(object sender, EventArgs e)
		{
			MySettingsProperty.Settings.FacebookPostGruposDiscussãoAnexo = this.TextBoxAnexoPath.Text;
			MySettingsProperty.Settings.Save();
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x0008413C File Offset: 0x0008233C
		private void BtnProcurarAnexo_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				InitialDirectory = MyProject.Computer.FileSystem.SpecialDirectories.Desktop
			};
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.TextBoxAnexoPath.Text = openFileDialog.FileName;
			}
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x0008418C File Offset: 0x0008238C
		private void BtnAddDescrição_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.RichTextBoxPostagem.Text, string.Empty, false) != 0;
			if (flag)
			{
				this.ListViewDescrições.Items.Add(this.RichTextBoxPostagem.Text);
				this.CarregarPostagensToListOfString();
				this.RichTextBoxPostagem.Clear();
				this.ObterPostagensCount();
			}
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x000841F0 File Offset: 0x000823F0
		private void ListViewDescrições_DoubleClick(object sender, EventArgs e)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_02:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0B:
				int num2 = 2;
				this.RichTextBoxPostagem.Text = ((ListView)sender).SelectedItems[0].Text;
				IL_2F:
				num2 = 3;
				((ListView)sender).Items.RemoveAt(((ListView)sender).SelectedIndices[0]);
				IL_53:
				goto IL_BA;
				IL_55:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_73:
				goto IL_AF;
				IL_75:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_8D:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_75;
			}
			IL_AF:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_BA:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x000842D0 File Offset: 0x000824D0
		private void ListViewDescrições_KeyDown(object sender, KeyEventArgs e)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_02:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0B:
				int num2 = 2;
				((ListView)sender).Items.RemoveAt(((ListView)sender).SelectedIndices[0]);
				IL_2F:
				num2 = 3;
				this.CarregarPostagensToListOfString();
				IL_38:
				num2 = 4;
				this.ObterPostagensCount();
				IL_41:
				num2 = 5;
				this.GravarRelatório();
				IL_4A:
				goto IL_B9;
				IL_4C:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_72:
				goto IL_AE;
				IL_74:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_8C:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_74;
			}
			IL_AE:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_B9:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x0000F1F9 File Offset: 0x0000D3F9
		private void BtnImportarDescrições_Click(object sender, EventArgs e)
		{
			this.ImportarPostagens();
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x0000F203 File Offset: 0x0000D403
		private void BtnExportarDescrições_Click(object sender, EventArgs e)
		{
			this.ExportarMensagens();
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x0000F20D File Offset: 0x0000D40D
		private void BtnLimparDescrições_Click(object sender, EventArgs e)
		{
			this.LimparPostagens();
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x000843B0 File Offset: 0x000825B0
		private void TextBoxDelayApósColarPostagem_TextChanged(object sender, EventArgs e)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_02:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0B:
				int num2 = 2;
				MySettingsProperty.Settings.FacebookPostGruposDiscussãoDelayApósColarPostagem = Conversions.ToInteger(this.TextBoxDelayApósColarPostagem.Text);
				IL_28:
				num2 = 3;
				MySettingsProperty.Settings.Save();
				IL_35:
				goto IL_9C;
				IL_37:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_55:
				goto IL_91;
				IL_57:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_6F:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_57;
			}
			IL_91:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_9C:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x00084474 File Offset: 0x00082674
		private void TextBoxDelay_TextChanged(object sender, EventArgs e)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_02:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0B:
				int num2 = 2;
				MySettingsProperty.Settings.FacebookPostGruposDiscussãoDelay = Conversions.ToInteger(this.TextBoxDelay.Text);
				IL_28:
				num2 = 3;
				MySettingsProperty.Settings.Save();
				IL_35:
				goto IL_9C;
				IL_37:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_55:
				goto IL_91;
				IL_57:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_6F:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_57;
			}
			IL_91:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_9C:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x00084538 File Offset: 0x00082738
		private void TextBoxDelayAleatório_TextChanged(object sender, EventArgs e)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_02:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0B:
				int num2 = 2;
				MySettingsProperty.Settings.FacebookPostGruposDiscussãoDelayAleatórioAdicional = Conversions.ToInteger(this.TextBoxDelayAleatório.Text);
				IL_28:
				num2 = 3;
				MySettingsProperty.Settings.Save();
				IL_35:
				goto IL_9C;
				IL_37:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_55:
				goto IL_91;
				IL_57:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_6F:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_57;
			}
			IL_91:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_9C:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x000845FC File Offset: 0x000827FC
		public void Iniciar()
		{
			bool flag = Operators.CompareString(RSL.RL(this.NomeDoSoftware), "A0", false) == 0;
			if (flag)
			{
				bool flag2 = (double)this.Postados() >= Conversion.Val(10.0);
				if (flag2)
				{
					this.Parar();
					MessageBox.Show(Tradução.Str("O limite da versão demonstração foi atingido! Obtenha a licença para poder continuar."), this.NomeDoSoftware, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			bool flag3 = this.ListViewGrupos.Items.Count == 0;
			if (flag3)
			{
				MessageBox.Show(Tradução.Str("Extraia ou importe grupos!"), this.NomeDoSoftware, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				bool flag4 = this.Postagens.Count == 0;
				if (flag4)
				{
					MessageBox.Show(Tradução.Str("Adicione ou importe postagens!"), this.NomeDoSoftware, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					this.TimerPrincipal.Start();
					this.Status(Tradução.Str("Iniciando..."));
					this.BtnIniciar.Text = Tradução.Str("Parar");
				}
			}
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x00084708 File Offset: 0x00082908
		public void Parar()
		{
			this.TimerPrincipal.Stop();
			this.ProgressBarPrincipal.Value = 0;
			this.Status(Tradução.Str("Parado!"));
			this.BtnIniciar.Text = Tradução.Str("Iniciar");
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x00084758 File Offset: 0x00082958
		private void BtnIniciar_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.BtnIniciar.Text, Tradução.Str("Iniciar"), false) == 0;
			if (flag)
			{
				this.Iniciar();
			}
			else
			{
				this.Parar();
			}
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x0008479C File Offset: 0x0008299C
		private void TimerPrincipal_Tick(object sender, EventArgs e)
		{
			ProgressBar progressBarPrincipal = this.ProgressBarPrincipal;
			progressBarPrincipal.Increment(1);
			checked
			{
				progressBarPrincipal.Maximum = (int)Math.Round(unchecked(4.0 + Conversion.Val(this.TextBoxDelay.Text) + (double)this.DelayAleatório));
				bool flag = progressBarPrincipal.Value == progressBarPrincipal.Maximum;
				if (flag)
				{
					progressBarPrincipal.Value = 0;
				}
				bool flag2 = progressBarPrincipal.Value == 1;
				if (flag2)
				{
					this.DelayAleatório = Conversions.ToInteger(Delays.DelayAleatório(Conversions.ToInteger(this.TextBoxDelayAleatório.Text)));
					bool flag3 = this.ListViewGrupos.Items.Count == 0;
					if (flag3)
					{
						this.Parar();
						MessageBox.Show(Tradução.Str("Processo concluído!"), this.NomeDoSoftware, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					try
					{
						this.Status(Tradução.Str("Carregando grupo..."));
						ListViewItem listViewItem = this.ListViewGrupos.Items[0];
						this.GrupoNome = listViewItem.Text;
						this.GrupoID = listViewItem.SubItems[1].Text;
						this.ListViewGrupos.Items[0].Remove();
						this.ObterGruposCount();
						this.GravarGrupos();
						this.Chrome.Navigate().GoToUrl("https://www.facebook.com/groups/" + this.GrupoID + "/buy_sell_discussion");
					}
					catch (Exception ex)
					{
					}
				}
				bool flag4 = progressBarPrincipal.Value == 2;
				if (flag4)
				{
					this.Status(Tradução.Str("Configurando postagem..."));
					try
					{
						string xpathToFind = "(//div[contains(@Class,'x6s0dn4 x9f619 x78zum5')]//span[contains(@class,'x193iq5w xeuugli x13faqbe x1vvkbs x1xmvt09 x1lliihq x1s928wv ')])[2]";
						WebDriverWait webDriverWait = new WebDriverWait(this.Chrome, TimeSpan.FromSeconds(3.0));
						webDriverWait.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(xpathToFind)));
					}
					catch (Exception ex2)
					{
					}
					try
					{
						string xpathToFind2 = "//span[contains(@class, 'x193iq5w xeuugli x13faqbe x1vvkbs x1xmvt09 x1lliihq x1s928wv xhkezso x1gmr53x x1cpjm7i x1fgarty x1943h6x xudqn12 x3x7a5m x6prxxf xvq8zen x1s688f xi81zsa') and text()='Discussão']";
						WebDriverWait webDriverWait2 = new WebDriverWait(this.Chrome, TimeSpan.FromSeconds(2.0));
						webDriverWait2.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind2)));
						this.Chrome.FindElement(By.XPath(xpathToFind2)).Click();
					}
					catch (Exception ex3)
					{
					}
					try
					{
						string xpathToFind3 = "//span[text()='Foto/vídeo']";
						WebDriverWait webDriverWait3 = new WebDriverWait(this.Chrome, TimeSpan.FromSeconds(3.0));
						webDriverWait3.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(xpathToFind3)));
						this.Chrome.FindElement(By.XPath(xpathToFind3)).Click();
					}
					catch (Exception ex4)
					{
						progressBarPrincipal.Value = 0;
						return;
					}
					try
					{
						string xpathToFind4 = "//div[@class='x78zum5 xl56j7k']";
						int num = Conversions.ToInteger(this.TextBoxDelayImagem.Text);
						WebDriverWait webDriverWait4 = new WebDriverWait(this.Chrome, TimeSpan.FromSeconds((double)num));
						webDriverWait4.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind4)));
						IWebElement webElement = this.Chrome.FindElement(By.XPath(xpathToFind4));
						this.Chrome.FindElement(By.XPath(xpathToFind4)).Click();
						Thread.Sleep(500);
					}
					catch (Exception ex5)
					{
						this.AdicionarNoRelatório("#001", this.GrupoNome);
						progressBarPrincipal.Value = 0;
					}
					bool flag5 = Operators.CompareString(this.TextBoxAnexoPath.Text, "", false) != 0;
					if (flag5)
					{
						try
						{
							Thread.Sleep(2000);
							string xpathToFind5 = "//input[@type='file']";
							IWebElement webElement2 = this.Chrome.FindElement(By.XPath(xpathToFind5));
							string text = this.TextBoxAnexoPath.Text;
							bool flag6 = File.Exists(text);
							if (!flag6)
							{
								throw new Exception("O caminho do arquivo não é válido: " + text);
							}
							webElement2.SendKeys(text);
							Thread.Sleep(1000);
						}
						catch (Exception ex6)
						{
						}
					}
					Thread.Sleep(3000);
					bool flag7 = !this.CheckBoxColou.Checked;
					if (flag7)
					{
						bool flag8 = Operators.CompareString(this.CheckBoxEnviarAnexo.Text, "", false) == 0;
						if (flag8)
						{
							try
							{
								string text2 = this.TextBoxAnexoPath.Text;
								string xpathToFind6 = "//div[@class='x1n2onr6 x1ja2u2z x1jx94hy x1qpq9i9 xdney7k xu5ydu1 xt3gfkd x9f619 xh8yej3 x6ikm8r x10wlt62 xquyuld']";
								WebDriverWait webDriverWait5 = new WebDriverWait(this.Chrome, TimeSpan.FromSeconds(1.0));
								webDriverWait5.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(xpathToFind6)));
								IWebElement toElement = this.Chrome.FindElement(By.XPath(xpathToFind6));
								Actions actions = new Actions(this.Chrome);
								Thread.Sleep(10);
								actions.MoveToElement(toElement).SendKeys(OpenQA.Selenium.Keys.Tab);
								Thread.Sleep(10);
								actions.MoveToElement(toElement).SendKeys(OpenQA.Selenium.Keys.Tab);
								Thread.Sleep(10);
								actions.MoveToElement(toElement).SendKeys(OpenQA.Selenium.Keys.Tab);
								Thread.Sleep(10);
								actions.MoveToElement(toElement).SendKeys(OpenQA.Selenium.Keys.Tab).SendKeys(OpenQA.Selenium.Keys.Enter).Perform();
							}
							catch (Exception ex7)
							{
							}
						}
					}
					this.TextoImagem();
					try
					{
						string text3 = this.TextBoxAnexoPath.Text;
						string xpathToFind7 = "//div[@class='x1n2onr6 x1ja2u2z x1jx94hy x1qpq9i9 xdney7k xu5ydu1 xt3gfkd x9f619 xh8yej3 x6ikm8r x10wlt62 xquyuld']";
						WebDriverWait webDriverWait6 = new WebDriverWait(this.Chrome, TimeSpan.FromSeconds(1.0));
						webDriverWait6.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(xpathToFind7)));
						IWebElement toElement2 = this.Chrome.FindElement(By.XPath(xpathToFind7));
						Actions actions2 = new Actions(this.Chrome);
						int num2;
						bool flag9 = int.TryParse(this.TextBoxTabs.Text, out num2);
						if (flag9)
						{
							int num3 = num2;
							for (int i = 1; i <= num3; i++)
							{
								actions2.MoveToElement(toElement2).SendKeys(OpenQA.Selenium.Keys.Tab);
								Thread.Sleep(500);
							}
							bool flag10 = !this.CheckBoxEnviarAnexo.Checked;
							if (flag10)
							{
								int num4 = 1;
								do
								{
									actions2.MoveToElement(toElement2).SendKeys(OpenQA.Selenium.Keys.Tab);
									Thread.Sleep(500);
									num4++;
								}
								while (num4 <= 2);
							}
						}
						else
						{
							MessageBox.Show("Digite um número válido na TextBox!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
						bool flag11 = !this.CheckBoxColou.Checked;
						if (flag11)
						{
							actions2.MoveToElement(toElement2).SendKeys(OpenQA.Selenium.Keys.Tab);
							Thread.Sleep(500);
						}
						actions2.MoveToElement(toElement2).SendKeys(OpenQA.Selenium.Keys.Tab).SendKeys(OpenQA.Selenium.Keys.Enter).Perform();
						Thread.Sleep(3000);
						progressBarPrincipal.Value = 3;
					}
					catch (Exception ex8)
					{
						Console.WriteLine("Erro");
					}
				}
				bool flag12 = progressBarPrincipal.Value == 3;
				if (flag12)
				{
					bool flag13 = false;
					try
					{
						this.Chrome.FindElement(By.XPath("//form[@method='POST']//div[@role='presentation']"));
						flag13 = true;
					}
					catch (Exception ex9)
					{
						flag13 = false;
					}
					bool flag14 = !flag13;
					if (!flag14)
					{
						progressBarPrincipal.Value = 2;
						return;
					}
					this.Status(Tradução.Str("Postou!"));
					this.AdicionarNoRelatório(Tradução.Str("Postou"), this.GrupoNome);
					bool flag15 = Operators.CompareString(RSL.RL(this.NomeDoSoftware), "A0", false) == 0;
					if (flag15)
					{
						bool flag16 = (double)this.Postados() >= Conversion.Val(10.0);
						if (flag16)
						{
							this.Parar();
							MessageBox.Show(Tradução.Str("O limite da versão demonstração foi atingido! Obtenha a licença para poder continuar."), this.NomeDoSoftware, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							return;
						}
					}
				}
				bool flag17 = progressBarPrincipal.Value >= 4;
				if (flag17)
				{
					string statusStr = string.Format(Tradução.Str("Aguardando delay... {0}/{1}"), progressBarPrincipal.Value - 4, progressBarPrincipal.Maximum - 4);
					this.Status(statusStr);
				}
			}
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x00085098 File Offset: 0x00083298
		public object CodigoInutil()
		{
			string xpathToFind = "//DIV[@class='x10l6tqk x12y6twl x160vmok x1tk7jg1']";
			WebDriverWait webDriverWait = new WebDriverWait(this.Chrome, TimeSpan.FromSeconds(3.0));
			webDriverWait.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(xpathToFind)));
			this.Chrome.FindElement(By.XPath(xpathToFind)).Click();
			Thread.Sleep(1000);
			string xpathToFind2 = "//img[@class='x1b0d499 xl1xv1r' and @src='https://static.xx.fbcdn.net/rsrc.php/v3/y7/r/Ivw7nhRtXyo.png' and @style='height: 24px; width: 24px;']";
			WebDriverWait webDriverWait2 = new WebDriverWait(this.Chrome, TimeSpan.FromSeconds(3.0));
			webDriverWait2.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(xpathToFind2)));
			this.Chrome.FindElement(By.XPath(xpathToFind2)).Click();
			Thread.Sleep(1000);
			string xpathToFind3 = "//DIV[@class='x10l6tqk x12y6twl x160vmok x1tk7jg1']";
			WebDriverWait webDriverWait3 = new WebDriverWait(this.Chrome, TimeSpan.FromSeconds(3.0));
			webDriverWait3.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(xpathToFind3)));
			this.Chrome.FindElement(By.XPath(xpathToFind3)).Click();
			Thread.Sleep(1000);
			string xpathToFind4 = "//div[@aria-label='Fechar' and @role='button' and contains(@class, 'x1i10hfl')]";
			WebDriverWait webDriverWait4 = new WebDriverWait(this.Chrome, TimeSpan.FromSeconds(3.0));
			webDriverWait4.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(xpathToFind4)));
			this.Chrome.FindElement(By.XPath(xpathToFind4)).Click();
			Thread.Sleep(1000);
			string xpathToFind5 = "//div[@class='xi81zsa x1lkfr7t xkjl1po x1mzt3pk xh8yej3 x13faqbe']";
			WebDriverWait webDriverWait5 = new WebDriverWait(this.Chrome, TimeSpan.FromSeconds(1.0));
			webDriverWait5.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(xpathToFind5)));
			IWebElement webElement = this.Chrome.FindElement(By.XPath(xpathToFind5));
			this.Chrome.FindElement(By.XPath(xpathToFind5)).Click();
			string xpathToFind6 = "//img[@class='x1b0d499 xl1xv1r' and @src='https://static.xx.fbcdn.net/rsrc.php/v3/y7/r/Ivw7nhRtXyo.png' and @style='height: 24px; width: 24px;']";
			WebDriverWait webDriverWait6 = new WebDriverWait(this.Chrome, TimeSpan.FromSeconds(1.0));
			webDriverWait6.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(xpathToFind6)));
			this.Chrome.FindElement(By.XPath(xpathToFind6)).Click();
			Thread.Sleep(1000);
			string xpathToFind7 = "//DIV[@class='x10l6tqk x12y6twl x160vmok x1tk7jg1']";
			WebDriverWait webDriverWait7 = new WebDriverWait(this.Chrome, TimeSpan.FromSeconds(3.0));
			webDriverWait7.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(xpathToFind7)));
			this.Chrome.FindElement(By.XPath(xpathToFind7)).Click();
			Thread.Sleep(1000);
			string xpathToFind8 = "//img[@class='x1b0d499 xl1xv1r' and @src='https://static.xx.fbcdn.net/rsrc.php/v3/y7/r/Ivw7nhRtXyo.png' and @style='height: 24px; width: 24px;']";
			WebDriverWait webDriverWait8 = new WebDriverWait(this.Chrome, TimeSpan.FromSeconds(3.0));
			webDriverWait8.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(xpathToFind8)));
			this.Chrome.FindElement(By.XPath(xpathToFind8)).Click();
			Thread.Sleep(1000);
			string xpathToFind9 = "//DIV[@class='x10l6tqk x12y6twl x160vmok x1tk7jg1']";
			WebDriverWait webDriverWait9 = new WebDriverWait(this.Chrome, TimeSpan.FromSeconds(3.0));
			webDriverWait9.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(xpathToFind9)));
			this.Chrome.FindElement(By.XPath(xpathToFind9)).Click();
			Thread.Sleep(1000);
			string xpathToFind10 = "//img[@class='x1b0d499 xl1xv1r' and @src='https://static.xx.fbcdn.net/rsrc.php/v3/y7/r/Ivw7nhRtXyo.png' and @style='height: 24px; width: 24px;']";
			WebDriverWait webDriverWait10 = new WebDriverWait(this.Chrome, TimeSpan.FromSeconds(3.0));
			webDriverWait10.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(xpathToFind10)));
			this.Chrome.FindElement(By.XPath(xpathToFind10)).Click();
			Thread.Sleep(1000);
			string xpathToFind11 = "//span[contains(@class, 'x193iq5w') and text()='Adicionar fotos/vídeos']";
			WebDriverWait webDriverWait11 = new WebDriverWait(this.Chrome, TimeSpan.FromSeconds(3.0));
			webDriverWait11.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(xpathToFind11)));
			this.Chrome.FindElement(By.XPath(xpathToFind11)).Click();
			Thread.Sleep(1000);
			object result;
			return result;
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x0008547C File Offset: 0x0008367C
		public int Postados()
		{
			int num = 0;
			checked
			{
				try
				{
					foreach (object obj in this.ListViewRelatório.Items)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						bool flag = Operators.CompareString(listViewItem.Text, Tradução.Str("Postou"), false) == 0;
						if (flag)
						{
							num++;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				return num;
			}
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x0000F217 File Offset: 0x0000D417
		public void ObterRelatórioCount()
		{
			this.LabelRelatórioCount.Text = string.Format(Tradução.Str("Postados: {0}"), this.Postados());
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x0008550C File Offset: 0x0008370C
		public void AdicionarNoRelatório(object Status, object Grupo)
		{
			object[] array;
			bool[] array2;
			object obj = NewLateBinding.LateGet(this.ListViewRelatório.Items, null, "Add", array = new object[]
			{
				Status
			}, null, null, array2 = new bool[]
			{
				true
			});
			if (array2[0])
			{
				Status = RuntimeHelpers.GetObjectValue(array[0]);
			}
			ListViewItem listViewItem = (ListViewItem)obj;
			NewLateBinding.LateCall(listViewItem.SubItems, null, "Add", array = new object[]
			{
				Grupo
			}, null, null, array2 = new bool[]
			{
				true
			}, true);
			if (array2[0])
			{
				Grupo = RuntimeHelpers.GetObjectValue(array[0]);
			}
			listViewItem.SubItems.Add(Conversions.ToString(MyProject.Computer.Clock.LocalTime));
			ListViewTools.SelecionarÚltimoItem(this.ListViewRelatório);
			this.ObterRelatórioCount();
			this.GravarRelatório();
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x000855DC File Offset: 0x000837DC
		public void GravarRelatório()
		{
			MySettingsProperty.Settings.FacebookPostGruposDiscussãoRelatório = new StringCollection();
			MySettingsProperty.Settings.FacebookPostGruposDiscussãoRelatório.AddRange(this.ListViewRelatório.Items.Cast<ListViewItem>().Select((FacebookPostGruposDiscussãoFormPrincipal._Closure$__.$I464-0 == null) ? (FacebookPostGruposDiscussãoFormPrincipal._Closure$__.$I464-0 = ((ListViewItem lvi) => string.Join("\t", lvi.SubItems.Cast<ListViewItem.ListViewSubItem>().Select((FacebookPostGruposDiscussãoFormPrincipal._Closure$__.$I464-1 == null) ? (FacebookPostGruposDiscussãoFormPrincipal._Closure$__.$I464-1 = ((ListViewItem.ListViewSubItem si) => si.Text)) : FacebookPostGruposDiscussãoFormPrincipal._Closure$__.$I464-1)))) : FacebookPostGruposDiscussãoFormPrincipal._Closure$__.$I464-0).ToArray<string>());
			MySettingsProperty.Settings.Save();
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x00085654 File Offset: 0x00083854
		public void CarregarRelatório()
		{
			bool flag = MySettingsProperty.Settings.FacebookPostGruposDiscussãoRelatório == null;
			if (flag)
			{
				MySettingsProperty.Settings.FacebookPostGruposDiscussãoRelatório = new StringCollection();
			}
			this.ListViewRelatório.Items.AddRange(MySettingsProperty.Settings.FacebookPostGruposDiscussãoRelatório.Cast<string>().Select((FacebookPostGruposDiscussãoFormPrincipal._Closure$__.$I465-0 == null) ? (FacebookPostGruposDiscussãoFormPrincipal._Closure$__.$I465-0 = ((string lvi) => new ListViewItem(lvi.Split(new char[]
			{
				'\t'
			})))) : FacebookPostGruposDiscussãoFormPrincipal._Closure$__.$I465-0).ToArray<ListViewItem>());
			this.ObterRelatórioCount();
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x000856DC File Offset: 0x000838DC
		public void LimparRelatório()
		{
			bool flag = this.ListViewRelatório.Items.Count != 0;
			if (flag)
			{
				bool flag2 = Operators.CompareString(RSL.RL(this.NomeDoSoftware), "A0", false) == 0;
				if (flag2)
				{
					MessageBox.Show(Tradução.Str("Não é possível limpar o relatório na versão demonstração!"), this.NomeDoSoftware, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					this.ListViewRelatório.Items.Clear();
					this.ObterRelatórioCount();
					MySettingsProperty.Settings.FacebookPostGruposDiscussãoRelatório.Clear();
					MySettingsProperty.Settings.Save();
				}
			}
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x0000F240 File Offset: 0x0000D440
		private void BtnExportarRelatório_Click(object sender, EventArgs e)
		{
			ListViewTools.ExportarListView(this.ListViewRelatório, string.Format(Tradução.Str("{0} - Relatório"), this.NomeDoSoftware));
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x0000F264 File Offset: 0x0000D464
		private void BtnLimparRelatório_Click(object sender, EventArgs e)
		{
			this.LimparRelatório();
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x00009BF1 File Offset: 0x00007DF1
		public void Fim()
		{
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x00009BF1 File Offset: 0x00007DF1
		private void Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x00085774 File Offset: 0x00083974
		private void Button1_Click_1(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				InitialDirectory = MyProject.Computer.FileSystem.SpecialDirectories.Desktop
			};
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.TextBoxAnexoPath2.Text = openFileDialog.FileName;
			}
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x000857C4 File Offset: 0x000839C4
		private void Button2_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				InitialDirectory = MyProject.Computer.FileSystem.SpecialDirectories.Desktop
			};
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.TextBoxAnexoPath3.Text = openFileDialog.FileName;
			}
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x00085814 File Offset: 0x00083A14
		private void Button3_Click(object sender, EventArgs e)
		{
			string xpathToFind = "//div[@role='none' and contains(@class, 'x1ja2u2z')]//span[text()='Publicar']";
			IWebElement webElement = this.Chrome.FindElement(By.XPath(xpathToFind));
			webElement.Click();
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x00085844 File Offset: 0x00083A44
		public object TextoImagem()
		{
			bool flag = !this.CheckBoxColou.Checked;
			checked
			{
				if (flag)
				{
					bool flag2 = this.CheckBoxEnviarAnexo.Checked > false;
					if (flag2)
					{
						bool flag3 = Operators.CompareString(this.TextBoxAnexoPath.Text, "", false) != 0;
						if (flag3)
						{
							try
							{
								string xpathToFind = "//input[@type='file']";
								Thread.Sleep(1000);
								IWebElement webElement = this.Chrome.FindElement(By.XPath(xpathToFind));
								Thread.Sleep(1000);
								string text = this.TextBoxAnexoPath.Text;
								Thread.Sleep(1000);
								bool flag4 = File.Exists(text);
								if (!flag4)
								{
									throw new Exception("O caminho do arquivo não é válido: " + text);
								}
								Thread.Sleep(1000);
								bool flag5 = !this.CheckBoxNaoDuplicar.Checked;
								if (flag5)
								{
									webElement.SendKeys(text);
								}
								Thread.Sleep(1000);
							}
							catch (Exception ex)
							{
							}
						}
						bool flag6 = Operators.CompareString(this.TextBoxAnexoPath2.Text, "", false) != 0;
						if (flag6)
						{
							try
							{
								string xpathToFind2 = "//input[@type='file']";
								Thread.Sleep(1000);
								IWebElement webElement2 = this.Chrome.FindElement(By.XPath(xpathToFind2));
								Thread.Sleep(1000);
								string text2 = this.TextBoxAnexoPath2.Text;
								Thread.Sleep(1000);
								bool flag7 = File.Exists(text2);
								if (!flag7)
								{
									throw new Exception("O caminho do arquivo não é válido: " + text2);
								}
								Thread.Sleep(1000);
								bool flag8 = !this.CheckBoxNaoDuplicar.Checked;
								if (flag8)
								{
									webElement2.SendKeys(text2);
								}
								Thread.Sleep(1000);
							}
							catch (Exception ex2)
							{
							}
						}
						else
						{
							string xpathToFind3 = "//input[@type='file']";
							Thread.Sleep(1000);
							IWebElement webElement3 = this.Chrome.FindElement(By.XPath(xpathToFind3));
							Thread.Sleep(1000);
							string text3 = this.TextBoxAnexoPath2.Text;
							Thread.Sleep(1000);
							bool flag9 = File.Exists(text3);
							if (flag9)
							{
								Thread.Sleep(1000);
								bool flag10 = !this.CheckBoxNaoDuplicar.Checked;
								if (flag10)
								{
									webElement3.SendKeys(" ");
								}
								Thread.Sleep(1000);
							}
						}
						bool flag11 = Operators.CompareString(this.TextBoxAnexoPath3.Text, "", false) != 0;
						if (flag11)
						{
							try
							{
								string xpathToFind4 = "//input[@type='file']";
								Thread.Sleep(1000);
								IWebElement webElement4 = this.Chrome.FindElement(By.XPath(xpathToFind4));
								Thread.Sleep(1000);
								string text4 = this.TextBoxAnexoPath3.Text;
								Thread.Sleep(1000);
								bool flag12 = File.Exists(text4);
								if (!flag12)
								{
									throw new Exception("O caminho do arquivo não é válido: " + text4);
								}
								Thread.Sleep(1000);
								bool flag13 = !this.CheckBoxNaoDuplicar.Checked;
								if (flag13)
								{
									webElement4.SendKeys(text4);
								}
								Thread.Sleep(1000);
							}
							catch (Exception ex3)
							{
							}
						}
					}
					bool flag14 = !this.CheckBox3.Checked;
					if (flag14)
					{
						try
						{
							IWebElement webElement5 = this.Chrome.FindElement(By.CssSelector("input[type='file']"));
							webElement5.SendKeys(this.TextBoxAnexoPath.Text);
						}
						catch (Exception ex4)
						{
						}
					}
					try
					{
						string xpathToFind5 = "//div[@class='notranslate _5rpu']";
						WebDriverWait webDriverWait = new WebDriverWait(this.Chrome, TimeSpan.FromSeconds(2.0));
						webDriverWait.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(xpathToFind5)));
						IWebElement webElement6 = this.Chrome.FindElement(By.XPath(xpathToFind5));
						webElement6.Click();
						string text5 = this.Postagens[Conversions.ToInteger(Delays.NúmeroAleatório(this.Postagens.Count))];
						webElement6.SendKeys(text5);
						Thread.Sleep((int)Math.Round(Conversion.Val(this.TextBoxDelayApósColarPostagem.Text + "000")));
					}
					catch (Exception ex5)
					{
					}
				}
				else
				{
					try
					{
						string xpathToFind6 = "(//div[@class='_1mf _1mj'])[2]";
						WebDriverWait webDriverWait2 = new WebDriverWait(this.Chrome, TimeSpan.FromSeconds(2.0));
						webDriverWait2.Until<IWebElement>(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(xpathToFind6)));
						IWebElement webElement7 = this.Chrome.FindElement(By.XPath(xpathToFind6));
						webElement7.SendKeys(this.Postagens[Conversions.ToInteger(Delays.NúmeroAleatório(this.Postagens.Count))]);
						Thread.Sleep((int)Math.Round(Conversion.Val(this.TextBoxDelayApósColarPostagem.Text + "000")));
						Thread.Sleep(100);
					}
					catch (Exception ex6)
					{
					}
				}
				object result;
				return result;
			}
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x00009BF1 File Offset: 0x00007DF1
		private void Label9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x00085DBC File Offset: 0x00083FBC
		private void CheckBoxNaoDuplicar_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBoxNaoDuplicar.Checked;
			if (@checked)
			{
				MySettingsProperty.Settings.fpd1 = 1;
			}
			else
			{
				MySettingsProperty.Settings.fpd1 = 0;
			}
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x00085DF8 File Offset: 0x00083FF8
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBox1.Checked;
			if (@checked)
			{
				MySettingsProperty.Settings.fpd2 = 1;
			}
			else
			{
				MySettingsProperty.Settings.fpd2 = 0;
			}
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x00085E34 File Offset: 0x00084034
		private void CheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBox2.Checked;
			if (@checked)
			{
				MySettingsProperty.Settings.fpd3 = 1;
			}
			else
			{
				MySettingsProperty.Settings.fpd3 = 0;
			}
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x00085E70 File Offset: 0x00084070
		private void CheckBox3_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBox3.Checked;
			if (@checked)
			{
				MySettingsProperty.Settings.fpd4 = 1;
			}
			else
			{
				MySettingsProperty.Settings.fpd4 = 0;
			}
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x00085EAC File Offset: 0x000840AC
		private void CheckBoxColou_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBoxColou.Checked;
			if (@checked)
			{
				MySettingsProperty.Settings.fpd5 = 1;
			}
			else
			{
				MySettingsProperty.Settings.fpd5 = 0;
			}
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x00085EE8 File Offset: 0x000840E8
		private void Button3_Click_1(object sender, EventArgs e)
		{
			this.TextBoxAnexoPath.Text = "";
			string text = this.RichTextBoxPostagem.Text;
			try
			{
				foreach (object obj in this.ListViewDescrições.Items)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					bool flag = Operators.CompareString(listViewItem.Text, text, false) == 0;
					if (flag)
					{
						this.ListViewDescrições.Items.Remove(listViewItem);
						break;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x00085F90 File Offset: 0x00084190
		private void Button4_Click(object sender, EventArgs e)
		{
			this.TextBoxAnexoPath2.Text = "";
			string text = this.RichTextBoxPostagem.Text;
			try
			{
				foreach (object obj in this.ListViewDescrições.Items)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					bool flag = Operators.CompareString(listViewItem.Text, text, false) == 0;
					if (flag)
					{
						this.ListViewDescrições.Items.Remove(listViewItem);
						break;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x00086038 File Offset: 0x00084238
		private void Button5_Click(object sender, EventArgs e)
		{
			this.TextBoxAnexoPath3.Text = "";
			string text = this.RichTextBoxPostagem.Text;
			try
			{
				foreach (object obj in this.ListViewDescrições.Items)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					bool flag = Operators.CompareString(listViewItem.Text, text, false) == 0;
					if (flag)
					{
						this.ListViewDescrições.Items.Remove(listViewItem);
						break;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x04000520 RID: 1312
		private const int KEYEVENTF_KEYUP = 2;

		// Token: 0x04000521 RID: 1313
		private const byte VK_CONTROL = 17;

		// Token: 0x04000522 RID: 1314
		private ChromeDriverService Service;

		// Token: 0x04000523 RID: 1315
		private ChromeDriver ChromeDriver;

		// Token: 0x04000524 RID: 1316
		private EventFiringWebDriver Chrome;

		// Token: 0x04000525 RID: 1317
		private string NomeDoSoftware;

		// Token: 0x04000526 RID: 1318
		private List<string> Postagens;

		// Token: 0x04000527 RID: 1319
		private string PostagemMsg;

		// Token: 0x04000528 RID: 1320
		private int DelayAleatório;

		// Token: 0x04000529 RID: 1321
		private string GrupoNome;

		// Token: 0x0400052A RID: 1322
		private string GrupoID;
	}
}
