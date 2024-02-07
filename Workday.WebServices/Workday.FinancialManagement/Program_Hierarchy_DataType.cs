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
	public class Program_Hierarchy_DataType : INotifyPropertyChanged
	{
		private string program_Hierarchy_IDField;

		private string program_Hierarchy_NameField;

		private bool include_Program_Hierarchy_ID_In_NameField;

		private bool include_Program_Hierarchy_ID_In_NameFieldSpecified;

		private bool program_Hierarchy_is_InactiveField;

		private bool program_Hierarchy_is_InactiveFieldSpecified;

		private Organization_SubtypeObjectType organization_Subtype_ReferenceField;

		private Program_HierarchyObjectType parent_Program_Hierarchy_ReferenceField;

		private ProgramObjectType[] contains_Program_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Program_Hierarchy_ID
		{
			get
			{
				return this.program_Hierarchy_IDField;
			}
			set
			{
				this.program_Hierarchy_IDField = value;
				this.RaisePropertyChanged("Program_Hierarchy_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Program_Hierarchy_Name
		{
			get
			{
				return this.program_Hierarchy_NameField;
			}
			set
			{
				this.program_Hierarchy_NameField = value;
				this.RaisePropertyChanged("Program_Hierarchy_Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Program_Hierarchy_ID_In_Name
		{
			get
			{
				return this.include_Program_Hierarchy_ID_In_NameField;
			}
			set
			{
				this.include_Program_Hierarchy_ID_In_NameField = value;
				this.RaisePropertyChanged("Include_Program_Hierarchy_ID_In_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Program_Hierarchy_ID_In_NameSpecified
		{
			get
			{
				return this.include_Program_Hierarchy_ID_In_NameFieldSpecified;
			}
			set
			{
				this.include_Program_Hierarchy_ID_In_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Program_Hierarchy_ID_In_NameSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Program_Hierarchy_is_Inactive
		{
			get
			{
				return this.program_Hierarchy_is_InactiveField;
			}
			set
			{
				this.program_Hierarchy_is_InactiveField = value;
				this.RaisePropertyChanged("Program_Hierarchy_is_Inactive");
			}
		}

		[XmlIgnore]
		public bool Program_Hierarchy_is_InactiveSpecified
		{
			get
			{
				return this.program_Hierarchy_is_InactiveFieldSpecified;
			}
			set
			{
				this.program_Hierarchy_is_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Program_Hierarchy_is_InactiveSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Organization_SubtypeObjectType Organization_Subtype_Reference
		{
			get
			{
				return this.organization_Subtype_ReferenceField;
			}
			set
			{
				this.organization_Subtype_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Subtype_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Program_HierarchyObjectType Parent_Program_Hierarchy_Reference
		{
			get
			{
				return this.parent_Program_Hierarchy_ReferenceField;
			}
			set
			{
				this.parent_Program_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Parent_Program_Hierarchy_Reference");
			}
		}

		[XmlElement("Contains_Program_Reference", Order = 6)]
		public ProgramObjectType[] Contains_Program_Reference
		{
			get
			{
				return this.contains_Program_ReferenceField;
			}
			set
			{
				this.contains_Program_ReferenceField = value;
				this.RaisePropertyChanged("Contains_Program_Reference");
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
