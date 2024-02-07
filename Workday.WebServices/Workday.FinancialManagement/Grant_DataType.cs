using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Grant_DataType : INotifyPropertyChanged
	{
		private string grant_IDField;

		private string grant_NameField;

		private bool include_Grant_ID_in_NameField;

		private bool include_Grant_ID_in_NameFieldSpecified;

		private bool grant_is_InactiveField;

		private bool grant_is_InactiveFieldSpecified;

		private Object_Class_SetObjectType object_Class_Set_ReferenceField;

		private Facilities_and_Admin_Cost_ScheduleObjectType facilities_and_Administration_Cost_Schedule_ReferenceField;

		private Related_Worktags_by_Worktag_Type_DataType[] related_Worktags_DataField;

		private Grant_HierarchyObjectType[] grant_Hierarchy_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Grant_ID
		{
			get
			{
				return this.grant_IDField;
			}
			set
			{
				this.grant_IDField = value;
				this.RaisePropertyChanged("Grant_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Grant_Name
		{
			get
			{
				return this.grant_NameField;
			}
			set
			{
				this.grant_NameField = value;
				this.RaisePropertyChanged("Grant_Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Grant_ID_in_Name
		{
			get
			{
				return this.include_Grant_ID_in_NameField;
			}
			set
			{
				this.include_Grant_ID_in_NameField = value;
				this.RaisePropertyChanged("Include_Grant_ID_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Grant_ID_in_NameSpecified
		{
			get
			{
				return this.include_Grant_ID_in_NameFieldSpecified;
			}
			set
			{
				this.include_Grant_ID_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Grant_ID_in_NameSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Grant_is_Inactive
		{
			get
			{
				return this.grant_is_InactiveField;
			}
			set
			{
				this.grant_is_InactiveField = value;
				this.RaisePropertyChanged("Grant_is_Inactive");
			}
		}

		[XmlIgnore]
		public bool Grant_is_InactiveSpecified
		{
			get
			{
				return this.grant_is_InactiveFieldSpecified;
			}
			set
			{
				this.grant_is_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Grant_is_InactiveSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Object_Class_SetObjectType Object_Class_Set_Reference
		{
			get
			{
				return this.object_Class_Set_ReferenceField;
			}
			set
			{
				this.object_Class_Set_ReferenceField = value;
				this.RaisePropertyChanged("Object_Class_Set_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Facilities_and_Admin_Cost_ScheduleObjectType Facilities_and_Administration_Cost_Schedule_Reference
		{
			get
			{
				return this.facilities_and_Administration_Cost_Schedule_ReferenceField;
			}
			set
			{
				this.facilities_and_Administration_Cost_Schedule_ReferenceField = value;
				this.RaisePropertyChanged("Facilities_and_Administration_Cost_Schedule_Reference");
			}
		}

		[XmlArray(Order = 6), XmlArrayItem("Related_Worktags_by_Type_Data", IsNullable = false)]
		public Related_Worktags_by_Worktag_Type_DataType[] Related_Worktags_Data
		{
			get
			{
				return this.related_Worktags_DataField;
			}
			set
			{
				this.related_Worktags_DataField = value;
				this.RaisePropertyChanged("Related_Worktags_Data");
			}
		}

		[XmlElement("Grant_Hierarchy_Reference", Order = 7)]
		public Grant_HierarchyObjectType[] Grant_Hierarchy_Reference
		{
			get
			{
				return this.grant_Hierarchy_ReferenceField;
			}
			set
			{
				this.grant_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Grant_Hierarchy_Reference");
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
