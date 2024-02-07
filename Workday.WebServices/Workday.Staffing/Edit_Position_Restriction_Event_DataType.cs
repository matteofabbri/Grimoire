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
	public class Edit_Position_Restriction_Event_DataType : INotifyPropertyChanged
	{
		private Event_Classification_SubcategoryObjectType position_Edit_Reason_ReferenceField;

		private Position_Definition_DataType position_DataField;

		private Position_Group_Restriction_DataType position_Group_Restrictions_DataField;

		private Qualification_Data_for_Position_Restriction_or_Job_ProfileType qualification_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Event_Classification_SubcategoryObjectType Position_Edit_Reason_Reference
		{
			get
			{
				return this.position_Edit_Reason_ReferenceField;
			}
			set
			{
				this.position_Edit_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Position_Edit_Reason_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Position_Definition_DataType Position_Data
		{
			get
			{
				return this.position_DataField;
			}
			set
			{
				this.position_DataField = value;
				this.RaisePropertyChanged("Position_Data");
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

		[XmlElement(Order = 3)]
		public Qualification_Data_for_Position_Restriction_or_Job_ProfileType Qualification_Replacement_Data
		{
			get
			{
				return this.qualification_Replacement_DataField;
			}
			set
			{
				this.qualification_Replacement_DataField = value;
				this.RaisePropertyChanged("Qualification_Replacement_Data");
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
