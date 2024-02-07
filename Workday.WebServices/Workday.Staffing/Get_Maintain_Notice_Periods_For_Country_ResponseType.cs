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
	public class Get_Maintain_Notice_Periods_For_Country_ResponseType : INotifyPropertyChanged
	{
		private CountryObjectType[] notice_Periods_For_Country_Request_ReferencesField;

		private Response_FilterType response_FilterField;

		private Response_ResultsType response_ResultsField;

		private Notice_Period_Line_For_CountryType[] notice_PeriodsField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlArray(Order = 0), XmlArrayItem("Country_Reference", IsNullable = false)]
		public CountryObjectType[] Notice_Periods_For_Country_Request_References
		{
			get
			{
				return this.notice_Periods_For_Country_Request_ReferencesField;
			}
			set
			{
				this.notice_Periods_For_Country_Request_ReferencesField = value;
				this.RaisePropertyChanged("Notice_Periods_For_Country_Request_References");
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

		[XmlElement("Notice_Periods", Order = 3)]
		public Notice_Period_Line_For_CountryType[] Notice_Periods
		{
			get
			{
				return this.notice_PeriodsField;
			}
			set
			{
				this.notice_PeriodsField = value;
				this.RaisePropertyChanged("Notice_Periods");
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
