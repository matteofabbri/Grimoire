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
	public class Project_Standard_Cost_Rate_Snapshot_DetailsType : INotifyPropertyChanged
	{
		private DateTime effective_DateField;

		private decimal default_Hourly_RateField;

		private Project_Worker_Standard_Cost_Rate_DetailsType[] project_Worker_Standard_Cost_Rate_Detail_DataField;

		private Project_Unnamed_Resource_Standard_Cost_Rate_DetailsType[] project_Unnamed_Resource_Standard_Cost_Rate_Detail_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Default_Hourly_Rate
		{
			get
			{
				return this.default_Hourly_RateField;
			}
			set
			{
				this.default_Hourly_RateField = value;
				this.RaisePropertyChanged("Default_Hourly_Rate");
			}
		}

		[XmlElement("Project_Worker_Standard_Cost_Rate_Detail_Data", Order = 2)]
		public Project_Worker_Standard_Cost_Rate_DetailsType[] Project_Worker_Standard_Cost_Rate_Detail_Data
		{
			get
			{
				return this.project_Worker_Standard_Cost_Rate_Detail_DataField;
			}
			set
			{
				this.project_Worker_Standard_Cost_Rate_Detail_DataField = value;
				this.RaisePropertyChanged("Project_Worker_Standard_Cost_Rate_Detail_Data");
			}
		}

		[XmlElement("Project_Unnamed_Resource_Standard_Cost_Rate_Detail_Data", Order = 3)]
		public Project_Unnamed_Resource_Standard_Cost_Rate_DetailsType[] Project_Unnamed_Resource_Standard_Cost_Rate_Detail_Data
		{
			get
			{
				return this.project_Unnamed_Resource_Standard_Cost_Rate_Detail_DataField;
			}
			set
			{
				this.project_Unnamed_Resource_Standard_Cost_Rate_Detail_DataField = value;
				this.RaisePropertyChanged("Project_Unnamed_Resource_Standard_Cost_Rate_Detail_Data");
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
