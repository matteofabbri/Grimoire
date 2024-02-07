using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_Document_WWSType : INotifyPropertyChanged
	{
		private Worker_DocumentObjectType worker_Document_ReferenceField;

		private Worker_Document_Details_DataType worker_Document_Detail_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Worker_DocumentObjectType Worker_Document_Reference
		{
			get
			{
				return this.worker_Document_ReferenceField;
			}
			set
			{
				this.worker_Document_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Document_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Worker_Document_Details_DataType Worker_Document_Detail_Data
		{
			get
			{
				return this.worker_Document_Detail_DataField;
			}
			set
			{
				this.worker_Document_Detail_DataField = value;
				this.RaisePropertyChanged("Worker_Document_Detail_Data");
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
