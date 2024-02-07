using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CompensationReview
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Employee_AwardType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType employee_Award_ReferenceField;

		private Employee_Award_DataType[] employee_Award_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Employee_Award_Reference
		{
			get
			{
				return this.employee_Award_ReferenceField;
			}
			set
			{
				this.employee_Award_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Award_Reference");
			}
		}

		[XmlElement("Employee_Award_Data", Order = 1)]
		public Employee_Award_DataType[] Employee_Award_Data
		{
			get
			{
				return this.employee_Award_DataField;
			}
			set
			{
				this.employee_Award_DataField = value;
				this.RaisePropertyChanged("Employee_Award_Data");
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
