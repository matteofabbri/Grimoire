using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Contingent_Worker_DataType : INotifyPropertyChanged
	{
		private string user_IDField;

		private IDType[] integration_ID_DataField;

		private Personal_Info_DataType[] personal_Info_DataField;

		private Contingent_Worker_Contract_Info_DataType[] contingent_Worker_Contract_Info_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string User_ID
		{
			get
			{
				return this.user_IDField;
			}
			set
			{
				this.user_IDField = value;
				this.RaisePropertyChanged("User_ID");
			}
		}

		[XmlArray(Order = 1), XmlArrayItem("ID", IsNullable = false)]
		public IDType[] Integration_ID_Data
		{
			get
			{
				return this.integration_ID_DataField;
			}
			set
			{
				this.integration_ID_DataField = value;
				this.RaisePropertyChanged("Integration_ID_Data");
			}
		}

		[XmlElement("Personal_Info_Data", Order = 2)]
		public Personal_Info_DataType[] Personal_Info_Data
		{
			get
			{
				return this.personal_Info_DataField;
			}
			set
			{
				this.personal_Info_DataField = value;
				this.RaisePropertyChanged("Personal_Info_Data");
			}
		}

		[XmlElement("Contingent_Worker_Contract_Info_Data", Order = 3)]
		public Contingent_Worker_Contract_Info_DataType[] Contingent_Worker_Contract_Info_Data
		{
			get
			{
				return this.contingent_Worker_Contract_Info_DataField;
			}
			set
			{
				this.contingent_Worker_Contract_Info_DataField = value;
				this.RaisePropertyChanged("Contingent_Worker_Contract_Info_Data");
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
