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
	public class Change_No_Retro_Processing_Prior_To_DataType : INotifyPropertyChanged
	{
		private EmployeeObjectType employee_ReferenceField;

		private DateTime proposed_No_Retro_Processing_Prior_ToField;

		private bool proposed_No_Retro_Processing_Prior_ToFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public EmployeeObjectType Employee_Reference
		{
			get
			{
				return this.employee_ReferenceField;
			}
			set
			{
				this.employee_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Proposed_No_Retro_Processing_Prior_To
		{
			get
			{
				return this.proposed_No_Retro_Processing_Prior_ToField;
			}
			set
			{
				this.proposed_No_Retro_Processing_Prior_ToField = value;
				this.RaisePropertyChanged("Proposed_No_Retro_Processing_Prior_To");
			}
		}

		[XmlIgnore]
		public bool Proposed_No_Retro_Processing_Prior_ToSpecified
		{
			get
			{
				return this.proposed_No_Retro_Processing_Prior_ToFieldSpecified;
			}
			set
			{
				this.proposed_No_Retro_Processing_Prior_ToFieldSpecified = value;
				this.RaisePropertyChanged("Proposed_No_Retro_Processing_Prior_ToSpecified");
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
