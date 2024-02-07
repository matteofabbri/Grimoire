using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Revenue_Category_DataType : INotifyPropertyChanged
	{
		private string revenue_Category_IDField;

		private string revenue_Category_NameField;

		private Tax_ApplicabilityObjectType tax_Applicability_ReferenceField;

		private Related_Worktags_by_Worktag_Type_DataType[] related_Worktags_DataField;

		private bool revenue_Category_InactiveField;

		private bool revenue_Category_InactiveFieldSpecified;

		private Spend_CategoryObjectType maps_to_Spend_Category_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Revenue_Category_ID
		{
			get
			{
				return this.revenue_Category_IDField;
			}
			set
			{
				this.revenue_Category_IDField = value;
				this.RaisePropertyChanged("Revenue_Category_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Revenue_Category_Name
		{
			get
			{
				return this.revenue_Category_NameField;
			}
			set
			{
				this.revenue_Category_NameField = value;
				this.RaisePropertyChanged("Revenue_Category_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Tax_ApplicabilityObjectType Tax_Applicability_Reference
		{
			get
			{
				return this.tax_Applicability_ReferenceField;
			}
			set
			{
				this.tax_Applicability_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Applicability_Reference");
			}
		}

		[XmlArray(Order = 3), XmlArrayItem("Related_Worktags_by_Type_Data", IsNullable = false)]
		public Related_Worktags_by_Worktag_Type_DataType[] Related_Worktags_Data
		{
			get
			{
				return this.related_Worktags_DataField;
			}
			set
			{
				this.related_Worktags_DataField = value;
				this.RaisePropertyChanged("Related_Worktags_Data");
			}
		}

		[XmlElement(Order = 4)]
		public bool Revenue_Category_Inactive
		{
			get
			{
				return this.revenue_Category_InactiveField;
			}
			set
			{
				this.revenue_Category_InactiveField = value;
				this.RaisePropertyChanged("Revenue_Category_Inactive");
			}
		}

		[XmlIgnore]
		public bool Revenue_Category_InactiveSpecified
		{
			get
			{
				return this.revenue_Category_InactiveFieldSpecified;
			}
			set
			{
				this.revenue_Category_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Revenue_Category_InactiveSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Spend_CategoryObjectType Maps_to_Spend_Category_Reference
		{
			get
			{
				return this.maps_to_Spend_Category_ReferenceField;
			}
			set
			{
				this.maps_to_Spend_Category_ReferenceField = value;
				this.RaisePropertyChanged("Maps_to_Spend_Category_Reference");
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
