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
	public class Create_Evergreen_Job_Requisition_DataType : INotifyPropertyChanged
	{
		private Supervisory_OrganizationObjectType supervisory_Organization_ReferenceField;

		private Evergreen_Job_Requisition_Data_for_Create_and_EditType evergreen_Requisition_DataField;

		private Post_Job_Sub_Business_ProcessType post_Job_Sub_ProcessField;

		private Assign_Organization_Roles_Sub_Business_ProcessType assign_Organization_Roles_Sub_ProcessField;

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
		public Evergreen_Job_Requisition_Data_for_Create_and_EditType Evergreen_Requisition_Data
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

		[XmlElement(Order = 2)]
		public Post_Job_Sub_Business_ProcessType Post_Job_Sub_Process
		{
			get
			{
				return this.post_Job_Sub_ProcessField;
			}
			set
			{
				this.post_Job_Sub_ProcessField = value;
				this.RaisePropertyChanged("Post_Job_Sub_Process");
			}
		}

		[XmlElement(Order = 3)]
		public Assign_Organization_Roles_Sub_Business_ProcessType Assign_Organization_Roles_Sub_Process
		{
			get
			{
				return this.assign_Organization_Roles_Sub_ProcessField;
			}
			set
			{
				this.assign_Organization_Roles_Sub_ProcessField = value;
				this.RaisePropertyChanged("Assign_Organization_Roles_Sub_Process");
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
