using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payee_Earning_DataType : INotifyPropertyChanged
	{
		private Pay_ComponentObjectType earning_ReferenceField;

		private string external_Payroll_CodeField;

		private bool position_BasedField;

		private bool position_BasedFieldSpecified;

		private Position_ElementObjectType position_ReferenceField;

		private Payee_Compensation_DataType[] compensation_DataField;

		private Payee_Benefit_Plan_DataType[] benefit_Plan_DataField;

		private Payee_Benefit_Coverage_Type_DataType[] benefit_Coverage_TypeDataField;

		private Payee_Time_Off_DataType[] time_Off_DataField;

		private External_Payroll_Input_Details_DataType[] external_Payroll_Input_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Pay_ComponentObjectType Earning_Reference
		{
			get
			{
				return this.earning_ReferenceField;
			}
			set
			{
				this.earning_ReferenceField = value;
				this.RaisePropertyChanged("Earning_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string External_Payroll_Code
		{
			get
			{
				return this.external_Payroll_CodeField;
			}
			set
			{
				this.external_Payroll_CodeField = value;
				this.RaisePropertyChanged("External_Payroll_Code");
			}
		}

		[XmlElement(Order = 2)]
		public bool Position_Based
		{
			get
			{
				return this.position_BasedField;
			}
			set
			{
				this.position_BasedField = value;
				this.RaisePropertyChanged("Position_Based");
			}
		}

		[XmlIgnore]
		public bool Position_BasedSpecified
		{
			get
			{
				return this.position_BasedFieldSpecified;
			}
			set
			{
				this.position_BasedFieldSpecified = value;
				this.RaisePropertyChanged("Position_BasedSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Position_ElementObjectType Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement("Compensation_Data", Order = 4)]
		public Payee_Compensation_DataType[] Compensation_Data
		{
			get
			{
				return this.compensation_DataField;
			}
			set
			{
				this.compensation_DataField = value;
				this.RaisePropertyChanged("Compensation_Data");
			}
		}

		[XmlElement("Benefit_Plan_Data", Order = 5)]
		public Payee_Benefit_Plan_DataType[] Benefit_Plan_Data
		{
			get
			{
				return this.benefit_Plan_DataField;
			}
			set
			{
				this.benefit_Plan_DataField = value;
				this.RaisePropertyChanged("Benefit_Plan_Data");
			}
		}

		[XmlElement("Benefit_Coverage_TypeData", Order = 6)]
		public Payee_Benefit_Coverage_Type_DataType[] Benefit_Coverage_TypeData
		{
			get
			{
				return this.benefit_Coverage_TypeDataField;
			}
			set
			{
				this.benefit_Coverage_TypeDataField = value;
				this.RaisePropertyChanged("Benefit_Coverage_TypeData");
			}
		}

		[XmlElement("Time_Off_Data", Order = 7)]
		public Payee_Time_Off_DataType[] Time_Off_Data
		{
			get
			{
				return this.time_Off_DataField;
			}
			set
			{
				this.time_Off_DataField = value;
				this.RaisePropertyChanged("Time_Off_Data");
			}
		}

		[XmlElement("External_Payroll_Input_Data", Order = 8)]
		public External_Payroll_Input_Details_DataType[] External_Payroll_Input_Data
		{
			get
			{
				return this.external_Payroll_Input_DataField;
			}
			set
			{
				this.external_Payroll_Input_DataField = value;
				this.RaisePropertyChanged("External_Payroll_Input_Data");
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
