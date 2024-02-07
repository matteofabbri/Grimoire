using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class State_Tax_Election_DataType : INotifyPropertyChanged
	{
		private Payroll_State_AuthorityObjectType payroll_State_Authority_ReferenceField;

		private Payroll_Payee_State_Election_for_State_and_LocalType[] state_Income_Tax_DataField;

		private Payroll_Payee_SUTA_Electon_for_State_and_LocalType state_Unemployment_DataField;

		private Payroll_Payee_EIC_Election_for_State_and_LocalType earned_Income_Credit_DataField;

		private Payroll_Payee_County_Election_for_State_and_LocalType[] payroll_State_County_Tax_DataField;

		private Payroll_Payee_City_Election_for_State_and_LocalType[] payroll_State_City_Tax_DataField;

		private Payroll_Payee_School_District_Election_for_State_and_LocalType[] payroll_State_School_District_Tax_DataField;

		private Payroll_Payee_Other_Election_for_State_and_LocalType[] payroll_State_Other_Tax_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_State_AuthorityObjectType Payroll_State_Authority_Reference
		{
			get
			{
				return this.payroll_State_Authority_ReferenceField;
			}
			set
			{
				this.payroll_State_Authority_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_State_Authority_Reference");
			}
		}

		[XmlElement("State_Income_Tax_Data", Order = 1)]
		public Payroll_Payee_State_Election_for_State_and_LocalType[] State_Income_Tax_Data
		{
			get
			{
				return this.state_Income_Tax_DataField;
			}
			set
			{
				this.state_Income_Tax_DataField = value;
				this.RaisePropertyChanged("State_Income_Tax_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Payroll_Payee_SUTA_Electon_for_State_and_LocalType State_Unemployment_Data
		{
			get
			{
				return this.state_Unemployment_DataField;
			}
			set
			{
				this.state_Unemployment_DataField = value;
				this.RaisePropertyChanged("State_Unemployment_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Payroll_Payee_EIC_Election_for_State_and_LocalType Earned_Income_Credit_Data
		{
			get
			{
				return this.earned_Income_Credit_DataField;
			}
			set
			{
				this.earned_Income_Credit_DataField = value;
				this.RaisePropertyChanged("Earned_Income_Credit_Data");
			}
		}

		[XmlElement("Payroll_State_County_Tax_Data", Order = 4)]
		public Payroll_Payee_County_Election_for_State_and_LocalType[] Payroll_State_County_Tax_Data
		{
			get
			{
				return this.payroll_State_County_Tax_DataField;
			}
			set
			{
				this.payroll_State_County_Tax_DataField = value;
				this.RaisePropertyChanged("Payroll_State_County_Tax_Data");
			}
		}

		[XmlElement("Payroll_State_City_Tax_Data", Order = 5)]
		public Payroll_Payee_City_Election_for_State_and_LocalType[] Payroll_State_City_Tax_Data
		{
			get
			{
				return this.payroll_State_City_Tax_DataField;
			}
			set
			{
				this.payroll_State_City_Tax_DataField = value;
				this.RaisePropertyChanged("Payroll_State_City_Tax_Data");
			}
		}

		[XmlElement("Payroll_State_School_District_Tax_Data", Order = 6)]
		public Payroll_Payee_School_District_Election_for_State_and_LocalType[] Payroll_State_School_District_Tax_Data
		{
			get
			{
				return this.payroll_State_School_District_Tax_DataField;
			}
			set
			{
				this.payroll_State_School_District_Tax_DataField = value;
				this.RaisePropertyChanged("Payroll_State_School_District_Tax_Data");
			}
		}

		[XmlElement("Payroll_State_Other_Tax_Data", Order = 7)]
		public Payroll_Payee_Other_Election_for_State_and_LocalType[] Payroll_State_Other_Tax_Data
		{
			get
			{
				return this.payroll_State_Other_Tax_DataField;
			}
			set
			{
				this.payroll_State_Other_Tax_DataField = value;
				this.RaisePropertyChanged("Payroll_State_Other_Tax_Data");
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
