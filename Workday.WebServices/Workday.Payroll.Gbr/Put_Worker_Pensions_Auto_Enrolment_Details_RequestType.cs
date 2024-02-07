using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll.Gbr
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Worker_Pensions_Auto_Enrolment_Details_RequestType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType worker_Pensions_Auto_Enrolment_Details_ReferenceField;

		private Worker_Pensions_Auto_Enrolment_Details_DataType worker_Pensions_Auto_Enrolment_Details_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Worker_Pensions_Auto_Enrolment_Details_Reference
		{
			get
			{
				return this.worker_Pensions_Auto_Enrolment_Details_ReferenceField;
			}
			set
			{
				this.worker_Pensions_Auto_Enrolment_Details_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Pensions_Auto_Enrolment_Details_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Worker_Pensions_Auto_Enrolment_Details_DataType Worker_Pensions_Auto_Enrolment_Details_Data
		{
			get
			{
				return this.worker_Pensions_Auto_Enrolment_Details_DataField;
			}
			set
			{
				this.worker_Pensions_Auto_Enrolment_Details_DataField = value;
				this.RaisePropertyChanged("Worker_Pensions_Auto_Enrolment_Details_Data");
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
