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
	public class Defined_Contribution_PackageType : INotifyPropertyChanged
	{
		private Employee_Defined_Contribution_Election_DataType employee_Defined_Contribution_Election_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Employee_Defined_Contribution_Election_DataType Employee_Defined_Contribution_Election_Data
		{
			get
			{
				return this.employee_Defined_Contribution_Election_DataField;
			}
			set
			{
				this.employee_Defined_Contribution_Election_DataField = value;
				this.RaisePropertyChanged("Employee_Defined_Contribution_Election_Data");
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
