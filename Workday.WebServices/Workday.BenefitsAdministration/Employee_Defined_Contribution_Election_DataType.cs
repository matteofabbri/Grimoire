using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Employee_Defined_Contribution_Election_DataType : INotifyPropertyChanged
	{
		private EmployeeObjectType employee_ReferenceField;

		private DateTime takes_Effect_On_DateField;

		private Defined_Contribution_Election_DataType[] defined_Contribution_Election_DataField;

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
		public DateTime Takes_Effect_On_Date
		{
			get
			{
				return this.takes_Effect_On_DateField;
			}
			set
			{
				this.takes_Effect_On_DateField = value;
				this.RaisePropertyChanged("Takes_Effect_On_Date");
			}
		}

		[XmlElement("Defined_Contribution_Election_Data", Order = 2)]
		public Defined_Contribution_Election_DataType[] Defined_Contribution_Election_Data
		{
			get
			{
				return this.defined_Contribution_Election_DataField;
			}
			set
			{
				this.defined_Contribution_Election_DataField = value;
				this.RaisePropertyChanged("Defined_Contribution_Election_Data");
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
