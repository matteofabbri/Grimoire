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
	public class Create_Applicant_DataType : INotifyPropertyChanged
	{
		private string applicant_IDField;

		private Personal_Information_DataType personal_DataField;

		private IDType[] external_Integration_ID_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Applicant_ID
		{
			get
			{
				return this.applicant_IDField;
			}
			set
			{
				this.applicant_IDField = value;
				this.RaisePropertyChanged("Applicant_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Personal_Information_DataType Personal_Data
		{
			get
			{
				return this.personal_DataField;
			}
			set
			{
				this.personal_DataField = value;
				this.RaisePropertyChanged("Personal_Data");
			}
		}

		[XmlArray(Order = 2), XmlArrayItem("ID", IsNullable = false)]
		public IDType[] External_Integration_ID_Data
		{
			get
			{
				return this.external_Integration_ID_DataField;
			}
			set
			{
				this.external_Integration_ID_DataField = value;
				this.RaisePropertyChanged("External_Integration_ID_Data");
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
