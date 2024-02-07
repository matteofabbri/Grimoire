using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class RequisitionType : INotifyPropertyChanged
	{
		private RequisitionObjectType requisition_ReferenceField;

		private Requisition_DataType[] requisition_dataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public RequisitionObjectType Requisition_Reference
		{
			get
			{
				return this.requisition_ReferenceField;
			}
			set
			{
				this.requisition_ReferenceField = value;
				this.RaisePropertyChanged("Requisition_Reference");
			}
		}

		[XmlElement("Requisition_data", Order = 1)]
		public Requisition_DataType[] Requisition_data
		{
			get
			{
				return this.requisition_dataField;
			}
			set
			{
				this.requisition_dataField = value;
				this.RaisePropertyChanged("Requisition_data");
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
