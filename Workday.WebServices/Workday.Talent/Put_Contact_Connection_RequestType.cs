using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Contact_Connection_RequestType : INotifyPropertyChanged
	{
		private Worker_Contact_ConnectionObjectType worker_Contact_Connection_ReferenceField;

		private Worker_Contact_Connection_DataType worker_Contact_Connection_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Worker_Contact_ConnectionObjectType Worker_Contact_Connection_Reference
		{
			get
			{
				return this.worker_Contact_Connection_ReferenceField;
			}
			set
			{
				this.worker_Contact_Connection_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Contact_Connection_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Worker_Contact_Connection_DataType Worker_Contact_Connection_Data
		{
			get
			{
				return this.worker_Contact_Connection_DataField;
			}
			set
			{
				this.worker_Contact_Connection_DataField = value;
				this.RaisePropertyChanged("Worker_Contact_Connection_Data");
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
