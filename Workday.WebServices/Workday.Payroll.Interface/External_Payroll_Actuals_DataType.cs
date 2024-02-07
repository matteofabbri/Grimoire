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
	public class External_Payroll_Actuals_DataType : INotifyPropertyChanged
	{
		private DateTime dateField;

		private Pay_ComponentObjectType pay_Component_Workday_ReferenceField;

		private string external_Payroll_CodeField;

		private Position_ElementObjectType position_ReferenceField;

		private decimal hoursField;

		private bool hoursFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				this.dateField = value;
				this.RaisePropertyChanged("Date");
			}
		}

		[XmlElement(Order = 1)]
		public Pay_ComponentObjectType Pay_Component_Workday_Reference
		{
			get
			{
				return this.pay_Component_Workday_ReferenceField;
			}
			set
			{
				this.pay_Component_Workday_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Component_Workday_Reference");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 4)]
		public decimal Hours
		{
			get
			{
				return this.hoursField;
			}
			set
			{
				this.hoursField = value;
				this.RaisePropertyChanged("Hours");
			}
		}

		[XmlIgnore]
		public bool HoursSpecified
		{
			get
			{
				return this.hoursFieldSpecified;
			}
			set
			{
				this.hoursFieldSpecified = value;
				this.RaisePropertyChanged("HoursSpecified");
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
