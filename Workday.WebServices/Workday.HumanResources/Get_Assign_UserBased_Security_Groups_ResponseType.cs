using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Get_Assign_User-Based_Security_Groups_ResponseType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Get_Assign_UserBased_Security_Groups_ResponseType : INotifyPropertyChanged
	{
		private System_UserObjectType[] request_ReferencesField;

		private Assign_UserBased_Security_Groups_Request_CriteriaType request_criteriaField;

		private Response_FilterType response_FilterField;

		private Assign_UserBased_Security_Groups_Response_GroupType response_GroupField;

		private Response_ResultsType response_ResultsField;

		private Assign_UserBased_Security_GroupsType[] response_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlArray(Order = 0), XmlArrayItem("Workday_Account_Reference", IsNullable = false)]
		public System_UserObjectType[] Request_References
		{
			get
			{
				return this.request_ReferencesField;
			}
			set
			{
				this.request_ReferencesField = value;
				this.RaisePropertyChanged("Request_References");
			}
		}

		[XmlElement(Order = 1)]
		public Assign_UserBased_Security_Groups_Request_CriteriaType Request_criteria
		{
			get
			{
				return this.request_criteriaField;
			}
			set
			{
				this.request_criteriaField = value;
				this.RaisePropertyChanged("Request_criteria");
			}
		}

		[XmlElement(Order = 2)]
		public Response_FilterType Response_Filter
		{
			get
			{
				return this.response_FilterField;
			}
			set
			{
				this.response_FilterField = value;
				this.RaisePropertyChanged("Response_Filter");
			}
		}

		[XmlElement(Order = 3)]
		public Assign_UserBased_Security_Groups_Response_GroupType Response_Group
		{
			get
			{
				return this.response_GroupField;
			}
			set
			{
				this.response_GroupField = value;
				this.RaisePropertyChanged("Response_Group");
			}
		}

		[XmlElement(Order = 4)]
		public Response_ResultsType Response_Results
		{
			get
			{
				return this.response_ResultsField;
			}
			set
			{
				this.response_ResultsField = value;
				this.RaisePropertyChanged("Response_Results");
			}
		}

		[XmlArray(Order = 5), XmlArrayItem("Assign_User-Based_Security_Groups", IsNullable = false)]
		public Assign_UserBased_Security_GroupsType[] Response_Data
		{
			get
			{
				return this.response_DataField;
			}
			set
			{
				this.response_DataField = value;
				this.RaisePropertyChanged("Response_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
