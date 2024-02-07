using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Project_Standard_Cost_Rate_Sheet_DataType : INotifyPropertyChanged
	{
		private string project_Standard_Cost_Rate_Sheet_IDField;

		private string standard_Cost_Rate_Sheet_NameField;

		private CurrencyObjectType rate_Sheet_Currency_ReferenceField;

		private Project_Standard_Cost_Rate_Snapshot_DetailsType[] project_Standard_Cost_Rate_Sheet_Snapshot_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Project_Standard_Cost_Rate_Sheet_ID
		{
			get
			{
				return this.project_Standard_Cost_Rate_Sheet_IDField;
			}
			set
			{
				this.project_Standard_Cost_Rate_Sheet_IDField = value;
				this.RaisePropertyChanged("Project_Standard_Cost_Rate_Sheet_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Standard_Cost_Rate_Sheet_Name
		{
			get
			{
				return this.standard_Cost_Rate_Sheet_NameField;
			}
			set
			{
				this.standard_Cost_Rate_Sheet_NameField = value;
				this.RaisePropertyChanged("Standard_Cost_Rate_Sheet_Name");
			}
		}

		[XmlElement(Order = 2)]
		public CurrencyObjectType Rate_Sheet_Currency_Reference
		{
			get
			{
				return this.rate_Sheet_Currency_ReferenceField;
			}
			set
			{
				this.rate_Sheet_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Rate_Sheet_Currency_Reference");
			}
		}

		[XmlElement("Project_Standard_Cost_Rate_Sheet_Snapshot_Data", Order = 3)]
		public Project_Standard_Cost_Rate_Snapshot_DetailsType[] Project_Standard_Cost_Rate_Sheet_Snapshot_Data
		{
			get
			{
				return this.project_Standard_Cost_Rate_Sheet_Snapshot_DataField;
			}
			set
			{
				this.project_Standard_Cost_Rate_Sheet_Snapshot_DataField = value;
				this.RaisePropertyChanged("Project_Standard_Cost_Rate_Sheet_Snapshot_Data");
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
