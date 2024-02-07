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
	public class Condition_Rule_Data_WWSType : INotifyPropertyChanged
	{
		private string condition_Rule_IDField;

		private string rule_DescriptionField;

		private string commentField;

		private Condition_Rule_CategoryObjectType[] condition_Rule_Category_ReferenceField;

		private Condition_Item_Data_WWSType[] condition_Item_DataField;

		private CountryObjectType[] countries_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Condition_Rule_ID
		{
			get
			{
				return this.condition_Rule_IDField;
			}
			set
			{
				this.condition_Rule_IDField = value;
				this.RaisePropertyChanged("Condition_Rule_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Rule_Description
		{
			get
			{
				return this.rule_DescriptionField;
			}
			set
			{
				this.rule_DescriptionField = value;
				this.RaisePropertyChanged("Rule_Description");
			}
		}

		[XmlElement(Order = 2)]
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
				this.RaisePropertyChanged("Comment");
			}
		}

		[XmlElement("Condition_Rule_Category_Reference", Order = 3)]
		public Condition_Rule_CategoryObjectType[] Condition_Rule_Category_Reference
		{
			get
			{
				return this.condition_Rule_Category_ReferenceField;
			}
			set
			{
				this.condition_Rule_Category_ReferenceField = value;
				this.RaisePropertyChanged("Condition_Rule_Category_Reference");
			}
		}

		[XmlElement("Condition_Item_Data", Order = 4)]
		public Condition_Item_Data_WWSType[] Condition_Item_Data
		{
			get
			{
				return this.condition_Item_DataField;
			}
			set
			{
				this.condition_Item_DataField = value;
				this.RaisePropertyChanged("Condition_Item_Data");
			}
		}

		[XmlElement("Countries_Reference", Order = 5)]
		public CountryObjectType[] Countries_Reference
		{
			get
			{
				return this.countries_ReferenceField;
			}
			set
			{
				this.countries_ReferenceField = value;
				this.RaisePropertyChanged("Countries_Reference");
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
