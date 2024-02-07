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
	public class Change_Additional_Names_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType person_Additional_Name_Change_ReferenceField;

		private WorkerObjectType worker_ReferenceField;

		private Additional_Name_DataType[] additional_Name_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Person_Additional_Name_Change_Reference
		{
			get
			{
				return this.person_Additional_Name_Change_ReferenceField;
			}
			set
			{
				this.person_Additional_Name_Change_ReferenceField = value;
				this.RaisePropertyChanged("Person_Additional_Name_Change_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public WorkerObjectType Worker_Reference
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

		[XmlElement("Additional_Name_Data", Order = 2)]
		public Additional_Name_DataType[] Additional_Name_Data
		{
			get
			{
				return this.additional_Name_DataField;
			}
			set
			{
				this.additional_Name_DataField = value;
				this.RaisePropertyChanged("Additional_Name_Data");
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
