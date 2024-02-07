using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Batch_RequestType : INotifyPropertyChanged
	{
		private Application_BatchObjectType batch_ReferenceField;

		private Application_Batch_DataType batch_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Application_BatchObjectType Batch_Reference
		{
			get
			{
				return this.batch_ReferenceField;
			}
			set
			{
				this.batch_ReferenceField = value;
				this.RaisePropertyChanged("Batch_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Application_Batch_DataType Batch_Data
		{
			get
			{
				return this.batch_DataField;
			}
			set
			{
				this.batch_DataField = value;
				this.RaisePropertyChanged("Batch_Data");
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
