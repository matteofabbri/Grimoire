using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.CompensationReview
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Import_Employee_Awards_RequestType : INotifyPropertyChanged
	{
		private Compensation_Review_EventObjectType compensation_Review_Event_ReferenceField;

		private Employee_Award_Data__HV_Type[] employee_Award_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Compensation_Review_EventObjectType Compensation_Review_Event_Reference
		{
			get
			{
				return this.compensation_Review_Event_ReferenceField;
			}
			set
			{
				this.compensation_Review_Event_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Review_Event_Reference");
			}
		}

		[XmlElement("Employee_Award_Data", Order = 1)]
		public Employee_Award_Data__HV_Type[] Employee_Award_Data
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

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
