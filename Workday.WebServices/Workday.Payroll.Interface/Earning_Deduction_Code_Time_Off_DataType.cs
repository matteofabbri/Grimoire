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
	public class Earning_Deduction_Code_Time_Off_DataType : INotifyPropertyChanged
	{
		private Pay_ComponentObjectType code_ReferenceField;

		private string external_Payroll_CodeField;

		private bool position_BasedField;

		private bool position_BasedFieldSpecified;

		private Position_ElementObjectType position_ReferenceField;

		private Payee_Time_Off_DataType[] time_Off_DataField;

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

		[XmlElement("Time_Off_Data", Order = 4)]
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
