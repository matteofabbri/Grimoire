using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Application_Batch_DataType : INotifyPropertyChanged
	{
		private string batch_IDField;

		private Application_Batch_UsageObjectType application_Batch_Usage_ReferenceField;

		private Integration_System__Audited_ObjectType source_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Batch_ID
		{
			get
			{
				return this.batch_IDField;
			}
			set
			{
				this.batch_IDField = value;
				this.RaisePropertyChanged("Batch_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Application_Batch_UsageObjectType Application_Batch_Usage_Reference
		{
			get
			{
				return this.application_Batch_Usage_ReferenceField;
			}
			set
			{
				this.application_Batch_Usage_ReferenceField = value;
				this.RaisePropertyChanged("Application_Batch_Usage_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Integration_System__Audited_ObjectType Source_Reference
		{
			get
			{
				return this.source_ReferenceField;
			}
			set
			{
				this.source_ReferenceField = value;
				this.RaisePropertyChanged("Source_Reference");
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
