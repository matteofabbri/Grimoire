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
	public class Project_Asset_DataType : INotifyPropertyChanged
	{
		private string project_Asset_IDField;

		private ProjectObjectType project_ReferenceField;

		private string nameField;

		private string descriptionField;

		private Spend_CategoryObjectType spend_Category_ReferenceField;

		private decimal uncapitalized_CostField;

		private bool uncapitalized_CostFieldSpecified;

		private decimal capitalized_CostField;

		private bool capitalized_CostFieldSpecified;

		private decimal project_Asset_CostField;

		private bool project_Asset_CostFieldSpecified;

		private DateTime capitalization_DateField;

		private bool capitalization_DateFieldSpecified;

		private Business_AssetObjectType business_Asset_ReferenceField;

		private DateTime acquisition_DateField;

		private bool acquisition_DateFieldSpecified;

		private Document_StatusObjectType status_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Project_Asset_ID
		{
			get
			{
				return this.project_Asset_IDField;
			}
			set
			{
				this.project_Asset_IDField = value;
				this.RaisePropertyChanged("Project_Asset_ID");
			}
		}

		[XmlElement(Order = 1)]
		public ProjectObjectType Project_Reference
		{
			get
			{
				return this.project_ReferenceField;
			}
			set
			{
				this.project_ReferenceField = value;
				this.RaisePropertyChanged("Project_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 3)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 4)]
		public Spend_CategoryObjectType Spend_Category_Reference
		{
			get
			{
				return this.spend_Category_ReferenceField;
			}
			set
			{
				this.spend_Category_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Uncapitalized_Cost
		{
			get
			{
				return this.uncapitalized_CostField;
			}
			set
			{
				this.uncapitalized_CostField = value;
				this.RaisePropertyChanged("Uncapitalized_Cost");
			}
		}

		[XmlIgnore]
		public bool Uncapitalized_CostSpecified
		{
			get
			{
				return this.uncapitalized_CostFieldSpecified;
			}
			set
			{
				this.uncapitalized_CostFieldSpecified = value;
				this.RaisePropertyChanged("Uncapitalized_CostSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Capitalized_Cost
		{
			get
			{
				return this.capitalized_CostField;
			}
			set
			{
				this.capitalized_CostField = value;
				this.RaisePropertyChanged("Capitalized_Cost");
			}
		}

		[XmlIgnore]
		public bool Capitalized_CostSpecified
		{
			get
			{
				return this.capitalized_CostFieldSpecified;
			}
			set
			{
				this.capitalized_CostFieldSpecified = value;
				this.RaisePropertyChanged("Capitalized_CostSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Project_Asset_Cost
		{
			get
			{
				return this.project_Asset_CostField;
			}
			set
			{
				this.project_Asset_CostField = value;
				this.RaisePropertyChanged("Project_Asset_Cost");
			}
		}

		[XmlIgnore]
		public bool Project_Asset_CostSpecified
		{
			get
			{
				return this.project_Asset_CostFieldSpecified;
			}
			set
			{
				this.project_Asset_CostFieldSpecified = value;
				this.RaisePropertyChanged("Project_Asset_CostSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Capitalization_Date
		{
			get
			{
				return this.capitalization_DateField;
			}
			set
			{
				this.capitalization_DateField = value;
				this.RaisePropertyChanged("Capitalization_Date");
			}
		}

		[XmlIgnore]
		public bool Capitalization_DateSpecified
		{
			get
			{
				return this.capitalization_DateFieldSpecified;
			}
			set
			{
				this.capitalization_DateFieldSpecified = value;
				this.RaisePropertyChanged("Capitalization_DateSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public Business_AssetObjectType Business_Asset_Reference
		{
			get
			{
				return this.business_Asset_ReferenceField;
			}
			set
			{
				this.business_Asset_ReferenceField = value;
				this.RaisePropertyChanged("Business_Asset_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 10)]
		public DateTime Acquisition_Date
		{
			get
			{
				return this.acquisition_DateField;
			}
			set
			{
				this.acquisition_DateField = value;
				this.RaisePropertyChanged("Acquisition_Date");
			}
		}

		[XmlIgnore]
		public bool Acquisition_DateSpecified
		{
			get
			{
				return this.acquisition_DateFieldSpecified;
			}
			set
			{
				this.acquisition_DateFieldSpecified = value;
				this.RaisePropertyChanged("Acquisition_DateSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public Document_StatusObjectType Status_Reference
		{
			get
			{
				return this.status_ReferenceField;
			}
			set
			{
				this.status_ReferenceField = value;
				this.RaisePropertyChanged("Status_Reference");
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
