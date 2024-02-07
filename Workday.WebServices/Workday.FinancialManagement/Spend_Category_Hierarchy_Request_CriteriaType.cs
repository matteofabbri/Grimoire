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
	public class Spend_Category_Hierarchy_Request_CriteriaType : INotifyPropertyChanged
	{
		private string spend_Category_Hierarchy_NameField;

		private bool exclude_Hierarchy_DependenciesField;

		private bool exclude_Hierarchy_DependenciesFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Spend_Category_Hierarchy_Name
		{
			get
			{
				return this.spend_Category_Hierarchy_NameField;
			}
			set
			{
				this.spend_Category_Hierarchy_NameField = value;
				this.RaisePropertyChanged("Spend_Category_Hierarchy_Name");
			}
		}

		[XmlElement(Order = 1)]
		public bool Exclude_Hierarchy_Dependencies
		{
			get
			{
				return this.exclude_Hierarchy_DependenciesField;
			}
			set
			{
				this.exclude_Hierarchy_DependenciesField = value;
				this.RaisePropertyChanged("Exclude_Hierarchy_Dependencies");
			}
		}

		[XmlIgnore]
		public bool Exclude_Hierarchy_DependenciesSpecified
		{
			get
			{
				return this.exclude_Hierarchy_DependenciesFieldSpecified;
			}
			set
			{
				this.exclude_Hierarchy_DependenciesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Hierarchy_DependenciesSpecified");
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
