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
	public class Edit_Evergreen_Requisition_Event_DataType : INotifyPropertyChanged
	{
		private Supervisory_OrganizationObjectType supervisory_Organization_ReferenceField;

		private Event_Classification_SubcategoryObjectType edit_Evergreen_Requisition_Reason_ReferenceField;

		private Evergreen_Job_Requisition_Data_for_Create_and_EditType[] evergreen_Requisition_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Supervisory_OrganizationObjectType Supervisory_Organization_Reference
		{
			get
			{
				return this.supervisory_Organization_ReferenceField;
			}
			set
			{
				this.supervisory_Organization_ReferenceField = value;
				this.RaisePropertyChanged("Supervisory_Organization_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Event_Classification_SubcategoryObjectType Edit_Evergreen_Requisition_Reason_Reference
		{
			get
			{
				return this.edit_Evergreen_Requisition_Reason_ReferenceField;
			}
			set
			{
				this.edit_Evergreen_Requisition_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Edit_Evergreen_Requisition_Reason_Reference");
			}
		}

		[XmlElement("Evergreen_Requisition_Data", Order = 2)]
		public Evergreen_Job_Requisition_Data_for_Create_and_EditType[] Evergreen_Requisition_Data
		{
			get
			{
				return this.evergreen_Requisition_DataField;
			}
			set
			{
				this.evergreen_Requisition_DataField = value;
				this.RaisePropertyChanged("Evergreen_Requisition_Data");
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
