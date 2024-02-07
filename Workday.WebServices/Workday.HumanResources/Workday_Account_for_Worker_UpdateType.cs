using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Workday_Account_for_Worker_UpdateType : INotifyPropertyChanged
	{
		private Worker_ReferenceType worker_ReferenceField;

		private RoleObjectType non_Worker_ReferenceField;

		private Workday_Account_for_Worker_DataType workday_Account_for_Worker_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Worker_ReferenceType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public RoleObjectType Non_Worker_Reference
		{
			get
			{
				return this.non_Worker_ReferenceField;
			}
			set
			{
				this.non_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Non_Worker_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Workday_Account_for_Worker_DataType Workday_Account_for_Worker_Data
		{
			get
			{
				return this.workday_Account_for_Worker_DataField;
			}
			set
			{
				this.workday_Account_for_Worker_DataField = value;
				this.RaisePropertyChanged("Workday_Account_for_Worker_Data");
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
