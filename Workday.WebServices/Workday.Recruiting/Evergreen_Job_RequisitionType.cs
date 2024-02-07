using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Evergreen_Job_RequisitionType : INotifyPropertyChanged
	{
		private Evergreen_Job_RequisitionObjectType evergreen_Job_Requisition_ReferenceField;

		private Evergreen_Job_Requisition_Data_2Type evergreen_Job_Requisition_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Evergreen_Job_RequisitionObjectType Evergreen_Job_Requisition_Reference
		{
			get
			{
				return this.evergreen_Job_Requisition_ReferenceField;
			}
			set
			{
				this.evergreen_Job_Requisition_ReferenceField = value;
				this.RaisePropertyChanged("Evergreen_Job_Requisition_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Evergreen_Job_Requisition_Data_2Type Evergreen_Job_Requisition_Data
		{
			get
			{
				return this.evergreen_Job_Requisition_DataField;
			}
			set
			{
				this.evergreen_Job_Requisition_DataField = value;
				this.RaisePropertyChanged("Evergreen_Job_Requisition_Data");
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
