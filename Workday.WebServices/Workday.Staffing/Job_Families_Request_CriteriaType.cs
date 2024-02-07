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
	public class Job_Families_Request_CriteriaType : INotifyPropertyChanged
	{
		private External_Field_and_Parameter_Initialization_ProviderObjectType[] field_And_Parameter_Criteria_DataField;

		private bool include_InActive_Job_FamiliesField;

		private bool include_InActive_Job_FamiliesFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlArray(Order = 0), XmlArrayItem("Provider_Reference", IsNullable = false)]
		public External_Field_and_Parameter_Initialization_ProviderObjectType[] Field_And_Parameter_Criteria_Data
		{
			get
			{
				return this.field_And_Parameter_Criteria_DataField;
			}
			set
			{
				this.field_And_Parameter_Criteria_DataField = value;
				this.RaisePropertyChanged("Field_And_Parameter_Criteria_Data");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_InActive_Job_Families
		{
			get
			{
				return this.include_InActive_Job_FamiliesField;
			}
			set
			{
				this.include_InActive_Job_FamiliesField = value;
				this.RaisePropertyChanged("Include_InActive_Job_Families");
			}
		}

		[XmlIgnore]
		public bool Include_InActive_Job_FamiliesSpecified
		{
			get
			{
				return this.include_InActive_Job_FamiliesFieldSpecified;
			}
			set
			{
				this.include_InActive_Job_FamiliesFieldSpecified = value;
				this.RaisePropertyChanged("Include_InActive_Job_FamiliesSpecified");
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
