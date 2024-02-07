using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Get_Citizenship_Statuses_ResponseType : INotifyPropertyChanged
	{
		private Citizenship_StatusObjectType[] request_ReferencesField;

		private Response_FilterType response_FilterField;

		private Response_ResultsType response_ResultsField;

		private Citizenship_StatusType[] response_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlArray(Order = 0), XmlArrayItem("Citizenship_Status_Reference", IsNullable = false)]
		public Citizenship_StatusObjectType[] Request_References
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

		[XmlElement(Order = 2)]
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

		[XmlArray(Order = 3), XmlArrayItem("Citizenship_Status", IsNullable = false)]
		public Citizenship_StatusType[] Response_Data
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
