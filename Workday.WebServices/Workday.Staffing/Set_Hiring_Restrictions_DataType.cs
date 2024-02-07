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
	public class Set_Hiring_Restrictions_DataType : INotifyPropertyChanged
	{
		private Supervisory_OrganizationObjectType supervisory_Organization_ReferenceField;

		private Event_Classification_SubcategoryObjectType hiring_Restrictions_Request_Reason_ReferenceField;

		private Position_Group_Restriction_DataType position_Group_Restrictions_DataField;

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
		public Event_Classification_SubcategoryObjectType Hiring_Restrictions_Request_Reason_Reference
		{
			get
			{
				return this.hiring_Restrictions_Request_Reason_ReferenceField;
			}
			set
			{
				this.hiring_Restrictions_Request_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Hiring_Restrictions_Request_Reason_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Position_Group_Restriction_DataType Position_Group_Restrictions_Data
		{
			get
			{
				return this.position_Group_Restrictions_DataField;
			}
			set
			{
				this.position_Group_Restrictions_DataField = value;
				this.RaisePropertyChanged("Position_Group_Restrictions_Data");
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
