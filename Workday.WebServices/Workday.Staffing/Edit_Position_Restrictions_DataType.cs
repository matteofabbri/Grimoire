using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Edit_Position_Restrictions_DataType : INotifyPropertyChanged
	{
		private Position_RestrictionsObjectType position_ReferenceField;

		private Edit_Position_Restriction_Event_DataType edit_Position_Restriction_Event_DataField;

		private Edit_Assign_Position_Organization_Sub_Business_ProcessType edit_Assign_Organization_Sub_ProcessField;

		private Request_Compensation_Default_Sub_Business_ProcessType request_Default_Compensation_Sub_ProcessField;

		private Assign_Pay_Group_for_Position_Restrictions_Sub_Business_ProcessType assign_Pay_Group_Sub_ProcessField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Position_RestrictionsObjectType Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Edit_Position_Restriction_Event_DataType Edit_Position_Restriction_Event_Data
		{
			get
			{
				return this.edit_Position_Restriction_Event_DataField;
			}
			set
			{
				this.edit_Position_Restriction_Event_DataField = value;
				this.RaisePropertyChanged("Edit_Position_Restriction_Event_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Edit_Assign_Position_Organization_Sub_Business_ProcessType Edit_Assign_Organization_Sub_Process
		{
			get
			{
				return this.edit_Assign_Organization_Sub_ProcessField;
			}
			set
			{
				this.edit_Assign_Organization_Sub_ProcessField = value;
				this.RaisePropertyChanged("Edit_Assign_Organization_Sub_Process");
			}
		}

		[XmlElement(Order = 3)]
		public Request_Compensation_Default_Sub_Business_ProcessType Request_Default_Compensation_Sub_Process
		{
			get
			{
				return this.request_Default_Compensation_Sub_ProcessField;
			}
			set
			{
				this.request_Default_Compensation_Sub_ProcessField = value;
				this.RaisePropertyChanged("Request_Default_Compensation_Sub_Process");
			}
		}

		[XmlElement(Order = 4)]
		public Assign_Pay_Group_for_Position_Restrictions_Sub_Business_ProcessType Assign_Pay_Group_Sub_Process
		{
			get
			{
				return this.assign_Pay_Group_Sub_ProcessField;
			}
			set
			{
				this.assign_Pay_Group_Sub_ProcessField = value;
				this.RaisePropertyChanged("Assign_Pay_Group_Sub_Process");
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
