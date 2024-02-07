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
	public class Project_Worker_Standard_Cost_Rate_DetailsType : INotifyPropertyChanged
	{
		private bool deleteField;

		private bool deleteFieldSpecified;

		private string project_Worker_Standard_Cost_Rate_Detail_IDField;

		private string orderField;

		private Project_Cost_Rate_RuleObjectType project_Cost_Rate_Rule_ReferenceField;

		private decimal hourly_RateField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
				this.RaisePropertyChanged("Delete");
			}
		}

		[XmlIgnore]
		public bool DeleteSpecified
		{
			get
			{
				return this.deleteFieldSpecified;
			}
			set
			{
				this.deleteFieldSpecified = value;
				this.RaisePropertyChanged("DeleteSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public string Project_Worker_Standard_Cost_Rate_Detail_ID
		{
			get
			{
				return this.project_Worker_Standard_Cost_Rate_Detail_IDField;
			}
			set
			{
				this.project_Worker_Standard_Cost_Rate_Detail_IDField = value;
				this.RaisePropertyChanged("Project_Worker_Standard_Cost_Rate_Detail_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
				this.RaisePropertyChanged("Order");
			}
		}

		[XmlElement(Order = 3)]
		public Project_Cost_Rate_RuleObjectType Project_Cost_Rate_Rule_Reference
		{
			get
			{
				return this.project_Cost_Rate_Rule_ReferenceField;
			}
			set
			{
				this.project_Cost_Rate_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Project_Cost_Rate_Rule_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Hourly_Rate
		{
			get
			{
				return this.hourly_RateField;
			}
			set
			{
				this.hourly_RateField = value;
				this.RaisePropertyChanged("Hourly_Rate");
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
