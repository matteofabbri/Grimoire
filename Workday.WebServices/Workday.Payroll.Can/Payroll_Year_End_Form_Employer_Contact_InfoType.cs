using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Can
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Year_End_Form_Employer_Contact_InfoType : INotifyPropertyChanged
	{
		private T4_Contact_InformationType[] t4_Contact_InformationField;

		private T4A_Contact_InformationType[] t4A_Contact_InformationField;

		private RL1_Contact_InformationType[] rL1_Contact_InformationField;

		private RL2_Contact_InformationType[] rL2_Contact_InformationField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("T4_Contact_Information", Order = 0)]
		public T4_Contact_InformationType[] T4_Contact_Information
		{
			get
			{
				return this.t4_Contact_InformationField;
			}
			set
			{
				this.t4_Contact_InformationField = value;
				this.RaisePropertyChanged("T4_Contact_Information");
			}
		}

		[XmlElement("T4A_Contact_Information", Order = 1)]
		public T4A_Contact_InformationType[] T4A_Contact_Information
		{
			get
			{
				return this.t4A_Contact_InformationField;
			}
			set
			{
				this.t4A_Contact_InformationField = value;
				this.RaisePropertyChanged("T4A_Contact_Information");
			}
		}

		[XmlElement("RL-1_Contact_Information", Order = 2)]
		public RL1_Contact_InformationType[] RL1_Contact_Information
		{
			get
			{
				return this.rL1_Contact_InformationField;
			}
			set
			{
				this.rL1_Contact_InformationField = value;
				this.RaisePropertyChanged("RL1_Contact_Information");
			}
		}

		[XmlElement("RL-2_Contact_Information", Order = 3)]
		public RL2_Contact_InformationType[] RL2_Contact_Information
		{
			get
			{
				return this.rL2_Contact_InformationField;
			}
			set
			{
				this.rL2_Contact_InformationField = value;
				this.RaisePropertyChanged("RL2_Contact_Information");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
