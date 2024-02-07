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
	public class Payee_Time_Tracking_DataType : INotifyPropertyChanged
	{
		private Pay_ComponentObjectType code_ReferenceField;

		private string external_Payroll_CodeField;

		private bool position_BasedField;

		private bool position_BasedFieldSpecified;

		private Position_ElementObjectType position_ReferenceField;

		private Payee_Daily_Calculated_Time_Summary_DataType[] daily_Calculated_Time_Block_DataField;

		private Payee_Period_Calculated_Time_Summary_DataType[] period_Calculated_Time_Block_DataField;

		private Time_Block_Correction_DataType[] payee_Time_Tracking_Correction_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Pay_ComponentObjectType Code_Reference
		{
			get
			{
				return this.code_ReferenceField;
			}
			set
			{
				this.code_ReferenceField = value;
				this.RaisePropertyChanged("Code_Reference");
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

		[XmlElement("Daily_Calculated_Time_Block_Data", Order = 4)]
		public Payee_Daily_Calculated_Time_Summary_DataType[] Daily_Calculated_Time_Block_Data
		{
			get
			{
				return this.daily_Calculated_Time_Block_DataField;
			}
			set
			{
				this.daily_Calculated_Time_Block_DataField = value;
				this.RaisePropertyChanged("Daily_Calculated_Time_Block_Data");
			}
		}

		[XmlElement("Period_Calculated_Time_Block_Data", Order = 5)]
		public Payee_Period_Calculated_Time_Summary_DataType[] Period_Calculated_Time_Block_Data
		{
			get
			{
				return this.period_Calculated_Time_Block_DataField;
			}
			set
			{
				this.period_Calculated_Time_Block_DataField = value;
				this.RaisePropertyChanged("Period_Calculated_Time_Block_Data");
			}
		}

		[XmlArray(Order = 6), XmlArrayItem("Payee_Time_Block_Correction_Data", typeof(Time_Block_Correction_DataType), IsNullable = false)]
		public Time_Block_Correction_DataType[] Payee_Time_Tracking_Correction_Data
		{
			get
			{
				return this.payee_Time_Tracking_Correction_DataField;
			}
			set
			{
				this.payee_Time_Tracking_Correction_DataField = value;
				this.RaisePropertyChanged("Payee_Time_Tracking_Correction_Data");
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
