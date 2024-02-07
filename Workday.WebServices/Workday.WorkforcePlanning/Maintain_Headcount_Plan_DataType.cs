using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.WorkforcePlanning
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Maintain_Headcount_Plan_DataType : INotifyPropertyChanged
	{
		private Headcount_Plan_TemplateObjectType headcount_Plan_Template_ReferenceField;

		private Headcount_Plan_VersionObjectType headcount_Plan_Version_ReferenceField;

		private DateTime organizations_Effective_As_Of_DateField;

		private bool organizations_Effective_As_Of_DateFieldSpecified;

		private Organization_Management_DataType[] organization_Management_DataField;

		private Organizations_to_Exclude_DataType[] organizations_to_Exclude_DataField;

		private Headcount_Plan_Dimension_Management_DataType[] headcount_Plan_Dimension_Management_DataField;

		private Edit_Headcount_Plan_Sub_Business_ProcessType edit_Headcount_Plan_Sub_Business_ProcessField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Headcount_Plan_TemplateObjectType Headcount_Plan_Template_Reference
		{
			get
			{
				return this.headcount_Plan_Template_ReferenceField;
			}
			set
			{
				this.headcount_Plan_Template_ReferenceField = value;
				this.RaisePropertyChanged("Headcount_Plan_Template_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Headcount_Plan_VersionObjectType Headcount_Plan_Version_Reference
		{
			get
			{
				return this.headcount_Plan_Version_ReferenceField;
			}
			set
			{
				this.headcount_Plan_Version_ReferenceField = value;
				this.RaisePropertyChanged("Headcount_Plan_Version_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Organizations_Effective_As_Of_Date
		{
			get
			{
				return this.organizations_Effective_As_Of_DateField;
			}
			set
			{
				this.organizations_Effective_As_Of_DateField = value;
				this.RaisePropertyChanged("Organizations_Effective_As_Of_Date");
			}
		}

		[XmlIgnore]
		public bool Organizations_Effective_As_Of_DateSpecified
		{
			get
			{
				return this.organizations_Effective_As_Of_DateFieldSpecified;
			}
			set
			{
				this.organizations_Effective_As_Of_DateFieldSpecified = value;
				this.RaisePropertyChanged("Organizations_Effective_As_Of_DateSpecified");
			}
		}

		[XmlElement("Organization_Management_Data", Order = 3)]
		public Organization_Management_DataType[] Organization_Management_Data
		{
			get
			{
				return this.organization_Management_DataField;
			}
			set
			{
				this.organization_Management_DataField = value;
				this.RaisePropertyChanged("Organization_Management_Data");
			}
		}

		[XmlElement("Organizations_to_Exclude_Data", Order = 4)]
		public Organizations_to_Exclude_DataType[] Organizations_to_Exclude_Data
		{
			get
			{
				return this.organizations_to_Exclude_DataField;
			}
			set
			{
				this.organizations_to_Exclude_DataField = value;
				this.RaisePropertyChanged("Organizations_to_Exclude_Data");
			}
		}

		[XmlElement("Headcount_Plan_Dimension_Management_Data", Order = 5)]
		public Headcount_Plan_Dimension_Management_DataType[] Headcount_Plan_Dimension_Management_Data
		{
			get
			{
				return this.headcount_Plan_Dimension_Management_DataField;
			}
			set
			{
				this.headcount_Plan_Dimension_Management_DataField = value;
				this.RaisePropertyChanged("Headcount_Plan_Dimension_Management_Data");
			}
		}

		[XmlElement(Order = 6)]
		public Edit_Headcount_Plan_Sub_Business_ProcessType Edit_Headcount_Plan_Sub_Business_Process
		{
			get
			{
				return this.edit_Headcount_Plan_Sub_Business_ProcessField;
			}
			set
			{
				this.edit_Headcount_Plan_Sub_Business_ProcessField = value;
				this.RaisePropertyChanged("Edit_Headcount_Plan_Sub_Business_Process");
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
