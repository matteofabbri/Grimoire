using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(Get_Workers_ResponseRootType)), XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Get_Workers_ResponseType : INotifyPropertyChanged
	{
		private Worker_Request_ReferencesType request_ReferencesField;

		private Worker_Request_CriteriaType request_CriteriaField;

		private Response_FilterType response_FilterField;

		private Worker_Response_GroupType response_GroupField;

		private Response_ResultsType response_ResultsField;

		private WorkerType[] response_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Worker_Request_ReferencesType Request_References
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
		public Worker_Request_CriteriaType Request_Criteria
		{
			get
			{
				return this.request_CriteriaField;
			}
			set
			{
				this.request_CriteriaField = value;
				this.RaisePropertyChanged("Request_Criteria");
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
		public Worker_Response_GroupType Response_Group
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

		[XmlArray(Order = 5), XmlArrayItem("Worker", IsNullable = false)]
		public WorkerType[] Response_Data
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
