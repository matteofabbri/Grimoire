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
	public class Background_Check_Request_CriteriaType : INotifyPropertyChanged
	{
		private WorkerObjectType requester_ReferenceField;

		private RoleObjectType recipient_ReferenceField;

		private DateTime submission_DateField;

		private bool submission_DateFieldSpecified;

		private Unique_IdentifierObjectType workflow_State_ReferenceField;

		private bool package_SelectedField;

		private bool package_SelectedFieldSpecified;

		private External_Field_and_Parameter_Initialization_ProviderObjectType[] field_And_Parameter_Criteria_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Requester_Reference
		{
			get
			{
				return this.requester_ReferenceField;
			}
			set
			{
				this.requester_ReferenceField = value;
				this.RaisePropertyChanged("Requester_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public RoleObjectType Recipient_Reference
		{
			get
			{
				return this.recipient_ReferenceField;
			}
			set
			{
				this.recipient_ReferenceField = value;
				this.RaisePropertyChanged("Recipient_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Submission_Date
		{
			get
			{
				return this.submission_DateField;
			}
			set
			{
				this.submission_DateField = value;
				this.RaisePropertyChanged("Submission_Date");
			}
		}

		[XmlIgnore]
		public bool Submission_DateSpecified
		{
			get
			{
				return this.submission_DateFieldSpecified;
			}
			set
			{
				this.submission_DateFieldSpecified = value;
				this.RaisePropertyChanged("Submission_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Unique_IdentifierObjectType Workflow_State_Reference
		{
			get
			{
				return this.workflow_State_ReferenceField;
			}
			set
			{
				this.workflow_State_ReferenceField = value;
				this.RaisePropertyChanged("Workflow_State_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public bool Package_Selected
		{
			get
			{
				return this.package_SelectedField;
			}
			set
			{
				this.package_SelectedField = value;
				this.RaisePropertyChanged("Package_Selected");
			}
		}

		[XmlIgnore]
		public bool Package_SelectedSpecified
		{
			get
			{
				return this.package_SelectedFieldSpecified;
			}
			set
			{
				this.package_SelectedFieldSpecified = value;
				this.RaisePropertyChanged("Package_SelectedSpecified");
			}
		}

		[XmlArray(Order = 5), XmlArrayItem("Provider_Reference", IsNullable = false)]
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
