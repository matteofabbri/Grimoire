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
	public class Default_Funding_Source_DataType : INotifyPropertyChanged
	{
		private string funding_Source_NameField;

		private string funding_Source_DescriptionField;

		private bool funding_Source_Not_Available_for_SelectionField;

		private bool funding_Source_Not_Available_for_SelectionFieldSpecified;

		private Funding_Source_Taggable_DataType[] funding_Source_Taggable_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Funding_Source_Name
		{
			get
			{
				return this.funding_Source_NameField;
			}
			set
			{
				this.funding_Source_NameField = value;
				this.RaisePropertyChanged("Funding_Source_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Funding_Source_Description
		{
			get
			{
				return this.funding_Source_DescriptionField;
			}
			set
			{
				this.funding_Source_DescriptionField = value;
				this.RaisePropertyChanged("Funding_Source_Description");
			}
		}

		[XmlElement(Order = 2)]
		public bool Funding_Source_Not_Available_for_Selection
		{
			get
			{
				return this.funding_Source_Not_Available_for_SelectionField;
			}
			set
			{
				this.funding_Source_Not_Available_for_SelectionField = value;
				this.RaisePropertyChanged("Funding_Source_Not_Available_for_Selection");
			}
		}

		[XmlIgnore]
		public bool Funding_Source_Not_Available_for_SelectionSpecified
		{
			get
			{
				return this.funding_Source_Not_Available_for_SelectionFieldSpecified;
			}
			set
			{
				this.funding_Source_Not_Available_for_SelectionFieldSpecified = value;
				this.RaisePropertyChanged("Funding_Source_Not_Available_for_SelectionSpecified");
			}
		}

		[XmlElement("Funding_Source_Taggable_Data", Order = 3)]
		public Funding_Source_Taggable_DataType[] Funding_Source_Taggable_Data
		{
			get
			{
				return this.funding_Source_Taggable_DataField;
			}
			set
			{
				this.funding_Source_Taggable_DataField = value;
				this.RaisePropertyChanged("Funding_Source_Taggable_Data");
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
